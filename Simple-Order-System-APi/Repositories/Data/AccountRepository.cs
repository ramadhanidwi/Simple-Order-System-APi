using Microsoft.EntityFrameworkCore;
using Simple_Order_System_APi.Contexts;
using Simple_Order_System_APi.Handlers;
using Simple_Order_System_APi.Models;
using Simple_Order_System_APi.ViewModels;

namespace Simple_Order_System_APi.Repositories.Data
{
    public class AccountRepository : GeneralRepository<int, Account>
    {
        private readonly MyContext context;

        public AccountRepository(MyContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<int> Register(RegisterVM registerVM)
        {
            int result = 0;

            Employee employee = new Employee
            {
                Id = registerVM.Id,
                FirstName = registerVM.FirstName,
                LastName = registerVM.LastName,
                OfficeCode = registerVM.OfficeCode,
                JobTitle = registerVM.JobTitle,
                Email = registerVM.Email,
            };
            await context.Employees.AddAsync(employee);
            result = await context.SaveChangesAsync();

            Account account = new Account
            {
                EmployeeId = registerVM.Id,

                //Password = registerVM.Password
                //Password = BCrypt.Net.BCrypt.HashPassword(registerVM.Password),
                Password = Hashing.HashPassword(registerVM.Password),

            };
            await context.Accounts.AddAsync(account);
            result = await context.SaveChangesAsync();

            AccountRole accountRole = new AccountRole
            {
                AccountId =registerVM.Id,
                RoleId = 2
            };
            await context.AccountRoles.AddAsync(accountRole);
            result = await context.SaveChangesAsync();

            return result;
        }
        public async Task<bool> Login(LoginVM loginVM)
        {
            var getAccount = await context.Employees
            .Include(e => e.Account)
            .Select(e => new LoginVM
            {
                Email = e.Email,
                Password = e.Account.Password
            }).SingleOrDefaultAsync(a => a.Email == loginVM.Email);

            if (getAccount is null)
            {
                return false;
            }
            //return BCrypt.Net.BCrypt.Verify(loginVM.Password, getAccount.Password);
            return Hashing.ValidatePassword(loginVM.Password, getAccount.Password);

            //return getAccounts.Any(e => e.Email == loginVM.Email && e.Password == loginVM.Password);
        }

        public async Task<UserDataVM> GetUserdata(string email)
        {

            var userdata = (from e in context.Employees
                            join a in context.Accounts
                            on e.Id equals a.EmployeeId 
                            join ar in context.AccountRoles 
                            on a.EmployeeId equals ar.AccountId
                            join r in context.Roles
                            on ar.RoleId equals r.Id
                            where e.Email == email
                            select new UserDataVM
                            {
                                Email = e.Email,
                                FullName = String.Concat(e.FirstName, " ", e.LastName),
                                //Role = r.Name
                            }).FirstOrDefault();

            return userdata;
        }
        public async Task<IEnumerable<string>> GetRolesByID(string email)
        {
            var getId = context.Employees.FirstOrDefault(e => e.Email == email);
            return context.AccountRoles.Where(ar => ar.AccountId == getId.Id).Join(
                context.Roles,
                ar => ar.RoleId,
                r => r.Id,
                (ar, r) => r.Name).ToList();
        }
    }
}
