using Simple_Order_System_APi.Contexts;
using Simple_Order_System_APi.Models;

namespace Simple_Order_System_APi.Repositories.Data
{
    public class ProductRepository : GeneralRepository<int, Product>
    {
        private readonly MyContext context;

        public ProductRepository(MyContext context) : base(context)
        {
            this.context = context;
        }
    }
}
