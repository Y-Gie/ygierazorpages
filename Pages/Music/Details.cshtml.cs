#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ygierazorpages.Data;

namespace ygierazorpages.Pages.Music
{
    public class DetailsModel : PageModel
    {
        private readonly ygierazorpages.Data.ygierazorpagesContext _context;

        public DetailsModel(ygierazorpages.Data.ygierazorpagesContext context)
        {
            _context = context;
        }

        public Music Music { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Music = await _context.Music.FirstOrDefaultAsync(m => m.ID == id);

            if (Music == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
