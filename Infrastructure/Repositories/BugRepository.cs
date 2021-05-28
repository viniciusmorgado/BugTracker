﻿using DonattoTech.BugTracker.Core.Models;
using DonattoTech.BugTracker.Infrastructure.Data;
using System.Collections.Generic;
using System.Linq;

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
            catch (System.Exception ex)
            {

                throw new System.Exception("Não foi possível receber a lista de bugs.", ex);
            }
        }

       public IEnumerable<Bug> GetSolvedBugs()
       {
            try
            {
                return _bugDbContext.Bugs.Where(x => x.Status == "Resolvido");
            }
            catch (System.Exception ex)
            {

                throw new System.Exception("Não foi possível receber a lista de bugs.", ex);
            }
       }
    }
}