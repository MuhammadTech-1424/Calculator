using System;
using Kalkulyator;
class Program
{
    static void Main()
    {
        try
        {
            Calculator calculate = new Calculator();
            calculate.UserInputs();
            calculate.MatematicalOperations();
            calculate.Compare();
            calculate.NumbersUpTo();
            calculate.CheckPassword();
            calculate.MultiplicationTable();
        }
        catch (Exception)
        {
            Console.WriteLine("Noto'g'ri ma'lumot kiritdingiz");
        }
    }
}