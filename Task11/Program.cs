// 11. Напеишите программу, которая выодит случайное трехзначное числоиз
// и удаляет вторую цифру

// 456->46
// 782->72
// 918->98

int number = new Random().Next(100, 1000);
Console.WriteLine("Случайное трехзначное число -> {number}");
int maxDigitt = MaxDigitt (number); 
Console.WriteLine($"Число {number} -> {maxDigitt}");
int MaxDigitt(int num)
{
    int firstDigit = num / 100;
    int secontDigit = num % 10;
    int result = firstDigit*10 + secontDigit;
    return result;
}