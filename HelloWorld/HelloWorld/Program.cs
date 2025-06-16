namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            if (args.Length > 0)
            {
                foreach (var arg in args)
                {
                    Console.WriteLine(arg);
                }
            }
            var s = Console.ReadLine();
            if (int.TryParse(s, out var val))
                Console.WriteLine(val);
            else
                Console.WriteLine("no");
            
        }
        }
    }
