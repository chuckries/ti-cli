using Xunit;
using Moq;
using TI;

namespace tests
{
    public class UnitTests
    {
        Mock<IUnit> _mockUnit;

        public UnitTests()
        {
            _mockUnit = new Mock<IUnit>();
            _mockUnit.SetupAllProperties();
        }

        [Fact]
        public void TestUnitCost()
        {
            IUnit unit = _mockUnit.Object;
            Assert.Equal(0, unit.Cost);
        }

        [Fact]
        public void TestUnitRoll()
        {
            IUnit unit = _mockUnit.Object;
            Assert.Equal(0, unit.Roll);
        }

        [Fact]
        public void TestUnitMovement()
        {
            IUnit unit = _mockUnit.Object;
            Assert.Equal(0, unit.Movement);
        }
    }
}
