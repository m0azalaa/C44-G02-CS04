namespace session4_C_
{
    internal class Program
    {
        
        #region Q1
        // Passing By Value Type
        static void swap(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        //Passing By Value Type
        static void SwapByRef(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        #endregion

        #region Q2
        
        //Passing Parameters Refrence Type : (By Value , By Refrence)
        //By Value in Refrence Type :
        static int SumArrayByValue(int[] arr)
        { //returns the sum of array
            int sum = 0;
            arr = new int[] { 10, 20, 30 }; //this is changing the refrence (Oobject)
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        //By Refrence in Refrence Type :
        static int SumArrayByRefrence(ref int[] arr)
        { //returns the sum of array
            int sum = 0;
            arr = new int[] { 10, 20, 30 }; //this is changing the refrence (Oobject)
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        #endregion

        static void Main(string[] args)
        {
            #region Q1
            //1.Passing By Value Type : is passing variable form ValueType is like sending a copy of our variables in the function
            // that's why the main value of a,b doesn't chang
            //Passing By Value :
            //nothing will change in values
            int a = 4, b = 5;
            Console.WriteLine($"A : {a}"); //4
            Console.WriteLine($"B : {b}"); //5
            Console.WriteLine("----After Swap----");
            swap(a, b);
            Console.WriteLine($"A : {a}"); //4
            Console.WriteLine($"B : {b}"); //5

            //2. Passing By Refrence Type: here u r not giving function copy of value but the real numbers 
            //so the numbers will change here
            //it's the same syntax but with adding 'ref' before declaring the function


            int ra = 4, rb = 5;
            Console.WriteLine($"A : {ra}"); //4
            Console.WriteLine($"B : {rb}"); //5
            Console.WriteLine("----After Swap By Refrence----");
            SwapByRef(ref ra, ref rb);
            //here the function changed the Values
            Console.WriteLine($"A : {ra}"); //5
            Console.WriteLine($"B : {rb}"); //4

            #endregion


        }
    }
}
