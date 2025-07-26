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

        #region Q3
        static void accept(int a, int b, int c, int d)
        {
            int sum = a + b;
            int sub = c - d;
            Console.WriteLine($"Sum : {sum}");
            Console.WriteLine($"sub : {sub}");
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

            #region Q2
            // 2- Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            //By Value Type
            int[] Numbers = { 1, 2, 3 };
            Console.WriteLine(SumArrayByValue(Numbers)); //60 he's cont the numbers in the function
            Console.WriteLine(Numbers[0]); //1 : it's the same doesn't changed

            Console.WriteLine("==============================");

            //Passing By Refrence in Refrence Type : u sending the numbers
            int[] Numbers02 = { 1, 2, 3 };
            Console.WriteLine(SumArrayByRefrence(ref Numbers02)); //60
            Console.WriteLine(Numbers02[0]); //10 this's changed 
            #endregion

            #region Q3
            Console.Write("Enter first number: ");
            int.TryParse(Console.ReadLine(), out int num1);

            Console.Write("Enter second number: ");
            int.TryParse(Console.ReadLine(), out int num2);

            Console.Write("Enter third number: ");
            int.TryParse(Console.ReadLine(), out int num3);

            Console.Write("Enter fourth number: ");
            int.TryParse(Console.ReadLine(), out int num4);

            accept(num1, num2, num3, num4);

            #endregion
        }
    }
}
