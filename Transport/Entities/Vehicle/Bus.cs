using Transport.Entities.Engines;
using Transport.Entities.Chassises;
using Transport.Entities.Transmissions;
using Transport.Enums;

namespace Transport.Entities.Vehicle
{
    class Bus : Vehicle
    {     

        public uint SeatPostsNumber { get; private set; }


        public Bus(Engine engine, BusChassis chassis, Transmission transmission, string manufacturer, uint seatPostsNumber) : 
            base(engine, chassis, transmission, manufacturer)
        {
            SeatPostsNumber = seatPostsNumber;
        }

        public override string ToString()
        {
            return $"Seat posts number in bus: {SeatPostsNumber}\n{base.ToString()}";
        }
    }
}
