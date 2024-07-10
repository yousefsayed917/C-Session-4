namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment 4
            #region Q1
            //int a = 3, b = 5;
            //Console.WriteLine("before swaping");
            //Console.WriteLine(a);//3
            //Console.WriteLine(b);//5
            //swap(a, b);//doesn't work  because the main stack frame will delete
            //all changes should pass by reference 
            //swap(ref a, ref b);//passing by reference
            //Console.WriteLine("after swaping");
            //Console.WriteLine(a);//3
            //Console.WriteLine(b);//5
            #endregion
            #region Q2
            //int[] Numbers = { 1, 2, 3 };
            //int result = SumArr(Numbers);
            //passing numbers with out (ref)and the change of 
            // arr[0] will execute because array is reference type
            //Console.WriteLine(result);// 105
            //int result = SumArr(ref Numbers); //create new object of the array with different values
            //Console.WriteLine(result);//1
            #endregion
            #region Q3
            //bool flag;
            //int num1, num2, num3, num4;
            //do
            //{
            //    Console.WriteLine("Enter 2 Numbers To Get Summition");
            //    flag = int.TryParse(Console.ReadLine()!, out num1);
            //    flag = int.TryParse(Console.ReadLine()!, out num2);
            //    Console.WriteLine("Enter 2 Numbers To Get Subtraction");
            //    flag = int.TryParse(Console.ReadLine()!, out num3);
            //    flag = int.TryParse(Console.ReadLine()!, out num4);
            //} while (!flag);
            //(int sum, int sub) = SumAndSub(num1, num2, num3, num4);
            //Console.WriteLine($"{num1}+{num2}={sum}");
            //Console.WriteLine($"{num3}+{num4}={sub}");
            #endregion
            #region Q4
            //bool flag;
            //int num;
            //do
            //{
            //    Console.WriteLine("Enter a Number To Get Summition Of his Digits");
            //    flag = int.TryParse(Console.ReadLine()!, out num);
            //} while (!flag);
            //Console.WriteLine($"The sum of the digits of the num = {SumOfDigits(num)} ");
            #endregion
            #region Q5
            //bool flag;
            //int num;
            //do
            //{
            //    Console.WriteLine("Enter a Number To know If Itis Prime Or Not");
            //    flag = int.TryParse(Console.ReadLine()!, out num);
            //} while (!flag);
            //if (IsPrime(num))

            //    Console.WriteLine("true");
            //else
            //    Console.WriteLine("false");
            #endregion
            #region Q6
            //int[] array = new int[5];
            //bool flag;
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < 5; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine($"Enter element {i + 1}: ");
            //        flag = int.TryParse(Console.ReadLine()!, out array[i]);
            //    } while (!flag);
            //}
            //(int Max, int Min) = MaxMinArray(ref array);
            //Console.WriteLine($"Max element in array = {Max}");
            //Console.WriteLine($"Min element in array = {Min}");
            #endregion
            #region Q7
            //bool flag;
            //int num;
            //do
            //{
            //    Console.WriteLine("Enter a Number To Get The Factorial Of This Number");
            //    flag = int.TryParse(Console.ReadLine()!, out num);
            //} while (!flag);
            //Console.WriteLine($"Factorial Of {num} = {GetFactorial(num)}");
            #endregion
            #region Q8
            //bool flag;
            //string s;
            //int Position;
            //char NewChar;
            //do
            //{
            //    Console.WriteLine("Enter A String To Modify A Letter In A Certain Position");
            //    s = Console.ReadLine()!;
            //    if (s != null)
            //        flag = true;
            //    else
            //        flag = false;
            //    Console.WriteLine("Enter A Position");
            //    flag = int.TryParse(Console.ReadLine()!, out Position);
            //    Console.WriteLine("Enter A New Char");
            //    flag = Char.TryParse(Console.ReadLine()!, out NewChar);
            //} while (!flag);
            //Console.WriteLine($"String Before Modifying {s}");
            //Console.WriteLine($"String After Modifying {ChangeChar(ref s,NewChar,Position)}");
            #endregion
            #endregion
        }
    }
}
