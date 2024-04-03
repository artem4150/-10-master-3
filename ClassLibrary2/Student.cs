
using System;
using System.Drawing;
using System.Security.Claims;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace лаба_9_2
{
	public class Student 
	{

        
        private string name;
        private int age;
        private double gpa;
        static int count = 0;
        static string[] Names = { "АВГУСТИН", "ВЛАС", "ДАЛМАТ", "КАЛИСТРАТ", "МАКСИМИЛИАН", "САРМАТ" };
        public static int GetCount() { return count; }

        public void SetStudent(string Name, int Age, double Gpa)
        {
            name = Name;
            age = Age;
            gpa = Gpa;
            
        }
        public string GetName()
        {
            return Name;
        }

        public int GetAge()
        {
            return Age;
        }

        public Student()
        {
            Name = string.Empty;
            Age = 0;
            Gpa = 0;
            count++;
        }
        public Student(string N, int A, double G)
        {
            Name = N;
            Age = A;
            Gpa = G;
            count++;
        }
        public Student(Student s)
        {
            Name = s.Name;
            Age = s.Age;
            Gpa = s.Gpa;
            count++;

        }
        public int Age
        {
            get => age;
            set
            {
                // Количество рублей не может быть меньше 0
                if (value < 0 && value > 150)
                {
                    Console.WriteLine("Error!");
                    age = 0;
                }
                else age = value;
            }
        }

        public double Gpa
        {
            get => gpa;
            set
            {
                // Количество рублей не может быть меньше 0
                if (value < 0 && value > 10)
                {
                    Console.WriteLine("Error!");
                    gpa = 0;
                }
                else gpa = value;
            }
        }
        public string Name
        {
            get => name;
            set
            {
                
                // Количество рублей не может быть меньше 0
                if (HasCharacters)
                {
                    Console.WriteLine("Error!");
                    name = "";
                }
                else name = value;
            }
        }
        public bool HasCharacters
        {
            get { return !string.IsNullOrEmpty(name); }
        }

        

        public void Show()
        {
            Console.WriteLine($"Имя: {Name}, возраст: {Age}, Gpa: {Gpa}.");
        }
        public string StudentComparison(Student student1, Student student2)
        {
            string name1 = student1.name;
            int age1 = student1.age;
            double gpa1 = student1.gpa;
            string name2 = student2.name;
            int age2 = student2.age;
            double gpa2 = student2.gpa;
            string result = name1 +" ";
            if (age1 > age2)
            {
                result += "старше ";
            }
            if (age1 == age2)
            {
                result += "ровесник ";
            }
            if (age1 < age2) { result += "младше "; }
            result += name2 + ". " + Convert.ToString(gpa1)+" " + name1;
            if (gpa1 > gpa2)
            {
                result += " выше ";
            }
            if (gpa1 == gpa2)
            {
                result += " равен ";
            }
            if (gpa1 < gpa2) { result += " ниже "; }
            result += Convert.ToString(gpa2) +" "+ name2;
            return result;
        }
        static public string StudentComparison2(Student student1, Student student2)
        {
            string result = $"{student1.name} ";

            if (student1.age > student2.age)
                result += "старше ";
            else if (student1.age == student2.age)
                result += "ровесник ";
            else
                result += "младше ";

            result += $"{student2.name}. {student1.gpa} {student1.name} ";

            if (student1.gpa > student2.gpa)
                result += "выше ";
            else if (student1.gpa == student2.gpa)
                result += "равен ";
            else
                result += "ниже ";

            result += $"{student2.gpa} {student2.name}";

            return result;
        }
        public static Student operator ++(Student student)
        {
            Student Result = new Student();
            
            
            
            Result.Age = student.Age;
            Result.Age++;
            return Result;
        }
        ////public static Student operator ~(Student student)
        ////{
        ////    Student Result = new Student();

        ////    Result.name = Functions.CapitalizeFirstLetter(student.GetName());

            
        ////    return Result;
        ////}
        public static explicit operator int(Student s)
        {
            
            if (18 <= s.Age && s.Age <= 22)
            {
                return s.Age - 17;
            }
            return -1;
        }
        public static implicit operator bool(Student s)
        {
            
            return s.Gpa < 6;
        }
        public static Student operator -(int d, Student st)
        {
            Student s = new Student(st);
            s.Gpa -=d;
            
            return s;
        }
        public static Student operator %(string d, Student st)
        {
            Student s = new Student(st);
            s.name = d;
            return s;
        }

        public override string ToString()
        {
            return $"Имя: {Name}, возраст: {Age}, Gpa: {Gpa}.";
        }
        public override bool Equals(object obj)
        {
            bool equals = true;
            if (obj is Student)
            {
                Student r = (Student)obj;
                equals &= (this.name == r.name) && (this.name == r.name);
                equals &= (this.age == r.age) && (this.age == r.age);
                equals &= (this.gpa == r.gpa) && (this.gpa == r.gpa);
            }
            return equals;
        }
        public void Init()
        {
            Console.WriteLine("Введите имя студента:");
            name = Console.ReadLine();
            Console.WriteLine("Введите возраст студента:");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите GPA студента:");
            gpa = double.Parse(Console.ReadLine());
        }
        public void RandomInit()
        {
            Random random = new Random();
            Name = Names[random.Next(Names.Length)];
            age = random.Next(18, 30); 
            gpa = random.NextDouble() * (10 - 0) + 0; 
        }
        // Метод для вывода информации о студенте
        public void PrintInfo()
        {
            Console.WriteLine($"Имя: {name}, возраст: {age}, GPA: {gpa}");
        }

        // Виртуальный метод для вывода информации о студенте
        public virtual void PrintInfoVirtual()
        {
            Console.WriteLine($"Имя: {name}, возраст: {age}, GPA: {gpa}");
        }

        // Пример статического метода для просмотра элементов массива с помощью обычной функции
        public static void ViewStudents(Student[] students)
        {
            Console.WriteLine("Просмотр элементов массива с помощью обычной функции:");
            foreach (var student in students)
            {
                student.PrintInfo();
            }
        }

        // Пример статического метода для просмотра элементов массива с помощью виртуальной функции
        public static void ViewStudentsVirtual(Student[] students)
        {
            Console.WriteLine("Просмотр элементов массива с помощью виртуальной функции:");
            foreach (var student in students)
            {
                student.PrintInfoVirtual();
            }
        }
    }
}

