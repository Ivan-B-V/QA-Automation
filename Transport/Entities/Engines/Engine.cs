using Transport.Enums;

namespace Transport.Entities.Engines
{

    public abstract class Engine
    {

        public uint Power { get; protected set; }

        public EngineType Type { get; protected set; }

        public string SerialNumber { get; protected set; }

        public override string ToString()
        {
            return $"EngineType: {Type}, Engine power: {Power}, SerialNumber: {SerialNumber}";
        }

    }
}
