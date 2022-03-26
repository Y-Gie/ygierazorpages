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
    public class IndexModel : PageModel
    {
        private readonly ygierazorpages.Data.ygierazorpagesContext _context;

        public IndexModel(ygierazorpages.Data.ygierazorpagesContext context)
        {
            _context = context;
        }

        public IList<Music> Music { get;set; }

        public async Task OnGetAsync()
        {
            Music = await _context.Music.ToListAsync();
        }
    }
}
