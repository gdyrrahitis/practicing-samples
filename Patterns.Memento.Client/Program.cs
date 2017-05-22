namespace Patterns.Memento.Client
{
    using System;
    using Patterns.Memento;

    class Program
    {
        private static Memento _memento;

        static void Main(string[] args)
        {
            var bag = new ShapeBag();
            while (true)
            {
                Console.WriteLine("Press 1 to save rectangle, 2 for triangle, 3 to save state, 4 to recover state, 5 to show bag, 0 to exit");
                var input = Convert.ToInt32(Console.ReadLine());
                if (input == 0)
                {
                    break;
                }
                else if (input == 1)
                {
                    bag.AddShape($"rectangle{Guid.NewGuid()}", new Rectangle());
                    Console.WriteLine("Saved rectangle");
                }
                else if (input == 2)
                {
                    bag.AddShape($"triangle{Guid.NewGuid()}", new Triangle());
                    Console.WriteLine("Saved triangle");
                }
                else if (input == 3)
                {
                    _memento = bag.CreateMemento();
                    Console.WriteLine("Created checkpoint");
                }
                else if (input == 4)
                {
                    bag.RestoreMemento(_memento);
                    Console.WriteLine("Restored checkpoint");
                }
                else if (input == 5)
                {
                    foreach (var item in bag.GetShapes())
                    {
                        Console.WriteLine($"{item.Key} is {item.Value.GetType().Name}");
                    }
                }

                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
