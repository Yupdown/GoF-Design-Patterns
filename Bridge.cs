using System;

public class PatternBridge
{
    public interface IAbstraction
    {
        void Operation();
    }

    public class AbstractionA : IAbstraction
    {
        private IImplementor _implementor;

        public AbstractionA(IImplementor implementor)
        {
            _implementor = implementor;
        }

        public void Operation()
        {
            _implementor.OperationImpA();
        }
    }

    public class AbstractionB : IAbstraction
    {
        private IImplementor _implementor;

        public AbstractionB(IImplementor implementor)
        {
            _implementor = implementor;
        }

        public void Operation()
        {
            _implementor.OperationImpB();
        }
    }

    public interface IImplementor
    {
        void OperationImpA();
        void OperationImpB();
    }

    public class ImplementorA : IImplementor
    {
        public void OperationImpA()
        {
            Console.WriteLine("Operating A in ImplementerA");
        }

        public void OperationImpB()
        {
            Console.WriteLine("Operating B in ImplementerA");
        }
    }

    public class ImplementorB : IImplementor
    {
        public void OperationImpA()
        {
            Console.WriteLine("Operating A in ImplementerB");
        }

        public void OperationImpB()
        {
            Console.WriteLine("Operating B in ImplementerB");
        }
    }
    
    public static void Main(string[] args)
    {
        IAbstraction[] abstractions = new IAbstraction[]
        {
           new AbstractionA(new ImplementorA()),
           new AbstractionA(new ImplementorB()),
           new AbstractionB(new ImplementorA()),
           new AbstractionB(new ImplementorB()),
       };

        foreach (IAbstraction abstraction in abstractions)
        {
            abstraction.Operation();
        }
    }
}