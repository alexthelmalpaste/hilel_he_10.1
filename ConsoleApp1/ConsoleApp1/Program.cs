using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder report = new StringBuilder();
        Console.Write("Введіть заголовок звіту: ");
        string title = Console.ReadLine();
        report.AppendLine($"Звіт: {title}");
        report.AppendLine($"Дата: {DateTime.Now:dd.MM.yyyy}");
        report.AppendLine("Список подій:");

        while (true)
        {
            Console.Write("Введіть подію (або 'exit' для завершення): ");
            string eventEntry = Console.ReadLine();

            if (eventEntry.ToLower() == "exit")
                break;

            report.AppendLine($"- {eventEntry}");
        }

        Console.WriteLine("\n=== Згенерований звіт ===");
        Console.WriteLine(report.ToString());
    }
}
