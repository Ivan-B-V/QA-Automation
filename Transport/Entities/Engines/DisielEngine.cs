using Task3_Transport.Enums;

namespace Task3_Transport.Entities.Engines
{
    class DisielEngine : InternalСombustionEngine
    {
        public DisielEngine(uint volume, uint power, string serialnumber)
        {
            Type = EngineType.Disiel;
            Power = power;
            SerialNumber = serialnumber;
            Volume = volume;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
