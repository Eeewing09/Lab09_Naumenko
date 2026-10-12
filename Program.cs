// int totalExercises = 0;

// for (int number = 8; number > totalExercises; number--)
// {
//     Console.WriteLine($"Упражнение {number}");
// }
// Console.WriteLine("Домашнее задание готово");
// for (int room = 5; room <= 50; room += 5)
// {
//     Console.WriteLine($"Кабинет {room}");
// }
// int count = 0;
// for (int ticket = 4; ticket <= 30; ticket++)
// {
//     if (ticket == 4 || ticket == 12 || ticket == 19)
//     {
//         count++;
//         continue;
//     }
//     Console.WriteLine($"Первый доступный билет: {ticket}");
//     Console.WriteLine($"число пропущенных {count}");
//     break;
// }
// for (; ; )
// {
//     Console.WriteLine("Введите код группы (для выхода - «exit»): ");
//     string groupCode = Console.ReadLine();
//     if (groupCode == "exit")
//     {
//         break;
//     }
//     Console.WriteLine($"Записан код группы: {groupCode}");
// }

// Console.WriteLine("Работа с журналом завершена");
// задача А
// for (int c = 1; c <= 100; c += 2)
// {

//     Console.WriteLine(c);

// }
// // задача Б
// for (int z = 100; z >= 0; z -= 10)
// {
//     Console.WriteLine(z);
// }
// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");
// задача 8
// for (int i = 100; i >= 2; i -= 2)
// {
//     Console.WriteLine(i);
// }
//зд 9
int sum = 0;
for (int u = 1; u <= 50; u += 1)
{
    if (u % 5 == 0)
    {
        continue;
    }
    else { sum += u; }
}
Console.WriteLine(sum);