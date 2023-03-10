using Simple_Order_System_APi.Contexts;
using Simple_Order_System_APi.Models;

namespace Simple_Order_System_APi.Repositories.Data
{
    public class PaymentRepository : GeneralRepository<int, Payment>
    {
        public PaymentRepository(MyContext context) : base(context)
        {
        }
    }
}
