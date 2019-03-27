using System;

public class PatternFactoryMethod
{
    public abstract class Creator
    {
        private IProduct _product;

        public void Operation()
        {
            if (_product == null)
            {
                _product = FactoryMethod();
            }

            _product.Operation();
        }

        protected abstract IProduct FactoryMethod();
    }

    public class CreatorA : Creator
    {
        protected override IProduct FactoryMethod()
        {
            return new ProductA();
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
            Console.WriteLine("Operate ProductA");
        }
    }

    public static void Main(string[] args)
    {
        Creator creator = new CreatorA();

        creator.Operation();
    }
}