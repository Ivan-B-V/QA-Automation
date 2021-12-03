using System;
using System.Collections.Generic;
using Transport.Entities.Vehicle;
using Transport.Entities.Engines;
using Transport.Entities.Chassises;
using Transport.Entities.Transmissions;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Linq;

using Transport.Enums;
using TransportDepartment.Entities;
using System.Collections;
using TransportDepartment.Context;

namespace TransportDepartment
{
    class Program
    {
        static void Main(string[] args)
        {
            Department department = new (CreateVehiclesList());

            //Полная информацию о всех транспортных средствах, обьем двигателя которых больше, чем 1.5 литров
            var first = department.Select(u => new { eng = u.Engine as InternalСombustionEngine, u})
                                .Where(obj => obj?.eng?.Volume > 1.5)
                                .Select(obj1 => obj1.u)
                                .ToList();

            //Тип двигателя, серийный номер и его мощность для всех автобусов и грузовиков
            var second = department.Where(obj => obj.GetType() == typeof(Bus) || obj.GetType() == typeof(Truck))
                                 .Select(obj => new EngineContext { Type = obj.Engine.Type, Power = obj.Engine.Power, SerialNumber = obj.Engine.SerialNumber })
                                 .ToList();

            //Полная информацию о всех транспортных средствах, сгруппированную по типу трансмиссии
            var third = department.GroupBy(v => v.Transmission.Type)
                                .Select(group => new TransmissionTypeGroupContext { TransmissionType = group.Key, Vehicles = group.ToList() })
                                .ToList();

            WriteVehicleToXML(first);
            WriteVehicleToXML(second);
            WriteVehicleToXML(third);



            //using (FileStream stream = new FileStream("test2.xml", FileMode.Open))
            //{
            //    List<Engine> engines = (List<Engine>)serializer.Deserialize(stream);

            //    Console.WriteLine("Объект десериализован");
            //    foreach (var engine in engines)
            //    {
            //        Console.WriteLine(engine?.ToString());
            //    }

            //}
        }

        public static void WriteVehicleToXML(object obj)
        {
            XmlSerializer serializer = new XmlSerializer(obj.GetType(), new Type[] { typeof(Bus), typeof(Car), typeof(Truck), typeof(Scooter),
                                                         typeof(DisielEngine), typeof(PetrolEngine), typeof(ElectricMotor),
                                                         typeof(VariableSpeedDrive), typeof(TorqueConverter), typeof(Mechanical)});

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
