using System;

public class PatternFacade
{
    public class ClassA
    {
        public void Operation()
        {
            Console.WriteLine("Operate ClassA");
        }
    }

    public class ClassB
    {
        public void Operation()
        {
            Console.WriteLine("Operate ClassB");
        }
    }

    public class ClassC
    {
        public void Operation()
        {
            Console.WriteLine("Operate ClassC");
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

        public void OperationClassA()
        {
            _classA.Operation();
        }

        public void OperationClassB()
        {
            _classB.Operation();
        }

        public void OperationClassC()
        {
            _classC.Operation();
        }
    }

    public static void Main(string[] args)
    {
        ClassA classA = new ClassA();
        ClassB classB = new ClassB();
        ClassC classC = new ClassC();

        Facade facade = new Facade(classA, classB, classC);

        facade.OperationClassA();
        facade.OperationClassB();
        facade.OperationClassC();
    }
}