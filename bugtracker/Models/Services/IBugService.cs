using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bugtracker.Models.Services
{
    public interface IBugService
    {
        Task<IEnumerable<Bug>> ListAsync();
    }
}
