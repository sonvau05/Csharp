using System;

class Program
{
    static void Main()
    {
        Library lib = new();
        while (true)
        {
            Console.WriteLine("\n1. Add  2. Show  3. Search  4. Filter  5. Exit");
            Console.Write("Option: ");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Title: ");
                    string t = Console.ReadLine();
                    Console.Write("Author: ");
                    string a = Console.ReadLine();
                    lib.Add(t, a);
                    break;
                case "2":
                    lib.Show();
                    break;
                case "3":
                    Console.Write("Title: ");
                    lib.Search(Console.ReadLine());
                    break;
                case "4":
                    Console.Write("Author: ");
                    lib.Filter(Console.ReadLine());
                    break;
                case "5":
                    return;
            }
        }
    }
}