namespace PrototypeDemo
{
    public class MyClass : ICloneable
    {
        public MyClass()
        {
            Console.WriteLine("Dloooouhy vypocet");
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
