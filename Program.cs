using System;

Console.WriteLine("Bu KALKULYATOR dasturi");

// Input operatori
Console.Write("1-sonni kiriting: ");
double son1 = Convert.ToDouble(Console.ReadLine());
Console.Write("2-sonni kiriting: ");
double son2 = Convert.ToDouble(Console.ReadLine());

// Matematik operatorlar
Console.WriteLine($"Sonlar yig'indisi {son1 + son2}.");
Console.WriteLine($"Sonlar ayirmasi {son1 - son2}.");
Console.WriteLine($"Sonlar ko'paytmasi {son1 * son2}.");
Console.WriteLine($"Sonlar bo'linmasi {son1 / son2}, qoldiq {son1 % son2}.");

// Taqqoslash operatorlari
Console.WriteLine($"1-son 2-sidan kattami? {son1 > son2}");
Console.WriteLine($"1-son 2-sidan kichikmi? {son1 < son2}");
Console.WriteLine($"Sonlar tengmi? {son1 == son2}");

// Shart operatori
if (son1 > son2)
{
    Console.WriteLine(son1 + "soni" + son2 + "sonidan katta.");
}
else if(son1==son2)
{
    Console.WriteLine("Sonlar o\'zaro teng.");
}
else
{
    Console.WriteLine("1-son 2-sidan kichik.");
}
