using System;

class Program
{
    static void Main()
    {
        var pm = new ProductManager();
        while (true)
        {
            Console.Write("\n1.Thêm 2.Hiển thị 3.Tìm 4.Xóa 5.Sắp xếp 6.Sửa 7.Thoát\nChọn: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 7) break;

            switch (choice)
            {
                case 1: pm.Add(); break;
                case 2: if (pm.IsEmpty()) Console.WriteLine("Trống!"); else pm.Display(); break;
                case 3: pm.Search(Console.ReadLine()); break;
                case 4: pm.Delete(int.Parse(Console.ReadLine())); break;
                case 5: pm.Sort(); break;
                case 6: pm.Edit(int.Parse(Console.ReadLine())); break;
            }
        }
    }
}