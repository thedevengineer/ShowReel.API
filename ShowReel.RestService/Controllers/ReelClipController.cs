using Microsoft.AspNetCore.Mvc;
using ShowReel.Core.Interface.Services;
using ShowReel.RestService.Models;

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
        [Route("Calculate")]
        public IActionResult Calulate(int[] clipIds)
        {
            try
            {
                var clips = _clipService.FindAllWithVideoQuality(clipIds).ToList();

                return Ok(_reelClipService.CalculateTimeCode(clips));
            }
            catch (Exception ex)
            {
                return  BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Submit(ReelClipRequest request)
        {
            //Todo: Add code to save to database
            return Ok();
        }
    }
}
