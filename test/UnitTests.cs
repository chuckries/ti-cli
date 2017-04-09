using Xunit;
using TwilightImperium;

namespace tests
{
    public class UnitTests
    {
        public UnitTests()
        {
        }

        [Fact]
        public void TestUnitCost()
        {
            SpaceDock spaceDock = new SpaceDock();
            Assert.Equal(4, spaceDock.Cost);
        }
    }
}
