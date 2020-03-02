using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JammedComputers.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace JammedComputers.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly JammedComputers.Data.JammedComputersContext _context;

        public IndexModel(ILogger<IndexModel> logger, JammedComputers.Data.JammedComputersContext ctxt)
        {
            _logger = logger;
            _context = ctxt;
        }

        public IList<Blog> Blogs { get; set; }

        public async Task OnGetAsync()
        {
            var blgs = from m in _context.Blog
                       select m;
            Blogs = await blgs.ToListAsync();
        }
    }
}
