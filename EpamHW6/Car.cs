using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamHW6
{
    internal class Car
    {
        public string name;
        public int max_velocity;
        public string Name
        { 
            get { return name; }  
            set { name = value; }
        }
        public int Max_velocity
        {
            get { return max_velocity; }
            set { max_velocity = value; }
        }
        public Car(string carName,int carVelocity)
        { 
            Name = carName;
            Max_velocity = carVelocity;
        }
    }
}
