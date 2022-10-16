/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

void number(int fNumber, int sNumber)
{
    double result = 1;
    for (int newNumber = 1; newNumber <= sNumber; newNumber++)
    {
        result = result * fNumber;
    }
    Console.WriteLine(result);
}

number(125, 50);