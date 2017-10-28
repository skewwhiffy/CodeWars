using FluentAssertions;

namespace Solutions.Tests.NunitCompatibility
{
  public static class Assert
  {
    public static void AreEqual(object expected, object actual)
    {
      actual.Should().Be(expected);
    }
  }
}