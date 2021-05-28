using DonattoTech.BugTracker.Core.Models;
using System.Collections.Generic;

namespace DonattoTech.BugTracker.Infrastructure.Repositories
{
    public interface IBugRepository
    {
        IEnumerable<Bug> GetBugs();

        IEnumerable<Bug> GetSolvedBugs();
    }   
}
