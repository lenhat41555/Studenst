using System;

namespace Studenst
{
    class Program
    {
      

        private static void Main1(string[] args)
        {
            Student student1 = new Student(1, "le nhat", "hue", 30);

            Student student2 = new Student();
            student2.SetId(2);
            student2.SetName("Ph. Quang Khánh");
            student2.SetAddress("Lạng Sơn");
            student2.SetAge(25);

            Console.WriteLine(student1.ToString());
            Console.WriteLine(student2.ToString());
            Console.Read();
        }
    }
}
