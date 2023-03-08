using Simple_Order_System_APi.Contexts;
using Simple_Order_System_APi.Models;

namespace Simple_Order_System_APi.Repositories.Data
{
    public class OrderRepository : GeneralRepository<int, Order>
    {
        public OrderRepository(MyContext context) : base(context)
        {
        }
    }
}
