using ShowReel.Core.App.CustomException;
using Xunit;
using ShowReel.Core.App.Models;
using ShowReel.Core.App.Extensions;

namespace ShowReel.Test
{
    public class PalTimeCodeTest
    {
        [Fact]
        public void PalTimeCode_Sum__Pass()
        {
            string[] inputs = { "00:00:30:12" , "00:01:30:00", "00:00:10:14" };
            string output = "00:02:11:01";

            var sumation = new PalTimeCode(0, 0, 0, 0);
            foreach (string input in inputs)
            {
                var timeCode = new PalTimeCode(input);
                var res = timeCode.Sum(sumation);

                sumation = new PalTimeCode(res.hour, res.minute, res.sec, res.frame);   
            }
            var actualOutput = sumation.ToString();

            Assert.Equal(output, actualOutput);
        }
    }
}
