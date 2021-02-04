using bugtracker.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bugtracker.Models.Repositories
{
    public class BugRepository : BaseRepository, IBugRepository
    {
        public BugRepository(BugDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Bug>> ListAsync()
        {
            return await _context.Bugs.ToListAsync();
        }
    }
}
