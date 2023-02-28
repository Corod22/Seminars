// 12. Напишите программу, которая будет принимать на вход два числа
// и выводить является ли первое число кратным второму. Если первое 
// число не кратно второму, то программа выводит остаток отделения.

// 34, 5-> не кратно, остаток 4
// 16, 4-> кратно
// Console.WriteLine("Введите 1 число");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// int multiplicityNumber=firstNumber%secondNumber;
// if (multiplicityNumber==0)
// {
//     Console.WriteLine("Кратно");
// }
// else
// {
//     Console.WriteLine($"Не кратно, остаток-> {multiplicityNumber}");
// }

Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int multiplicityNumber = MultiplicityNumber(firstNumber, secondNumber);
if (multiplicityNumber==0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Не кратно, остаток-> {multiplicityNumber}");
}

int MultiplicityNumber(int first, int second)
{
    int result = first %second;
    return result;
}