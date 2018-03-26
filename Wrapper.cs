using System;
using System.Collections.Generic;
using System.IO;

namespace lab1._2 {
    class Wrapper {
        private LinkedList<Teacher> List;

        public Wrapper() // Default constructor
        {
            List = new LinkedList<Teacher>();
        }

        public void Insert(Teacher p) // Inserting element into end of list
        {
            List.AddLast(p);
        }

        public void Remove()
        {
            List.Remove(List.First);
        }

        public void Change(Teacher what, Teacher whom)
        {
            List.Find(what).Value = whom;
        }

        public Teacher GetValue()
        {
            return List.First.Value;
        }

        public LinkedListNode<Teacher> GetFirst()
        {
            return List.First;
        }

        public LinkedListNode<Teacher> GetLast()
        {
            return List.Last;
        }

        public void Print()
        {
            int count = 0;
            foreach (var item in List)
            {
                Console.WriteLine($"{count}:");
                Console.WriteLine($"Цикловая комиссия: { item.Com }");
                Console.WriteLine($"Стаж: { item.Experience }");
                Console.WriteLine($"Фамилия: { item.Surname }");
                count++;
            }
        }

        public LinkedListNode<Teacher> GetNext(LinkedListNode<Teacher> now)
        {
            return now.Next;
        }

        public LinkedListNode<Teacher> GetPrev(LinkedListNode<Teacher> now)
        {
            return now.Previous;
        }

        public void LoadFromFile(String fileName)
        {
            this.List.Clear();
            FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            String line = "", com = "", exp = "";

            while (true)
            {
                line = reader.ReadLine();
                if (line == null) break;
                com = reader.ReadLine();
                exp = reader.ReadLine();
                this.Insert(new Teacher(line, com, Convert.ToDouble(exp)));
            }

            reader.Close();
        }

        public void SaveToFile(String filename)
        {
            FileStream file = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);
            foreach (var item in List)
            {
                writer.WriteLine(item.Surname);
                writer.WriteLine(item.Com);
                writer.WriteLine(item.Experience);
            }

            writer.Close();
        }

        public Teacher getFromIndex(int index)
        {
            int count = 0;
            foreach (var item in List)
            {
                if (count == index) return item;
                count++;
            }
            return null;
        }
    }
}