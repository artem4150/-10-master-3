using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба10 
{ 
    public class Functions
    {
        static public int Input() // проверка отрицательных чисел
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
    }
}
