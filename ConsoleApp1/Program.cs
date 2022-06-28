line1:

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Blue;



Console.WriteLine("Enter what you need:");
var jop = Console.ReadLine();
if (jop== "*")
{

    Console.WriteLine("Enter value1");
    var value1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter value2");
    var value2 = int.Parse(Console.ReadLine());
    var result = value1 *value2;
    Console.WriteLine("value1 *value2 = " + result);


}

if (jop== "+")
{
    Console.WriteLine("Enter value1");
    var value1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter valu2");
    var value2 = int.Parse(Console.ReadLine());
    var result = value1 + value2;
    Console.WriteLine(" value1 + value2 = " + result);

}
if (jop == "-")
{

    Console.WriteLine("Enter value1");
    var value1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter value2");
    var value2 = int.Parse(Console.ReadLine());
    var result = value1 - value2;
    Console.WriteLine("value1 - value2 = " + result);


}
if (jop == "/" )
{
    Console.WriteLine("Enter value1");
    var value = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter value2");
    var value2 = int.Parse(Console.ReadLine());
    var result = value2 / value2;
    Console.WriteLine(" value1 / value2 = " + result);

}
if (jop == "text")
{   
    Console.WriteLine("Do you want to raed or write");
    var selection = Console.ReadLine();
    if (selection == "read")
    {
        var noteText = System.IO.File.ReadAllText("Note.txt");
        Console.WriteLine(noteText);

    }


    if (selection == "write")
    {
        Console.WriteLine(" Plaese enter your note");
        var entry = Console.ReadLine();
        System.IO.File.AppendAllText("Note.txt", entry + "\n");
    }
}
Console.ResetColor();

goto line1;