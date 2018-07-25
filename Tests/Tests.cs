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
        [InlineData(10, "ten")]
        [InlineData(11, "eleven")]
        [InlineData(12, "twelve")]
        [InlineData(13, "thirteen")]
        [InlineData(14, "fourteen")]
        [InlineData(15, "fifteen")]
        [InlineData(16, "sixteen")]
        [InlineData(17, "seventeen")]
        [InlineData(18, "eighteen")]
        [InlineData(19, "nineteen")]
        public void Teens(int e, string name) =>
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

        [Theory]
        [InlineData(30, "thirty")]
        [InlineData(31, "thirty-one")]
        [InlineData(39, "thirty-nine")]
        [InlineData(40, "forty")]
        [InlineData(41, "forty-one")]
        [InlineData(49, "forty-nine")]
        [InlineData(50, "fifty")]
        [InlineData(51, "fifty-one")]
        [InlineData(59, "fifty-nine")]
        [InlineData(60, "sixty")]
        [InlineData(61, "sixty-one")]
        [InlineData(69, "sixty-nine")]
        [InlineData(70, "seventy")]
        [InlineData(71, "seventy-one")]
        [InlineData(79, "seventy-nine")]
        [InlineData(80, "eighty")]
        [InlineData(81, "eighty-one")]
        [InlineData(89, "eighty-nine")]
        [InlineData(90, "ninety")]
        [InlineData(91, "ninety-one")]
        [InlineData(99, "ninety-nine")]
        public void Tens(int e, string name) =>
            e.ToWords().ShouldBe(name);
    }
}
