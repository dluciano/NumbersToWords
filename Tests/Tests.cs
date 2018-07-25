using Shouldly;
using System;
using ToWords;
using Xunit;

namespace Tests
{
    public class Tests
    {
        [Theory]
        [InlineData(0, "zero")]
        [InlineData(1, "one")]
        [InlineData(2, "two")]
        [InlineData(3, "three")]
        [InlineData(4, "four")]
        [InlineData(5, "five")]
        [InlineData(6, "six")]
        [InlineData(7, "seven")]
        [InlineData(8, "eight")]
        [InlineData(9, "nine")]
        public void OnesTests(int e, string name) =>
            e.ToWords().ShouldBe(name);
    }
}
