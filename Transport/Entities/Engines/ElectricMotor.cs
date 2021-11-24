using Transport.Enums;

namespace Transport.Entities.Engines
{
    public class ElectricMotor : Engine
    {
        public int WorkingVoltage { get; set; }

        public ElectricMotor() { }
        
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
