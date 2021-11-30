using System;
using System.Collections;
using System.Collections.Generic;
using Transport.Entities.Vehicle;

namespace TransportDepartment.Entities
{

    class Department : ICollection<Vehicle>, IEnumerable<Vehicle>
    {
        public List<Vehicle> vehicles;

        public Department(List<Vehicle> collection)
        {
            vehicles = new List<Vehicle>(collection);
        }

        public Vehicle this[int index] { get => vehicles[index]; set => vehicles[index] = value; }

        public int Count => vehicles.Count;

        public bool IsReadOnly => false;

        public void Add(Vehicle item)
        {
            vehicles.Add(item);
        }

        public void Clear()
        {
            vehicles.Clear();
        }

        public bool Contains(Vehicle item)
        {
            return vehicles.Contains(item);
        }

        public void CopyTo(Vehicle[] array, int arrayIndex)
        {

            vehicles.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Vehicle> GetEnumerator()
        {
            return vehicles.GetEnumerator();
        }

        public int IndexOf(Vehicle item)
        {
            return vehicles.IndexOf(item);
        }

        public void Insert(int index, Vehicle item)
        {
            vehicles.Insert(index, item);
        }

        public bool Remove(Vehicle item)
        {
            return vehicles.Remove(item);
        }

        public void RemoveAt(int index)
        {
            vehicles.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator() => vehicles.GetEnumerator();
    }
}
