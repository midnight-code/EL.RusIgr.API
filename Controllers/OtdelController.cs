using EL.RusIgr.API.Model;
using EL.RusIgr.API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EL.RusIgr.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OtdelController : ControllerBase
    {
        private readonly IOtdelRepositor _otdelRepositor;
        public OtdelController(IOtdelRepositor otdelRepositor) => _otdelRepositor = otdelRepositor;

        [HttpGet, Route("otdel")]
        public ActionResult<IEnumerable<OtdelModel>> GetOtdelAll()
        {
            try
            {
                List<OtdelModel> model = _otdelRepositor.GetAllOtdel().ToList();
                if(model.Count > 0)
                    return Ok(model);
            }
            catch
            {
                return StatusCode(StatusCodes.Status405MethodNotAllowed);
            }
            return NotFound();
        }
    }
}
