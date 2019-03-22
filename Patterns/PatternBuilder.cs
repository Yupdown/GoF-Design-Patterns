using System;

public class PatternBuilder
{
    public interface IBuilder
    {
        ISubject subject { get; }

        IBuilder BuildSubject();

        IBuilder SetName(string name);
    }

    public class Builder : IBuilder
    {
        private ISubject _subject;

        public ISubject subject
        {
            get
            { return _subject; }
        }

        public IBuilder BuildSubject()
        {
            _subject = new Subject();

            return this;
        }

        public IBuilder SetName(string name)
        {
            _subject.SetName(name);

            return this;
        }
    }

    public interface ISubject
    {
        void SetName(string name);

        void Operation();
    }

    public class Subject : ISubject
    {
        private string _name;

        public void Operation()
        {
            Console.WriteLine("Operating " + _name);
        }

        public void SetName(string name)
        {
            _name = name;
        }
    }

    public static void Main(string[] args)
    {
        IBuilder builder = new Builder();

        builder.BuildSubject()
            .SetName("Hello");

        ISubject subject = builder.subject;

        subject.Operation();
    }
}
