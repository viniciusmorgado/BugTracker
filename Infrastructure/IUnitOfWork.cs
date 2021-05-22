using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonattoTech.BugTracker.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
        void Rollback();
    }
}
