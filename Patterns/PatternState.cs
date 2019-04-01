using System;

public class PatternState
{
    public class Context
    {
        private IState _state;

        public Context()
        {
            _state = new StateA();
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public void Operation()
        {
            _state.Operation(this);
        }
    }

    public interface IState
    {
        void Operation(Context context);
    }

    public class StateA : IState
    {
        public void Operation(Context context)
        {
            Console.WriteLine("Operate StateA");

            context.SetState(new StateB());
        }
    }

    public class StateB : IState
    {
        public void Operation(Context context)
        {
            Console.WriteLine("Operate StateB");

            context.SetState(new StateA());
        }
    }


    public static void Main(string[] args)
    {
        Context context = new Context();
        
        for (int num = 0; num < 3; num++)
        {
            context.Operation();
        }
    }
}