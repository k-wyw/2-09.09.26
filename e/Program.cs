using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string currentText = "";
            Stack<string> history = new Stack<string>();
            while (true)
            {
                Console.WriteLine("1. сохранение текста ");
                Console.WriteLine("2. отмена ");
                Console.WriteLine("3. вывести текст ");
                Console.WriteLine("4. выход ");
                string choice = Console.ReadLine()?.Trim();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введите текст для сохранения: ");

                        string newText = Console.ReadLine();
                        history.Push(currentText);
                        currentText = newText;
                        Console.WriteLine("Текст сохранён.");
                        break;

                    case "2":
                        if (history.Count == 0)
                        {
                            Console.WriteLine("Нет действий для отмены — история пуста.");
                        }
                        else
                        {
                            currentText = history.Pop();
                            Console.WriteLine("Действие отменено. Восстановлен предыдущий текст.");
                        }
                        break;

                    case "3":
                        Console.WriteLine($"Текущий текст: \"{currentText}\"");
                        break;

                    case "4":
                        Console.WriteLine("До свидания!");
                        return;

                    default:
                        Console.WriteLine("Неверный выбор, попробуйте снова.");
                        break;
                }
            }
        }
    }
}