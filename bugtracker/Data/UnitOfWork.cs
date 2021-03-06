using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bugtracker.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BugDbContext _bugDbContext;

        public UnitOfWork(BugDbContext bugDbContext)
        {
            _bugDbContext = bugDbContext;
        }

        public void Commit()
        {
            _bugDbContext.SaveChanges();
        }

        public void Rollback()
        {
            throw new System.NotImplementedException();
        }
    }
}
