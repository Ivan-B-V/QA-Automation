using Transport.Entities.Engines;
using Transport.Entities.Chassises;
using Transport.Entities.Transmissions;
using Transport.Enums;

namespace Transport.Entities.Vehicle
{
    public class Scooter : Vehicle
    {
        public ScooterTypes ScooterType { get; set; }

        /// <summary>
        /// Initializes a new instance of the Scooter class.
        /// </summary>
        /// <param name="engine"> An Engine object for creating new instatnce.  </param>
        /// <param name="chassis"> An Chassis object for creating new instatnce.</param>
        /// <param name="transmission"> An Transmission object for creating new instatnce. </param>
        /// <param name="manufacturer"> A string to name manufacturer. </param>
        /// <param name="scooterType"> Scooter type. </param>
        /// <exception cref="System.ArgumentOutOfRangeException"> Throws when chassis has more than 3  wheels and less than 2. </exception>
        /// <exception cref="System.ArgumentException"> Throws when transmission type is not VariableSpeedDrive.</exception>
        /// <exception cref="System.ArgumentException"> Throws when Engine type is not electic or petrol.</exception>
        /// <exception cref="System.ArgumentNullException"> Throws when engine, chassis or transmission params are null. </exception>
        public Scooter(Engine engine, Chassis chassis, Transmission transmission, string manufacturer, ScooterTypes scooterType) : base(engine, chassis, transmission, manufacturer)
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
            if (chassis.WheelBase > 3 || chassis.WheelBase < 2)
            {
                throw new System.ArgumentOutOfRangeException(nameof(chassis), $"Scooter chassis can't has {chassis.WheelBase}.");
            }
            
            if (transmission.Type != TransmissionTypes.VariableSpeedDrive)
            {
                throw new System.ArgumentException($"Scooter can has only {TransmissionTypes.VariableSpeedDrive}", nameof(transmission));
            }

            if (engine.Type != EngineType.Electric && engine.Type != EngineType.Petrol)
            {
                throw new System.ArgumentException($"Scooter can has only {EngineType.Electric} or {EngineType.Petrol}.", nameof(engine));
            }

            ScooterType = scooterType;
        }

        public Scooter() { }

        public override string ToString()
        {
            return $"Scooter type: {ScooterType}\n{base.ToString()}";
        }
    }
}
