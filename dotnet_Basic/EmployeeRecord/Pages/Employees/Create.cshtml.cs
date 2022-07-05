using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EmployeeRecord.Data;
using EmployeeRecord.Models;

namespace EmployeeRecord.Pages.Employees
{
    public class CreateModel : PageModel
    {
        private readonly EmployeeRecord.Data.EmployeeContext _context;

        public CreateModel(EmployeeRecord.Data.EmployeeContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public EmployeeModel EmployeeModel { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.EmployeeModel == null || EmployeeModel == null)
            {
                return Page();
            }

            _context.EmployeeModel.Add(EmployeeModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
