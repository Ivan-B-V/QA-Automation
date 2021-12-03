
using System.Collections.Generic;
using Transport.Entities.Vehicle;
using Transport.Enums;

namespace TransportDepartment.Context
{
    public class TransmissionTypeGroupContext
    {
        public List<Vehicle> Vehicles { get; set; }
        public TransmissionTypes TransmissionType { get; set; }

    }
}
