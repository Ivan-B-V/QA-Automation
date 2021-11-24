using System;
using System.Xml.Serialization;
using Transport.Enums;

namespace Transport.Entities.Transmissions
{
    [XmlInclude(typeof(Mechanical))]
    [XmlInclude(typeof(VariableSpeedDrive))]
    [XmlInclude(typeof(TorqueConverter))]
    [Serializable]
    public abstract class Transmission
    {
        
        public string Manufacturer { get;  set; }

        public int Gears { get;  set; }

        public TransmissionTypes Type { get;  set; }

        public Transmission() { }

        public override string ToString()
        {
            return $"TransmisiionType: {Type}, Gears: {Gears}, Manufacturer: {Manufacturer}";
        }
    }   
}
