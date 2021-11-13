
namespace Transport.Entities.Transport
{
    class Truck : Vehicle
    {
        public string Manufacturer { get; private set; }

        public uint MaxTrailerWeight { get; private set; }
        
        public Truck()
        {
            
        }
    }
}
