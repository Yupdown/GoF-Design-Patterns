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
                Operate();
            }

            if (_next != null)
            {
                _next.HandleRequest<Receiver>();
            }
        }

        public abstract void Operate();
    }

    public class ReceiverA : Handler
    {
        public override void Operate()
        {
            Console.WriteLine("Operating ReceiverA");
        }
    }

    public class ReceiverB : Handler
    {
        public override void Operate()
        {
            Console.WriteLine("Operating ReceiverB");
        }
    }

    public class ReceiverC : Handler
    {
        public override void Operate()
        {
            Console.WriteLine("Operating ReceiverC");
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