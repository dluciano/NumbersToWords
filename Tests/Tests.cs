using Shouldly;
using System;
using ToWords;
using Xunit;

namespace UnitTests
{
    public class NumberToWordsTests
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

        [Theory]
        [InlineData(20, "twenty")]
        [InlineData(21, "twenty-one")]
        [InlineData(22, "twenty-two")]
        [InlineData(23, "twenty-three")]
        [InlineData(24, "twenty-four")]
        [InlineData(25, "twenty-five")]
        [InlineData(26, "twenty-six")]
        [InlineData(27, "twenty-seven")]
        [InlineData(28, "twenty-eight")]
        [InlineData(29, "twenty-nine")]
        public void Twenties(int e, string name) =>
            e.ToWords().ShouldBe(name);
    }
}
