/*
вывети заголовок программы

объявляем начало и конец интервала поиска
просим пользователя загадать число в этом интервале

пока интервал существует (начало меньше конца)
    спрашиваем у пользователя, больше ли его число среднего значения интервала
    если да, сдвигаем начало интервала на среднее значение + 1
    если нет, сдвигаем конец интервала на среднее значение
вывод найденного числа (когда начало равно концу, это и есть загаданное число)

выйти из программы
*/

WriteTitle("Угадай число!");

int start = 1;
int end = 1024;

Console.WriteLine($"Загадайте число от {start} до {end}.");

while(start < end)
{
    int mid = (start + end) / 2;
    Console.Write($"Ваше число больше чем {mid}? (д/н y/n): ");
    string response = Console.ReadLine().Trim().ToLower();
    if(response == "д" || response == "y")
    {
        start = mid + 1;
    }
    else
    {
        end = mid;
    }
    Console.WriteLine($"Теперь ваш интервал от {start} до {end}.");
}
Console.WriteLine($"Ваше число: {start}!");                                               

ExitApp();

void WriteTitle(string title)
{
    Console.WriteLine(title);
    Console.WriteLine(new string('-', title.Length));
    Console.WriteLine();
}

void ExitApp()
{
    Console.WriteLine();
    Console.Write("Для выхода нажми Enter");
    Console.ReadLine();
}
