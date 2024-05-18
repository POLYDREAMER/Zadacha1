int[] arr = { 6, 2, 1, 5, 3, 4, 2 };

Console.WriteLine("Масив:");
foreach (var element in arr)
{
    Console.Write($"{element} ");
}


Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Сума всiх елементiв у заданому масивi:");
int sum = arr.Sum();
Console.WriteLine($"{sum}");


Console.WriteLine("");
Console.WriteLine("Мiнiмальний i максимальний елементи у масивi:");
int min = arr.Min();
int max = arr.Max();
Console.WriteLine($"Мiнiмальний елемент: {min}, Максимальний елемент: {max}");


Console.WriteLine("");
Console.WriteLine("Середнє значення елементiв у масивi:");
double average = arr.Average();
Console.WriteLine($"{average}");


Console.WriteLine("");
Console.WriteLine("Чи мiститься елемент 3 умасивi:");
bool containsElement = arr.Contains(3); // Перевірка, чи є число 3 у масиві
Console.WriteLine($"{containsElement}");


Console.WriteLine("");
Array.Sort(arr); // Сортування в порядку зростання
Console.WriteLine("Вiдсортований за зростанням масив:");
foreach (var element in arr)
{
    Console.Write($"{element} ");
}


Console.WriteLine("");
int evenCount = 0;
int oddCount = 0;
foreach (var element in arr)
{
    if (element % 2 == 0)
        evenCount++;
    else
        oddCount++;
}
Console.WriteLine($"Кiлькiсть парних чисел: {evenCount}, Кiлькiсть непарних чисел: {oddCount}");


Console.WriteLine("");
var duplicates = arr.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key);
Console.WriteLine("Повторюванi елементи:");
foreach (var duplicate in duplicates)
{
    Console.Write($"{duplicate} ");
}


Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Елементи, сума яких 7:");
int targetSum = 7; // Задана сума

for (int i = 0; i < arr.Length; i++)
{
    for (int j = i + 1; j < arr.Length; j++)
    {
        if (arr[i] + arr[j] == targetSum)
        {
            Console.WriteLine($"Пара елементiв: {arr[i]} та {arr[j]}");
        }
    }
}
