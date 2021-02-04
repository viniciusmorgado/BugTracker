using bugtracker.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bugtracker.Models.Services
{
    public class BugService : IBugService
    {
        private readonly IBugRepository _bugRepository;

        public BugService(IBugRepository bugRepository)
        {
           _bugRepository = bugRepository;
        }

        public async Task<IEnumerable<Bug>> ListAsync()
        {
            return await _bugRepository.ListAsync();
        }
    }
}
