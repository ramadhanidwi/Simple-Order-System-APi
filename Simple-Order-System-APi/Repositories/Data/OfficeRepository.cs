using Simple_Order_System_APi.Contexts;
using Simple_Order_System_APi.Models;

namespace Simple_Order_System_APi.Repositories.Data
{
    public class OfficeRepository : GeneralRepository<int, Office>
    {
        private readonly MyContext context;

        public OfficeRepository(MyContext context) : base(context)
        {
            this.context = context;
        }
    }
}
