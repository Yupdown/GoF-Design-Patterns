using System;

public class PatternIterator
{
    public interface IAggregate
    {
        IIterator CreateIterator();
    }

    public class Aggregate : IAggregate
    {
        private string[] _strings;

        public string[] strings
        {
            get
            { return _strings; }
        }

        public Aggregate(string[] strings)
        {
            _strings = strings;
        }

        public IIterator CreateIterator()
        {
            return new Iterator(this);
        }
    }

    public interface IIterator
    {
        string Next();
        bool HasNext();
    }

    public class Iterator : IIterator
    {
        private Aggregate _aggregate;

        private int _index;

        public Iterator(Aggregate aggregate)
        {
            _aggregate = aggregate;

            _index = 0;
        }

        public string Next()
        {
            return _aggregate.strings[_index++];
        }

        public bool HasNext()
        {
            return _index < _aggregate.strings.Length;
        }
    }

    public static void Main(string[] args)
    {
        string[] strings = new string[]
        {
            "string A",
            "string B",
            "string C",
            "string D",
            "string E"
        };

        IAggregate aggregate = new Aggregate(strings);

        IIterator iterator = aggregate.CreateIterator();

        while (iterator.HasNext())
        {
            Console.WriteLine(iterator.Next());
        }
    }
}