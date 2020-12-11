using Xunit;
using PracticeInterfaceSegregationPrinciple.Sample2.BeforeISP;

namespace Test.Sample2.BeforeISP
{
    public class TestMultifunctionalCar
    {
        public class DriveMethod
        {
            [Fact]
            public void Drive_Calculated()
            {
                MultiFunctionalCar car = new MultiFunctionalCar();

                string expected = "MultiFunctionalCar Drive";
                Assert.Equal(expected, car.Drive());
            }
        }

        public class FlyMethod
        {
            [Fact]
            public void Drive_Calculated()
            {
                MultiFunctionalCar car = new MultiFunctionalCar();

                string expected = "MultiFunctionalCar Fly";
                Assert.Equal(expected, car.Fly());
            }
        }
    }
}
