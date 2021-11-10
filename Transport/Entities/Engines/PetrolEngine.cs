
namespace Task3_Transport.Entities.Engines
{
    class PetrolEngine : InternalСombustionEngine
    {

        public PetrolEngine(uint volume, uint power, string serialnumber)
        {
            Type = Enums.EngineType.Petrol;
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
