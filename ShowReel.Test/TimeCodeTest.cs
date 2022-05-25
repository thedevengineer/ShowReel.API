using Xunit;
using ShowReel.Core.Domain;
using ShowReel.Core.Extensions;
using ShowReel.Core.Exceptions;

namespace ShowReel.Test
{
    public class TimeCodeTest
    {
        [Fact]
        public void TimeCode__CorrectFormat__Pass()
        {
            var input = "11:23:25:22";
            var timeCode = new PalTimeCode(input);

            Assert.Equal(input, $"{timeCode.Hours}:{timeCode.Minutes}:{timeCode.Seconds}:{timeCode.Frames}");
        }

        [Fact]
        public void TimeCode__WhiteSpace__InvalidFormatException()
        {
            var input = " ";

            Assert.Throws<InvalidFormatException>(() => new NtscTimeCode(input));
        }

        [Fact]
        public void TimeCode__Characters__InvalidFormatException()
        {
            var input = "aa:bb:cc:dd";

            Assert.Throws<InvalidFormatException>(() => new NtscTimeCode(input));
        }

    }
}