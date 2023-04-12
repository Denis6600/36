//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] FillArray(int lenght, int minValue, int maxValue)
{
    int[] result = new int[lenght];
    Random rand = new Random();
    for (int i = 0; i < lenght; i++)
        result[i] = rand.Next(minValue, maxValue + 1);
    return result;
}

int GetSum(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i=i+2)
            sum =+ sum + array[i];

    return (sum);
}

int[] array = FillArray(4, -9, 9);
int sum = GetSum(array);
System.Console.WriteLine(string.Join(", ", array));
System.Console.WriteLine($"сумма элементов: {sum}");