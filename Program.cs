using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace PW6
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("База сотрудников\nВыберите опцию из меню:");
            Console.WriteLine("1.Вывести данные на экран");
            Console.WriteLine("2.Добавить новую запись");
            int option = Convert.ToInt32( Console.ReadLine());             
            string filePath = (@"C:\SKILLBOX\6PW\Employees.txt");
            bool isEmpty = File.Exists(filePath);
            if (!isEmpty)
            {
                Console.WriteLine("Файла нет");
            }
            switch (option)
            {
                case 1:
                    ShowInformation(filePath);
                    break;
                    case 2:
                    AddNewEmployee(filePath);
                    break;
                    default:break;
            }
            Console.ReadKey();
        }

        static void AddNewEmployee(string filePath)
        {                      
           // Console.WriteLine("Введите Ф.И.О:");            
        }
        
        static void ShowInformation(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
            
        }

       

    }
}
