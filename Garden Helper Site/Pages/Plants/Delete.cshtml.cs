using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Garden_Helper_Site.Data;
using Garden_Helper_Site.Models;

namespace Garden_Helper_Site.Pages.Plants
{
    public class DeleteModel : PageModel
    {
        private readonly Garden_Helper_Site.Data.Garden_Helper_SiteContext _context;

        public DeleteModel(Garden_Helper_Site.Data.Garden_Helper_SiteContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Plant Plant { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Plant == null)
            {
                return NotFound();
            }

            var plant = await _context.Plant.FirstOrDefaultAsync(m => m.ID == id);

            if (plant == null)
            {
                return NotFound();
            }
            else 
            {
                Plant = plant;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Plant == null)
            {
                return NotFound();
            }
            var plant = await _context.Plant.FindAsync(id);

            if (plant != null)
            {
                Plant = plant;
                _context.Plant.Remove(Plant);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
