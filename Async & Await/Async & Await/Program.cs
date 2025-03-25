using System;
using System.Threading.Tasks;

class Program
{
    private static async Task Delay(int ms)
    {
        await Task.Delay(ms);
    }

    private static async Task<double> Cong(double a, double b)
    {
        await Delay(1000);
        return a + b;
    }

    private static async Task<double> Tru(double a, double b)
    {
        await Delay(1000);
        return a - b;
    }

    private static async Task<double> Nhan(double a, double b)
    {
        await Delay(1000);
        return a * b;
    }

    private static async Task<double> Chia(double a, double b)
    {
        await Delay(1000);
        if (b == 0) throw new Exception("Không thể chia cho 0");
        return a / b;
    }

    static async Task Main(string[] args)
    {
        try
        {
            double a = 10;
            double b = 5;

            Console.WriteLine("Bắt đầu tính toán...");

            double ketQuaCong = await Cong(a, b);
            Console.WriteLine($"Cộng: {a} + {b} = {ketQuaCong}");

            double ketQuaTru = await Tru(a, b);
            Console.WriteLine($"Trừ: {a} - {b} = {ketQuaTru}");

            double ketQuaNhan = await Nhan(a, b);
            Console.WriteLine($"Nhân: {a} * {b} = {ketQuaNhan}");

            double ketQuaChia = await Chia(a, b);
            Console.WriteLine($"Chia: {a} / {b} = {ketQuaChia}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi: {ex.Message}");
        }
    }
}