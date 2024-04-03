using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace лаба10
{
    internal class Piano: MusicalInstrument
    {
        Random rnd = new Random();
        static string[] KeyboardLayouts = { "октавная", "шкальная", "дигитальная" };
        protected int NumberOfKeys
        {
            get => NumberOfKeys;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error!");
                    NumberOfKeys = 0;
                }
                else NumberOfKeys = value;
            }
        }

        protected string KeyboardLayout { get; set; }

        public Piano() : base()
        {
            NumberOfKeys = 0;
            KeyboardLayout = string.Empty;
        }

        public Piano(int keys, string name, string layout) : base(name)
        {
            NumberOfKeys = keys;
            KeyboardLayout = layout;
        }

        public override void Show()
        {
            Console.WriteLine($"Название: {Name}, количество клавиш: {NumberOfKeys}, раскладка: {KeyboardLayout}");
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj is Piano p)
                return this.NumberOfKeys == p.NumberOfKeys
                    && this.KeyboardLayout == p.KeyboardLayout
                    && this.Name == p.Name;
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + $"Фортепиано. Количество клавищ: {NumberOfKeys}, раскладка: {KeyboardLayout}";
        }

        public override void Init()
        {
            base.Init();
            Console.WriteLine("Введите тип расскладки");
            KeyboardLayout = Console.ReadLine();
            Console.WriteLine("Введите количество клавиш");
            NumberOfKeys = Functions.Input();
        }
        public override void RandomInit()
        {
            base.RandomInit();
            KeyboardLayout = KeyboardLayouts[rnd.Next(KeyboardLayouts.Length)];
            NumberOfKeys = rnd.Next(1,89);
        }
    }
}

