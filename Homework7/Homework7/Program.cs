using System;

class Program
{
    static void Main()
    {
        ICarManager cm = new CarManager();
        while (true)
        {
            Console.Write("\n1.Thêm 2.Hiển thị 3.Tìm 4.Xóa 5.Sắp xếp 6.Sửa 7.Thoát\nChọn: ");
            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 7)
            {
                Console.WriteLine("Chọn sai!");
                continue;
            }
            if (choice == 7) break;

            switch (choice)
            {
                case 1: cm.Add(); break;
                case 2: if (cm.IsEmpty()) Console.WriteLine("Trống!"); else cm.Display(); break;
                case 3: Console.Write("Tên: "); cm.Search(Console.ReadLine()); break;
                case 4: Console.Write("ID: "); cm.Delete(int.Parse(Console.ReadLine())); break;
                case 5: cm.Sort(); Console.WriteLine("Sắp xếp xong!"); break;
                case 6: Console.Write("ID: "); cm.Edit(int.Parse(Console.ReadLine())); break;
            }
        }
    }
}