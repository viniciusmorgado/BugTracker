using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bugtracker.Data
{
    public interface IUnitOfWork
    {
        void Commit();
        void Rollback();
    }
}
