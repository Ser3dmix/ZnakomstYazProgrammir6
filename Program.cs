// Знакомство с яз.программирования. Семинар-6. ОДНОМЕРНЫЕ МАССИВЫ. Занятие 2.
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)                  // метод создает рамдомный массив
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }

    return array;
}


void ShowArray(int[] array)                                                   // метод формирует массив для вывода на консоль                               
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();                                                     // строка позволяет перенести следующую информацию на другую строку
}
*/


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//ЗАДАЧА 1. Напишите программу,кот. перевернет одномерный массив.
/*
void ReverseArray(int[]array)                       // метод переворачивания массива(вар-1)
{
    for(int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

void ReverseArrayMod(int[]array)                       // метод переворачивания массива(вар-2)
{
    for(int i = 0, j = array.Length - 1; i < j; i++, j--) //добавили нужные переменные
    {
        int temp = array[i];                              // тем самым упростили код
        array[i] = array[j];
        array[j] = temp;
    }
}

Console.Write("введите количество элементов :");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("введите минимальное значение :");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("введите максимальное значение :");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);
ReverseArray(myArray);
ShowArray(myArray);

*/






////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// HOMEWORK
// HOMEWORK
// HOMEWORK

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//ЗАДАЧА-41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.(решить без использования массива)
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3 - здесь неправильный ответ в задаче (числа не 3 , а 4)

/*
int CreateNums(int amntN)                                               
{
    int count = 0;
    for(int c = 1; c <= amntN; c++)
    {
        Console.Write("Введите число : ");
        int k = Convert.ToInt32(Console.ReadLine());
        if(k > 0)count++;
    }
    return count;
}

Console.Write("какое количество чисел Вы хотите ввести? :");                     
int kk = Convert.ToInt32(Console.ReadLine());

int n = CreateNums(kk);
Console.Write($" Вы ввели {n} чисел больше нуля ");     //решено
*/



///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//ЗАДАЧА-43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// доп.задание - рассмотреть исключения(параллельность прямых - проверить на это в программе)
//                                     (совпадение прямых - проверить в программе)


//double Intersec(double b1, double k1, double b2, double k2)

/*
Console.Write("задайте значение b1 :");                     
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("задайте значение k1 :");                     
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("задайте значение b2 :");                     
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("задайте значение k2 :");                     
double k2 = Convert.ToDouble(Console.ReadLine());

if(k1 == k2 && b1 != b2)Console.Write("Точки пересечения нет.Графики параллельны");
if(k1 == k2 && b1 == b2)Console.Write("Точки пересечения нет.Графики совпадают");

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

x = Math.Round(x, 2);
y = Math.Round(y, 2);

Console.WriteLine($"координаты точек пересечения прямых [X: {x}], [Y: {y}]");   //решено
*/

