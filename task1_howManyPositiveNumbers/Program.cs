/* Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

Console.WriteLine("введите М чисел через пробел");
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
int quantity = 0;

int FindPositiveNumbersQuantity (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0) quantity++;
        }
    return quantity;
}

FindPositiveNumbersQuantity(array);
Console.WriteLine($"вы ввели {quantity} чисел(-ла) больше 0");