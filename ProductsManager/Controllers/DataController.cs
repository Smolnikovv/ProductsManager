using Microsoft.AspNetCore.Mvc;
using ProductsManager.Services;

namespace ProductsManager.Controllers
{
    [Route("api/data")]
    public class DataController : ControllerBase
    {
        private readonly IDataService _service;

        public DataController(IDataService service) 
        {
            _service = service;
        }
        [HttpPost]
        public ActionResult InsertData()
        {
            if (_service.InsertData()) return Ok();
            return BadRequest();
        }
    }
}
