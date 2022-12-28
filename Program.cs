// See https://aka.ms/new-console-template for more information
double sayi;
Console.WriteLine("0 dan büyük bir sayı giriniz : ");
sayi = Convert.ToDouble(Console.ReadLine());
//2 ile kalanı 0 ise çift değilse tek sayı
if (sayi % 2 == 0)
{
    Console.WriteLine("Girdiğiniz sayı çift sayıdır.");
}
else
{
    Console.WriteLine("Girdiğiniz sayı tek sayıdır.");
}