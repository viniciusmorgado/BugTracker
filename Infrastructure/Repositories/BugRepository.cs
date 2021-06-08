using DonattoTech.BugTracker.Core.Models;
using DonattoTech.BugTracker.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DonattoTech.BugTracker.Infrastructure.Repositories
{
    public class BugRepository : IBugRepository
    {
        private readonly BugDbContext _bugDbContext;

        public BugRepository(BugDbContext bugDbContext)
        {
            _bugDbContext = bugDbContext;
        }

        public IEnumerable<Bug> GetBugs()
        {
            try
            {
               return _bugDbContext.Bugs.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possível receber a lista de bugs.", ex);
            }
        }

       public IEnumerable<Bug> GetSolvedBugs()
       {
            try
            {
                return _bugDbContext.Bugs.Where(x => x.Status == "Resolvido");
            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possível receber a lista de bugs.", ex);
            }
       }

        public IEnumerable<Bug> GetLastOneMonthBugs()
        {
            try
            {
                return _bugDbContext.Bugs.Where(x =>
                    DateTime.Compare(x.BeginDate, DateTime.Today.AddMonths(-1)) >= 0);
            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possível receber a lista de bugs.", ex);
            }
        }

        public async Task<Bug> PostANewBug(Bug bug)
        {
            try 
            {
                var result = _bugDbContext.Bugs.Add(bug);
                _bugDbContext.SaveChanges();
                return await Task.Run(() => result.Entity);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível gravar as informações no banco de dados.", ex);
            }
        }

        public async Task<Bug> GetOneItem(int value)
        {
            try
            {
                return await Task.Run(() => _bugDbContext.Bugs.Find(value));
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível encontrar as informações no banco de dados.", ex);
            }
        }

        public async Task<Bug> DeleteBugs(int id)
        {
            var bugForDelete = _bugDbContext.Bugs.Find(id);
            if (bugForDelete != null)
            {
                await Task.Run(() => _bugDbContext.Bugs.Remove(bugForDelete));
                _bugDbContext.SaveChanges();
            }
            return bugForDelete;
        }

        //public async Task<Bug> UpdateBugs(int id)
        //{
            
        //    var bugForUpdate = _bugDbContext.Bugs.Attach(id);
        //    await Task.Run(() => bugForUpdate.State = Microsoft.EntityFrameworkCore.EntityState.Modified);
        //    _bugDbContext.SaveChanges();
        //    return bugForUpdate;
        //}
        
    }
}