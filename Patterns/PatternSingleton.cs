using System;

public class PatternSingleton
{
    public class SingletonManual
    {
        private static SingletonManual _instance;

        public static SingletonManual GetInstance()
        {
            return _instance;
        }
        
        public static void CreateInstance()
        {
            _instance = new SingletonManual();
        }

        public void Operation()
        {
            Console.WriteLine("Operating Singleton (Manual)");
        }
    }

    public class SingletonAutomatic
    {
        private static SingletonAutomatic _instance;

        public static SingletonAutomatic GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SingletonAutomatic();
            }

            return _instance;
        }

        public void Operation()
        {
            Console.WriteLine("Operating Singleton (Automatic)");
        }
    }

    public static void Main(string[] args)
    {
        SingletonManual.CreateInstance();

        SingletonManual.GetInstance().Operation();

        SingletonAutomatic.GetInstance().Operation();
    }
}