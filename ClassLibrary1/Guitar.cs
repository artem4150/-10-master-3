using ClassLibrary1;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба10
{
    public class Guitar : MusicalInstrument, IInit //, ICloneable
    {
        Random rnd = new Random();
        protected int NumberOfStrings1;
        public int NumberOfStrings
        {
            get => NumberOfStrings1;
            set
            {

                if (value < 0)
                {
                    Console.WriteLine("Error!");
                    NumberOfStrings1 = 0;
                }
                else NumberOfStrings1 = value;
            }
        }
        public Guitar() : base()
        {
            NumberOfStrings = 0;
        }
        public Guitar(int numberofstrings, string name, int num) : base(name, num)
        {
            NumberOfStrings1 = numberofstrings;
        }
        public override void Show()
        {
            Console.WriteLine($"Название: {Name}, количество струн: {NumberOfStrings}");
        }

        public override bool Equals(object obj)
        {
            if (obj is Guitar g)
            {
                return this.NumberOfStrings == g.NumberOfStrings
                    && this.Name == g.Name;
            }
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + "Гитара. Количество струн: " + NumberOfStrings;
        }

        public override void Init()
        {
            base.Init();
            Console.WriteLine("Введите количество струн");
            NumberOfStrings1 = Functions.Input();
        }
        public override void RandomInit()
        {
            base.RandomInit();
            NumberOfStrings1 = rnd.Next(1, 18);
        }
        public int CompareTo(object obj)
        {
            if (obj is Guitar otherGuitar)
            {
                return NumberOfStrings.CompareTo(otherGuitar.NumberOfStrings);
            }

            throw new ArgumentException("Невозможно сравнить объекты");
        }
        public new object ShallowCopy()
        {
            return this.MemberwiseClone();
        }
        //public override object Clone()
        //{
        //    Guitar copy = (Guitar)MemberwiseClone();
        //    copy.Strings = new string[Strings.Length];
        //    for (int i = 0; i < Strings.Length; i++)
        //    {
        //        copy.Strings[i] = Strings[i];
        //    }
        //    return copy;
        //}
        public static void ViewGuitars(Guitar[] guitars)
        {
            Console.WriteLine("Обычный просмотр элементов массива:");
            foreach (var guitar in guitars)
            {
                Console.WriteLine(guitar.ToString());
            }
        }

        // Виртуальная функция для просмотра элементов массива
        public static void ViewGuitarsVirtual(Guitar[] guitars)
        {
            Console.WriteLine("Виртуальный просмотр элементов массива:");
            foreach (var guitar in guitars)
            {
                guitar.Show();
            }
        }
        public override object Clone()
        {
           
            var guitar = (Guitar)base.Clone();

            guitar.NumberOfStrings = this.NumberOfStrings;

            
            return guitar;
        }
    }
}
