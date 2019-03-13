using System;

public class PatternProxy
{
    public interface ISubject
    {
        void Operate();
    }

    public class Subject : ISubject
    {
        public void Operate()
        {
            Console.WriteLine("Operate Subject");
        }
    }

    public class ProxySubject : ISubject
    {
        private Subject _subject;

        public ProxySubject(Subject subject)
        {
            _subject = subject;
        }

        public void Operate()
        {
            _subject.Operate();
        }
    }

    public static void Main(string[] args)
    {
        ISubject proxy = new ProxySubject(new Subject());

        proxy.Operate();
    }
}