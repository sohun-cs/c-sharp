// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(DateTime.Now.ToString("dd/mm/yyyy HH:mm"));


int[] intArr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
foreach (int i in intArr)
{
    Console.WriteLine(i);
}

string[] dotnetDev = { "C#", "Razor", "MSSQL", "API", "ASP.NET Core", "Docker", "GraphQL" };
foreach (string dev in dotnetDev)
{
    Console.WriteLine(dev);
}