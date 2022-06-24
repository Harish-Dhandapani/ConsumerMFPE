using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ConsumerMicroservice.Models;
using ConsumerMicroservice.Repository;

namespace ConsumerMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        //PropertyRepo _repo = new PropertyRepo();
        PropertyMasterRepo _repo = new PropertyMasterRepo();

        [HttpGet("ViewConsumerBusiness")]
        public ActionResult ViewConsumerBusiness()
        {
            return Ok(_repo.GetAllPMaster());
        }

        [HttpPost("CreateBusinessProperty")]
        public ActionResult CreateBusinessProperty([FromQuery]Property Prop)
        {
            if(Prop == null)
            {
                return NotFound("Invalid Details....");
            }
            else
            {
                return Ok(_repo.AddToPMaster(Prop));
            }
        }

        [HttpPut("UpdateBusinessProperty")]
        public ActionResult UpdateBusinessProperty(int Id,[FromForm]Property Prop)
        {
            if (Prop == null)
            {
                return NotFound("Invalid Details....");
            }
            else
            {
                return Ok(_repo.UpdatePMaster(Prop));
            }
        }
    }
}
