using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using лаба10;
using лаба_9_2;


namespace лаба10
{
    public class Program
    {

        static void Main(string[] args)
        {
            MusicalInstrument[] arr = new MusicalInstrument[20];
            for (int i = 0; i < 20;)
            {

                arr[i] = new Guitar();
                arr[i].RandomInit();
                arr[i + 1] = new Piano();
                arr[i + 1].RandomInit();
                arr[i + 2] = new ElectricGuitar();
                arr[i + 2].RandomInit();
                arr[i + 3] = new MusicalInstrument();
                arr[i + 3].RandomInit();
                i += 4;
            }
            int countMusic = 1;

            foreach (MusicalInstrument item in arr)
            {
                Console.Write(countMusic + ") ");
                item.Show();
                countMusic++;
            }

            PianoF(arr);
            SumStrings(arr);
            SumStringsEl(arr);

            // Вывод массива из 9 лабы
            Console.WriteLine("лабараторная работа №9");
            Student[] arr1 = new Student[20];
            for (int i = 0; i < 20;)
            {

                arr1[i] = new Student();
                arr1[i].RandomInit();
                
                i += 1;
            }
            int countStudent = 1;
            foreach (Student item in arr1)
            {
                Console.Write(countStudent + ") ");
                item.Show();
                countStudent++;
            }
            
            countMusic = 1;
            Console.WriteLine("Исходный: ");
            foreach (MusicalInstrument item in arr)
            {
                Console.Write(countMusic + ") ");
                item.Show();
                countMusic++;
            }

            Console.WriteLine("Добавлен новый инструмент в начало списка ");
            Piano piano1 = new Piano(84, "Yamaha", "октавная", 3);
            arr[0] = piano1;
            Array.Sort(arr);
            Console.WriteLine("Отсортированный по Id: ");
            countMusic = 1;
            foreach (MusicalInstrument item in arr)
            {
                Console.Write(countMusic + ") ");
                item.Show();
                countMusic++;
            }

            // Бинарный поиск по Id
            Console.WriteLine("Номер инструмента: ");
            int pos = Array.BinarySearch(arr, new Piano(84, "Yamaha", "октавная", 3));
            if (pos < 0)
            {
                Console.WriteLine("Элемент не найден");
            }
            else
            {
                Console.WriteLine($"Элемент находится на {pos + 1} позиции");
            }
            Array.Sort(arr, new sort());

            Console.WriteLine("Отсортированный массив: ");
            countMusic = 1;
            foreach (MusicalInstrument item in arr)
            {
                Console.Write(countMusic + ") ");
                item.Show();
                countMusic++;
            }

            // Бинарный поиск 
            Console.WriteLine("Номер инструмента в списке: ");
            pos = Array.BinarySearch(arr, new Piano(84, "Yamaha", "октавная", 3), new sort());
            if (pos < 0)
            {
                Console.WriteLine("Элемент не найден");
            }
            else
            {
                Console.WriteLine($"Элемент находится на {pos + 1} позиции");
            }

            // поверхостное копирования
            Piano PianoOrig = new Piano();
            PianoOrig.RandomInit();
            Console.WriteLine(PianoOrig);
            Piano PianoCopy = (Piano)PianoOrig.ShallowCopy();
            Console.WriteLine(PianoCopy);

            // глубокое копирование
            Piano PianoOrig1 = new Piano();
            Piano PianoClone = PianoOrig1.Clone() as Piano;
            Console.WriteLine( PianoClone);
            Console.WriteLine("После изменений:");
            PianoCopy.Name = "поверхостное копирования" + PianoOrig1.Name;
            PianoCopy.num.number = 200;
            PianoClone.Name = "глубокое копирование" + PianoOrig1.Name;
            PianoClone.num.number = 300;
            Console.WriteLine("1"+PianoOrig1 );
            Console.WriteLine(PianoCopy );
            Console.WriteLine(PianoClone );
            MusicalInstrument[] instruments = new MusicalInstrument[3];
            instruments[0] = new MusicalInstrument("Piano", 1);
            instruments[1] = new MusicalInstrument("Guitar", 2);
            instruments[2] = new MusicalInstrument("ElectricGuitar", 3);

            // Вызов обычной функции для просмотра элементов массива
            MusicalInstrument.ViewInstruments(instruments);

            // Вызов виртуальной функции для просмотра элементов массива
            MusicalInstrument.ViewInstrumentsVirtual(instruments);
            Piano[] pianos = new Piano[3];
            pianos[0] = new Piano(88, "YAMAHA", "октавная", 1);
            pianos[1] = new Piano(76, "Roland", "шкальная", 2);
            pianos[2] = new Piano(61, "Casio", "дигитальная", 3);

            // Вызов обычной функции для просмотра элементов массива
            Piano.ViewPianos(pianos);

            // Вызов виртуальной функции для просмотра элементов массива
            Piano.ViewPianosVirtual(pianos);
            Guitar[] guitars = new Guitar[3];
            guitars[0] = new Guitar(6, "Fender", 1);
            guitars[1] = new Guitar(7, "Gibson", 2);
            guitars[2] = new Guitar(12, "Taylor", 3);

            // Вызов обычной функции для просмотра элементов массива
            Guitar.ViewGuitars(guitars);

            // Вызов виртуальной функции для просмотра элементов массива
            Guitar.ViewGuitarsVirtual(guitars);
            ElectricGuitar[] electricGuitars = new ElectricGuitar[3];
            electricGuitars[0] = new ElectricGuitar("батарейки", "Fender", 6, 1);
            electricGuitars[1] = new ElectricGuitar("аккумуляторы", "Gibson", 7, 2);
            electricGuitars[2] = new ElectricGuitar("фиксированный источник питания", "Ibanez", 6, 3);

            // Вызов обычной функции для просмотра элементов массива
            ElectricGuitar.ViewElectricGuitars(electricGuitars);

            // Вызов виртуальной функции для просмотра элементов массива
            ElectricGuitar.ViewElectricGuitarsVirtual(electricGuitars);
            // Создание объекта Piano
            Piano piano = new Piano(88, "Yamaha", "октавная", 1);
            Console.WriteLine("Original Piano:");
            Console.WriteLine(piano);

            // Клонирование объекта Piano
            Piano clonedPiano = (Piano)piano.Clone();
            Console.WriteLine("\nCloned Piano:");
            Console.WriteLine(clonedPiano);

            // Создание объекта Guitar
            Guitar guitar = new Guitar(6, "Fender", 1);
            Console.WriteLine("\nOriginal Guitar:");
            Console.WriteLine(guitar);

            // Клонирование объекта Guitar
            Guitar clonedGuitar = (Guitar)guitar.Clone();
            Console.WriteLine("\nCloned Guitar:");
            Console.WriteLine(clonedGuitar);

            // Создание объекта ElectricGuitar
            ElectricGuitar electricGuitar = new ElectricGuitar("батарейки", "Fender", 6, 1);
            Console.WriteLine("\nOriginal Electric Guitar:");
            Console.WriteLine(electricGuitar);

            // Клонирование объекта ElectricGuitar
            ElectricGuitar clonedElectricGuitar = (ElectricGuitar)electricGuitar.Clone();
            Console.WriteLine("\nCloned Electric Guitar:");
            Console.WriteLine(clonedElectricGuitar);
            Array.Sort(arr);
            Console.WriteLine("Отсортированный массив по IComparable:");
            countMusic = 1;
            foreach (MusicalInstrument item in arr)
            {
                Console.Write(countMusic + ") ");
                item.Show();
                countMusic++;
            }
            // Отсортированный по Id
            Array.Sort(arr);
            Console.WriteLine("Отсортированный по Id: ");
            countMusic = 1;
            foreach (MusicalInstrument item in arr)
            {
                Console.Write(countMusic + ") ");
                item.Show();
                countMusic++;
            }

            // Сортировка по IComparable
            Array.Sort(arr);
            Console.WriteLine("Отсортированный массив по IComparable:");
            countMusic = 1;
            foreach (MusicalInstrument item in arr)
            {
                Console.Write(countMusic + ") ");
                item.Show();
                countMusic++;
            }
            Array.Sort(arr, new PianoKeysComparer());
            Console.WriteLine("Отсортированный массив по количеству клавиш на фортепиано:");
            countMusic = 1;
            foreach (MusicalInstrument item in arr)
            {
                Console.Write(countMusic + ") ");
                item.Show();
                countMusic++;
            }
            // Сначала отсортируем массив arr по Id
            Array.Sort(arr);

            // Элемент, который мы ищем
            Piano target = new Piano(84, "Yamaha", "октавная", 3);

            // Используем бинарный поиск для поиска элемента в отсортированном массиве
            int index = Array.BinarySearch(arr, target);

            // Проверяем результат бинарного поиска
            if (index >= 0)
            {
                // Элемент найден
                Console.WriteLine($"Элемент найден на позиции {index + 1}");
                Console.WriteLine("Найденный элемент:");
                arr[index].Show(); // Показываем найденный элемент
            }
            else
            {
                // Элемент не найден
                Console.WriteLine("Элемент не найден");
            }
            // Создание оригинального объекта Piano
            var originalPiano = new Piano(88, "Yamaha", "октавная", 1);

            // Поверхностное копирование
            var shallowCopyPiano = (Piano)originalPiano.ShallowCopy();

            // Глубокое копирование
            var deepCopyPiano = (Piano)originalPiano.Clone();

            // Изменение значения полей в копиях
            shallowCopyPiano.Name = "Shallow Copy Piano";
            deepCopyPiano.Name = "Deep Copy Piano";
            deepCopyPiano.NumberOfKeys = 76;

            // Вывод информации об оригинальном объекте и его копиях
            Console.WriteLine("Original Piano:");
            Console.WriteLine(originalPiano);

            Console.WriteLine("\nShallow Copy Piano:");
            Console.WriteLine(shallowCopyPiano);

            Console.WriteLine("\nDeep Copy Piano:");
            Console.WriteLine(deepCopyPiano);
            // Создание массива студентов
            Student[] students = new Student[3];
            students[0] = new Student("Иван", 20, 4.5);
            students[1] = new Student("Мария", 22, 5.0);
            students[2] = new Student("Петр", 19, 3.8);

            // Просмотр элементов массива с помощью обычной функции
            Student.ViewStudents(students);

            // Просмотр элементов массива с помощью виртуальной функции
            Student.ViewStudentsVirtual(students);
        }
        public static Random rnd = new Random();
        public static void SumStrings(MusicalInstrument[] arr)
        {
            if (arr != null && arr.Length > 0)
            {
                int k = 0;
                int sum = 0;
                foreach (MusicalInstrument item in arr)
                {
                    Guitar guit = item as Guitar;
                    if (guit != null)
                    {
                        sum += guit.NumberOfStrings;
                        k++;
                    }
                }
                if (k > 0)
                {
                    int sr = sum / k;
                    Console.WriteLine($"\nСреднее количество струн всех гитар: {sr}");
                }
                else
                {
                    Console.WriteLine("\nНет гитар для подсчета среднего количества струн.");
                }
            }
            else
            {
                Console.WriteLine("\nМассив инструментов пуст.");
            }
        }

