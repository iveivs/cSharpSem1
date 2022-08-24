﻿// Задача №0    Напишите программу, которая на вход принимает
//              число и выдаёт его квадрат (число умноженное на само себя).
//              Например: 4 -> 16 -3 -> 9 -7 -> 49 

// Задача №1     Напишите программу, которая на вход принимает два числа и проверяет, является
//               ли первое число квадратом второго. Например:
//               a = 25; b = 5 -> да
//               a = 2 b = 10 -> нет


// Задача №3     Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//               Например:
//               3 -> Среда
//               5 -> Пятница



// Задача №5    Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые
//              числа в промежутке от -N до N. 
//              Например:
//              4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//              2 -> " -2, -1, 0, 1, 2"


//    Задача №7
//    Напишите программу, которая принимает на вход трёхзначное число и на выходе
//    показывает последнюю цифру этого числа.
//    Например:
//    456 -> 6
//    782 -> 2


//    Задача №9
//    Напишите программу, которая выводит случайное число из отрезка [10, 99] и
//    показывает наибольшую цифру числа.
//    Например:
//    78 -> 8
//    12-> 2


//    Задача №11
//    Напишите программу, которая выводит случайное трёхзначное число и удаляет
//    вторую цифру этого числа.
//    Например:
//    456 -> 46
//    782 -> 72 


//    Задача №12
//    Напишите программу, которая будет принимать на вход два числа и выводить,
//    является ли второе число кратным первому. Если второе число некратно
//    первому, то программа выводит о статок от деления.
//    Например:
//    34, 5 -> некратно, остаток 4
//    16, 4 -> кратно


//    Задача №14
//    Напишите программу, которая принимает на вход число и проверяет, кратно ли оно
//    одновременно 7 и 23.
//    Например:
//    14 -> нет
//    161 -> да


//    Задача №16
//    Напишите программу, которая принимает на вход два числа и проверяет, является
//    ли одно число квадратом другого.
//    Например:
//    5, 25 -> да
//    -4, 16 -> да
//    25, 5 -> да
//    8,9 -> нет

//    Задача №17
//    Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
//    выдаёт номер четверти плоскости, в которой находится эта точка.
//    Например:
//    x=34; y=-30 -> 4
//    x=2; y=4-> 1
//    x=-34; y=-30 -> 3


//    Задача №18
//    Напишите программу, которая по заданному номеру
//    четверти, показывает диапазон возможных
//    координат точек в этой четверти (x и y).


//    Задача №20
//    Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между
//    ними в 2D пространстве.
//    Например:
//    A (3,6); B (2,1) -> 5,09
//    A (7,-5); B (1,-1) -> 7,21


//    Задача №22
//    Напишите программу, которая принимает на вход
//    число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//    Например:
//    5 -> 1, 4, 9, 16, 25.
//    2 -> 1,4


//    Задача №24
//    Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//    Например:
//    7 -> 28
//    4 -> 10
//    8 -> 36


//    Задача №26
//    Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//    Пример:
//    456 -> 3
//    78 -> 2
//    89126 -> 5


//    Задача №28
//    Напишите программу, которая принимает на вход
//    число N и выдаёт произведение чисел от 1 до N.
//    Например:
//    4 -> 24
//    5 -> 120


//    Задача №30
//    Напишите программу, которая выводит массив из 8
//    элементов, заполненный нулями и единицами в
//    случайном порядке.
//    Например:
//    [1,0,1,1,0,1,0,0]


//    Задача №31
//    Задайте массив из 12 элементов, заполненный
//    случайными числами из промежутка [-9, 9].
//    Найдите сумму отрицательных и положительных
//    элементов массива.
//    Например:
//    Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
//    сумма положительных чисел равна 29, сумма
//    отрицательных равна -20.


//    Задача №32
//    Напишите программу замена элементов массива:
//    положительные элементы замените на
//    соответствующие отрицательные, и наоборот.
//    Пример:
//    [-4, -8, 8, 2] -> [4, 8, -8, -2]


//    Задача №33
//    Задайте массив. Напишите программу, которая
//    определяет, присутствует ли заданное число в массиве.
//    Например:
//    4; массив [6, 7, 19, 345, 3] -> нет
//    -3; массив [6, 7, 19, 345, 3] -> да


