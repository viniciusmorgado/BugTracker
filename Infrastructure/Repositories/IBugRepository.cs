using DonattoTech.BugTracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonattoTech.BugTracker.Infrastructure.Repositories
{
    public interface IBugRepository
    {
        IEnumerable<Bug> GetBugs();
    }   
}
