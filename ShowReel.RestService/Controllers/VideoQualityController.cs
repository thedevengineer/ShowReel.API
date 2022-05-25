using Microsoft.AspNetCore.Mvc;
using ShowReel.Core.Interface.Repositories;

namespace ShowReel.RestService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VideoQualityController : Controller
    {
        private readonly IVideoQualityService _videoQualityService;
        public VideoQualityController(IVideoQualityService videoQualityService)
        {
            this._videoQualityService = videoQualityService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                var result = this._videoQualityService.GetAll();
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
                var result = this._videoQualityService.Get(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
