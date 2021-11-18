using Transport.Entities.Engines;
using Transport.Entities.Chassises;
using Transport.Entities.Transmissions;
using Transport.Enums;

namespace Transport.Entities.Vehicle
{
    public class Truck : Vehicle
    {

        public uint MaxTrailerWeight { get; private set; }

        /// <summary>
        /// Initializes a new instance of the Truck class.
        /// </summary>
        /// <param name="engine"> An Engine object for creating new instatnce.  </param>
        /// <param name="chassis"> An Chassis object for creating new instatnce.</param>
        /// <param name="transmission"> An Transmission object for creating new instatnce. </param>
        /// <param name="manufacturer"> A string to name manufacturer. </param>
        /// <param name="maxTrailerWeight"> Maximum trailer weight which truck could pull. </param>
        /// <exception cref="System.ArgumentOutOfRangeException"> Throws when chassis has less than 4 wheels. </exception>
        /// <exception cref="System.ArgumentException"> Throws when transmission is VariableSpeedDrive.</exception>
        /// <exception cref="System.ArgumentNullException"> Throws when engine, chassis or transmission params are null. </exception>
        public Truck(Engine engine, Chassis chassis, Transmission transmission, string manufacturer, uint maxTrailerWeight) :
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
                throw new System.ArgumentOutOfRangeException(nameof(chassis), $"Truck can't has {chassis.WheelBase} wheels.");
            }
            if (transmission.Type == TransmissionTypes.VariableSpeedDrive)
            {
                throw new System.ArgumentException($"Truck can't {TransmissionTypes.VariableSpeedDrive}.", nameof(chassis));
            }
            MaxTrailerWeight = maxTrailerWeight;
        }

        public override string ToString()
        {
            return $"Max trailer weight: {MaxTrailerWeight}\n{base.ToString()}";
        }
    }
}
