using System;
using System.Collections.Generic;

public class PatternObserver
{
    public abstract class Subject<T>
    {
        private List<Observer<T>> _observers;

        public Subject()
        {
            _observers = new List<Observer<T>>();
        }

        public void AttachObserver(Observer<T> observer)
        {
            _observers.Add(observer);
        }

        public void Notify(T message)
        {
            foreach (Observer<T> observer in _observers)
            {
                observer.Update(message);
            }
        }
    }

    public class SubjectA : Subject<string>
    {
        public void SendMessage(string message)
        {
            Notify(message);
        }
    }

    public abstract class Observer<T>
    {
        public abstract void Update(T message);
    }

    public class ObserverA : Observer<string>
    {
        public override void Update(string message)
        {
            Console.WriteLine("Received the Message in ObserverA: " + message);
        }
    }

    public class ObserverB : Observer<string>
    {
        public override void Update(string message)
        {
            Console.WriteLine("Received the Message in ObserverB: " + message);
        }
    }

    public static void Main(string[] args)
    {
        SubjectA subject = new SubjectA();

        subject.AttachObserver(new ObserverA());
        subject.AttachObserver(new ObserverB());

        subject.SendMessage("Hello, World!");
    }
}