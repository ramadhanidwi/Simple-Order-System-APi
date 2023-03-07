using Microsoft.EntityFrameworkCore;

namespace Simple_Order_System_APi.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) 
        {
            
        }
    }
}
