using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transport.Entities.Vehicle;
using Transport.Entities.Chassises;
using Transport.Entities.Transmissions;
using Transport.Entities.Engines;
using Transport.Enums;

namespace Transport.Tests
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void TestCarConstructorChassisHasLessThan2Wheels()
        {
            Car car = new Car(
                new PetrolEngine((float)3.0, 250, "serialnumber"),
                new Chassis(1, 400, "somenumber"),
                new Mechanical(6, "ZF"),
                "BMW",
                CarTypes.Sedan);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void ParamsEngineChassisTransmissionInConstructorEqualsNull()
        {
            Car car = new Car(
                null,
                null,
                null,
                "MAZ",
                CarTypes.Sedan
                );
        }
    }
}
