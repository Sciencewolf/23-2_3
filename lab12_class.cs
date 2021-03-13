using System;
using System.Text;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class labor {
        public string name { get; set; }
        public string surname { get; set; }
        public string Class { get; set; }
    }

    public class list {
        public List<String> userName = new List<String>();
        public List<String> userSurname = new List<String>();
        public List<String> userClass = new List<String>();
    }

    class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            list ls = new list();
            labor lb = new labor();
            Console.WriteLine("Введіть к-сть учнів");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть дані");
            for (int i=1;i<=amount;i++)
            {
                lb.name = Console.ReadLine();
                ls.userName.Add(lb.name);
                lb.surname = Console.ReadLine();
                ls.userSurname.Add(lb.surname);
                lb.Class = Console.ReadLine();
                ls.userClass.Add(lb.Class);
            }

            Console.WriteLine();
            Console.Write("Name\t\tSurname\t\tClass\n");
            Console.WriteLine("-------------------------------------");
            foreach (string list in ls.userName) Console.Write(list + "\t");
            foreach (string list2 in ls.userSurname) Console.Write(list2 + "\t");
            foreach (string list3 in ls.userClass) Console.Write(list3 + "\t");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
