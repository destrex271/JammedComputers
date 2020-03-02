using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JammedComputers.Data;
using JammedComputers.Models;

namespace JammedComputers
{
    public class IndexModel : PageModel
    {
        private readonly JammedComputers.Data.JammedComputersContext _context;

        public IndexModel(JammedComputers.Data.JammedComputersContext context)
        {
            _context = context;
        }

        public IList<Blog> Blog { get;set; }

        public async Task OnGetAsync()
        {
            Blog = await _context.Blog.ToListAsync();
        }
    }
}
