// Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числ




int secondNumber(int num) {

int dec = 0;
int ed = 0;


 dec = num % 100;
 ed = dec/10;
 return ed;
}

int number;
Console.WriteLine("Введите трехзначное число: ");
number = Convert.ToInt32(Console.ReadLine());

if(number>1000 || number < 99) {
  Console.WriteLine("это не трехзначное число");
}
else {
int d = secondNumber(number);
Console.WriteLine("Вторая цифра введенного числа: " + d);}