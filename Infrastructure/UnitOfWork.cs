using DonattoTech.BugTracker.Infrastructure.Data;

namespace DonattoTech.BugTracker.Infrastructure
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
