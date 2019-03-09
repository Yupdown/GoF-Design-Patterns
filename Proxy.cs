using System;

public class Proxy
{
    public class Subject
    {
        public void Operate()
        {
            Console.WriteLine("Operate Subject");
        }
    }

    public class ProxySubject
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
        ProxySubject proxy = new ProxySubject(new Subject());

        proxy.Operate();
    }
}