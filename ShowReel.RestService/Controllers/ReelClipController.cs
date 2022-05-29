using Microsoft.AspNetCore.Mvc;
using ShowReel.Core.Interface.Services;

namespace ShowReel.RestService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReelClipController : Controller
    {
        private readonly IReelClipService _reelClipService;
        private readonly IClipService _clipService;
        public ReelClipController(IReelClipService reelClipService, IClipService clipService)
        {
            this._reelClipService = reelClipService;
            this._clipService = clipService;
        }
        [HttpPost]
        public IActionResult Calulate(int[] ClipIds)
        {
            try
            {
                var clips = _clipService.FindAllWithVideoQuality(ClipIds).ToList();

                return Ok(_reelClipService.CalculateTimeCode(clips));
            }
            catch (Exception ex)
            {
                return  BadRequest(ex.Message);
            }
        }
    }
}
