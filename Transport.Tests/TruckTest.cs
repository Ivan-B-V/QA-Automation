using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transport.Entities.Vehicle;
using Transport.Entities.Chassises;
using Transport.Entities.Transmissions;
using Transport.Entities.Engines;
using Transport.Enums;

namespace Transport.Tests
{
    [TestClass]
    public class TruckTest
    {
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void TruckChassisCannotHaveLessThan4Wheels()
        {
            Truck truck = new Truck(
                new DisielEngine(5, 250, "13-34-56"),
                new Chassis(3, 1000, "12-456-12"),
                new Mechanical(12,"34-56784-33-AA"),
                "Scania",
                12000
                );
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void TruckCannotHaveVariableSpeedDriveTransmission()
        {
            Truck truck = new Truck(
                new DisielEngine(5, 250, "13-34-56"),
                new Chassis(6, 1000, "12-456-12"),
                new VariableSpeedDrive("NoName"),
                "Scania",
                12000
                );
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void ParamsEngineChassisTransmissionInConstructorEqualsNull()
        {
            Truck truck = new Truck(
                null,
                null,
                null,
                "MAZ",
                1400
                );
        }
    }
}
