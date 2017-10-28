using Solutions.Tests.NunitCompatibility;

namespace Solutions.Tests
{
  public class TwoToOneTests
  {
    int[] Test1 = new int[] {0,0,0,0};
    int[] Test2 = new int[] {1,1,1,1};
    int[] Test3 = new int[] {0,1,1,0};
    int[] Test4 = new int[] {0,1,0,1};

    [Test]
    public void BasicTesting()
    {
      Assert.AreEqual(0 , Kata.binaryArrayToNumber(Test1));
      Assert.AreEqual(15 , Kata.binaryArrayToNumber(Test2));
      Assert.AreEqual(6 , Kata.binaryArrayToNumber(Test3));
      Assert.AreEqual(5 , Kata.binaryArrayToNumber(Test4));
    }
  }
}