using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Garden_Helper_Site.Data;
using Garden_Helper_Site.Models;

namespace Garden_Helper_Site.Pages.Plants
{
    public class CreateModel : PageModel
    {
        private readonly Garden_Helper_Site.Data.Garden_Helper_SiteContext _context;

        public CreateModel(Garden_Helper_Site.Data.Garden_Helper_SiteContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Plant Plant { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Plant == null || Plant == null)
            {
                return Page();
            }

            _context.Plant.Add(Plant);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
