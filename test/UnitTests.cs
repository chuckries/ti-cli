using Xunit;

namespace tests
{
    public class MockUnit : TI.Unit
    {
        public MockUnit(byte cost, byte roll, byte movement) : 
            base(cost, roll, movement)
        {
        }
    }

    public class UnitTests
    {
        private readonly MockUnit _mockUnit;
        private const byte kCost = 5;
        private const byte kRoll = 8;
        private const byte kMovement = 1;

        public UnitTests()
        {
            _mockUnit = new MockUnit(kCost, kRoll, kMovement);
        }

        [Fact]
        public void TestUnitCost()
        {
            Assert.Equal(kCost, _mockUnit.Cost);
        }

        [Fact]
        public void TestUnitRoll()
        {
            Assert.Equal(kRoll, _mockUnit.Roll);
        }

        [Fact]
        public void TestUnitMovement()
        {
            Assert.Equal(kMovement, _mockUnit.Movement);
        }
    }
}
