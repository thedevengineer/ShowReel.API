using Microsoft.AspNetCore.Mvc;
using ShowReel.Core.Repositories;
using ShowReel.Data;

namespace ShowReel.RestService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VideoQualityController : Controller
    {
        private readonly IVideoQualityRepository _videoQualityRepository;
        public VideoQualityController(IVideoQualityRepository videoQualityRepository)
        {
            this._videoQualityRepository = videoQualityRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                var result = this._videoQualityRepository.GetAll();
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
                var result = this._videoQualityRepository.Get(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
