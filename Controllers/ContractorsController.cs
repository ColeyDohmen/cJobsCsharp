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

        [HttpGet("{id}")]
        public ActionResult<Contractor> Get(int id)
        {
            try
            {
                return Ok(_service.GetById(id));
            }
            catch (System.Exception err)
            {

                return BadRequest(err.Message);
            }
        }

        [HttpPost]
        public ActionResult<Contractor> Create([FromBody] Contractor newContractor)
        {
            try
            {
                return Ok(_service.Create(newContractor));
            }
            catch (System.Exception err)
            {

                return BadRequest(err.Message);
            }
        }
    }
}