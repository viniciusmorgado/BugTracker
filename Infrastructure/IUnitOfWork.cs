namespace DonattoTech.BugTracker.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
        void Rollback();
    }
}
