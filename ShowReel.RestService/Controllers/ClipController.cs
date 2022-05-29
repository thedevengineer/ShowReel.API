using Microsoft.AspNetCore.Mvc;
using ShowReel.Core.Interface.Services;

namespace ShowReel.RestService.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ClipController : Controller
    {
        private readonly IClipService _clipService;
        public ClipController(IClipService clipService)
        {
            this._clipService = clipService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                var result = this._clipService.GetAllWithVideoQuality();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Index(int id)
        {

            try
            {
                var result = this._clipService.FindWithVideoQualityByIds(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
