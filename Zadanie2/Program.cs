//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

int N = GetNumber();
listNumber(N);

int GetNumber()
{
    Console.WriteLine("Введите число: "); //Задаем и выводим число;
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void listNumber (int number, int start = 1)
{

    if (start <= N)
    {
        Console.WriteLine(start);
        listNumber(number, start + 1);
    }
}

//Заполнение массива
/*static iint[] GetArray(int number)
{
    //Определение кол-ва цифр в числе
    int Count = CountDigits(number);
    // Создание массива из цифр
    int [] array = new int[Count];
    for (int i = Count -1; i >= 0; i--)
    {
        array[i] = number % 10;
        number /= 10;
    }
    return array;
}*/
    // Создание массива из цифр
    //int [] array = new int[N];

