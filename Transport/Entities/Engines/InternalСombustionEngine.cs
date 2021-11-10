
namespace Task3_Transport.Entities.Engines
{
    class InternalСombustionEngine : Engine
    {
        public uint Volume { get; protected set; }

        public override string ToString()
        {
            return $"{base.ToString()} Volume: {Volume}.";
        }
    } 
}
