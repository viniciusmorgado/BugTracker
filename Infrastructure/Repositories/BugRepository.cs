using DonattoTech.BugTracker.Core.Models;
using DonattoTech.BugTracker.Infrastructure.Data;
using System.Collections.Generic;
using System.Linq;

namespace DonattoTech.BugTracker.Infrastructure.Repositories
{
    public class BugRepository : IBugRepository
    {
        private readonly BugDbContext _bugDbContext;

        public BugRepository(BugDbContext bugDbContext)
        {
            _bugDbContext = bugDbContext;
        }

        public IEnumerable<Bug> GetBugs()
        {
            return _bugDbContext.Bugs.ToList();
        }
    }
}
