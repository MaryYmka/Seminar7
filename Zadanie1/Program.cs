//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

//Console.WriteLine("Введите число: ");
//string str = Console.ReadLine(); // считываем вводимую строку
//int num = Convert.ToInt32(str); // строку конвертируем в число


int number = GetNumber();

int GetNumber()
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int sum = FindSum(number);

int FindSum(int number)
{
    if (number == 0)
    {
        return 0;
    }
     return number%10 + FindSum(number/10);
    //return sum;
    
}

Console.WriteLine(sum);

