using Microsoft.AspNetCore.Mvc;
using ShowReel.Core.Repositories;
using ShowReel.Data.Repositories;

namespace ShowReel.RestService.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ReelController : Controller
    {
        private readonly IReelRepository _reelRepository;
        public ReelController(IReelRepository reelRepository)
        {
            this._reelRepository = reelRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                var result = this._reelRepository.GetAll();
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
                var result = this._reelRepository.Get(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
