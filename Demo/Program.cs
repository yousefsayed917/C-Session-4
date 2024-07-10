namespace Demo
{
    internal class Program
    {
        
        #region functions Session 04
        public static void print(string pattern = "#", int count = 7)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(pattern);
            }
        }
        public static void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
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
        static void Main(string[] args)
        {
            #region Session 04
            #region function
            //components            
            //1- prototype          //2- calling            //*name
            //* return type         //* name
            //* body                //*arguments
            //* parameters
            //print("*",5);//passing by order
            //Program.print(/* # , 7 */);//default value
            //print(count: 8, pattern: "@");//passing by name

            #endregion
            #region Nullable Value Type
            //Nullable<int> x;//allow null for in (int value + null)
            //int? age; //syntax suger 
            //age = null; 

            #endregion
            #region How To Work With Nullbale ValueType
            //int a = 5;//only value
            //int? b;//value + null
            //b = a; //implicit casting
            //int? k = null; //value + null
            //int l = 20;//value
            //l = (int)k;//explicit casting
            ////----------------------
            //if (k!=null)
            //    l = (int)k;
            //else
            //    l = 0;
            ////------------
            //l = k.HasValue ? k.Value : l; // ternary
            ////------------
            //l = k ?? 0;//coleasing operator // syntax suger
            #endregion
            #region Null Propagation Operator
            //double x = default;
            //int[]? Numbers = default;
            //for (int i = 0;(Numbers!=null)&& (i <Numbers.Length); i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}
            ////---------------
            //if (Numbers != null)
            //{
            //    for (int i = 0;i < Numbers?.Length; i++)
            //    {
            //        Console.WriteLine(Numbers[i]);
            //    }
            //}
            ////----------------
            //int length = Numbers?.Length ?? 0;//Coleasing Operator


            #endregion
            #region Passing By Value
            //int a = 3, b = 5;
            //Console.WriteLine("before swaping");
            //Console.WriteLine(a);//3
            //Console.WriteLine(b);//5
            //swap(a, b);//doesn't work should pass by reference
            //swap(ref a, ref b);//passing by reference
            //Console.WriteLine("after swaping");
            //Console.WriteLine(a);//3
            //Console.WriteLine(b);//5
            #endregion
            #region Passing By Reference
            //int[] Numbers = { 1, 2, 3 };
            //int result = SumArr(Numbers);
            //passing numbers with out (ref)and the change of 
            //element [0]will execute because array is reference type
            //Console.WriteLine(result);// 105
            //int result = SumArr(ref Numbers); //change the array with aother array
            //Console.WriteLine(result);//1

            #endregion
            #endregion
        }
    }
}
