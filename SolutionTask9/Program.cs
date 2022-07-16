
void variant1(System.Random numberSintezator)
{
    int number = numberSintezator.Next(10, 100);

    Console.WriteLine(number);

    // Вариант 1
    int firstNumber = number / 10;
    int secondNumber = number % 10;

    if (firstNumber > secondNumber)
    {
        Console.WriteLine(firstNumber);
    }
    else
    {
        Console.WriteLine(secondNumber);
    }
}

void variant2(System.Random numberSintezator)
{
    char[] digits = numberSintezator.Next(10, 100).ToString().ToCharArray();

    Console.WriteLine(digits);

    int firstNumber = ((int)digits[0] - 48);
    int secondNumber = ((int)digits[1] - 48);

    int resultNumber = firstNumber > secondNumber ? resultNumber = firstNumber : resultNumber = secondNumber;

    Console.WriteLine(resultNumber);
}

System.Random numberSintezator = new Random();

variant1(numberSintezator);

variant2(numberSintezator);


// Вариант 2

// char[] digits = numberSintezator.Next(10,100).ToString().ToCharArray();

// int firstNumber = ((int)digits[0]-48);
// int secondNumber = ((int)digits[1]-48);

// int resultNumber = firstNumber>secondNumber?resultNumber=firstNumber:resultNumber=secondNumber;

// Console.WriteLine(resultNumber);