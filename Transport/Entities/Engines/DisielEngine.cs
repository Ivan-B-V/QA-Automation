using Transport.Enums;

namespace Transport.Entities.Engines
{
    public class DisielEngine : InternalСombustionEngine
    {
        public DisielEngine() { } 

        public DisielEngine(float volume, uint power, string serialnumber): base(volume)
        {
            Type = EngineType.Disiel;
            Power = power;
            SerialNumber = serialnumber;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
