// Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числ



/*
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

if(number>999 || number < 100) {
  Console.WriteLine("это не трехзначное число");
}
else {
int d = secondNumber(number);
Console.WriteLine("Вторая цифра введенного числа: " + d);}
*/



// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
 
void TherdNumber(int num){     //не нужно возвращать данные
string i = num.ToString();      // преобарзую в строку
int n = i.Length;
if (n<3)
{
Console.WriteLine("Третьей цифры нет");
}
else {
  Console.WriteLine(i[2]);
}

}
TherdNumber(778);  // нет условия, что программа принимает на вход число, поэтому сделала без запроса.


*/

//Напишите программу, которая принимает
//на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void Day (int num) {
  
  if (num < 6 ){
     Console.WriteLine ("не выходной");
  }
  else if (num > 5) {
      Console.WriteLine ("Выходной");
  }
  
  
} 

Console.WriteLine("Введите число от 1 до 7 :");
int dayNumber=Convert.ToInt32(Console.ReadLine());
Day(dayNumber);
