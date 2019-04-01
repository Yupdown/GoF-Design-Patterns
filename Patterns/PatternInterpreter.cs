using System;
using System.Collections.Generic;

public class PatternInterpreter
{
    public class Context
    {

    }

    public abstract class AbstractExpression
    {
        public abstract string Interpret(Context context);
    }

    public class TerminalExpression : AbstractExpression
    {
        public override string Interpret(Context context)
        {
            return "Terminal Expression";
        }
    }

    public class NonTerminalExpression : AbstractExpression
    {
        private List<AbstractExpression> _subExpressions;

        public NonTerminalExpression()
        {
            _subExpressions = new List<AbstractExpression>();
        }

        public override string Interpret(Context context)
        {
            string str = "Non Terminal Expression" + '\n';

            foreach (AbstractExpression subExpression in _subExpressions)
            {
                str += "└ " + subExpression.Interpret(context) + '\n';
            }

            return str;
        }

        public void AddSubExpression(AbstractExpression expression)
        {
            _subExpressions.Add(expression);
        }
    }

    public static void Main(string[] args)
    {
        Context context = new Context();

        NonTerminalExpression expression = new NonTerminalExpression();

        expression.AddSubExpression(new TerminalExpression());
        expression.AddSubExpression(new TerminalExpression());

        Console.WriteLine(expression.Interpret(context));
    }
}