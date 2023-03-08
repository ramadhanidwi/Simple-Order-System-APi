using Simple_Order_System_APi.Contexts;
using Simple_Order_System_APi.Models;

namespace Simple_Order_System_APi.Repositories.Data
{
    public class RoleRepository : GeneralRepository<int, Role>
    {
        private readonly MyContext context;

        public RoleRepository(MyContext context) : base(context)
        {
            this.context = context;
        }
    }
}
