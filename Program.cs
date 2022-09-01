// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// Console.WriteLine("Enter number A");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number B");
// int b = Convert.ToInt32(Console.ReadLine());
// int step = a;

// for (int i = 1; i < b; i++)
// {
//     step = step * a;
// }
// Console.WriteLine("Ответ = "+ step);

// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

// Console.Write("Enter number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int SumNumber(int number)
// {

//     int count = Convert.ToString(number).Length;
//     int advance = 0;
//     int result = 0;

//     for (int i = 0; i < count; i++)
//     {
//         advance = number - number % 10;
//         result = result + (number - advance);
//         number = number / 10;
//     }
//     return result;
// }

// int sumNumber = SumNumber(number);
// Console.WriteLine("Сумма чисел -> " + sumNumber);

// Напишите программу, которая задаёт массив из введенного числа и выводит их на экран.
// пользователь вводит число элементов в массиве и минимальное, и максимальное значение . 
// надо заполнить массив рандоными данными от минимального до максимального значение .И важное уточнениее , 
// делать все в методе который возвращает массив


Console.Write("Min: ");
if (int.TryParse(Console.ReadLine(), out var min))
{
    Console.Write("Max: ");
    if (int.TryParse(Console.ReadLine(), out var max))
    {
        var rnd = new Random();
        int[] mas = new int[10];

        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = rnd.Next(min, max);
        }

        Console.WriteLine(string.Join(" ", mas));
    }
}
