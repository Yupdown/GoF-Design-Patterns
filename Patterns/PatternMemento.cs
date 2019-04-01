using System;

public class PatternMemento
{
    public class Originator
    {
        private string _state;

        public void SetState(string state)
        {
            _state = state;
        }

        public Memento CreateMemento()
        {
            return new Memento(_state);
        }

        public void Restore(Memento memento)
        {
            _state = memento.state;
        }

        public void Operate()
        {
            Console.WriteLine("Operating Originator as " + _state + " State");
        }
    }

    public class Memento
    {
        private string _state;

        public string state
        {
            get
            { return _state; }
        }

        public Memento(string state)
        {
            _state = state;
        }
    }

    public static void Main(string[] args)
    {
        Originator originator = new Originator();

        originator.SetState("A");
        originator.Operate();

        Memento memento = originator.CreateMemento();

        originator.SetState("B");
        originator.Operate();

        originator.Restore(memento);
        originator.Operate();
    }
}