using System;

public class PatternDecorator
{
    public interface IComponent
    {
        void Operate();
    }

    public class Component : IComponent
    {
        public void Operate()
        {
            Console.WriteLine("Operating Component");
        }
    }

    public abstract class Decorator : IComponent
    {
        protected IComponent _component;

        public Decorator(IComponent component)
        {
            _component = component;
        }

        public abstract void Operate();
    }

    public class DecoratorA : Decorator
    {
        public DecoratorA(IComponent component) : base(component)
        {

        }

        public override void Operate()
        {
            _component.Operate();

            Console.WriteLine("Powered by DecoratorA");
        }
    }

    public class DecoratorB : Decorator
    {
        public DecoratorB(IComponent component) : base(component)
        {

        }

        public override void Operate()
        {
            _component.Operate();

            Console.WriteLine("Powered by DecoratorB");
        }
    }

    public static void Main(string[] args)
    {
        IComponent decoratorA = new DecoratorA(new Component());
        IComponent decoratorB = new DecoratorB(decoratorA);

        decoratorA.Operate();
        Console.WriteLine();

        decoratorB.Operate();
    }
}