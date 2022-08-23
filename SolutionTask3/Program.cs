// Задача №3       Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//                 Например:
//                 3 -> Среда
//                 5 -> Пятница

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