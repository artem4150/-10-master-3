using ClassLibrary1;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace лаба10
{
    public class MusicalInstrument : IInit, IComparable, ICloneable
    {
        Random rnd = new Random();
        
        private string name;
        public IdNumber num;
        static string[] Names = { "ROCKDALE STARS BLACK", "IBANEZ GRX70QA-TRB", "YAMAHA F310", "YAMAHA C40", "ROLAND FP-30X-BK" };
        public string Name
        {
            get => name;
            set
            {

                
                if (HasCharacters)
                {
                    Console.WriteLine("");
                    name = "";
                }
                else name = value;
            }
        }

        public bool HasCharacters
        {
            get { return !string.IsNullOrEmpty(name); }
        }

        public MusicalInstrument(string name, int number)
        {
            Name = name;
            num = new IdNumber(number);
        }

        public MusicalInstrument()
        {
            Name = "";
            num = new IdNumber(1);
        }

        public virtual void Show()
        {
            Console.WriteLine($"Название: {Name}");
        }

        public override bool Equals(object obj)
        {
            if (obj is MusicalInstrument m)
            {
                return this.Name == m.Name;
            }
            return false;
        }

        public override string ToString()
        {
            return Name;
        }

        public virtual void Init()
        {

            Console.WriteLine("Введите название");
            Name = Console.ReadLine();
        }
        public virtual void RandomInit()
        {

            Name = Names[rnd.Next(Names.Length)];
        }
        
        
        
        public object ShallowCopy()
        {
            return this.MemberwiseClone();
        }
        public string GetName(MusicalInstrument m)
        {
            return m.Name;
        }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            MusicalInstrument otherInstrument = obj as MusicalInstrument;
            if (otherInstrument != null)
                return this.Name.CompareTo(otherInstrument.Name);
            else
                throw new ArgumentException("Объект не музыкальный элемент");
        }
        public virtual object Clone()
        {
            var instrument = (MusicalInstrument)MemberwiseClone();
            instrument.Name = (string)Name.Clone();
           
            return instrument;
        }
        public static void ViewInstruments(MusicalInstrument[] instruments)
        {
            Console.WriteLine("Обычный просмотр элементов массива:");
            foreach (var instrument in instruments)
            {
                Console.WriteLine(instrument.ToString());
            }
        }
        public static void ViewInstrumentsVirtual(MusicalInstrument[] instruments)
        {
            Console.WriteLine("Виртуальный просмотр элементов массива:");
            foreach (var instrument in instruments)
            {
                instrument.Show();
            }
        }

    }
}
