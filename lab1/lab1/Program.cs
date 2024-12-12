// ЛАБОРАТОРНАЯ РАБОТА №1

// задание 1
static int? getNumAfterDot(double decimalValue)
{
    var stringValue = Convert.ToString(decimalValue);
    for (int i = 1; i < stringValue.Length; i++)
    {
        if (stringValue[i - 1] == ',')
        {
            return int.Parse(stringValue[i].ToString());
        }
    }
    return null;
}

const double START_DOUBLE = 27.3198;
int? d = getNumAfterDot(START_DOUBLE);
Console.WriteLine($"Задание 1. Первая цифра после запятой для {START_DOUBLE} - {d}");

// задание 2
static void showHoursAndMinutesHavePassedToday()
{
    int totalSeconds = (int)(DateTime.Now - DateTime.Today).TotalSeconds;
    const int HOUR_SECONDS = 3600;
    const int MINUT_SECONDS = 60;
    int hours = totalSeconds / HOUR_SECONDS;
    int restSeconds = totalSeconds - hours * HOUR_SECONDS;
    int minutes = restSeconds / MINUT_SECONDS;
    Console.WriteLine($"С начала суток прошло {totalSeconds} секунд. Это {hours} ч. и {minutes} минут");
}
Console.WriteLine("Задание 2");
showHoursAndMinutesHavePassedToday();

// задание 3
static void showAngleDegreeByTime(int h, int m, int s)
{
    const double SECOND_DEGREE = 0.0083;
    const int HOURS_SECONDS = 3600;
    const int MINUT_SECONDS = 60;
    int totalSecond = h * HOURS_SECONDS + m * MINUT_SECONDS + s;
    double result = totalSecond * SECOND_DEGREE;
    Console.WriteLine($"Угол равен {result} гр.");
}
Console.WriteLine("Задание 3");
showAngleDegreeByTime(10, 10, 40);

// Задание 4
int a = 4;
int b = 7;
Console.WriteLine("Задание 4");
Console.WriteLine($"a = {a}, b = {b}");
(a, b) = (b, a);
Console.WriteLine($"a = {a}, b = {b}");

// Задание 5
static void showDataTriangle()
{
    Console.WriteLine("Введите длину 1 катета");
    int firstLag = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите длину 2 катета");
    int secondLag = int.Parse(Console.ReadLine());
    
    int square = firstLag * secondLag / 2;

    double hypotenuse = Math.Round(Math.Sqrt(Math.Pow(firstLag, 2) + Math.Pow(secondLag, 2)), 2);

    double perimeter = firstLag + secondLag + hypotenuse;

    Console.WriteLine($"Площадь {square},периметр {perimeter}");
    Console.ReadKey();
}

Console.WriteLine("Задание 5");
showDataTriangle();