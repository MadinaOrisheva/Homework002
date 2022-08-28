// Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

int num;
int secondNumber() {

int dec = (num % 100)/10;
return dec;
}
// испольховала бесконечный цикл для удобства проверки выполнения условия с разными числами
while (true) {
Console.WriteLine("Введите трехзначное число: ");
num = Convert.ToInt32(Console.ReadLine());
int dec = secondNumber();
Console.WriteLine("Вторая цифра введенного числа: " + dec);
}