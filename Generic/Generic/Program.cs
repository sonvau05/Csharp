using System;

namespace StudentManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager<Student> manager = new StudentManager<Student>();
            while (true)
            {
                Console.WriteLine("\n=== QUẢN LÝ SINH VIÊN ===");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. List");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. Exit");
                Console.Write("Chọn chức năng (1-5): ");

                if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 5)
                {
                    Console.WriteLine("Lựa chọn không hợp lệ! Vui lòng chọn lại.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Nhập ID: ");
                        string id = Console.ReadLine();
                        Console.Write("Nhập tên: ");
                        string name = Console.ReadLine();
                        Console.Write("Nhập tuổi: ");
                        if (int.TryParse(Console.ReadLine(), out int age))
                        {
                            manager.Add(new Student(id, name, age));
                            Console.WriteLine("Đã thêm sinh viên!");
                        }
                        else
                        {
                            Console.WriteLine("Tuổi không hợp lệ!");
                        }
                        break;

                    case 2:
                        Console.WriteLine("\nDanh sách sinh viên:");
                        manager.List();
                        break;

                    case 3: 
                        Console.Write("Nhập ID sinh viên cần cập nhật: ");
                        string updateId = Console.ReadLine();
                        Console.Write("Nhập tên mới: ");
                        string newName = Console.ReadLine();
                        Console.Write("Nhập tuổi mới: ");
                        if (int.TryParse(Console.ReadLine(), out int newAge))
                        {
                            manager.Update(updateId, newName, newAge);
                        }
                        else
                        {
                            Console.WriteLine("Tuổi không hợp lệ!");
                        }
                        break;

                    case 4:
                        Console.Write("Nhập ID sinh viên cần xóa: ");
                        string deleteId = Console.ReadLine();
                        manager.Delete(deleteId);
                        break;

                    case 5:
                        Console.WriteLine("Thoát chương trình!");
                        return;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            }
        }
    }
}