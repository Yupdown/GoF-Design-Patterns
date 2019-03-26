using System;

public class PatternPrototype
{
    public interface IPrototype <T>
    {
        T Clone();
    }

    public interface IProduct
    {
        void Operation();
    }

    public class Product : IPrototype<IProduct>, IProduct
    {
        private string _name;

        public Product(string name)
        {
            _name = name;
        }

        public IProduct Clone()
        {
            return new Product(_name);
        }

        public void Operation()
        {
            Console.WriteLine("Operate " + _name);
        }
    }

    public static void Main(string[] args)
    {
        IPrototype<IProduct> prototype = new Product("ProductA");

        IProduct product = prototype.Clone();

        product.Operation();
    }
}