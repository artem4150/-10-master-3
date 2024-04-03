using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба10
{
    internal class MusicalInstrument
    {
        Random rnd = new Random();

        protected string name;
        
        static string[] Names = { "ROCKDALE STARS BLACK", "IBANEZ GRX70QA-TRB", "YAMAHA F310", "YAMAHA C40", "ROLAND FP-30X-BK", 'KORG LP-380 RW U' }
        public string Name
        {
            get => name;
            set
            {
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

        public MusicalInstrument(string name)
        {
            Name = name;
        }

        public MusicalInstrument()
        {
            Name = "";
        }

        public virtual void Show()
        {
            Console.WriteLine($"Название: {Name}");
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj is MusicalInstrument m)
                return this.Name == m.Name;
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
    }
}
