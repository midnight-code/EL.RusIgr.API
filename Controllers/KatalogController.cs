using EL.RusIgr.API.Model;
using EL.RusIgr.API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace EL.RusIgr.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KatalogController : ControllerBase
    {
        private readonly IKatalogRepositor _katalogRepositor;

        public KatalogController(IKatalogRepositor katalogRepositor) => _katalogRepositor = katalogRepositor;

        [HttpGet, Route("katalog_tipotdel")]
        public ActionResult<IEnumerable<KatalogModel>> GetKatalogByidTipOtdela(int idtip)
        {
            List<KatalogModel> katalogModels = _katalogRepositor.GetKatalogByTipId(idtip).ToList();
            if(katalogModels.Count == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(katalogModels);
            }
        }

        [HttpGet, Route("katalog_details")]
        public ActionResult<KatalogModel> GetKatalogDetails(int id)
        {
            KatalogModel katalogModels = _katalogRepositor.GetKatalogById(id);
            if (katalogModels == null)
            {
                return NotFound("Тупо нихуя");
            }
            else
            {
                return Ok(katalogModels);
            }
        }

        [HttpGet, Route("katalog_ls")]
        public ActionResult<KatalogModel> GetKatalogDetailsLS(int id)
        {
            KatalogModel katalogModels = _katalogRepositor.GetKatalogById(id);
            if (katalogModels == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(katalogModels);
            }
        }

    }
}
