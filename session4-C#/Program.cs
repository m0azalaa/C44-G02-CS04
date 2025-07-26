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
            #endregion
        }
    }
}
