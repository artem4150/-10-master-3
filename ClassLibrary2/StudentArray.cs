using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace лаба_9_2
{
	public class StudentArray
	{
		Student[] studentarray;
        static Random rnd = new Random();
		public int Length
		{
			get => studentarray.Length;
		}
        static int count = 0;

        public static int GetCount() { return count; }
        public void Show()
		{
			for (int i = 0; i < studentarray.Length; i++)
			{
				studentarray[i].Show();
            }
        }
        public StudentArray(int length)
        {
            studentarray = new Student[length];
            for (int i = 0; i < length; i++)
            {
                studentarray[i] = new Student(Functions.GenerateRandomString(),rnd.Next(50), rnd.Next(50));
            }
            count++;
        }
        

        public StudentArray(int length,bool m)
        {
            studentarray = new Student[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Введите имя, возраст, gpa - {i}  студента");
                studentarray[i] = new Student(Functions.CheckIfWord(), Functions.Input(), Functions.InputDouble());
            }
            count++;

        }

        public StudentArray(StudentArray other)
        {
            this.studentarray = new Student[other.Length];
            for (int i = 0; i < other.Length; i++)
                this.studentarray[i] = other.studentarray[i];
            count++;
        }

        public Student this[int index]
        {
            get
            {
                if (0 <= index && index < studentarray.Length)
                    return studentarray[index];
                else
                    throw new Exception("Индекс выходит за пределы коллекции");
                
            }
            set
            {
                if (0 <= index && index < studentarray.Length)
                    studentarray[index] = value;
                else
                    Console.WriteLine("Индекс выходит за пределы коллекции");
            }
        }


        public StudentArray()
        {
            studentarray = new Student[0];
        }

       
        
    }
}

