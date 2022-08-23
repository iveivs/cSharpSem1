// Задача №5    Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые
//              числа в промежутке от -N до N. Например:
//                                                       4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//                                                       2 -> " -2, -1, 0, 1, 2"

string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    
    int startNumber = (inputNumber * -1);

    string lineOutput = "";

    while (startNumber < inputNumber)
    {
        lineOutput = lineOutput + startNumber + ", ";
        startNumber++;
    }
    lineOutput = lineOutput+inputNumber;

    Console.WriteLine(lineOutput);
}