using DonattoTech.BugTracker.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DonattoTech.BugTracker.Infrastructure.Repositories
{
    public interface IBugRepository
    {
        IEnumerable<Bug> GetBugs();

        IEnumerable<Bug> GetSolvedBugs();

        IEnumerable<Bug> GetLastOneMonthBugs();

        Task<Bug> PostANewBug(Bug bug);

        //Task<Bug> GetOneItem(int value);
    }   
}
