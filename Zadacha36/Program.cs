// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
int sum = 0;
 for (int i = 1; i < numbers.Length; i+=2)
 {
    sum = sum + numbers[i];
 }
Console.WriteLine($"сумма элементов на нечетных позициях = {sum}");
 
 void FillArrayRandomNumbers(int[] numbers)
 {
    for (int j = 0; j < numbers.Length; j++)
    {
        numbers[j] = new Random().Next(-10,10);
    }
 }
void PrintArray(int[] numbers)
{
    Console.Write("[");
    for (int j = 0; j < numbers.Length; j++)
    {
       Console.Write(numbers[j] + ", "); 
    }
    Console.Write("\b\b");
    Console.WriteLine("]");
    Console.WriteLine();
}