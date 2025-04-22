using System;
using Kalkulyator;
class Program
{
    static void Main()
    {
        Calculator calculate = new Calculator();
        calculate.UserInputs();
        calculate.MatematicalOperations();
        calculate.Compare();
        calculate.NumbersUpTo();
        calculate.CheckPassword();
        calculate.MultiplicationTable();
    }
}