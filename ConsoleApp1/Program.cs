﻿line1:

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Blue;


Console.WriteLine("Enter what you need to do:");
switch (Console.ReadLine())
{
    case "data":
        var json = System.IO.File.ReadAllText(@"..\..\..\Data.json");
        var UsersData = System.Text.Json.JsonSerializer.Deserialize<List<cars1>>(json);
        foreach (var item in UsersData)
        {
            Console.WriteLine($"name:{item.name}\n email:{item.Email},\n Age:{item.Age},\n car:{item.car},\n  Modail:{item.modail},\n color:{item.color}");
        }
        break;

    case "+":
        Console.WriteLine("Enter value1");
        var value1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value2");
        var value2 = int.Parse(Console.ReadLine());
        var result = value1 + value2;
        Console.WriteLine("Value1 + value2 = " + result); break;
    case "-":
        Console.WriteLine("Enter value1");
        var value3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value-2");
        var value5 = int.Parse(Console.ReadLine());
        var result1 = value3 - value5;
        Console.WriteLine("Value 1 - value 2 = " + result1); break;
    case "/":
        Console.WriteLine("Enter value1");
        var value6 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value2");
        var value4 = int.Parse(Console.ReadLine());
        var result2 = value6 / value4;
        Console.WriteLine("Value1 / value2 = " + result2); break;
    case "*":
        Console.WriteLine("Enter value1");
        var value7 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value2");
        var value8 = int.Parse(Console.ReadLine());
        var result3 = value7 * value8;
        Console.WriteLine("Value 1 * value 2 = " + result3);
        break;
    case "text":
        Console.WriteLine("Do you want to read or write");
        var selection = Console.ReadLine();
        if (selection == "read")
        {
            var noteText = System.IO.File.ReadAllText("Note.txt");
            Console.WriteLine(noteText);
        }
        if (selection == "write")
        {
            Console.WriteLine("Please enter your note");
            var entry = Console.ReadLine();
            System.IO.File.AppendAllText("Note.txt", entry + "\n");
        }
        break;
    default:
        Console.WriteLine("Worng command");
        break;

}
goto line1;

public class cars
{
    public cars1[] carss { get; set; }
}

public class cars1
{
    public string name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public string car { get; set; }
    public int modail { get; set; }
    public string color { get; set; }
}
