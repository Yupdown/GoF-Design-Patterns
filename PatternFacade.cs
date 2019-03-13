using System;

public class PatternFacade
{
    public class ClassA
    {
        public void Operate()
        {
            Console.WriteLine("Operating ClassA");
        }
    }

    public class ClassB
    {
        public void Operate()
        {
            Console.WriteLine("Operating ClassB");
        }
    }

    public class ClassC
    {
        public void Operate()
        {
            Console.WriteLine("Operating ClassC");
        }
    }

    public class Facade
    {
        private ClassA _classA;
        private ClassB _classB;
        private ClassC _classC;

        public Facade(ClassA classA, ClassB classB, ClassC classC)
        {
            _classA = classA;
            _classB = classB;
            _classC = classC;
        }

        public void OperateClassA()
        {
            _classA.Operate();
        }

        public void OperateClassB()
        {
            _classB.Operate();
        }

        public void OperateClassC()
        {
            _classC.Operate();
        }
    }

    public static void Main(string[] args)
    {
        ClassA classA = new ClassA();
        ClassB classB = new ClassB();
        ClassC classC = new ClassC();

        Facade facade = new Facade(classA, classB, classC);

        facade.OperateClassA();
        facade.OperateClassB();
        facade.OperateClassC();
    }
}