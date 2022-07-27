int coordXPointA;
int coordYPointA;
int coordXPointB;
int coordYPointB;

double lengthAB;


// Считывает координаты точек A и B
void readDataOfPoint()
{
  Console.WriteLine("Введите координату X в точке A");
  coordXPointA = int.Parse(Console.ReadLine());

  Console.WriteLine("Введите координату Y в точке B");
  coordYPointA = int.Parse(Console.ReadLine());

  Console.WriteLine("Введите координату X в точке A");
  coordXPointB = int.Parse(Console.ReadLine());

  Console.WriteLine("Введите координату Y в точке B");
  coordYPointB = int.Parse(Console.ReadLine());
}

// Вычисляет растояние между точками А и В
void colculateLengthAB()
{
    lengthAB = Math.Sqrt(Math.Pow((coordXPointA - coordXPointB), 2) + Math.Pow((coordYPointA - coordYPointB),2));
}


readDataOfPoint();
colculateLengthAB();

Console.WriteLine(lengthAB);