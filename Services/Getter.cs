using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JammedComputers.Models;

namespace JammedComputers.Services
{
    public class Getter
    {

        private readonly JammedComputers.Data.JammedComputersContext _context;

        public Getter(JammedComputers.Data.JammedComputersContext ct)
        {
            _context = ct;
        }

        public IList<Blog> GetBlogs()
        {
            var blgs = from m in _context.Blog
                       select m;
            return blgs.ToList<Blog>();
        }

    }
}
