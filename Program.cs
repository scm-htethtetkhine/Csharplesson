using System;
namespace myproject
{
    class program
    {
        // C# Program to Swap Values of Two Variables
        public static void Swapvalues(int num1 = 30, int num2 = 50)
        {
            int temp = 0;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("swap numbers are num1 = " + num1 + " , num2 = " + num2);
        }

        //C# Program to Multiply two Floating Point Numbers
        public static void Multiply()
        {
            float num1 = 5.75F;
            float num2 = 4.32F;
            float Mul = num1 * num2;
            Console.WriteLine("Multiply two floating point numbers is " + Mul);
        }

        //C# Program to perform all arithmetic operations
        public static void Arithmetic()
        {
            int num1 = 20, num2 = 10;
            int result = (num1 + num2);
            Console.WriteLine("Addition = " + result);
            result = (num1 - num2);
            Console.WriteLine("Subtraction = " + result);
            result = (num1 * num2);
            Console.WriteLine("Multiplication = " + result);
            result = (num1 / num2);
            Console.WriteLine("Division = " + result);
            result = (num1 % num2);
            Console.WriteLine("Modulo = " + result);
        }

        //C# Program to convert feet to meter
        public static void Feettometer()
        {
            double feet, meter;
            Console.WriteLine("Input Feet = ");
            feet = Convert.ToDouble(Console.ReadLine());
            meter = feet * 0.3048;
            Console.WriteLine("feet to meter is : " + meter);
        }

        //C# Program to convert celcius to farenheit 
        public static void Celtofaren()
        {
            double fahrenheit, celsius = 20;
            fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("Fahrenheit = " + fahrenheit);
        }

        //C# Program to convert farenheit to celcius
        public static void Farentocel()
        {
            double fahrenheit = 23, celsius;
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Celsius = " + celsius);
        }

        //C# Program to find the Size of data types
        public static void Sizedatatypes()
        {
            Console.WriteLine("Size of char: " + sizeof(char));
            Console.WriteLine("Size of Short: " + sizeof(short));
            Console.WriteLine("Size of int: " + sizeof(int));
            Console.WriteLine("Size of long: " + sizeof(long));
            Console.WriteLine("Size of float: " + sizeof(float));
            Console.WriteLine("Size of double: " + sizeof(double));
        }

        //C# Program to Print ASCII Value
        public static void Ascii()
        {
            int asciival;
            int i = 0;
            for (asciival = 33; asciival <= 127; asciival++)
            {
                Console.Write(" " + Convert.ToChar(asciival));
                i++;
            }
        }

        //C# Program to Calculate Area of Circle
        public static void Circlearea()
        {
            double radius = 10;
            double area = Math.PI * radius * radius;
            Console.WriteLine("Area of circle = " + area);
        }

        // C# Program to Calculate Area of Square
        public static void Squarearea()
        {
            int side = 6;
            int area = side * side;
            Console.WriteLine("Area of square = " + area);
        }

        //C# Program to Calculate Area of Rectangle
        public static void Rectangleearea()
        {
            int length = 8;
            int breadth = 5;
            int area = length * breadth;
            Console.WriteLine("Area of rectangle = " + area);
        }

        //C# Program to check whether an integer entered by the user is odd or even
        public static void Checknum()
        {
            int x;
            Console.Write("Input an integer = ");
            x = Convert.ToInt32(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine(x + " is an even integer.\n");
            }
            else
            {
                Console.WriteLine(x + " is an odd integer.\n");
            }
        }

        //C# Program to find the largest number among three number.
        public static void Largenum()
        {
            int x, y, z;
            Console.Write("Input the first number = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number = ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the third number = ");
            z = Convert.ToInt32(Console.ReadLine());
            if (x > y && x > z)
            {
                Console.WriteLine("largest number = " + x);
            }
            else if (y > x && y > z)
            {
                Console.WriteLine("largest number = " + y);
            }
            else
            {
                Console.WriteLine("largest number = " + z);
            }
        }

        //C# Program to Find the Largest Number using Conditional Operator
        public static void Largenumwithcondition()
        {
            int x, y, z, largest;
            Console.Write("Input the first number = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number = ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the third number = ");
            z = Convert.ToInt32(Console.ReadLine());
            largest = x > y ? (x > z ? x : z) : (y > z ? y : z);
            Console.WriteLine("largest number = " + largest);
        }

        //C# Program to find the Largest among Three Variables using Nested if
        public static void Nestedif()
        {
            int x, y, z;
            Console.Write("Input the first number = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number = ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the third number = ");
            z = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                if (x > z)
                {
                    Console.WriteLine("largest number = " + x);
                }
                else
                {
                    Console.WriteLine("largest number = " + z);
                }
            }
            else
            {
                if (y > z)
                {
                    Console.WriteLine("largest number = " + y);
                }
                else
                {
                    Console.WriteLine("largest number = " + z);
                }
            }
        }

        //C# program to accept two integers and check whether they are equal or not
        public static void Checkintequal()
        {
            int x, y;
            Console.Write("Input the first number = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number = ");
            y = Convert.ToInt32(Console.ReadLine());
            if (x == y)
            {
                Console.WriteLine("x = " + x + " and " + "y = " + y + " are equal.");
            }
            else
            {
                Console.WriteLine("x = " + x + " and " + "y = " + y + " are not equal.");
            }
        }

        //Write a C# program to create a function to input a string and count number of spaces are in the string
        public static void Countspace()
        {
            int count;
            string name = "I am the student";
            count = name.Split(' ').Length;
            Console.WriteLine("The count is " + count);
        }

        //C# program to create a function to calculate the sum of the individual digits of a given number
        public static void Sumdigit(int x)
        {
            int sum = 0;
            string num1 = Convert.ToString(x);

            for (int i = 0; i < num1.Length; i++)
                sum += Convert.ToInt32(num1.Substring(i, 1));
            Console.WriteLine("The sum of the digits of the number = " + sum);
        }

        //C# program to create a function to check whether a number is prime or not by a given number

        public static void Prime()
        {
            Console.Write("Enter a Number = ");
            int num = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine(num + " is a Prime Number", num);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
        }

        //C# program to create a function to display the n number Fibonacci sequence
        public static void Fibonacci()
        {
            int num1 = 0, num2 = 1, num3, i, number;
            Console.Write("Enter the number = ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write(num1 + " " + num2 + " ");
            for (i = 2; i < number; i++)
            {
                num3 = num1 + num2;
                Console.Write(num3 + " ");
                num1 = num2;
                num2 = num3;
            }
        }

        //C# program to create a recursive function to find the factorial of a given number
        public static void Factorial()
        {
            int i, j, fact;
            Console.WriteLine("Enter the Number");
            j = Convert.ToInt32(Console.ReadLine());
            fact = j;
            for (i = j - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial number = " + fact);
        }

        public static void Main()
        {
            Swapvalues();
            Multiply();
            Arithmetic();
            Feettometer();
            Celtofaren();
            Farentocel();
            Sizedatatypes();
            Ascii();
            Circlearea();
            Squarearea();
            Rectangleearea();
            Checknum();
            Largenum();
            Largenumwithcondition();
            Nestedif();
            Checkintequal();
            Countspace();
            Sumdigit(981);
            Prime();
            Fibonacci();
            Factorial();
        }
    }
}
