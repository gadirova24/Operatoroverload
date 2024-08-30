using System;
namespace Operator_Overload
{
	public class Student
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public int Age { get; set; }

        public Student(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public override string ToString()
        {
            return $"{Name} {Surname}, Age: {Age}";
        }


        public static bool operator>(Student stu1,Student stu2)
        {
            return stu1.Age > stu2.Age;
        }
        public static bool operator < (Student stu1, Student stu2)
        {
            return stu1.Age < stu2.Age;
        }
        public static bool operator >=(Student stu1, Student stu2)
        {
            return stu1.Age >= stu2.Age;
        }
        public static bool operator <= (Student stu1, Student stu2)
        {
            return stu1.Age <= stu2.Age;
        }
    }
}

