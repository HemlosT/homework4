/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

void number(int firstNumber, int secondNumber)
{
    double result = 0;
    result = Math.Pow(firstNumber, secondNumber);
    Console.WriteLine(result);
}

number(2, 7);