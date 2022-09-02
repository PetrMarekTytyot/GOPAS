namespace SingletonDemo
{
    public class Singleton
    {
        private static Singleton instance;
        private static Object syncRoot = new Object();
        public static Singleton Instance { 
            get {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null) instance = new Singleton();
                    }
                }
                return instance;
            } 
        }

        private Singleton() { }

        public void DoSmonething()
        {
            Console.WriteLine("Something.");
        }

    }

    public class Singleton2 { 
        private static Lazy<Singleton2> instanceWrapper = 
            new Lazy<Singleton2>(() => new Singleton2(), true);

        public static Singleton2 Instance => instanceWrapper.Value;

        private Singleton2() { }
    
    }
}
