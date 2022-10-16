/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.WriteLine("Введите цифры массива.Пример: 1, 12, ... 13, 4"); 
string[] array = Console.ReadLine().Split(", ");
if (array.Length != 8)
{
    Console.WriteLine("Данный массив не состоит из 8 символов");
}
int[] digital = new int[8];
for (int i = 0; i < array.Length; i++)
{
    digital[i] = Int32.Parse(array[i]);
}
Console.WriteLine("[{0}]", string.Join(", ", digital));