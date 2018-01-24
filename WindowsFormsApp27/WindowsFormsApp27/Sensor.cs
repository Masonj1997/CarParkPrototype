using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp27
{
    abstract class Sensor
    {
        protected bool carOnSensor = false;
        protected CarPark carPark;

        public Sensor(CarPark carPark)
        {
            this.carPark = carPark;
        }

        public abstract void CarDetected();


        public abstract void CarLeftSensor();

        public bool isCarOnSensor()
        {
            return carOnSensor;
        }
    }
}
