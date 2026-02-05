/*
вывети заголовок программы

выйти из программы
*/

WriteTitle("Угадай число!");
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
