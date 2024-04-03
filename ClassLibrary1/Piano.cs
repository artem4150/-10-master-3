using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace лаба10
{
    public class Piano: MusicalInstrument , IInit
    {
        Random rnd = new Random();
        static string[] KeyboardLayouts = { "октавная", "шкальная", "дигитальная" };
        protected int NumberOfKeys1;
        public int NumberOfKeys
        {
            get => NumberOfKeys1;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error!2");
                    NumberOfKeys1 = 0;
                }
                else NumberOfKeys1 = value;
            }
        }

        protected string KeyboardLayout1;
        public string KeyboardLayout
        {
            get => KeyboardLayout1;
            set
            {
                if (HasCharacters)
                {
                    Console.WriteLine("Error!3");
                    KeyboardLayout1 = string.Empty;
                }
                else KeyboardLayout1 = value;
            }
        }
        public Piano() : base()
        {
            NumberOfKeys = 0;
            KeyboardLayout = string.Empty;
        }

        public Piano(int keys, string name, string layout, int num) : base(name, num)
        {
            NumberOfKeys1 = keys;
            KeyboardLayout1 = layout;
        }

        public override void Show()
        {
            Console.WriteLine($"Название: {Name}, количество клавиш: {NumberOfKeys}, раскладка: {KeyboardLayout}");
        }

        public override bool Equals(object obj)
        {
            if (obj is Piano p)
            {
                return this.NumberOfKeys == p.NumberOfKeys
                    && this.KeyboardLayout == p.KeyboardLayout
                    && this.Name == p.Name;
            }
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
            KeyboardLayout1 = Console.ReadLine();
            Console.WriteLine("Введите количество клавиш");
            NumberOfKeys1 = Functions.Input();
        }
        public override void RandomInit()
        {
            base.RandomInit();
            KeyboardLayout1 = KeyboardLayouts[rnd.Next(KeyboardLayouts.Length)];
            NumberOfKeys1 = rnd.Next(1,89);
        }
        public new object ShallowCopy()
        {
            return this.MemberwiseClone();
        }
        // Обычная функция для просмотра элементов массива
        public static void ViewPianos(Piano[] pianos)
        {
            Console.WriteLine("Обычный просмотр элементов массива:");
            foreach (var piano in pianos)
            {
                Console.WriteLine(piano.ToString());
            }
        }

        // Виртуальная функция для просмотра элементов массива
        public static void ViewPianosVirtual(Piano[] pianos)
        {
            Console.WriteLine("Виртуальный просмотр элементов массива:");
            foreach (var piano in pianos)
            {
                piano.Show();
            }
        }
        public override object Clone()
        {
           
            var piano = (Piano)base.Clone();
            piano.NumberOfKeys = this.NumberOfKeys;

            piano.KeyboardLayout = (string)this.KeyboardLayout.Clone();

            return piano;
        }
    }
}

