using Transport.Entities.Engines;
using Transport.Entities.Chassises;
using Transport.Entities.Transmissions;
using Transport.Enums;

namespace Transport.Entities.Vehicle
{
    public class Bus : Vehicle
    {     

        public uint SeatPostsNumber { get; set; }

        /// <summary>
        /// Initializes a new instance of the Bus class.
        /// </summary>
        /// <param name="engine"> An Engine object for creating new instatnce.  </param>
        /// <param name="chassis"> An Chassis object for creating new instatnce.</param>
        /// <param name="transmission"> An Transmission object for creating new instatnce. </param>
        /// <param name="manufacturer"> A string to name manufacturer. </param>
        /// <param name="seatPostsNumber"></param>
        /// <exception cref="System.ArgumentOutOfRangeException"> Throws when chassis has less than 4 wheels. </exception>
        /// <exception cref="System.ArgumentException"> Throws when transmission type is VariableSpeedDrive. </exception>
        /// <exception cref="System.ArgumentNullException"> Throws when engine, chassis or transmission params are null. </exception>
        public Bus(Engine engine, Chassis chassis, Transmission transmission, string manufacturer, uint seatPostsNumber) : 
            base(engine, chassis, transmission, manufacturer)
        {
            if (engine is null)
            {
                throw new System.ArgumentNullException(nameof(engine), "The engine param cannot be null.");
            }
            if (chassis is null)
            {
                throw new System.ArgumentNullException(nameof(chassis), "The chassis param cannot be null.");
            }
            if (transmission is null)
            {
                throw new System.ArgumentNullException(nameof(transmission), "The transmission param cannot be null.");
            }
            if (chassis.WheelBase < 4)
            {
                throw new System.ArgumentOutOfRangeException(nameof(chassis), $"Bus can't has {chassis.WheelBase} wheels.");
            }
            if (transmission.Type == TransmissionTypes.VariableSpeedDrive)
            {
                throw new System.ArgumentException($"Bus can't {TransmissionTypes.VariableSpeedDrive}.", nameof(chassis));
            }
            SeatPostsNumber = seatPostsNumber;
        }

        public Bus() { }

        public override string ToString()
        {
            return $"Seat posts number in bus: {SeatPostsNumber}\n{base.ToString()}";
        }
    }
}
