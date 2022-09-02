namespace BuilderDemo
{
    public class Vehicle
    {
        public ISteering Steering { get; set; }
        public List<Wheel> Wheels { get; private set; } = new();

        public override string ToString()
        {
            return $"{base.ToString()}: Steering - {Steering}; {Wheels.Count} wheels";
        }

    }
}
