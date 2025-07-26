using System.Text;

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

        #region Q4
        static int sum(int num)
        {
            int sum = 0;
            string numstr = num.ToString();
            foreach (char Chardigit in numstr)
            {
                int intDigit = int.Parse(char.ToString(Chardigit));
                sum += intDigit;
            }
            return sum;
        }
        #endregion

        #region Q5 
        static bool isprime(int input)
        {
            for (int i = 2; i <= input / 2; i++)
            {
                if (input % i == 0)
                    return false;
            }
            return true;
        }
        #endregion

        #region Q6 
        static void MinMaxArray(int[] arr, ref int min, ref int max)
        {
            max = arr[0];
            min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min : {min}");
        }
        #endregion

        #region Q7
        static void Factorial(int n)
        {
            int sumf = 1;
            for (int i = 1; i <= n; i++)
            {
                sumf *= i;
                Console.Write($"{i}, ");
            }
            Console.WriteLine(sumf);
        }
        static void ChangeChar(string word, char n, int index)
        {
            StringBuilder newword = new StringBuilder(word);
            newword[index] = n;
            Console.WriteLine(newword);
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

            #region Q4
            Console.Write("Enter a number: ");
            int.TryParse(Console.ReadLine(), out int userNumber);

            int result = sum(userNumber);
            Console.WriteLine(result);
            #endregion

            #region Q5
            Console.WriteLine("enter number: ");
            int.TryParse(Console.ReadLine(), out int number);
            Console.WriteLine(isprime(number));
            #endregion

            #region Q6 
            int[] nums = { 1, 2, 34, 4, 5, 77, 5, 10, 0, 3, 8 };

            int min = 0, max = 0;
            MinMaxArray(nums, ref min, ref max);
            #endregion

            #region Q7

            Console.WriteLine("inter num: ");
            int.TryParse(Console.ReadLine(), out int nn);
            Factorial(nn);
            #endregion

            #region Q8
            ChangeChar(word:"this Word",n:'X',index:5);

            #endregion

            #region Q9
            for (int j = 1; j <= 3; j++) //for colums
            {
                for (int i = 1; i <= 3; i++)
                {
                    if (j == i) Console.Write("1 "); // .Write > for making them in one line 0 0 0
                    else Console.Write("0 ");                     //this forloop for the row 0 0 0 : we need to repeat this in 3 colums

                }
                Console.WriteLine(); //for making new line
            }
            #endregion

            #region Q10 Write a program in C# Sharp to find the sum of all elements of the  array.
            bool flag;
            int size;

            do
            {
                Console.WriteLine("Enter the size of Array: ");
                flag = int.TryParse(Console.ReadLine(), out size);
            } while (flag == false || size < 1);

            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the Elemnt of array: ");
                flag = int.TryParse(Console.ReadLine(), out numbers[i]);
            } while (flag == false) ;

            int sum = 0;
            for (int j = 0; j < size; j++)
            {
                sum += numbers[j];
            }
            Console.WriteLine(sum);
            #endregion

            #region Q12 12- Write a program in C# Sharp to find maximum and minimum element in an array
            int[] nummbers = { 1, 2, 3, 4, 5, 6, 10, 20, 34, 0 };
            int max = nummbers[0];
            int min = nummbers[0];
            for (int i = 0; i < nummbers.Length; i++)
            {
                if (nummbers[i] > max) max = nummbers[i];
                if (nummbers[i] < min) min = nummbers[i];
            }
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min : {min}");
            #endregion


            #region 13- Write a program in C# Sharp to find the second largest element in an array.
            int size;
            bool flag;
            //for taking the size of array without exceptions 
            do
            {
                Console.WriteLine("Enter the size of array: ");
                flag = int.TryParse(Console.ReadLine(), out size);
            } while (flag == false);
            int[] numbers = new int[size];
            //for taking the  the elements Of array:
            for (int i = 0; i < size; i++)
            {
                do
                {
                    Console.WriteLine("Enter the elements Of array: ");
                    flag = int.TryParse(Console.ReadLine(), out numbers[i]);
                } while (flag == false);
            }
            Array.Sort(numbers); //Asc sort
            Array.Reverse(numbers);//Desc Sort
            Console.WriteLine(numbers[1]);
            #endregion
        }
    }
}
