// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int result = number * number;

Console.WriteLine($"Квадрат введенного числа = {result}");*/


/*/*Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет*/

//Ввод первого числа
Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

//Ввод второго числа
Console.WriteLine("Введите целое число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

//Условие
if (number == secondNumber * secondNumber)
{
    Console.WriteLine($"{number} является квадратом {secondNumber}");
}
else
{
    Console.WriteLine($"{number} не является квадратом {secondNumber}");
}

/*Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда 
5 -> Пятница*/

Console.WriteLine("Введите целое число от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1)
{
    Console.WriteLine("Понедельник");
}
else if (day == 2)
{
    Console.WriteLine("Вторник");
}
else if (day == 3)
{
    Console.WriteLine("Среда");
}
else if (day == 4)
{
    Console.WriteLine("Четверг");
}
else if (day == 5)
{
    Console.WriteLine("Пятница");
}
else if (day == 6)
{
    Console.WriteLine("Суббота");
}
else if (day == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Вы ввели некорректное число");
}

/*Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8*/