        public static void SumStringsEl(MusicalInstrument[] arr)
        {
            if (arr != null && arr.Length > 0)
            {
                int sum = 0;
                foreach (MusicalInstrument item in arr)
                {
                    if (item.GetType() == typeof(ElectricGuitar))
                    {
                        ElectricGuitar guit = item as ElectricGuitar;
                        if (guit != null)
                        {
                            sum += guit.NumberOfStrings;
                        }
                    }
                }
                if (sum > 0)
                {
                    Console.WriteLine($"\nКоличество струн всех электрогитар с фиксированным источником питания: {sum}");
                }
                else
                {
                    Console.WriteLine("\nНет электрогитар с фиксированным источником питания для подсчета количества струн.");
                }
            }
            else
            {
                Console.WriteLine("\nМассив инструментов пуст.");
            }
        }

        public static void PianoF(MusicalInstrument[] arr)
        {
            if (arr != null && arr.Length > 0)
            {
                int max = 0;

                foreach (MusicalInstrument item in arr)
                {
                    if (item is Piano)
                    {
                        Piano guit = item as Piano;
                        if (guit != null && guit.KeyboardLayout == "октавная")
                        {
                            if (guit.NumberOfKeys > max)
                            {
                                max = guit.NumberOfKeys;
                            }
                        }
                    }
                }
                if (max > 0)
                {
                    Console.WriteLine($"\nМаксимальное количество клавиш на фортепиано с октавной раскладкой: {max}");
                }
                else
                {
                    Console.WriteLine("\nНет фортепиано с октавной раскладкой для подсчета максимального количества клавиш.");
                }
            }
            else
            {
                Console.WriteLine("\nМассив инструментов пуст.");
            }
        }


    }
}