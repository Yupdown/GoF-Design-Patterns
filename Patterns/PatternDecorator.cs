using System;

public class PatternDecorator
{
    public interface IComponent
    {
        void Operation();
    }

    public class Component : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("Operate Component");
        }
    }

    public abstract class Decorator : IComponent
    {
        protected IComponent _component;

        public Decorator(IComponent component)
        {
            _component = component;
        }

        public abstract void Operation();
    }

    public class DecoratorA : Decorator
    {
        public DecoratorA(IComponent component) : base(component)
        {

        }

        public override void Operation()
        {
            _component.Operation();

            Console.WriteLine("Powered by DecoratorA");
        }
    }

    public class DecoratorB : Decorator
    {
        public DecoratorB(IComponent component) : base(component)
        {

        }

        public override void Operation()
        {
            _component.Operation();

            Console.WriteLine("Powered by DecoratorB");
        }
    }

    public static void Main(string[] args)
    {
        IComponent decoratorA = new DecoratorA(new Component());
        IComponent decoratorB = new DecoratorB(decoratorA);

        decoratorA.Operation();
        Console.WriteLine();

        decoratorB.Operation();
    }
}