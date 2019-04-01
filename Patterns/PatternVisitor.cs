using System;

public class PatternVisitor
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }

    public class ElementA : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitElementA(this);
        }

        public void OperationA()
        {
            Console.WriteLine("Operate A");
        }
    }

    public class ElementB : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitElementB(this);
        }

        public void OperationB()
        {
            Console.WriteLine("Operate B");
        }
    }

    public interface IVisitor
    {
        void VisitElementA(ElementA element);
        void VisitElementB(ElementB element);
    }

    public class VisitorA : IVisitor
    {
        public void VisitElementA(ElementA element)
        {
            element.OperationA();
        }

        public void VisitElementB(ElementB element)
        {
            element.OperationB();
        }
    }

    public static void Main(string[] args)
    {
        IVisitor visitor = new VisitorA();

        IElement element;

        element = new ElementA();
        element.Accept(visitor);

        element = new ElementB();
        element.Accept(visitor);
    }
}