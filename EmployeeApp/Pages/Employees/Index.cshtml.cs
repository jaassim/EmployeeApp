﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmployeeApp.Data;
using EmployeeApp.Model;

namespace EmployeeApp.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly EmployeeApp.Data.EmployeeAppContext _context;

        public IndexModel(EmployeeApp.Data.EmployeeAppContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Employee != null)
            {
                Employee = await _context.Employee.ToListAsync();
            }
        }
    }
}
