using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
namespace Assignment8ex2
{   
    public class MathSolutions
    {
        public delegate double customDelegate(double a, double b);
        public double GetSum(double x, double y)
        {
            return x + y;
        }
        public double GetProduct(double a, double b)
        {
            return a * b;
        }
        public void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($" {a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($" {b} is smaller than {a}");
            else
                Console.WriteLine($" {b} is equal to {a}");
        }
        static void Main(string[] args)
        {
            // create a class object
            MathSolutions answer = new MathSolutions();
            Random r= new Random();
            double num1 = Math.Round(r.NextDouble()*100);
            double num2 = Math.Round(r.NextDouble()*100);
            Console.WriteLine($" {num1} + {num2} = {answer.GetSum(num1,num2)}");
            Console.WriteLine($" {num1} + {num2} = {answer.GetProduct(num1, num2)}");
            answer.GetSmaller(num1, num2);

            // action delegate
            Console.Write("Action Delegate: ");
            Action <double,double> actionDelegate = answer.GetSmaller;
            actionDelegate(10,4);

            // anonmyous Func Delegate with lambda expression
            Console.Write("Func Delegate: ");
            Func <double, double, double> multiply = (a,b) => a*b;
            Console.WriteLine($"3 * 4 = {multiply(3,4)}");

            // Custom singlecast delegate
            Console.Write("Custom Singlecast Delegate: ");
            customDelegate addition = new customDelegate(answer.GetSum);
            Console.WriteLine($"57 + 71 = {addition(57,71)}");

        }
    }
}