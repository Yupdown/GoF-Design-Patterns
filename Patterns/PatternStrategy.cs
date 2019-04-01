using System;

public class PatternStrategy
{
    public class Context
    {
        private IStrategy _strategy;

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Operation()
        {
            Console.WriteLine(_strategy.Algorithm("Context"));
        }
    }

    public interface IStrategy
    {
        string Algorithm(string context);
    }

    public class StrategyA : IStrategy
    {
        public string Algorithm(string context)
        {
            return "Operate " + context + " as StrategyA";
        }
    }

    public class StrategyB : IStrategy
    {
        public string Algorithm(string context)
        {
            return "Operate " + context + " as StrategyB";
        }
    }

    public static void Main(string[] args)
    {
        Context context = new Context();

        context.SetStrategy(new StrategyA());
        context.Operation();

        context.SetStrategy(new StrategyB());
        context.Operation();
    }
}