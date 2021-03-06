using bugtracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bugtracker.Repositories
{
    public interface IBugRepository
    {
        void Save(Bug bug);
    }
}
