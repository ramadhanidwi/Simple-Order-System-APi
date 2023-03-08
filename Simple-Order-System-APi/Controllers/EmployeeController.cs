using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Simple_Order_System_APi.Base;
using Simple_Order_System_APi.Models;
using Simple_Order_System_APi.Repositories.Data;

namespace Simple_Order_System_APi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : BaseController<int, Employee, EmployeeRepository>
    {
        public EmployeeController(EmployeeRepository repository) : base(repository)
        {
        }
    }
}
