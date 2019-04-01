using System;

public class PatternCommand
{
    public interface ICommand
    {
        void Execute();
    }

    public class CommandA : ICommand
    {
        private IReceiver _receiver;

        public CommandA(IReceiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.OperationA();
        }
    }

    public class CommandB : ICommand
    {
        private IReceiver _receiver;

        public CommandB(IReceiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.OperationB();
        }
    }

    public interface IReceiver
    {
        void OperationA();
        void OperationB();
    }

    public class Receiver : IReceiver
    {
        public void OperationA()
        {
            Console.WriteLine("Operate Receiver as A");
        }

        public void OperationB()
        {
            Console.WriteLine("Operate Receiver as B");
        }
    }

    public static void Main(string[] args)
    {
        IReceiver receiver = new Receiver();

        ICommand commandA = new CommandA(receiver);
        ICommand commandB = new CommandB(receiver);

        commandA.Execute();
        commandB.Execute();
    }
}