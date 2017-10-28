using FluentAssertions;
using Xunit;

namespace Solutions.Tests
{
    public class KataTests
    {
        [Fact]
        public void BasicTests()
        {
            Kata.DuplicateEncode("din").Should().Be("(((");
            Kata.DuplicateEncode("recede").Should().Be("()()()");
            Kata.DuplicateEncode("Success").Should().Be(")())())", "should ignore case");
            Kata.DuplicateEncode("(( @").Should().Be("))((");
        }
    }
}
