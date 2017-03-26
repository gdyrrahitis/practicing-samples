namespace Patterns.Iterator.V1
{
    using System.Collections.Generic;

    public class Person : PersonAggregate
    {
        private readonly IList<object> _items;

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            _items = new List<object> { name, surname, age };
        }

        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }
        public int Count => _items.Count;

        public override Iterator GetIterator()
        {
            return new PersonIterator(this);
        }

        public object this[int index] => _items[index];
    }
}