// Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

int num;
int secondNumber() {


int dec = (num % 100)/10;
return dec;
}

Console.WriteLine("Введите трехзначное число: ");
num = Convert.ToInt32(Console.ReadLine());
int dec = secondNumber();
Console.WriteLine("Вторая цифра введенного числа: " + dec);
