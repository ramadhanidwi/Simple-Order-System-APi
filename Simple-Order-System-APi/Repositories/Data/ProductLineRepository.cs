using Simple_Order_System_APi.Contexts;
using Simple_Order_System_APi.Models;

namespace Simple_Order_System_APi.Repositories.Data
{
    public class ProductLineRepository : GeneralRepository<int, ProductLine>
    {
        public ProductLineRepository(MyContext context) : base(context)
        {
        }
    }
}
