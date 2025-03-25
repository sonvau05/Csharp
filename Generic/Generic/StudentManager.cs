using System;
using System.Collections.Generic;

namespace StudentManagement
{
    public class StudentManager<T> where T : Student
    {
        private List<T> list;

        public StudentManager()
        {
            list = new List<T>();
        }

        public void Add(T item)
        {
            list.Add(item);
        }

        public void List()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Danh sách trống!");
                return;
            }
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }

        public void Update(string id, string newName, int newAge)
        {
            T student = list.Find(s => s.Id == id);
            if (student != null)
            {
                student.Name = newName;
                student.Age = newAge;
                Console.WriteLine("Đã cập nhật thông tin sinh viên!");
            }
            else
            {
                Console.WriteLine($"Không tìm thấy sinh viên với ID: {id}");
            }
        }

        public void Delete(string id)
        {
            T student = list.Find(s => s.Id == id);
            if (student != null)
            {
                list.Remove(student);
                Console.WriteLine("Đã xóa sinh viên!");
            }
            else
            {
                Console.WriteLine($"Không tìm thấy sinh viên với ID: {id}");
            }
        }
    }
}