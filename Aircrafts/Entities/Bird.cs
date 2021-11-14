using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aircrafts.Interfaces;
namespace Aircrafts.Entities
{
    class Bird : IFlyable
    {
        private uint maxSpeed = 20;
        private uint speed;
        public uint Speed
        {
            get => speed;
            protected set => speed = value > maxSpeed ? maxSpeed : value;
     
        }

        public Point3D Position { get; protected set; }


        public Bird(Point3D position)
        {
            Position = position;

            Speed = (uint)new Random().Next((int)maxSpeed);
        }

        public void FlyTO(Point3D point)
        {
            Position = point;
        }

        public uint GetFlyTime(Point3D point)
        {
            throw new NotImplementedException();
        }
    }
}
