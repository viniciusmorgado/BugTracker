using DonattoTech.BugTracker.Core.Models;
using DonattoTech.BugTracker.Infrastructure.Data;
using DonattoTech.BugTracker.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DonattoTech.BugTracker.Infrastructure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BugsController : ControllerBase
    {
        private readonly IBugRepository _bugRepository;

        public BugsController()
        {
            _bugRepository = new BugRepository(new BugDbContext());
        }

        #region GET
        
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Bug> Get() =>
            _bugRepository.GetBugs();

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Bug> GetSolved() =>
            _bugRepository.GetSolvedBugs();

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Bug> GetLastMonths() =>
            _bugRepository.GetLastOneMonthBugs();

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Task<Bug> Get(int id) =>
            _bugRepository.GetOneItem(id);

        #endregion

        #region POST

        // POST api/bugs
        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Bug bug) =>
            _bugRepository.PostANewBug(bug);

        #endregion

        #region UPDATE

        // PUT api/<ValuesController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value) { }

        #endregion

        #region DELETE

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) =>
            _bugRepository.DeleteBugs(id);

        #endregion
    }
}
