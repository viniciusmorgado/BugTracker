using bugtracker.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bugtracker.Models.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly BugDbContext _context;

        public BaseRepository(BugDbContext context)
        {
            _context = context;
        }
    }
}
