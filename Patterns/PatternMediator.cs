using System;
using System.Collections.Generic;

public class PatternMediator
{
    public abstract class Mediator
    {
        public abstract void Mediate(Colleague sender);
    }

    public class MediatorA : Mediator
    {
        private List<Colleague> _colleagues;

        public MediatorA()
        {
            _colleagues = new List<Colleague>();
        }

        public void AddColleague(Colleague colleague)
        {
            _colleagues.Add(colleague);
        }

        public override void Mediate(Colleague sender)
        {
            foreach (Colleague colleague in _colleagues)
            {
                if (colleague != sender)
                {
                    colleague.Operation();
                }
            }
        }
    }

    public abstract class Colleague
    {
        private Mediator _mediator;

        public Colleague(Mediator mediator)
        {
            _mediator = mediator;
        }

        public void Mediate()
        {
            _mediator.Mediate(this);
        }

        public abstract void Operation();
    }

    public class ColleagueA : Colleague
    {
        public ColleagueA(Mediator mediator) : base(mediator)
        {

        }

        public override void Operation()
        {
            Console.WriteLine("Operate ColleagueA");
        }
    }

    public class ColleagueB : Colleague
    {
        public ColleagueB(Mediator mediator) : base(mediator)
        {

        }

        public override void Operation()
        {
            Console.WriteLine("Operate ColleagueB");
        }
    }

    public static void Main(string[] args)
    {
        MediatorA mediator = new MediatorA();

        ColleagueA colleagueA = new ColleagueA(mediator);
        ColleagueB colleagueB = new ColleagueB(mediator);

        mediator.AddColleague(colleagueA);
        mediator.AddColleague(colleagueB);

        colleagueA.Mediate();
        colleagueB.Mediate();
    }
}