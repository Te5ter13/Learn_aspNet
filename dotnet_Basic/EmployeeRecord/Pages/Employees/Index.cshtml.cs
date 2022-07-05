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
    public class IndexModel : PageModel
    {
        private readonly EmployeeRecord.Data.EmployeeContext _context;

        public IndexModel(EmployeeRecord.Data.EmployeeContext context)
        {
            _context = context;
        }

        public IList<EmployeeModel> EmployeeModel { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.EmployeeModel != null)
            {
                EmployeeModel = await _context.EmployeeModel.ToListAsync();
            }
        }
    }
}
