using System;

public class PatternAdapter
{
    public interface IAdapter
    {
        void OperationAdapter();
    }

    public class Adaptee
    {
        public void OperationAdaptee()
        {
            Console.WriteLine("Operate Adaptee");
        }
    }

    public class ReferenceAdapter : IAdapter
    {
        private Adaptee _adaptee;

        public ReferenceAdapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public void OperationAdapter()
        {
            _adaptee.OperationAdaptee();
        }
    }

    public class ImplementationAdapter : Adaptee, IAdapter
    {
        public void OperationAdapter()
        {
            OperationAdaptee();
        }
    }

    public static void Main(string[] args)
    {
        IAdapter adapter;

        adapter = new ReferenceAdapter(new Adaptee());
        adapter.OperationAdapter();

        adapter = new ImplementationAdapter();
        adapter.OperationAdapter();
    }
}