//    Задача №35
//    Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
//    значения которых лежат в отрезке [10,99].
//    Например:
//    Пример для массива из 5, а не 123 элементов. В
//    своем решении сделайте для 123
//    [5, 18, 123, 6, 2] -> 1
//    [1, 2, 3, 6, 2] -> 0
//    [10, 11, 12, 13, 14] -> 5


//    Задача №37
//    Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний
//    элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//    Например:
//    [1 2 3 4 5] -> 5 8 3
//    [6 7 3 6] -> 36 21


//    Задача №39
//    Напишите программу, которая перевернёт
//    одномерный массив (последний элемент будет на
//    первом месте, а первый - на последнем и т.д.)
//    Например:
//    [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]
//    Комментарий: эту задачу можно решить 2 способами: 1)
//    менять числа местами в исходном массиве; 2) создать
//    новый массив и в него записать перевёрнутый исходный
//    массив по элементам.


//    Задача №40
//    Напишите программу, которая принимает на вход
//    три числа и проверяет, может ли существовать
//    треугольник с сторонами такой длины.


//    Задача №42
//    Напишите программу, которая будет
//    преобразовывать десятичное число в двоичное.
//    Например:
//    45 -> 101101
//    3 -> 11
//    2 -> 10


//    Задача №44
//    Не используя рекурсию, выведите первые N чисел
//    Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//    Например:
 //   Если N = 5 -> 0 1 1 2 3
 //   Если N = 3 -> 0 1 1
 //   Если N = 7 -> 0 1 1 2 3 5 8


//    Задача №45
//    Напишите программу, которая будет создавать
//    копию заданного одномерного массива с помощью
//    поэлементного копирования.


//    Задача №46
//    Задайте двумерный массив размером m×n,
//    заполненный случайными целыми числами.
//    Например:
//    m = 3, n = 4.
//    -1 4 8 19
//    5 -2 33 -2
//    -77 3 8 1


//    Задача №48
//    Задайте двумерный массив размера m на n, каждый
//    элемент в массиве находится по формуле: Aₘₙ =
//    m+n. Выведите полученный массив на экран.
//    Пример:
//    m = 3, n = 4.
//    0 1 2 3
//   1 2 3 4
//   2 3 4 5


//    Задача №49
//    Задайте двумерный массив. Найдите элементы, у
//    которых оба индекса чётные, и замените эти
//    элементы на их квадраты.
//    Например:
//    Например, изначально массив выглядел вот так:
//    1 4 7 2
//    5 9 2 3
//    8 4 2 4
//    Новый массив будет выглядеть вот так:
//    1 4 7 2
//    5 81 2 9
//    8 4 2 4


//   Задача №51
//   Задайте двумерный массив. Найдите сумму
//   элементов, находящихся на главной диагонали (с
//   индексами (0,0); (1;1) и т.д.
//   Например:
//   Например, задан массив:
//   1 4 7 2
//   5 9 2 3
//   8 4 2 4
//   Сумма элементов главной диагонали: 1+9+2 = 12


//   Задача 53.   
//   Задайте двумерный массив. Напишите программу, которая поменяет местами
//   первую и последнюю строку массива. Например:
//   1 4 2             6 8 8 
//   3 1 9   а будет   3 1 9  
//   6 8 8             1 4 2 

//   Задача 55. 
//   Задайте двумерный массив . Напишите программу, которая заменяет строки на столбцы
//   В случае если это не возможно , программа должна вывести сообщение для пользователя.


//   Задача 57. 
//   Составить частотный словарь элементов двумерного массива.
//   Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.


//   Задача 59. 
//   Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и солбец,
//   на пересечении которых расположен наименьший элемент массива.

//   Задача 63.  
//   Задайте значение N. Напишите программу, которая выдаёт все натуральные числа в промежутке от 1 до N.
//   Например:
//   N = 5 -> "5, 4, 3, 2, 1"

//   Задача 65   Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
//               в промежутке от M до N.
//               Например:
//               M = 4; N = 8 -> "4, 5, 6, 7, 8" 

// Задача 67   Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр
//             452 -> 11
//             63  -> 9

// Задача 69    Напишите программу, которая на вход принимает два числа А и В,
//              и возводит число А в целую степень В с помощью рекурсии.