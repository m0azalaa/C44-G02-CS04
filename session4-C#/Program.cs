namespace session4_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C44-G02-CS04
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
        }
    }
}
