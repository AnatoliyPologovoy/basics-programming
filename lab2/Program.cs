//задание 4 лаб 2
//static void Main()
//{
//    // Ввод данных
//    Console.Write("Введите значение x (в радианах): ");
//    double x = Convert.ToDouble(Console.ReadLine());

//    Console.Write("Введите точность q: ");
//    double q = Convert.ToDouble(Console.ReadLine());

//    // Инициализация переменных
//    double term = 1; // Первое слагаемое ряда Тейлора
//    double cosX = term; // Значение косинуса
//    int n = 0; // Счетчик слагаемых
//    int sign = -1; // Знак (-1)^n

//    // Вычисление ряда
//    do
//    {
//        n++;
//        term *= (x * x) / ((2 * n - 1) * (2 * n)); // Очередное слагаемое
//        cosX += sign * term; // Добавление слагаемого к результату
//        sign *= -1; // Переключение знака
//    } while (Math.Abs(term) >= q);

//    // Вывод результата
//    Console.WriteLine($"Приближенное значение cos({x}): {cosX}");
//    Console.WriteLine($"Количество учтенных слагаемых: {n + 1}");
//}