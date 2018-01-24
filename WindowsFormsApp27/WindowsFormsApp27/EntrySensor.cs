using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp27
{
    class EntrySensor : Sensor
    {
        public EntrySensor(CarPark carPark) : base(carPark) { }

        public override void CarDetected()
        {
            this.carOnSensor = true;
            carPark.CarArrivedAtEntrance();
        }

        public override void CarLeftSensor()
        {
            carPark.CarEnteredCarPark();
            this.carOnSensor = false;
        }
    }
}
