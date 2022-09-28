/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.*/

int Exponentiation(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}

Console.WriteLine("Введите целое число А");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целую степень В");
int numberB = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} равно {exponentiation}");


/*без цикла
double numberA;
double numberB;
double Exponentiation;

Console.WriteLine("Введите число А");
numberA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число В");
numberB = Convert.ToDouble(Console.ReadLine());

Exponentiation = Math.Pow(numberA, numberB);
Console.WriteLine("Число " +numberA+ " в степени " +numberB+ " равно " +Exponentiation+"");*/
