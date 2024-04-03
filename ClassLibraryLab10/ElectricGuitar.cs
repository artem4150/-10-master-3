using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace лаба10
{
    internal class ElectricGuitar: MusicalInstrument
    {
        Random rnd = new Random();

        protected string PowerSupply {  get; set; }

        static string[] PowerSupplys = { "батарейки", "аккумуляторы", "фиксированный источник питания", "USB" };
        public ElectricGuitar() : base()
        {
            PowerSupply = string.Empty;
        }
        public ElectricGuitar(string power, string name) : base(name)
        {
            PowerSupply = power;
        }
        public override void Show()
        {
            Console.WriteLine($"Название: {Name}, источник питания: {PowerSupply}");
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj is ElectricGuitar e)
                return this.PowerSupply == e.PowerSupply
                    && this.Name == e.Name;
            return false;
        }

        public override string ToString()
        {
            return base.ToString()+ $"Электрогитара.Источник питания: { PowerSupply}";
        }

        public override void Init()
        {
            base.Init();
            Console.WriteLine("Введите тип источника питания");
            PowerSupply = Console.ReadLine();
        }
        public override void RandomInit()
        {
            base.RandomInit();
            PowerSupply = PowerSupplys[rnd.Next(PowerSupplys.Length)];
        }
    }
}
