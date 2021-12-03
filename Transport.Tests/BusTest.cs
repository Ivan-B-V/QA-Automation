using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transport.Entities.Vehicle;
using Transport.Entities.Chassises;
using Transport.Entities.Transmissions;
using Transport.Entities.Engines;
using Transport.Enums;

namespace Transport.Tests
{
    [TestClass]
    public class BusTest
    {
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void ChassisInBusCannotHaveLessThan4Wheels()
        {
            Bus bus = new Bus(
                new DisielEngine(5, 250, "13-34-56"),
                new Chassis(3, 1000, "12-456-12"),
                new TorqueConverter(10, "Scania"),
                "MAZ",
                25);
        }
        
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void BusCannotHaveVariableSpeedDriveTransmission()
        {
            Bus bus = new Bus(
                new DisielEngine(5, 250, "13-34-56"),
                new Chassis(6, 1000, "12-456-12"),
                new VariableSpeedDrive("Aisin"),
                "MAZ",
                25);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void ParamsEngineChassisTransmissionInConstructorEqualsNull()
        {
            Bus bus = new Bus(
                null,
                null,
                null,
                "MAZ",
                34
                );
        }
    }
}
