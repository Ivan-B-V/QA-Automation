using Task3_Transport.Enums;

namespace Task3_Transport.Entities.Engines
{

    abstract class Engine
    {

        public uint Power { get; protected set; }

        public EngineType Type { get; protected set; }

        public string SerialNumber { get; protected set; }

        public override string ToString()
        {
            return $"Engine power: {Power}, EngineType: {Type}, SerialNumber: {SerialNumber}.";
        }

    }
}
