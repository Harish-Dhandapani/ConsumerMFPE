using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ConsumerMicroservice.Models;
using ConsumerMicroservice.Repository;

namespace ConsumerMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsumerController : ControllerBase
    {
        BusinessMasterRepo _repo = new BusinessMasterRepo();

        [HttpGet("ViewConsumerBusiness")]

        public ActionResult ViewConsumerBusiness()
        {
            return Ok(_repo.GetBusinessMaster());
        }

        [HttpPost("CreateConsumerBusiness")]
        public ActionResult CreateConsumerBusiness([FromQuery]Consumer consumer)
        {
            if(consumer == null)
            {
                return NotFound("Consumer Not Found");
            }
            else
            {
                _repo.AddBMaster(consumer);
                return Ok(consumer);
            }
        }

        [HttpPut("UpdateConsumerBusiness")]
        public ActionResult UpdateBusinessProperty(int ID,[FromForm]Consumer consumer)
        {
            if (consumer == null)
            {
                return NotFound("Consumer Not Found");
            }
            else
            {
                _repo.UpdateBMaster(consumer);
                return Ok(consumer);
            }
        }
        
    }
}
