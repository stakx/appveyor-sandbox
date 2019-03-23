using System;

using Xunit;

namespace DemoLib.Tests
{
    public sealed class DemolisherTests
    {
        [Fact]
        public void Demolish_when_called_on_null_throws_ArgumentNullException()
        {
            string str = null;
            Assert.Throws<ArgumentNullException>(() => str.Demolish());
        }

        [Fact]
        public void Demolish_when_called_on_empty_string_returns_empty_string()
        {
            Assert.Equal("", "".Demolish());
        }

        [Theory]
        [InlineData("D", "")]
        [InlineData("De", "D")]
        [InlineData("Dem", "De")]
        [InlineData("Demo", "Dem")]
        [InlineData("Demol", "Demo")]
        [InlineData("Demoli", "Demol")]
        [InlineData("Demolis", "Demoli")]
        [InlineData("Demolish", "Demolis")]
        public void Demolish_when_called_on_non_empty_string_removes_the_last_character(string str, string expected)
        {
            var actual = str.Demolish();
            Assert.Equal(expected, actual);
        }
    }
}
