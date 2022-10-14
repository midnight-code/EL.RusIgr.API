using EL.RusIgr.API.Model;
using EL.RusIgr.API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EL.RusIgr.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipOtdelaController : ControllerBase
    {
        private readonly ITipOtdelaRepositor _tipRepositor;
        public TipOtdelaController(ITipOtdelaRepositor tipRepositor) => _tipRepositor = tipRepositor;
        

        [HttpGet, Route("tipotdela_byotdel")]
        public ActionResult<List<TipOtdelaModel>> GetTipOtdelaByOtdelID(int id)
        {
            if (id > 0)
            {
                List<TipOtdelaModel> tipOtdelas = _tipRepositor.GetTipOtdelaByOtdelId(id).ToList();
                if (tipOtdelas.Count > 0)
                {
                    return Ok(tipOtdelas);
                }
            }
            return NotFound();
        }
    }
}
