using System;
using System.Collections.Generic;
using Transport.Entities.Vehicle;
using Transport.Entities.Engines;
using Transport.Entities.Chassises;
using Transport.Entities.Transmissions;
using Transport.Enums;
using TransportDepartment.Entities;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Linq;

namespace TransportDepartment
{
    class Program
    {
        static void Main(string[] args)
        {
            Department department = new(CreateVehiclesList());

            ////Full information about all vehicles which engine volume more than 1.5 L.
            var first = department.Select(u => new { eng = u.Engine as InternalСombustionEngine, u })
                                .Where(obj => obj?.eng?.Volume > 1.5)
                                .Select(obj1 => obj1.u)
                                .ToList();

            //Engine type, engine serial number, engine power of all vehicles.
            var second = department.Where(obj => obj.GetType() == typeof(Bus) || obj.GetType() == typeof(Truck))
                                 .Select(obj => (EnType: obj.Engine.Type, Serial: obj.Engine.SerialNumber, EnPower: obj.Engine.Power))
                                 .ToList();

            //Full information about all vehicles grouped by TransmissionType.
            var third = department.GroupBy(v => v.Transmission.Type)
                                .Select(group => (TransmissionType: group.Key, Vehicles: group.ToList()))
                                .ToList();
                              

            WriteToXML(first);
            WriteToXML(second);
            WriteToXML(third);
        }

        public static void WriteToXML(object obj)
        {
            XmlSerializer serializer = new XmlSerializer(obj.GetType(), new Type[] { obj.GetType() });

            using (FileStream stream = new FileStream($"test{obj.GetHashCode()}.xml", FileMode.Create))
            {
                serializer.Serialize(stream, obj);
                stream.Close();
            }
        }

        public static List<Vehicle> CreateVehiclesList()
        {
            List<Vehicle> vehicles = new()
            {
                new Bus(
                new DisielEngine((float)5.2, 320, "13-34-56"),
                new Chassis(6, 1000, "12-456-12"),
                new TorqueConverter(10, "Scania"),
                "MAZ",
                25),
                new Bus(
                new PetrolEngine((float)6.5, 370, "13-34-56"),
                new Chassis(6, 1000, "12-456-12"),
                new TorqueConverter(10, "Scania"),
                "MAZ",
                25),
                new Car(
                new ElectricMotor(100, "serialnumber"),
                new Chassis(4, 400, "somenumber"),
                new Mechanical(6, "ZF"),
                "BMW",
                CarTypes.Sedan),
                new Car(
                new PetrolEngine((float)2.4, 240, "serialnumber"),
                new Chassis(4, 400, "somenumber"),
                new Mechanical(6, "ZF"),
                "BMW",
                CarTypes.Sedan),
                new Scooter(
                new ElectricMotor(15, "13-34-56"),
                new Chassis(2, 1000, "12-456-12"),
                new VariableSpeedDrive("ZF"),
                "Yamaha",
                ScooterTypes.MaxiScooter
                ),
                new Scooter(
                new PetrolEngine((float)0.125, 10, "13-34-56"),
                new Chassis(2, 1000, "12-456-12"),
                new VariableSpeedDrive("ZF"),
                "Yamaha",
                ScooterTypes.MaxiScooter
                ),
                new Truck(
                new DisielEngine((float)7.5, 500, "13-34-56"),
                new Chassis(6, 1000, "12-456-12"),
                new Mechanical(12, "Caterpillar"),
                "Scania",
                12000
                ),
                new Truck(
                new DisielEngine((float)6.5, 450, "13-34-56"),
                new Chassis(6, 1000, "12-456-12"),
                new TorqueConverter(12, "Caterpillar"),
                "Scania",
                12000
                )
            };

            return vehicles;
        }


    }
}
