using System;
using System.Security.Cryptography.X509Certificates;

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
// switch operatori
Console.Write($"Bajariladigan arifmetik amalni kiriting (+, -, *, /):\n>>> ");
string operation = Console.ReadLine();
switch (operation)
{
    case "+":
        Console.WriteLine($"{son1} * {son2} = {son1*son2}");
        break;
    case "/":
        Console.WriteLine($"Bo'linma {son1/son2} ga teng, qoldiq {son1%son2}");
        break;
    default:
        Console.WriteLine("Bunday amal mavjud emas.");
        break;
}   
// switch expression
string result = operation switch 
{
    "+" => $"Yig'indi {son1+son2} ga teng.",
    "-" => $"Ayyirma {son1-son2} ga teng.",
    "*" => $"Ko'paytma {son1*son2} ga teng.",
    "/" => $"Bo'linma {son1/son2} ga, qoldiq {son1%son2} ga teng.",    
    _ => "Bunday amal mavjud emas."
};

