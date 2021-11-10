
namespace Transport.Entities.Transport
{
    class Truck : Transport
    {
        public string Manufacturer { get; private set; }

        public uint MaxTrailerWeight { get; private set; }
        
        public Truck()
        {
            
        }
    }
}
