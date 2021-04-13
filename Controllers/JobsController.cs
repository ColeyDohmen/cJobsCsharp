using cJobs.Models;
using cJobs.Services;
using Microsoft.AspNetCore.Mvc;

namespace cJobs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobsController : ControllerBase
    {
        private readonly JobsService _service;

        public JobsController(JobsService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<Job> Get()
        {
            try
            {
                return Ok(_service.GetAll());
            }
            catch (System.Exception err)
            {

                return BadRequest(err.Message);
            }
        }
    }
}