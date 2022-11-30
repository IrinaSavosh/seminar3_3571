// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int var = num;
int res;
while (num > 0)
{
   res = num % 10;
   sum = sum * 10 + res;
   num = num / 10;
}
if (var == sum)
{
   Console.WriteLine($"Число {var} является полиндромом"); ;
}
else
{
   Console.WriteLine($"Число {var} не является полиндромом");
}

