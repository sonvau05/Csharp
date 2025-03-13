using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Tạo hai luồng
        Thread thread1 = new Thread(PrintNumbers);
        Thread thread2 = new Thread(PrintLetters);

        // Chạy luồng
        thread1.Start();
        thread2.Start();

        // Đợi luồng hoàn thành
        thread1.Join();
        thread2.Join();

        Console.WriteLine("Đã xong tất cả!");
    }

    static void PrintNumbers()
    {
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"Luồng 1: Số {i}");
            Thread.Sleep(300); // Nghỉ 300ms
        }
    }

    static void PrintLetters()
    {
        char[] letters = { 'A', 'B', 'C' };
        for (int i = 0; i < letters.Length; i++)
        {
            Console.WriteLine($"Luồng 2: Chữ {letters[i]}");
            Thread.Sleep(300); // Nghỉ 300ms
        }
    }
}