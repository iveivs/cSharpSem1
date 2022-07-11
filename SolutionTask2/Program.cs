string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputNumber = int.Parse(inputLine);

   // switch (inputNumber)
   // {
   //  case 1:
   //    Console.WriteLine("Monday");
   //    break;

   //    case 2:
   //    Console.WriteLine("Tuesday");
   //    break;

   //   case 3:
   //    Console.WriteLine("Wednesday");
   //    break;

   //    case 4:
   //    Console.WriteLine("Thursday");
   //    break;

   //    case 5:
   //    Console.WriteLine("Friday");
   //    break;

   //    case 6:
   //    Console.WriteLine("Saturday");
   //    break;

   //    case 7:
   //    Console.WriteLine("Sunday");
   //    break;

    
     string [] dayOfWeek = new string [7];
     dayOfWeek[0] = "Monday";
     dayOfWeek[1] = "Tuesday";
     dayOfWeek[2] = "Wednesday";
     dayOfWeek[3] = "Thursday";
     dayOfWeek[4] = "Friday";
     dayOfWeek[5] = "Saturday";
     dayOfWeek[6] = "Sunday";

     Console.WriteLine(dayOfWeek[inputNumber -1]);
}
