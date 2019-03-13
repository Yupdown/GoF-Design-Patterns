using System;

public class PatternAdapter
{
    public interface IAdapter
    {
        void OperateAdapter();
    }

    public class Adaptee
    {
        public void OperateAdaptee()
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

        public void OperateAdapter()
        {
            _adaptee.OperateAdaptee();
        }
    }

    public class ImplementationAdapter : Adaptee, IAdapter
    {
        public void OperateAdapter()
        {
            OperateAdaptee();
        }
    }

    public static void Main(string[] args)
    {
        IAdapter adapter;

        adapter = new ReferenceAdapter(new Adaptee());
        adapter.OperateAdapter();

        adapter = new ImplementationAdapter();
        adapter.OperateAdapter();
    }
}