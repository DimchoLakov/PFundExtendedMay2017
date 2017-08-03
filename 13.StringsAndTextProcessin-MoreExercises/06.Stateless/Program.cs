using System;

namespace _06.Stateless
{
    class Program
    {
        static void Main(string[] args)
        {
            string state = Console.ReadLine();
            string fiction = Console.ReadLine();

            while (state != "collapse")
            {
                while (fiction.Length > 0)
                {
                    state = state.Replace(fiction, string.Empty);
                    fiction = fiction.Remove(0, 1);
                    if (fiction.Length == 0)
                    {
                        break;
                    }
                    fiction = fiction.Remove(fiction.Length - 1, 1);
                }

                if (state.Length > 0)
                {
                    Console.WriteLine(state);
                }
                else
                {
                    Console.WriteLine($"(void)");
                }
                state = Console.ReadLine();
                if (state == "collapse")
                {
                    break;
                }

                fiction = Console.ReadLine();
            }
        }
    }
}
