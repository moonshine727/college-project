
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
string date = DateTime.Now.ToString("dddd, dd.MM.yyyy");


Console.WriteLine("Добрый день, Даниил и Виктория!");
Console.WriteLine($"Сегодня {date}");

Console.ReadLine();