using System.ComponentModel;

namespace program3
{
    public class Student
    {
        private static int _nextId = 1;

        public int Id { get; private set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string ClassName { get; set; } = string.Empty;

        // Use BindingList so DataGridView updates automatically
        public static BindingList<Student> Students { get; } = new BindingList<Student>();

        public Student()
        {
            Id = _nextId++;
        }

        public static void Add(Student s)
        {
            Students.Add(s);
        }

        public static void Remove(Student s)
        {
            Students.Remove(s);
        }
    }
}