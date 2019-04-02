using System;
using System.Collections.Generic;

public class PatternFlyweight
{
    public interface IFlyweight
    {
        void Operation();
    }

    public class Flyweight : IFlyweight
    {
        public void Operation()
        {
            Console.WriteLine("Operate Flyweight (" + GetHashCode() + ")");
        }
    }

    public class FlyweightFactory
    {
        private Dictionary<string, IFlyweight> _flyweights;

        public FlyweightFactory()
        {
            _flyweights = new Dictionary<string, IFlyweight>();
        }

        public IFlyweight GetFlyweight(string key)
        {
            IFlyweight flyweight;

            _flyweights.TryGetValue(key, out flyweight);

            if (flyweight == null)
            {
                flyweight = new Flyweight();

                _flyweights.Add(key, flyweight);
            }

            return flyweight;
        }
    }

    public static void Main(string[] args)
    {
        FlyweightFactory flyweightFactory = new FlyweightFactory();

        IFlyweight[] flyweights = new IFlyweight[]
        {
            flyweightFactory.GetFlyweight("A"),
            flyweightFactory.GetFlyweight("A"),
            flyweightFactory.GetFlyweight("B"),
            flyweightFactory.GetFlyweight("C"),
            flyweightFactory.GetFlyweight("C")
        };

        foreach (IFlyweight flyweight in flyweights)
        {
            flyweight.Operation();
        }
    }
}
