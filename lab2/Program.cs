//Лабораторная работа 2

//задание 1
static void getSolutionQuadraticEquation()
{
    Console.Write("Введите значение a: ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите точность b: ");
    double b = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите точность c: ");
    double c = Convert.ToDouble(Console.ReadLine());

    double discriminant = Math.Pow(b, 2) - 4*a*c;

    // Определение корней в зависимости от дискриминанта
    if (discriminant > 0)
    {
        // Два действительных корня
        double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
        double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

        Console.WriteLine($"Уравнение имеет два различных действительных корня:");
        Console.WriteLine($"x1 = {x1}");
        Console.WriteLine($"x2 = {x2}");
    }
    if (discriminant == 0)
    {
        // Один действительный корень
        double x = -b / (2 * a);

        Console.WriteLine("Уравнение имеет один действительный корень:");
        Console.WriteLine($"x = {x}");
    }
    if (discriminant < 0)
    {
        // Комплексные корни
        double realPart = -b / (2 * a);
        double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);

        Console.WriteLine("Уравнение имеет два комплексных корня:");
        Console.WriteLine($"x1 = {realPart} + {imaginaryPart}i");
        Console.WriteLine($"x2 = {realPart} - {imaginaryPart}i");
    }

}
//getSolutionQuadraticEquation();

//Задание 2
static void getPi()
{
    Console.Write("Введите количество слагаемых: ");
    int n = Convert.ToInt32(Console.ReadLine()); // Счетчик слагаемых
    double sign = -1;       // Знак для чередования (+ и -)
    double denominator = 3; // Знаменатель дроби
    double result = 1;

    do
    {
        result += sign * 1 / denominator;
        n--;
        sign = -sign;                       
        denominator += 2;
    } while (n > 0);

    // Вывод результата
    Console.WriteLine($"Приближенное значение pi: {result*4}");
}
//getPi();

//Задание 3
static int getCountFourDigitFibonacciNum()
{
    int prePrevious = 1, previous = 1, current = 2, count = 0;
    do
    {
        if (current >= 1000)
        {
            count++;
        }
        prePrevious = previous;
        previous = current;
        current += prePrevious;
    } while (current <= 9999);
    return count; //4
}
//Console.WriteLine(getCountFourDigitFibonacciNum()); 

//задание 4 
static void getTeilorRow()
{
    Console.Write("Введите значение x (в радианах): ");
    double x = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите точность q: ");
    double q = Convert.ToDouble(Console.ReadLine());

    double term = 1; // Первое слагаемое ряда Тейлора
    double cosX = term; // Значение косинуса
    int n = 0; // Счетчик слагаемых
    int sign = -1; // Знак (-1)^n

    // Вычисление ряда
    do
    {
        n++;
        term *= (x * x) / ((2 * n - 1) * (2 * n)); // Очередное слагаемое
        cosX += sign * term; // Добавление слагаемого к результату
        sign *= -1; // Переключение знака
    } while (Math.Abs(term) >= q);

    // Вывод результата
    Console.WriteLine($"Приближенное значение cos({x}): {cosX}");
    Console.WriteLine($"Количество учтенных слагаемых: {n + 1}");
}
//getTeilorRow()

//Задание 5
static void getSumOfCubes()
{
    Console.Write("Введите число N: ");
    int N = int.Parse(Console.ReadLine());

    // Ограничиваем диапазон поиска: от -Math.Cbrt(N) до Math.Cbrt(N)
    int limit = (int)Math.Cbrt(Math.Abs(N)) + 1;

    bool found = false;

    for (int x = -limit; x <= limit; x++)
    {
        for (int y = -limit; y <= limit; y++)
        {
            for (int z = -limit; z <= limit; z++)
            {
                if (x * x * x + y * y * y + z * z * z == N)
                {
                    Console.WriteLine($"Решение найдено: x = {x}, y = {y}, z = {z}");
                    found = true;
                }
            }
        }
    }

    if (!found)
    {
        Console.WriteLine("No such combinations!");
    }
}
//getSumOfCubes();

static void getYearWord()
{
    Console.Write("Введите количество лет: ");
    string year = Console.ReadLine();
    int yearNum = int.Parse(year);
    int yearLastNum = int.Parse(year[year.Length - 1].ToString());

    string yearWord = "год";

    if (yearNum > 4 && yearNum < 21 || yearLastNum > 4 && yearLastNum <= 9)
    {
        yearWord = "лет";
        Console.WriteLine($"{year} {yearWord}");
        return;
    }
    if (yearLastNum > 1 && yearLastNum < 5)
    {
        yearWord = "года";
        Console.WriteLine($"{year} {yearWord}");
        return;
    }
    Console.WriteLine($"{year} {yearWord}");
}
//getYearWord();

Console.ReadKey();