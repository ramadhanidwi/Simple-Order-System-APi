﻿using Simple_Order_System_APi.Contexts;
using Simple_Order_System_APi.Models;

namespace Simple_Order_System_APi.Repositories.Data
{
    public class EmployeeRepository : GeneralRepository<int, Employee>
    {
        public EmployeeRepository(MyContext context) : base(context)
        {
        }
    }
}
