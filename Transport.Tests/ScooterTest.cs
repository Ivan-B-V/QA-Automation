using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transport.Entities.Vehicle;
using Transport.Entities.Chassises;
using Transport.Entities.Transmissions;
using Transport.Entities.Engines;
using Transport.Enums;

namespace Transport.Tests
{
    [TestClass]
    public class ScooterTest
    {
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void ScooterChassisCannotHaveMoreThan3Wheels()
        {
            Scooter scooter = new Scooter(
                new PetrolEngine(5, 250, "13-34-56"),
                new Chassis(4, 1000, "12-456-12"),
                new Mechanical(12, "34-56784-33-AA"),
                "Yamaha",
                ScooterTypes.MaxiScooter
                );
        } 

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void ScooterChassisCannotHaveLessThan2Wheels()
        {
            Scooter scooter = new Scooter(
                new PetrolEngine(5, 250, "13-34-56"),
                new Chassis(1, 1000, "12-456-12"),
                new VariableSpeedDrive("Yamaha"),
                "Yamaha",
                ScooterTypes.MaxiScooter
                );
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void MecanicalTransmissonInConstructor()
        {
            Scooter scooter = new Scooter(
                new PetrolEngine(5, 250, "13-34-56"),
                new Chassis(2, 1000, "12-456-12"),
                new Mechanical(12, "BMW"),
                "Yamaha",
                ScooterTypes.MaxiScooter
                );
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void TorqueConverterTransmissonInConstructor()
        {
            Scooter scooter = new Scooter(
                new PetrolEngine(5, 250, "13-34-56"),
                new Chassis(2, 1000, "12-456-12"),
                new TorqueConverter(12, "ZF"),
                "Yamaha",
                ScooterTypes.MaxiScooter
                );
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void DisielEngineInConstructor()
        {
            Scooter scooter = new Scooter(
                new DisielEngine(5, 250, "13-34-56"),
                new Chassis(2, 1000, "12-456-12"),
                new VariableSpeedDrive("ZF"),
                "Yamaha",
                ScooterTypes.MaxiScooter
                );
        }

        [TestMethod]
        public void PetrolEngineInConstructor()
        {
            Scooter scooter = new Scooter(
                new PetrolEngine(5, 250, "13-34-56"),
                new Chassis(2, 1000, "12-456-12"),
                new VariableSpeedDrive("ZF"),
                "Yamaha",
                ScooterTypes.MaxiScooter
                );
            Assert.AreEqual(EngineType.Petrol, scooter.Engine.Type);
        }

        [TestMethod]
        public void ElectricEngineInConstructor()
        {
            Scooter scooter = new Scooter(
                new ElectricMotor(250, "13-34-56"),
                new Chassis(2, 1000, "12-456-12"),
                new VariableSpeedDrive("ZF"),
                "Yamaha",
                ScooterTypes.MaxiScooter
                );
            Assert.AreEqual(EngineType.Electric, scooter.Engine.Type);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void ParamsEngineChassisTransmissionInConstructorEqualsNull()
        {
            Scooter scooter = new Scooter(
                null,
                null,
                null,
                "Yamaha",
                ScooterTypes.MaxiScooter
                );
        }


    }
}
