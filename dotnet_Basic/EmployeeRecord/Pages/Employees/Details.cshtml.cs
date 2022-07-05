using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmployeeRecord.Data;
using EmployeeRecord.Models;

namespace EmployeeRecord.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private readonly EmployeeRecord.Data.EmployeeContext _context;

        public DetailsModel(EmployeeRecord.Data.EmployeeContext context)
        {
            _context = context;
        }

      public EmployeeModel EmployeeModel { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.EmployeeModel == null)
            {
                return NotFound();
            }

            var employeemodel = await _context.EmployeeModel.FirstOrDefaultAsync(m => m.ID == id);
            if (employeemodel == null)
            {
                return NotFound();
            }
            else 
            {
                EmployeeModel = employeemodel;
            }
            return Page();
        }
    }
}
