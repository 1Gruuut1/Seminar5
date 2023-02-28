/*
int[] CreateRandomArray(int size, int minVailue, int maxVailue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minVailue, maxVailue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int GetSumOfNegatives(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            sum += array[i];
    }
    return sum;
}

Console.Write("Input a length of new array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);

int sumOfNegative = GetSumOfNegatives(myArray);
Console.WriteLine("Sum of negatives is " + sumOfNegative);
*/
// Задание 1: Напишате программу замены эллементов массива, положительный на отрицательный и наоборот:
/*
int[] CreateRandomArray(int size, int minVailue, int maxVailue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minVailue, maxVailue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int[] TransformArray(int[] collection)
{
    for(int index = 0; index < collection.Length; index++)
        collection[index] *= (-1);
    return collection;
}

Console.Write("Input a length of new array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(length, min, max);
ShowArray(array);

array = TransformArray(array);
ShowArray(array);
*/
// Задание 2: Задайте массив и напишите программу, которая определяет, присутствует ли заданное число в массиве:
/*
int[] CreateRandomArray(int size, int minVailue, int maxVailue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minVailue, maxVailue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

bool NumberFind(int find, int[] coll)
{
    for(int i = 0; i < coll.Length; i++)
        if (coll[i] == find)
            return true;
    return false;
}

Console.Write("Input a length of new array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(length, min, max);
ShowArray(array);

Console.Write("Input a find = ");
int find = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumberFind(find, array));
*/
// Задание 3: Задайте массив из M случайных чисел, и определите колличество элементов
//            значение которых лежат в отрезке от A до B:
/*
int[] CreateRandomArray(int size, int minVailue, int maxVailue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minVailue, maxVailue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int Numbers(int[] array, int a, int b)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] >= a && array[i] <= b)
        count++;
    return count;   
}

Console.Write("Input a length of new array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the beginning of the segment: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the end of the segment: ");
int b = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(length, min, max);
ShowArray(array);

Console.WriteLine(Numbers(array, a, b));
*/

//Домашнее задание:
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int[] CreateRandomArray(int size)
{   
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
    return array;
}   

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int NumberPositNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
           count++;
    return count;    
}

Console.Write("Input a length of new array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size);
Console.WriteLine("array: ");
ShowArray(myArray);
int sumOfNegative = NumberPositNumbers(myArray);
Console.WriteLine($"{sumOfNegative} even numbers");
*/
// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int minVailue, int maxVailue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minVailue, maxVailue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");

    Console.WriteLine();
}

int SumElement(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i+=2)
       sum += array[i];
    return sum;
}

Console.Write("Input a length of new array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(length, min, max);
ShowArray(array);
int sum = SumElement(array);

Console.WriteLine($"Sum elements standing in odd positions = {sum}");
*/
//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreateRandomArray(int size, int minVailue, int maxVailue)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minVailue, maxVailue + 1);

    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Math.Round(array[i],2);
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}


Console.Write("Input a length of new array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);
*/
/*
double[] CreateRandomayArr(int size)
{
    double[] numbers = new double[size];
   {
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
   }
   return numbers;
}

void ShowArray(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + "; ");
        }
    Console.WriteLine();
}

void FindingMinMaxValue(double[] numbers)
{
    double max = Int32.MinValue;
    double min = Int32.MaxValue;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }
   
    Console.WriteLine($"total {numbers.Length} numbers. Maximum value = {max}, minimum value = {min}");
    Console.WriteLine($"The difference between the maximum and minimum value = {max - min}");
}


Console.WriteLine("Input a length of new array: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] Num = CreateRandomayArr(size);
Console.WriteLine("array: ");
ShowArray(Num);
FindingMinMaxValue(Num);

*/

