// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да



int[] array = new int[5];
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 4; i >= 0; i = i - 1) 
{
    array[i] = num % 10; 
    num /= 10;
}

if(array[0] == array[4] && array[1] == array[3]) Console.WriteLine("Число является палиндромом");
else Console.WriteLine("Число не является палиндромом");