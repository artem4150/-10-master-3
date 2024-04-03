using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба10
{
    internal class Guitar:MusicalInstrument
    {
        Random rnd = new Random();
        protected int NumberOfStrings
        {
            get => NumberOfStrings;
            set
            {
                // Количество рублей не может быть меньше 0
                if (value < 0)
                {
                    Console.WriteLine("Error!");
                    NumberOfStrings = 0;
                }
                else NumberOfStrings = value;
            }
        }
        public Guitar() : base() 
        {
            NumberOfStrings = 0;
        }
        public Guitar(int numberofstrings, string name) : base(name) 
        {
            NumberOfStrings = numberofstrings;
        }
        public override void Show()
        {
            Console.WriteLine($"Название: {Name}, количество струн: {NumberOfStrings}");
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj is Guitar g)
                return this.NumberOfStrings == g.NumberOfStrings
                    && this.Name == g.Name; ;
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
            NumberOfStrings = Functions.Input();
        }
        public override void RandomInit()
        {
            base.RandomInit();
            NumberOfStrings = rnd.Next(0,18);
        }
    }
}
