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
        public void OnesTests(int e, string name) =>
            e.ToWords().ShouldBe(name);
    }
}
