using Task3_Transport.Enums;

namespace Task3_Transport.Entities.Engines
{
    class ElectricMotor : Engine
    {
        public int WorkingVoltage { get; private set; }
        
        public ElectricMotor(uint power, string serialnumber)
        {
            Type = EngineType.Electric;
            Power = power;
            SerialNumber = serialnumber;
        }

        public override string ToString()
        {
            return $"{base.ToString()} WorkingVoltage: {WorkingVoltage}.";
        }

    }
}
