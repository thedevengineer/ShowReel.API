using Xunit;
using ShowReel.Core.Domain;
using ShowReel.Core.Extensions;

namespace ShowReel.Test
{
    public class NtscTimeCodeTest
    {
        [Fact]
        public void NtscTimeCode_Sum__Pass()
        {
            string[] inputs = { "00:00:15:27", "00:00:18:11", "00:00:20:00" };
            string output = "00:00:54:08";

            var sumation = new NtscTimeCode(0, 0, 0, 0);
            foreach (string input in inputs)
            {
                var timeCode = new NtscTimeCode(input);
                var res = timeCode.Sum(sumation);

                sumation = new NtscTimeCode(res.hour, res.minute, res.sec, res.frame);   
            }
            var actualOutput = sumation.ToString();

            Assert.Equal(output, actualOutput);
        }
    }
}
