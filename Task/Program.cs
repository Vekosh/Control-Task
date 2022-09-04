/*
Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на стартевыполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

Console.WriteLine("Введите строки первого массива через пробел без запятых: ");
string[] inputArray = Console.ReadLine().Split();
Console.WriteLine("Получен массив строк : {0}", String.Join(" ", inputArray));
Console.WriteLine(@"Введите требуемое количество символов целым, положительным числом.
Программа создаст массив и заполнит его элементами из первого массива, количество символов в которых меньше или равно указанной вами длине.
(например 3)");
int inputLength = int.Parse(Console.ReadLine());
string[] sortItemArray = new string[0];
for (int i = 0, j = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length <= inputLength)
    {
        Array.Resize(ref sortItemArray, j + 1);
        sortItemArray[j] = inputArray[i];
        j++;
    }
}
Console.WriteLine("Получен массив сортированных строк: {0}", String.Join(" ", sortItemArray));