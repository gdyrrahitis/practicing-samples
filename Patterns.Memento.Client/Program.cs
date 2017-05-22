namespace Patterns.Memento.Client
{
    using System;
    using Patterns.Memento;

    internal class Program
    {
        private static Memento _memento;

        internal static void Main(string[] args)
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

                switch (input)
                {
                    case 1:
                        bag.AddShape($"rectangle{Guid.NewGuid()}", new Rectangle());
                        Console.WriteLine("Saved rectangle");
                        break;
                    case 2:
                        bag.AddShape($"triangle{Guid.NewGuid()}", new Triangle());
                        Console.WriteLine("Saved triangle");
                        break;
                    case 3:
                        _memento = bag.CreateMemento();
                        Console.WriteLine("Created checkpoint");
                        break;
                    case 4:
                        bag.RestoreMemento(_memento);
                        Console.WriteLine("Restored checkpoint");
                        break;
                    case 5:
                        foreach (var item in bag.GetShapes())
                        {
                            Console.WriteLine($"{item.Key} is {item.Value.GetType().Name}");
                        }
                        break;
                }

                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
