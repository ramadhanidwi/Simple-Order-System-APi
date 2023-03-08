using Simple_Order_System_APi.Contexts;
using Simple_Order_System_APi.Models;

namespace Simple_Order_System_APi.Repositories.Data
{
    public class CustomerRepository : GeneralRepository<int, Customer>
    {
        public CustomerRepository(MyContext context) : base(context)
        {
        }
    }
}
