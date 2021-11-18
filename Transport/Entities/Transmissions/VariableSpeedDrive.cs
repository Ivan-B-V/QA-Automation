using Transport.Enums;

namespace Transport.Entities.Transmissions
{
    public class VariableSpeedDrive : Transmission
    {
        public VariableSpeedDrive(string manufacturer)
        {
            Gears = 1;
            Manufacturer = manufacturer;
            Type = TransmissionTypes.VariableSpeedDrive;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
