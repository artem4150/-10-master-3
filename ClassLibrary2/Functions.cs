using System;
using System.Text;

namespace лаба_9_2
{

    internal class Functions
    {
        //public Functions()
        //{
        
        public Student student1 = new Student();
        public Student student2 = new Student();
        public static int Input() // проверка отрицательных чисел
        {
            int m;
            bool ok;
            do
            {
                string buf = Console.ReadLine();
                ok = int.TryParse(buf, out m);
                if (!ok) Console.WriteLine("ошибка! Введите действительное число");
            } while (!ok);
            return m;
        }
        static public int Input1() // проверка отрицательных чисел
        {
            int m;
            bool ok;
            do
            {
                string buf = Console.ReadLine();
                ok = int.TryParse(buf, out m);
                if (m <= 0) { ok = false; }
                if (!ok) Console.WriteLine("ошибка! Введите действительное число больше нуля");
            } while (!ok);
            return m;
        }
        static public double InputDouble() // проверка отрицательных чисел
        {
            double m1;
            bool ok;
            do
            {
                string buf = Console.ReadLine();
                ok = double.TryParse(buf, out m1);
                if (m1 <= 0) { ok = false; }
                if (!ok) Console.WriteLine("ошибка! Введите действительное число больше нуля");
            } while (!ok);
            return m1;
        }

        public static string CheckIfWord()
        {
            string input = Console.ReadLine();
            foreach (char c in input)
            {
                if (!Char.IsLetter(c))
                {
                    Console.WriteLine("Введите имя ученика");
                    break;

                }
            }
            return input;
        }

        static public string GenerateRandomString(int length = 6)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var random = new Random();
            var stringBuilder = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(chars.Length);
                stringBuilder.Append(chars[index]);
            }

            return stringBuilder.ToString();
        }

        static public int GenerateRandomInt()
        {
            Random random = new Random();
            int n = random.Next(150);
            return n;

        }

        static public double GenerateRandomDouble()
        {
            Random random = new Random();
            double n = random.Next(10);
            return n;

        }

        public void InputStudent()
        {
            Student student1 = new Student();
            Student student2 = new Student();
            Student student12 = new Student();
            Console.WriteLine("Введите имя, возраст, gpa - 1 студента");
            student1.SetStudent(CheckIfWord(), Input1(), InputDouble());
            Console.WriteLine("Введите имя, возраст, gpa - 2 студента");
            student2.SetStudent(CheckIfWord(), Input1(), InputDouble());
            string result = student12.StudentComparison(student1, student2);
            Console.WriteLine(result);
        }



        public void Task1RandomInput()
        {

            Student student1 = new Student();
            Student student2 = new Student();
            Student student12 = new Student();

            student1.SetStudent(GenerateRandomString(), GenerateRandomInt(), GenerateRandomDouble());

            student2.SetStudent(GenerateRandomString(), GenerateRandomInt(), GenerateRandomDouble());
            string result = student12.StudentComparison(student1, student2);
            Console.WriteLine(result);
        }
        public static string CapitalizeFirstLetter(string word)
        {
            if (string.IsNullOrEmpty(word))
                return word;

            string firstLetter = word.Substring(0, 1).ToUpper();
            string restOfWord = word.Substring(1);

            return firstLetter + restOfWord;

        }
        
        
        


    }
}

