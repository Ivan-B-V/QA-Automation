
namespace Transport.Entities.Engines
{
    public class PetrolEngine : InternalСombustionEngine
    {

        public PetrolEngine(float volume, uint power, string serialnumber): base(volume)
        {
            Type = Enums.EngineType.Petrol;
            Power = power;
            SerialNumber = serialnumber;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
