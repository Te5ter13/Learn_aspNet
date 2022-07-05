using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeeRecord.Data;
using EmployeeRecord.Models;

namespace EmployeeRecord.Pages.Employees
{
    public class EditModel : PageModel
    {
        private readonly EmployeeRecord.Data.EmployeeContext _context;

        public EditModel(EmployeeRecord.Data.EmployeeContext context)
        {
            _context = context;
        }

        [BindProperty]
        public EmployeeModel EmployeeModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.EmployeeModel == null)
            {
                return NotFound();
            }

            var employeemodel =  await _context.EmployeeModel.FirstOrDefaultAsync(m => m.ID == id);
            if (employeemodel == null)
            {
                return NotFound();
            }
            EmployeeModel = employeemodel;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(EmployeeModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeModelExists(EmployeeModel.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EmployeeModelExists(int id)
        {
          return (_context.EmployeeModel?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
