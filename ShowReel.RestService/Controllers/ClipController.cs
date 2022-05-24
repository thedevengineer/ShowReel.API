using Microsoft.AspNetCore.Mvc;
using ShowReel.Core.Repositories;
using ShowReel.Data.Repositories;

namespace ShowReel.RestService.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ClipController : Controller
    {
        private readonly IClipRepository _clipRepository;
        public ClipController(IClipRepository clipRepository)
        {
            this._clipRepository = clipRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                var result = this._clipRepository.GetAll();
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
                var result = this._clipRepository.Get(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
