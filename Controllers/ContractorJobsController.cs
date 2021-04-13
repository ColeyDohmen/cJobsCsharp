using cJobs.Models;
using cJobs.Services;
using Microsoft.AspNetCore.Mvc;

namespace cJobs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContractorJobsController : ControllerBase
    {
        private readonly ContractorJobsService _service;

        public ContractorJobsController(ContractorJobsService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult<ContractorJob> Create([FromBody] ContractorJob newCJ)
        {
            try
            {
                return Ok(_service.Create(newCJ));
            }
            catch (System.Exception err)
            {

                return BadRequest(err.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            try
            {
                _service.Delete(id);
                return Ok("deleted");
            }
            catch (System.Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}