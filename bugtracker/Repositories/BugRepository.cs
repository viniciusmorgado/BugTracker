using bugtracker.Data;
using bugtracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bugtracker.Repositories
{
    public class BugRepository : IBugRepository
    {
        private readonly BugDbContext _bugDbContext;

        public BugRepository(BugDbContext bugDbContext)
        {
            _bugDbContext = bugDbContext;
        }

        public void Save(Bug bug)
        {
            _bugDbContext.Bugs.Add(bug);
        }
    }
}
