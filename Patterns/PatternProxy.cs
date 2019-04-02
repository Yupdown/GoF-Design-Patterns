using System;

public class PatternProxy
{
    public interface ISubject
    {
        void Operation();
    }

    public class Subject : ISubject
    {
        public void Operation()
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

        public void Operation()
        {
            _subject.Operation();
        }
    }

    public static void Main(string[] args)
    {
        ISubject proxy = new ProxySubject(new Subject());

        proxy.Operation();
    }
}