using Transport.Enums;

namespace Transport.Entities.Engines
{
    public abstract class Engine
    {

        public uint Power { get;  set; }

        public EngineType Type { get;  set; }

        public string SerialNumber { get;  set; }

        public Engine() { }

        public override string ToString()
        {
            return $"EngineType: {Type}, Engine power: {Power}, SerialNumber: {SerialNumber}";
        }

    }
}
