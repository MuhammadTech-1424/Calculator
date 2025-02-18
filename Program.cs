using System;

Console.WriteLine("Bu KALKULYATOR dasturi");

Console.Write("1-sonni kiriting: ");
double son1 = Convert.ToDouble(Console.ReadLine());
Console.Write("2-sonni kiriting: ");
double son2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Sonlar yig'indisi {son1 + son2}.");
Console.WriteLine($"Sonlar ayirmasi {son1 - son2}.");
Console.WriteLine($"Sonlar ko'paytmasi {son1 * son2}.");
Console.WriteLine($"Sonlar bo'linmasi {son1 / son2}, qoldiq {son1 % son2}.");
