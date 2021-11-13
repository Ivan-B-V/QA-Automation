using Transport.Entities.Engines;
using Transport.Entities.Chassises;
using Transport.Entities.Transmissions;
using Transport.Enums;
using System.Collections.Generic;
namespace Transport.Entities.Vehicle
{
    class Scooter : Vehicle
    {
        public ScooterTypes ScooterType { get; private set; }
        
        public Scooter(Engine engine, Chassis chassis, VariableSpeedDrive transmission, string manufacturer, ScooterTypes scooterType) : base(engine, chassis, transmission, manufacturer)
        {
            ScooterType = scooterType;
        }
        
        public override string ToString()
        {
            return $"Scooter type: {ScooterType}\n{base.ToString()}";
        }
    }
}
