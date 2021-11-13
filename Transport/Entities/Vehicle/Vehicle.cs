using Transport.Entities.Transmissions;
using Transport.Entities.Engines;
using Transport.Entities.Chassises;

namespace Transport.Entities.Vehicle
{
    /// <summary>
    /// Represents abstraction class Vehicle.
    /// </summary>
    abstract class Vehicle
    {
        
        /// <summary>
        /// Engine property.
        /// </summary>
        public Engine Engine { get; protected set; }

        /// <summary>
        /// Transmission property.
        /// </summary>
        public Transmission Transmission { get; protected set; }

        /// <summary>
        /// Chassis property.
        /// </summary>
        public Chassis Chassis { get; protected set; }

        /// <summary>
        /// Manufacturer property.
        /// </summary>
        public string Manufacturer { get; protected set; }

        /// <summary>
        /// Initializes a new instance of the Vehicle class.
        /// </summary>
        /// <param name="engine"> An Engine object for creating new instatnce.  </param>
        /// <param name="chassis"> An Chassis object for creating new instatnce.</param>
        /// <param name="transmission"> An Transmission object for creating new instatnce. </param>
        /// <param name="manufacturer"> A string to name manufacturer. </param>
        public Vehicle(Engine engine, Chassis chassis, Transmission transmission, string manufacturer)
        {
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
            Manufacturer = manufacturer;
        }

        /// <summary>
        /// Converts the numeric value of this instance to its equivalent string representation.
        /// </summary>
        /// <returns>
        /// The string representation of the value of this instance.
        /// The representation consists of string representation of instance field and properties.
        /// </returns>
        public override string ToString()
        {
            return $"{Manufacturer}\n{Engine}\n{Transmission}\n{Chassis}";
        }

    }
}
