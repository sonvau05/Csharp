namespace StudentManagement
{
    public class Student
    {
        public string Id { get; private set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Age: {Age}";
        }
    }
}