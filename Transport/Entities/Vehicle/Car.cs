using Transport.Entities.Engines;
using Transport.Entities.Chassises;
using Transport.Entities.Transmissions;
using Transport.Enums;

namespace Transport.Entities.Vehicle
{
    public class Car : Vehicle
    {
        public CarTypes CarType { get; set; }

        /// <summary>
        /// Initializes a new instance of the Car class.
        /// </summary>
        /// <param name="engine"> An Engine object for creating new instatnce.  </param>
        /// <param name="chassis"> An Chassis object for creating new instatnce.</param>
        /// <param name="transmission"> An Transmission object for creating new instatnce. </param>
        /// <param name="manufacturer"> A string to name manufacturer. </param>
        /// <param name="carType"></param>
        /// <exception cref="System.ArgumentOutOfRangeException"> Throws when chassis has less than 3  wheels. </exception>
        /// <exception cref="System.ArgumentNullException"> Throws when engine, chassis or transmission params are null. </exception>
        public Car(Engine engine, Chassis chassis, Transmission transmission, string manufacturer, CarTypes carType) :
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
            if (chassis.WheelBase < 2)
            {
                throw new System.ArgumentOutOfRangeException(nameof(chassis), $"Car can't has {chassis.WheelBase} wheels.");
            }
            CarType = carType;
        }

        public Car() { }

        public override string ToString()
        {
            return $"Car type: {CarType}\n{base.ToString()}";
        }
    }
}
