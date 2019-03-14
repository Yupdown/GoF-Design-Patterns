using System;

public class PatternAbstractFactory
{
    public interface IAbstractFactory
    {
        IProduct CreateProduct();
    }

    public class AbstractFactoryA : IAbstractFactory
    {
        public IProduct CreateProduct()
        {
            return new ProductA();
        }
    }
    
    public class AbstractFactoryB : IAbstractFactory
    {
        public IProduct CreateProduct()
        {
            return new ProductB();
        }
    }

    public interface IProduct
    {
        void Operation();
    }

    public class ProductA : IProduct
    {
        public void Operation()
        {
            Console.WriteLine("Operating ProductA");
        }
    }

    public class ProductB : IProduct
    {
        public void Operation()
        {
            Console.WriteLine("Operating ProductB");
        }
    }

    public static void Main(string[] args)
    {
        IAbstractFactory abstractFactory;
        IProduct product;

        abstractFactory = new AbstractFactoryA();
        product = abstractFactory.CreateProduct();

        product.Operation();

        abstractFactory = new AbstractFactoryB();
        product = abstractFactory.CreateProduct();

        product.Operation();
    }
}
