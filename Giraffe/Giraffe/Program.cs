using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // string name = "John"; // initialising varaible
            // int age; //decalring varaible
            //age = 35; //giving varaible a value

            // Console.WriteLine(name + " is " + age); // Expected Print out John is 35

            /*string phrase = "Sample Phrase";
            char grade = 'A'; //only holds 1 single character with ' ' 
            int age = 30;
            double gpa = 1.1;//can hold decimal numbers similar to float and decimal accuracy range from floar,double,decimal
            bool isMale = true; //true or flase values;*/


            //Console.WriteLine("Hello\nWorld");// \n seperates string onto a new line

            //string phrase = "Hello World";
            //Console.WriteLine(phrase.Length); // prints out the length of a specified string
            //Console.WriteLine(phrase.ToUpper()); // Concerts String to Upper Case (.ToLower for lower case)
            //Console.WriteLine(phrase.Contains("Hello")); // Checks to see if a string contains specified text, returns true or false
            //Console.WriteLine(phrase[0]); //Print the Specified character that occurs at the value inside[] (0 indexed)
            //Console.WriteLine(phrase.IndexOf("World")); //Check if a string contains specified text and output the index of where it starts. returns -1 if not found.
            //Console.WriteLine(phrase.Substring(6)); // Prints out the characters of a string starting at the index specified also takes a lenght param

            //int num = 6;
            //num++; // adds one to the number when program is run
            //num--; // subtracts one from the number when program is ran
            //Console.WriteLine(5 + 8); //Perform any math functions
            //Console.WriteLine(5 % 2); // Divides Numbers and prints reminder
            //Console.WriteLine(Math.Abs(num));//gives the absolute value
            //Console.WriteLine(Math.Pow(num,2)); //Multiplies the first param to the power of the second
            //Console.WriteLine(Math.Sqrt(num)); //get the square root
            //Console.WriteLine(Math.Max(num, 4)); //prints out the biggest number Math.Min does the opposite
            //Console.WriteLine(Math.Max(num, 4)); //rounds to nearest whole number

            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine(); //Stores what the user types into name string
            //Console.WriteLine("Hello " + name);


            //Calculator
            //Console.WriteLine("46 " + "12"); //Output = 4612 need to convert strigns to numbers to add them
            //int num = Convert.ToInt32("46"); //Convert String to int Sting need to have a "number"
            //Console.WriteLine(num + 12);
            /*Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine()); //Console.Readline will return a string so need to conver to a number/int 
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + num2);*/

            //MadLib
            /*string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("The Sky is " + color);
            Console.WriteLine("The " + pluralNoun + " is Green");
            Console.WriteLine("How are you " + celebrity);
            */

            //Creating an Array method 1       
            //int[] luckyNumbers = { 1, 4, 7, 18, 22 }; //how to decalre and initize an array
            //luckyNumbers[1] = 10;//change the value located at index 1 to 10;
            //Console.WriteLine(luckyNumbers[1]);// Outputs the number that occurs at the specified index inside the [],starts at 0;

            //Creating an Array method 2
            //string[] friends = new string[10];//Specifies how many values an array can hold without entering them
            //friends[0] = "Shane"; //adding first value to array
            //friends[1] = "Stephen";//adding second value to array

            //Methods with no return
            //SayHi(); //to use a method it needs to be called in the main method by adding the methods name() to main method
            //SayHello("Shane",24); // if method has parameters we need to pass them in the main method

            //methods with return
            //Console.WriteLine(Cube(3));

            //if statements
            /*bool isMale = true;
              
            if (isMale) //add the condition between the ()
            { //true block
                Console.WriteLine("you are male"); //if isMale is true print this
            }
            else //add an else if there is more than just a true outcome
            {//false block
                Console.WriteLine("you are not male"); //if isMale is false print this
            }*/

            //bool isMale = false;
            //bool isTall = true;

            /*if (isMale && isTall) //&&= And both conditions have to be true, if one is false the entire statement is false
            {
                Console.WriteLine("you are a tall male");
            }
            else
            {
                Console.WriteLine("you are not male or not tall or both");
            }*/
            /*if (isMale || isTall) //||= only one conditon has to be true for the statement to be true
            {
                Console.WriteLine("you are a tall male");
            }
            else
            {
                Console.WriteLine("you are not male or not tall or both");
            }*/
            /*if (isMale && isTall) 
            {
                Console.WriteLine("you are a tall male");
            }
            else if(isMale && !isTall) //isMale true and isTall False,else if checks for another condition if above if fails/is not true
            {
                Console.WriteLine("you are a male and not tall ");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("you are not a male and  tall ");
            }
            else
            {
                Console.WriteLine("you are not a male or  tall ");
            }*/

            //Comparing 2 values using if statements
            //Console.WriteLine(GetMax1(20, 5));

            //Comparing 3 values using if statements
            //Console.WriteLine(GetMax2(20, 5,35));


            //Calculator2
            /*Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: "); //=,-,/,*
            string op = Console.ReadLine();

            Console.Write("Enter a second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if(op == "+") //if user enters + as operator
            {
                Console.WriteLine(num1 + num2);
            } 
            else if(op == "-")//if user enters - as operator
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "/")//if user enters / as operator
            {
                Console.WriteLine(num1 / num2);
            }
            else if(op == "*") //if user enters * as operator
            {
                Console.WriteLine(num1 * num2);
            }
            else
            {
                Console.WriteLine("invalid operator"); //if op not == +,-,/,*
            }*/

            //Switch Statements

            Console.ReadLine(); //Keeps the console window on screen until text is entered
        }

        /*static void SayHi() //void had no return type //Method names start with cap
        {
            Console.WriteLine("Hello User"); //in order to run method need to add a call in the main method
        }*/
        /*static void SayHello(string name, int age) //adding params to a method
       {
           Console.WriteLine("Hello " + name + " you are " +age); //in order to run method need to add a call in the main method
       }*/

        /*static int Cube(int num) //retun type of this method is int
        {
            int result = num * num * num;
            return result; //methods that arent void need to have the return keyword added
        }*/

        /*static int GetMax1(int num1, int num2)//get the bigger number and return to main method
        {
            int result;
            if (num1 > num2) //is num1 greater than num2
            {
                result = num1;
            }
            else
            {
                result = num2;
            }


            return result;
        }*/
        /*static int GetMax2(int num1, int num2,int num3)//get the bigger number of 3 number
        {
            int result;
            if (num1 >= num2 && num1 >= num3) //is num1 greater than num2 and num 3
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)//is num2 greater than num1 and num 3
            {
                result = num2;
            }
            else
            {
                result = num3;//is num3 greater than num1 and num 2
            }


            return result;
        }*/
      }
    }
