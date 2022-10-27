Console.WriteLine("Введите цену бензина за галлон в долларах, в США: ");
double number = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Цена бензина за галлон в долларах {number}!");
Console.WriteLine("Введите цену бензина за литр в рублях, в России: ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите курс доллара на сегодня: ");
double number3 = Convert.ToDouble(Console.ReadLine());
// цена в литрах и долларах США
double number2 = number / 3.785;
// цена в рублях 
double number4 = number2 * number3;
double number6 = number1 - number4;
double number7 = number4 - number1;
if (number4 == number1)
{
    Console.WriteLine (" Цена бензина в США и РФ равна ");
}
if (number4 < number1)
{
    Console.Write ("Цена бензина в США меньше чем в РФ на " + Math.Round(number6 , 2));
    Console.WriteLine (" рублей!");
}
if (number4 > number1)
{
    Console.Write ("Цена бензина в РФ меньше чем в США на " + Math.Round(number7 , 2));
    Console.WriteLine (" рублей!");
}
Console.WriteLine("Цена бензина за литр в долларах в США: " + Math.Round(number2 , 2));
Console.WriteLine("Цена бензина за литр в рублях в США: " + Math.Round(number4 , 2));
Console.WriteLine("Нажмите для выхода: ");
double number5 = Convert.ToDouble(Console.ReadLine());