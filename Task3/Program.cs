/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.Write("Введите цифру обозначающую день недели: ");
int Num = int.Parse(Console.ReadLine());
if (Num > 0 && Num < 5)
{
    Console.WriteLine("Будние дни:( ");
    return;
}
if (Num == 6 || Num == 7)
{
    Console.WriteLine("Выходные ИИИИУУУУУ ");
    return;
}
if (Num > 7)
{
    Console.WriteLine("В неделе пока что ещё 7 дней:3");
    return;
}
if (Num < 0 )
{
    Console.WriteLine("Ого, 0 дней в неделе, а жить когда?");
    return;
}
if (Num == 5)
{
    Console.WriteLine("О, ЕБАТЬ, ПЯТНИЦА, ПОРА НАХУЯРИТЬСЯ");
    return;
}
