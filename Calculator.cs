using System;
using System.Collections.Generic;
using System.Linq;
namespace Kalkulyator
{
    class Calculator
    {
        double son1 { get; set; }
        double son2 { get; set; }
        string operation { get; set; }
        string parol { get; set; }
        public void UserInputs()
        {
            Console.Write("1-sonni kiriting: ");
            son1 = double.Parse(Console.ReadLine());
            Console.Write("2-sonni kiriting: ");
            son2 = double.Parse(Console.ReadLine());
            Console.Write($"Bajariladigan arifmetik amalni kiriting (+, -, *, /):\n>>> ");
            operation = Console.ReadLine();
        }
        public void MatematicalOperations()
        {
            Console.WriteLine($"Sonlar yig'indisi {son1 + son2}.");
            Console.WriteLine($"Sonlar ayirmasi {son1 - son2}.");
            Console.WriteLine($"Sonlar ko'paytmasi {son1 * son2}.");
            Console.WriteLine($"Sonlar bo'linmasi {son1 / son2}, qoldiq {son1 % son2}.");
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
            string result = operation switch 
            {
                "+" => $"Yig'indi {son1+son2} ga teng.",
                "-" => $"Ayyirma {son1-son2} ga teng.",
                "*" => $"Ko'paytma {son1*son2} ga teng.",
                "/" => $"Bo'linma {son1/son2} ga, qoldiq {son1%son2} ga teng.",    
                _ => "Bunday amal mavjud emas."
            };
        }
        public void Compare()
        {
            Console.WriteLine($"1-son 2-sidan kattami? {son1 > son2}");
            Console.WriteLine($"1-son 2-sidan kichikmi? {son1 < son2}");
            Console.WriteLine($"Sonlar tengmi? {son1 == son2}");
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
        }
        public void NumbersUpTo()
        {
            int son = 1;
            while (son < son1)
            {
                Console.WriteLine(son);
                son ++;
            }
        }
        public void CheckPassword()
        {
            Console.WriteLine("Sizning parolingiz: \"0305\"");
            do
            {
                Console.Write("Parolingizni kiriting: ");
                parol = Console.ReadLine();
            } while (parol != "0305");
            Console.WriteLine("To'g'ri!");
        }
        public void MultiplicationTable()
        {     
            Console.WriteLine("< KARRA JADVALI >");
            for (int i1 = 1; i1 <= 10; i1 ++)
            {
                for (int i2 = 1; i2 <= 10; i2 ++)
                {
                    Console.WriteLine($"{i1} * {i2} = {i1 * i2}");
                }
                Console.Write("\n");
            }
        }
    }
}