namespace Patterns.Iterator.V2
{
    public class Person
    {
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }
    }
}