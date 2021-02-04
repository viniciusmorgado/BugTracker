using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bugtracker.Models.Repositories
{
    public interface IBugRepository
    {
        Task<IEnumerable<Bug>> ListAsync();
    }
}
