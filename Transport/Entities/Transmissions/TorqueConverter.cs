using Transport.Enums;

namespace Transport.Entities.Transmissions
{
    public class TorqueConverter : Transmission
    {
        public TorqueConverter(int gears, string manufacturer)
        {
            Gears = gears;
            Manufacturer = manufacturer;
            Type = TransmissionTypes.TorqueConverter;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
