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
    public class IndexModel : PageModel
    {
        private readonly Garden_Helper_Site.Data.Garden_Helper_SiteContext _context;

        public IndexModel(Garden_Helper_Site.Data.Garden_Helper_SiteContext context)
        {
            _context = context;
        }

        public IList<Plant> Plant { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Plant != null)
            {
                Plant = await _context.Plant.ToListAsync();
            }
        }
    }
}
