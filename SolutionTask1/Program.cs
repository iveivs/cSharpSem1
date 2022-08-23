// Задача 1        Напишите программу, которая на вход принимает
//                 два числа и проверяет, является ли первое число
//                 квадратом второго. Например:
//                 a = 25; b = 5 -> да
//                 a = 2 b = 10 -> нет

string? inputLineOne = Console.ReadLine();
string? inputLineTwo = Console.ReadLine();

if(inputLineOne != null && inputLineTwo != null)
    {
        int inputNumberOne = int.Parse(inputLineOne);
        int inputNumberTwo = int.Parse(inputLineTwo);

        //if(inputNumberOne == inputNumberTwo * inputNumberTwo)
        //{
        //    Console.WriteLine("yes");
        //}
    
        //else
        //{
        //    Console.WriteLine("no");
        //}
        if(inputNumberTwo == Math.Sqrt(inputNumberOne))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
        
    }