using System;

public class PatternTemplateMethod
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            PrimitiveA();
            PrimitiveB();
        }

        protected abstract void PrimitiveA();
        protected abstract void PrimitiveB();
    }

    public class SubClass : AbstractClass
    {
        protected override void PrimitiveA()
        {
            Console.WriteLine("Operate PrimitiveA in SubClass");
        }

        protected override void PrimitiveB()
        {
            Console.WriteLine("Operate PrimitiveB in SubClass");
        }
    }

    public static void Main(string[] args)
    {
        AbstractClass abstractClass = new SubClass();

        abstractClass.TemplateMethod();
    }
}