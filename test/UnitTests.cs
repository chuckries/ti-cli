using Xunit;
using Moq;
using TI.Unit;

namespace tests
{
    public class UnitTests
    {
        private Mock<IUnit> _mockUnit;

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
    }
}
