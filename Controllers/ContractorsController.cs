using cJobs.Models;
using cJobs.Services;
using Microsoft.AspNetCore.Mvc;

namespace cJobs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContractorsController : ControllerBase
    {
        private readonly ContractorsService _service;

        public ContractorsController(ContractorsService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<Contractor> Get()
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