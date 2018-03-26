using System;

namespace lab1._2
{
    class MyApplication
    {
        public MyApplication()
        {
            ConsoleKeyInfo key;
            Wrapper wr = new Wrapper();
            String name = "", com = "", exp = "";
            int choice = 0;

            do
            {
                Console.WriteLine("0 - Выход");
                Console.WriteLine("1 - Добавить объект класса в список");
                Console.WriteLine("2 - Загрузить из файла");
                Console.WriteLine("3 - Созранить в файл");
                Console.WriteLine("4 - Заменить введённый элемент");
                Console.WriteLine("5 - Удалить первый элемент");
                Console.WriteLine("6 - Получить значение первого элемента");
                Console.WriteLine("7 - Вывести список");

                key = Console.ReadKey();
                
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.Write("Введите фамилию: "); name = Console.ReadLine();
                        Console.Write("Введите цикловую комиссию: "); com = Console.ReadLine();
                        Console.Write("Введите стаж: "); exp = Console.ReadLine();
                        wr.Insert(new Teacher(name, com, Convert.ToDouble(exp)));
                        break;
                    case ConsoleKey.D2:
                        wr.LoadFromFile("Info");
                        break;
                    case ConsoleKey.D3:
                        wr.SaveToFile("Info");
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        Console.Write("Введите индекс заменяемого элемента: ");
                        choice = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите фамилию: "); name = Console.ReadLine();
                        Console.Write("Введите цикловую комиссию: "); com = Console.ReadLine();
                        Console.Write("Введите стаж: "); exp = Console.ReadLine();
                        wr.Change(wr.getFromIndex(choice), new Teacher(name, com, Convert.ToDouble(exp)));
                        break;
                    case ConsoleKey.D5:
                        wr.Remove();
                        break;
                    case ConsoleKey.D6:
                        Teacher p = wr.GetValue();
                        Console.WriteLine($"Имя: { p.Surname }");
                        Console.WriteLine($"Цикловая комиссия: { p.Com }");
                        Console.WriteLine($"Стаж: { p.Experience }");
                        break;
                    case ConsoleKey.D7:
                        Console.Clear();
                        wr.Print();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            } while (key.KeyChar != '0');
        }
    }
}
