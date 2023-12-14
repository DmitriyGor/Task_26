/*
Задача 26: 
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
Console.Write("Enter the number : "); // Введите число 

bool isNumber = int.TryParse(Console.ReadLine(), out int number);
// isNumber = true, то строка состоит только из чисел
// false - присутствуют в строке еще и символы
int count = 0; // Количество цифр в числе//
if (isNumber) // isNumber == true
{
while (number != 0)
{
    number/=10;
    count++;
}
Console.Write ($"number of digits in a number:  {count}");
}
else
{
   Console.WriteLine("Error! The line contains not only numbers, but also other symbols ");
   // Ошибка! В строчке присутсвуют не только цифры, но и другие символы
}
