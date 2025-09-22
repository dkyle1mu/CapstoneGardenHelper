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
    public class DetailsModel : PageModel
    {
        private readonly Garden_Helper_Site.Data.Garden_Helper_SiteContext _context;

        public DetailsModel(Garden_Helper_Site.Data.Garden_Helper_SiteContext context)
        {
            _context = context;
        }

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
    }
}
