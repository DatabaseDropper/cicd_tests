using Xunit;
namespace ci.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Thread.Sleep(2000);
            Console.WriteLine("success test run");
        }
    }
}