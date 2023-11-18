using System.Collections.Concurrent;
using System.Globalization;
using System.Net;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Write a program that allows the user to enter a number then print it.
            #region Q1
            Console.Write("Enter the number you want to print: ");
            string print = Console.ReadLine();
            Console.WriteLine(print);
            #endregion

            //Write a program that takes a number from the user then print yes
            //if that number can be divided by 3 and 4 otherwise print no.
            #region Q2
            Console.Write("Enter a number to check if the number divisible by 3 and 4: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine((num % 3 == 0 && num % 4 == 0) ? "Yes" : "No");
            #endregion

            /*
             * Write a program that allows the user to insert 2 integers then print the max.
             */
            #region Q3
            Console.Write("Write two number to check the bigger space between them: ");
            List<int> nums = new List<int>();
            nums = Console.ReadLine().Split().Select(s => int.Parse(s)).ToList();
            if (nums[0] > nums[1])
            {
                Console.WriteLine($"{nums[0]} is bigger");
            }
            else if (nums[0] < nums[1])
            {
                Console.WriteLine($"{nums[1]} is bigger");
            }
            else
            {
                Console.WriteLine($"The Two numbers are equal");
            }
            #endregion

            /*
             * Write a program that allows the user to insert an integer then print negative if it
             * is negative number otherwise print positive.
             */
            #region Q4
            Console.Write("Enter a number to Know if its a negative or positive: ");
            int x = int.Parse(Console.ReadLine());
            if (x == 0)
            {
                Console.WriteLine("The number is zero");
            }
            else
            {
                Console.WriteLine((x < 0) ? "Negative" : "Positive");
            }
            #endregion

            /* Write a program that takes 3 integers from the user then prints 
             * the max element and the min element.
             */
            #region Q5
            Console.Write("Enter a list of 3 Numbers seperated by space: ");
            List<int> numpers = new List<int>();
            numpers = Console.ReadLine().Split().Select(s => int.Parse(s)).ToList();
            Console.WriteLine($"The max: {numpers.Max()}");
            Console.WriteLine($"The min: {numpers.Min()}");
            #endregion


            /*
             * Write a program that allows the user 
             * to insert an integer number then check If a number is even or odd.
             */
            #region Q6
            Console.Write("Enter an integer number: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine((y % 2 == 0) ? "Even" : "Odd");
            #endregion

            /*
             * Write a program that takes character from the user then if it 
             * is a vowel chars (a,e,i,o,u) then print (vowel) otherwise print (consonant).
             */
            #region Q7
            List<char> chars = new List<char> { 'a', 'o', 'i', 'y', 'u' };
            Console.WriteLine("Enter a character to check if its vowel or consonent: ");
            Console.WriteLine((chars.Contains(char.Parse(Console.ReadLine()))) ? "vowel" : "Consonent");
            #endregion

            /*
             * Write a program that allows the user to insert an integer then 
             * print all numbers between 1 to that number.
             */
            #region Q8
            Console.Write("Enter number: ");
            int flag = int.Parse(Console.ReadLine());
            for (int i = 0; i < flag + 1; i++)
            {
                Console.Write(i);
                Console.Write(',');
            }
            #endregion

            /*
             * Write a program that allows the user to insert an integer then print 
             * a multiplication table up to 12.
             */
            #region Q9
            Console.Write("Enter number: ");
            int numberQ9 = int.Parse(Console.ReadLine());
            for (int i = 0; i < 13; i++)
            {
                Console.Write(numberQ9 * i);
                Console.Write(' ');
            }
            #endregion

            /*
             * Write a program that allows to user to insert number then print all even 
             * numbers between 1 to this number
             */
            #region Q10
            Console.Write("Enter number: ");
            int numberQ10 = int.Parse(Console.ReadLine());
            for (int i = 1; i < numberQ10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            #endregion

            /*
             * Write a program that takes two integers then prints the power.
             */
            #region Q11
            Console.Write("Enter Two numbers The Second One is the power: ");
            char[] numbers = Console.ReadLine().ToArray();
            int numberQ11a = Convert.ToInt32(numbers[0]), numberQ11b = Convert.ToInt32(numbers[1]);

            Console.WriteLine($"The result of {numberQ11a} Power {numberQ11b} = {numberQ11a ^ numberQ11b}");
            #endregion

            /*
             * Write a program to enter marks of five subjects and calculate total, average and percentage.
             */
            #region Q12 
            Console.Write("Enter Marks of five subjects (Space between them): ");
            List<int> marks = Console.ReadLine().Split().Select(s => int.Parse(s)).ToList();
            Console.WriteLine($"Total marks: {marks.Sum()}");
            Console.WriteLine($"Average Marks: {marks.Average()}");
            Console.WriteLine($"Percentage: {marks.Sum()}%");
            #endregion

            /*
             * Write a program to input the month number and print the number of days in that month.
             */
            #region Q13
            Console.Write("Month Number: ");
            int MonthNumber = Convert.ToInt32(Console.ReadLine());
            switch (MonthNumber)
            {
                case 1:
                    Console.WriteLine(31);
                    break;
                case 2:
                    Console.WriteLine(28);
                    break;
                case 3:
                    Console.WriteLine(30);
                    break;
                case 4:
                    Console.WriteLine(31);
                    break;
                case 5:
                    Console.WriteLine(30);
                    break;
                case 6:
                    Console.WriteLine(31);
                    break;
                case 7:
                    Console.WriteLine(30);
                    break;
                case 8:
                    Console.WriteLine(31);
                    break;
                case 9:
                    Console.WriteLine(30);
                    break;
                case 10:
                    Console.WriteLine(31);
                    break;
                case 11:
                    Console.WriteLine(30);
                    break;
                case 12:
                    Console.WriteLine(31);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            #endregion


            /*
             * Write a program to input marks of five subjects Physics, Chemistry, Biology, Mathematics and Computer, And Calculate percentage and grade.
             * Solution:
             *      first we need 5 list, for each subject list and then we list user to enter 5 marks for everySubject and then show the marks and grade for each subject
             */
            #region Q14
            string[] subject = { "Physics", "Chemistry", "Biology", "Mathematics", " Computer" };
            double[] mark = new double[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter Five marks of {subject[i]}");
                switch (subject[i])
                {
                    case "Physics":
                        mark[i] = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList().Average();
                        break;
                    case "Chemistry":
                        mark[i] = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList().Average();
                        break;
                    case "Biology":
                        mark[i] = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList().Average();
                        break;
                    case "Mathematics":
                        mark[i] = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList().Average();
                        break;
                    case "Computer":
                        mark[i] = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList().Average();
                        break;
                    default:
                        Console.WriteLine("Inavalid Input");
                        break;

                }
            }
            for (int i = 0; i < 5; i++)
            {
                if (mark[i] >= 90)
                {
                    Console.WriteLine($"The Grade of {subject[i]} IS: A");
                }
                else if (mark[i] >= 80)
                {
                    Console.WriteLine($"The Grade of {subject[i]} IS: B");
                }
                else if (mark[i] >= 70)
                {
                    Console.WriteLine($"The Grade of {subject[i]} IS: C");
                }
                else if (mark[i] >= 60)
                {
                    Console.WriteLine($"The Grade of {subject[i]} IS: D");
                }
                else if (mark[i] >= 40)
                {
                    Console.WriteLine($"The Grade of {subject[i]} IS: E");
                }
                else
                {
                    Console.WriteLine($"The Grade of {subject[i]} IS: F");
                }
            }
            #endregion



            /*
             * Write a program to check whether a number is positive or negative or zero.
             */
            #region Q15

            Console.Write("Enter a Number: ");

            int numberQ15 = Convert.ToInt32(Console.ReadLine());

            if (numberQ15 < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else if (numberQ15 > 0)
            {
                Console.WriteLine("the number is positive");
            }
            else
            {
                Console.WriteLine("The number is Zero");
            }

            #endregion

            /*
             * Write a program to create a Simple Calculator.
             */
            #region Q16

            string[] operation = { "Addition", "Subtraction", " Multiplication", " Division" };
            Console.WriteLine("Enter the Nubmer of Operatoin you want to apply(1-4): ");
            for (int i = 0; i < operation.Length; i++)
            {
                Console.WriteLine($"{i}. {operation[i]}");
            }
            Console.Write("Enter Number: ");
            int choise = int.Parse(Console.ReadLine());
            if (choise < 1 || choise > operation.Length)
            {
                Console.WriteLine("Invalid Input");
            }
            else
            {
                Console.Write("Enter First Operand: ");
                double first_operand = double.Parse(Console.ReadLine());
                Console.Write("Enter Second Operand: ");
                double Second_operand = double.Parse(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        Console.WriteLine($"The result of {first_operand} + {Second_operand}={first_operand + Second_operand}");
                        break;
                    case 2:
                        Console.WriteLine($"The result of {first_operand} - {Second_operand}={first_operand - Second_operand}");
                        break;
                    case 3:
                        Console.WriteLine($"The result of {first_operand} * {Second_operand}={first_operand * Second_operand}");
                        break;
                    case 4:
                        Console.WriteLine($"The result of {first_operand} / {Second_operand}={first_operand / Second_operand}");
                        break;
                }
            }
            #endregion


            /*
             * Write a program to allow the user to enter a string and print the REVERSE of it.
             */
            #region Q17

            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            foreach (char item in word.Reverse())
            {
                Console.Write(item);
            }

            #endregion


            /*
             * Write a program to allow the user to enter int and print the REVERSED of it.
             */

            #region Q18
            Console.Write("Enter a a number: ");
            int numberQ18 = int.Parse(Console.ReadLine());



            #endregion

            /*
             * Write a program in C# Sharp to find the sum of all elements of the array
             */
            #region Q19
            int[] numbersQ19 = { 1, 2, 3, 4, 5, 6, 9, 8, 7 };
            int sum = 0;
            foreach (int j in numbersQ19)
            {
                sum += j;
            }
            Console.WriteLine($"The sume of the arrey = {sum}");
            #endregion

            /*
             * Write a program in C# Sharp to count a total number of duplicate elements in an array.
             */
            #region Q20
            int[] numbersQ20 = { 1, 2, 5, 9, 8, 6, 5, 4, 3, 2, 7, 8 };
            int dublicate = 0;
            for (int j = 0; j < numbersQ20.Length; j++)
            {
                int d = 0;
                foreach (int item in numbersQ20)
                {
                    if (item == numbersQ20[j])
                    {
                        d++;
                    }
                }
                if (d > 1)
                {
                    dublicate++;
                }
            }

            #endregion


            /*
             * Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
             */
            #region Q21

            int[] ls1 = { 1, 2, 3, 4, 5, 6 };
            int[] ls2 = { 7, 8, 9, 10, 11, 12 };
            ls1 = ls1.Concat(ls2).ToArray();
            Array.Sort(ls1);
            foreach (int j in ls1)
            {
                Console.Write(j + " ");
            }
            #endregion


            /*
             * Write a program in C# Sharp to count the frequency of each element of an array.
             */
            #region Q22
            int[] freq = { 1, 9, 5, 1, 2, 3, 6, 5, 4, 7, 8, 5, 6, 9, 8, 5, 56, 1, 8 };
            int[] notFreq = new int[] { };
            int[] NumOfFreq = new int[] { };
            for (int i = 0; i < freq.Length; i++)
            {
                if (!notFreq.Contains(freq[i]))
                {
                    Console.WriteLine(notFreq.Contains(freq[i]));
                    notFreq = notFreq.Append(freq[i]).ToArray();
                    NumOfFreq = NumOfFreq.Append(1).ToArray();

                }
                else
                {
                    int index = Array.IndexOf(notFreq, freq[i]);
                    NumOfFreq[index]++;
                }

            }
            for (int j = 0; j < notFreq.Length; j++)
            {
                Console.WriteLine($"Number {notFreq[j]} has frquant {NumOfFreq[j]} Times");
            }
            #endregion


            /*
             * Write a program in C# Sharp to find maximum and minimum element in an array
             */
            #region Q23

            int[] numbersQ23 = { 42, 17, 89, 33, 56, 22, 98, 11, 74, 5 };
            int max = int.MinValue;
            int min = int.MaxValue;
            foreach (int item in numbersQ23)
            {
                if (item > max)
                {
                    max = item;
                }
                if (item < min)
                {
                    min = item;
                }
            }
            #endregion

            /*
             * Write a program in C# Sharp to find the second largest element in an array.
             */
            #region Q24
            int[] numbersQ24 = { 42, 17, 89, 33, 56, 22, 98, 11, 74, 5 };
            Array.Sort(numbersQ24);
            Console.WriteLine($"The Second Largest element in the array is {numbersQ24[numbersQ24.Length - 2]}");
            #endregion

            /*
             *Consider an Array of Integer values with size N, having values as in this Example
             */
            #region Q25




            #endregion

            /*
             * Given a list of space separated words, reverse the order of the words.
             */
            #region Q26

            Console.Write("Enter a sentence: ");
            string[] sentence = Console.ReadLine().Split().ToArray();
            for (int i = sentence.Length-1; i >=0 ; i--) 
            {
                Console.Write(sentence[i] +" ");
            }

            #endregion








        }

    }
}




















