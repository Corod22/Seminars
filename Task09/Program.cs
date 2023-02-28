// 9. Напишите программу, котроая выводит случайное 
// числоиз отрезка [10, 99] и показывает наибольшую цифру

// 78-> 8
// 12-> 2
// 85-> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");
// int firstDigit = number / 10;
// int secontDigit = number % 10;
// if (firstDigit > secontDigit)
//    {
//     Console.WriteLine($"Наибольшая цифра {firstDigit}");
//    }
//    else
//    {
//     Console.WriteLine($"Наибольшая цифра {secontDigit}");
//    }

// int result = firstDigit > secontDigit ? firstDigit : secontDigit;
// Console.WriteLine($"Наибольшая цифра {result}");

int maxDigit = MaxDigit (number);
Console.WriteLine($"Наибольшая цифра {maxDigit}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secontDigit = num % 10;
    int result = firstDigit > secontDigit ? firstDigit : secontDigit;
    return result;
}