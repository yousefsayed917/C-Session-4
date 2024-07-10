namespace Assignment
{
    internal class Program
    {
        #region func Assignment 4
        #region func Q1
        public static void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        #endregion
        #region func Q2
        public static int SumArr(ref int[] arr)
        {
            int sum = 0;
            //arr[0] = 100;
            arr = new int[] { 4, 5, 6 };
            if (arr != null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
        #endregion
        #region func Q3
        public static (int, int) SumAndSub(int num1, int num2, int num3, int num4)
        {
            int sum = num1 + num2;
            int sub = num3 - num4;
            return (sum, sub);
        }
        #endregion
        #region func Q4
        public static int SumOfDigits(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                int x = num % 10;
                sum += x;
                num /= 10;
            }

            return sum;
        }
        #endregion
        #region Func Q5
        public static bool IsPrime(int num)
        {
            int count = 0;
            for (int j = 1; j <= 9; j++)
            {
                if (num % j == 0)
                    count++;
            }
            if (count == 2)
                return true;
            else
                return false;
        }
        #endregion
        #region func Q6
        public static (int, int) MaxMinArray(ref int[] arr)
        {
            int Max = int.MinValue;
            int Min = int.MaxValue;
            foreach (int item in arr)
            {
                if (item > Max)
                    Max = item;
                if (item < Min)
                    Min = item;
            }
            return (Max, Min);
        }
        #endregion
        #region func Q7
        public static int GetFactorial(int num)
        {
            int fac = 1;
            for (int i = 1; i <= num; i++)
            {
                fac *= i;
            }
            return fac;
        }
        #endregion
        #region func Q8
        public static string ChangeChar(ref string s, char NewChar, int Position)
        {
            string x = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (Position < 0 || Position >= s.Length)
                {
                    string Exepssion = " The Position Is Out Of Range ";
                    return Exepssion;
                }
                char[] charArray = s.ToCharArray();
                charArray[Position] = NewChar;
                x = new string(charArray);
            }
            return x;
        }
        #endregion
        #endregion
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
