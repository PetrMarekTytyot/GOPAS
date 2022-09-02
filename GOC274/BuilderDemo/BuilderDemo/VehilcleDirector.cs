using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    public class VehilcleDirector
    {
        private VehicleBuilder builder;

        public VehilcleDirector(VehicleBuilder builder)
        {
            this.builder = builder;
        }

        public void BuildCar()
        {
            builder.BuildSteeringWheel();
            builder.BuildWheel();
            builder.BuildWheel();
            builder.BuildWheel();
            builder.BuildWheel();
        }

        public void BuildBike()
        {
            builder.BuildHandlebars();
            builder.BuildWheel();
            builder.BuildWheel();
        }
    }
}
