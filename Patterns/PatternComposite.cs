using System;
using System.Collections.Generic;

public class PatternComposite
{
    public interface IComponent
    {
        void Operation();
    }

    public class Composite : IComponent
    {
        private List<IComponent> _components;

        public Composite()
        {
            _components = new List<IComponent>();
        }

        public void Operation()
        {
            foreach (IComponent component in _components)
            {
                component.Operation();
            }
        }

        public void Add(IComponent component)
        {
            _components.Add(component);
        }
    }

    public class Leaf : IComponent
    {
        private string _name;

        public Leaf(string name)
        {
            _name = name;
        }

        public void Operation()
        {
            Console.WriteLine("Operate " + _name);
        }
    }

    public static void Main(string[] args)
    {
        Composite composite = new Composite();

        composite.Add(new Leaf("Leaf A"));
        composite.Add(new Leaf("Leaf B"));
        composite.Add(new Leaf("Leaf C"));
        composite.Add(new Leaf("Leaf D"));

        IComponent component = composite;

        component.Operation();
    }
}