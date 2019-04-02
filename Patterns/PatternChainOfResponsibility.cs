using System;

public class PatternChainOfResponsibility
{
    public abstract class Handler
    {
        private Handler _next;

        public void SetNextHandler(Handler handler)
        {
            _next = handler;
        }

        public void HandleRequest<Receiver>() where Receiver : Handler
        {
            if (this is Receiver)
            {
                Operation();
            }

            if (_next != null)
            {
                _next.HandleRequest<Receiver>();
            }
        }

        public abstract void Operation();
    }

    public class ReceiverA : Handler
    {
        public override void Operation()
        {
            Console.WriteLine("Operate ReceiverA");
        }
    }

    public class ReceiverB : Handler
    {
        public override void Operation()
        {
            Console.WriteLine("Operate ReceiverB");
        }
    }

    public class ReceiverC : Handler
    {
        public override void Operation()
        {
            Console.WriteLine("Operate ReceiverC");
        }
    }

    public static void Main(string[] args)
    {
        Handler[] receivers = new Handler[]
        {
            new ReceiverA(),
            new ReceiverB(),
            new ReceiverC()
        };

        for (int index = 0; index < receivers.Length - 1; index++)
        {
            receivers[index].SetNextHandler(receivers[index + 1]);
        }

        Handler handler = receivers[0];

        handler.HandleRequest<ReceiverA>();
        handler.HandleRequest<ReceiverB>();
        handler.HandleRequest<ReceiverC>();
    }
}