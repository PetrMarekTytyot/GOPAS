namespace BuilderDemo
{
    public class VehicleBuilder
    {
        private Vehicle vehicle = new();

        public void BuildWheel()
        {
            vehicle.Wheels.Add(new Wheel());
        }

        public void BuildHandlebars()
        {
            vehicle.Steering = new Handlebars();
        }

        public void BuildSteeringWheel()
        {
            vehicle.Steering = new SteeringWheel();
        }

        public Vehicle GetVehilce()
        {
            var result = vehicle;
            vehicle = new Vehicle();
            return result;
        }
    }
}
