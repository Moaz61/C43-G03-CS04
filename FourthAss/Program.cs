using static System.Formats.Asn1.AsnWriter;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Reflection.Metadata;
using System.Data.Common;
using System.Buffers.Text;
using System.Diagnostics.Metrics;

namespace FourthAss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int size;
            //bool flage;
            //do
            //{
            //    Console.Write("enter size of array: ");
            //    flage = int.TryParse(Console.ReadLine(), out size);
            //} while (!flage || size <= 0);

            //int[] arr1 = new int[size];
            //int[] arr2 = new int[size];
            //int[] arr3 = new int[size * 2];

            //for (int i = 0 ; i < size; i++)
            //{
            //    bool flage2;
            //    do
            //    {
            //        Console.WriteLine($"enter numbers in first array: {i + 1}");
            //        flage2 = int.TryParse(Console.ReadLine(),out arr1[i]);
            //    } while (!flage2);
            //}

            //for (int i = 0; i < size; i++)
            //{
            //    bool flage3;
            //    do
            //    {
            //        Console.WriteLine($"enter numbers in second array: {i + 1}");
            //        flage3 = int.TryParse(Console.ReadLine(), out arr2[i]);
            //    } while (!flage3);
            //}

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr3[i] = arr1[i];
            //}
            //int x = 0;
            //for(int i = arr2.Length ; i < arr3.Length; i++)
            //{
            //    arr3[i] = arr2[x];
            //    x++;
            //}

            //int temp;
            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    for (int j = i + 1; j < arr3.Length; j++)
            //    {
            //        if (arr3[i] > arr3[j])
            //        {
            //            temp = arr3[i];
            //            arr3[i] = arr3[j];
            //            arr3[j] = temp;
            //        }
            //    }
            //}

            //Console.WriteLine("sorted array:");
            //foreach (int num in arr3)
            //{
            //    Console.Write(num);
            //    Console.Write(" ");
            //}
            #endregion

            #region 2- Write a program in C# Sharp to count the frequency of each element of an array.
            //int size;
            //bool flag;
            //do
            //{
            //    Console.Write("enter size of array: ");
            //    flag = int.TryParse(Console.ReadLine(), out size);
            //} while (!flag || size <= 0);

            //int[] arr = new int[size];
            //int[] freq = new int[size];

            //for (int i = 0; i < size; i++)
            //{
            //    bool flag2;
            //    do
            //    {
            //        Console.WriteLine($"enter numbers in first array: {i + 1}");
            //        flag2 = int.TryParse(Console.ReadLine(), out arr[i]);
            //        freq[i] = -1;
            //    } while (!flag2);
            //}

            //int x, y, counter = 0;

            //for (int i = 0; i < size; i++)
            //{
            //    counter = 1;
            //    for (y = i + 1; y < size; y++)
            //    {
            //        if (arr[i] == arr[y])
            //        {
            //            counter++;
            //            freq[y] = 0;
            //        }
            //    }
            //    if (freq[i] != 0)
            //        freq[i] = counter;
            //}

            //Console.WriteLine("frequency array is: ");
            //for (int i = 0; i < size; i++)
            //{
            //    if (freq[i] > 0)
            //        Console.WriteLine($"{arr[i]} repeated {freq[i]} times");
            //}
            #endregion

            #region 3- Write a program in C# Sharp to find maximum and minimum element in an array
            //int size;
            //bool flag;

            //do
            //{
            //    Console.Write("Enter size of array: ");
            //    flag = int.TryParse(Console.ReadLine(), out size);
            //} while (!flag);

            //int [] arr = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    bool flag2;
            //    do 
            //    {
            //        Console.WriteLine($"Enter numbers in array: {i + 1}");
            //        flag2 = int.TryParse(Console.ReadLine(), out arr[i]);
            //    }while (!flag2);
            //}

            //int max = arr[0];
            //int min = arr[0];
            //for (int i = 0 ; i < size ; i++)
            //{
            //    if (max < arr[i])
            //        max = arr[i];
            //    if (min > arr[i])
            //        min = arr[i];
            //}

            //Console.WriteLine($"Max number is: {max}");
            //Console.WriteLine($"Min number is: {min}");
            #endregion

            #region 4- Write a program in C# Sharp to find the second largest element in an array. 
            //int size;
            //bool flage;
            //do
            //{
            //    Console.Write("enter size of array: ");
            //    flage = int.TryParse(Console.ReadLine(), out size);
            //} while (!flage);

            //int[] arr = new int[size];

            //for (int i = 0; i < size; i++)
            //{
            //    bool flage2;
            //    do
            //    {
            //        Console.WriteLine($"enter numbers of array: {i + 1}");
            //        flage2 = int.TryParse(Console.ReadLine(), out arr[i]);
            //    } while (!flage2);
            //}

            //int temp;
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = i + 1; j < size; j++)
            //    {
            //        if(arr[i] > arr[j])
            //        {
            //            temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }
            //}

            //int SecMaxNum = arr[size - 2];
            //Console.WriteLine($"second largest number is: {SecMaxNum}");
            #endregion

            #region 5- Consider an Array of Integer values with size N, having values as in this Example
            //int size;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("enter size of array: ");
            //    flag = int.TryParse(Console.ReadLine(), out size);
            //} while (!flag);

            //int[] arr = new int[size];

            //for (int i = 0; i < size; i++)
            //{
            //    bool flag2;
            //    do
            //    {
            //        Console.WriteLine($"enter number in array {i + 1}");
            //        flag2 = int.TryParse(Console.ReadLine(), out arr[i]);
            //    } while (!flag2);
            //}

            //int distance = 0;
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = i + 1; j < size; j++)
            //    {
            //        if (arr[i] == arr[j])
            //            if (distance < j - i - 1) 
            //                distance = j - i - 1;
            //    }
            //}
            //Console.WriteLine($"Distance = {distance}");
            #endregion

            #region 6- Given a list of space separated words, reverse the order of the words
            //string txt;
            //bool flag;

            //do
            //{
            //    Console.WriteLine("enter txt: ");
            //    txt = Console.ReadLine();
            //    flag = string.IsNullOrWhiteSpace (txt);
            //}while (flag);

            //string result = "";
            //string[] str = txt.Split(" ");

            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    result += str[i] + " ";
            //}

            //Console.WriteLine(result);
            #endregion

            #region 7- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array
            //int rows, cols , num;
            //bool flag1 , flag2 , flag3;
            //do
            //{
            //    Console.WriteLine("enter rows: ");
            //    flag1 = int.TryParse(Console.ReadLine(), out rows);
            //} while (!flag1);

            //do
            //{
            //    Console.WriteLine("enter colums: ");
            //    flag2 = int.TryParse(Console.ReadLine(), out cols);
            //} while (!flag2);


            //int[,] arr1 = new int[rows, cols];
            //int[,] arr2 = new int[rows, cols];

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        do
            //        {
            //            Console.Write($"enter value of first array [{i + 1}, {j + 1}]: ");
            //            flag3 = int.TryParse(Console.ReadLine(), out num);
            //        } while (!flag3);

            //        arr1[i, j] = num;
            //    }
            //}

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        arr2[i, j] = arr1[i, j];
            //    }
            //}

            //Console.WriteLine("second array is: ");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(arr2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region 8- Write a Program to Print One Dimensional Array in Reverse Order 
            //int size;
            //bool flage;
            //do
            //{
            //    Console.Write("enter size of array: ");
            //    flage = int.TryParse(Console.ReadLine(), out size);
            //} while (!flage);


            //int[] arr = new int[size];

            //for (int i = 0; i < size; i++)
            //{
            //    bool flage2;
            //    do
            //    {
            //        Console.WriteLine($"enter numbers of array: {i + 1}");
            //        flage2 = int.TryParse(Console.ReadLine(), out arr[i]);
            //    } while (!flage2);
            //}

            //for (int i = size - 1; i>=0 ; i--)
            //{
            //    Console.Write(arr[i]);
            //    Console.Write(" ");
            //}
            #endregion

            #region 9-Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example
            //// paas by value
            //static int Modify(int num)
            //{
            //    num = 20;
            //    return num;
            //}

            //int x = 10;
            //Modify(x);
            //Console.WriteLine($"before reference: {x}");

            //// paas by reference
            //static int Modify1(ref int Num)
            //{
            //    Num = 20;
            //    return Num;
            //}

            //int y = 10;
            //Modify1(ref y);
            //Console.WriteLine($"after reference: {y}");
            #endregion

            #region 10-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example
            ////difference when I change the object and assign it to a new object
            ////Passing By Value
            //static void Fun1(int[] arr)
            //{
            //    if (arr == null)
            //        return;
            //    arr = new int[] { 100, 200, 300 };

            //}

            ////Passing By Reference
            //static void Fun2(ref int[] arr)
            //{
            //    if (arr == null)
            //        return;
            //    arr = new int[] { 100, 200, 300 };
            //}


            //int[] arr = { 1, 2, 3};
            //Fun1(arr);
            //for (int i = 0; i < arr.Length; i++) 
            //    Console.WriteLine($"passing by value array: {arr[i]}");

            //int[] arr1 = {5 , 6 , 7};
            //Fun2(ref arr1);
            //for (int i = 0; i < arr1.Length; i++)
            //    Console.WriteLine($"passing by reference array: {arr1[i]}");
            #endregion

            #region 11-Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //static void SumSub(int x, int y, out int sum, out int sub)
            //{
            //    sum = x + y;
            //    sub = x - y;
            //}


            //int x, y, sum, sub;
            //bool flage1, flage2;
            //do
            //{
            //    Console.WriteLine("enter first number: ");
            //    flage1 = int.TryParse(Console.ReadLine(), out x);
            //} while (!flage1);

            //do
            //{
            //    Console.WriteLine("enter second number: ");
            //    flage2 = int.TryParse(Console.ReadLine(), out y);
            //} while (!flage2);

            //SumSub(x, y , out sum , out sub);
            //Console.WriteLine($"summition is: {sum}");
            //Console.WriteLine($"subtraction is: {sub}");
            #endregion

            #region 12-Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number
            //static int SumDigit(int num)
            //{
            //    int result = 0;
            //    while (num > 0)
            //    {
            //        result += num % 10;
            //        num /= 10;
            //    }
            //    return result;
            //}

            //int num;
            //bool flag;

            //do 
            //{
            //    Console.WriteLine("enter number to get sum of it's digits: ");
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //}
            //while (!flag);

            //Console.WriteLine($"sum of digits: {SumDigit(num)}");
            #endregion

            #region 13-Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not
            //static bool IsPrime(int num)
            //{
            //    if (num <= 1)
            //        return false;
            //    for (int i = 2; i < num; i++)
            //    {
            //        if (num % i == 0)
            //            return false;
            //    }
            //    return true;
            //}

            //int num;
            //bool flag;

            //do
            //{
            //    Console.WriteLine("enter number: ");
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //}
            //while (!flag);

            //bool prime = IsPrime(num);
            //if (prime)
            //    Console.WriteLine("number is prime");
            //else
            //    Console.WriteLine("number is not prime");

            #endregion

            #region 14-Create a function named MinMaxArray, to return the minimum and  maximum values stored in an array, using reference parameters
            //static void MinMaxArray (ref int[]arr , out int max , out int min)
            //{
            //    max = arr[0];
            //    min = arr[0];

            //    for(int i = 0; i<arr.Length; i++)
            //    {
            //        if (arr[i] > max)
            //            max = arr[i];
            //        if (arr[i] < min)
            //            min = arr[i];
            //    }
            //}

            //int size;
            //bool flag;
            //do
            //{
            //    Console.Write("enter size of array: ");
            //    flag = int.TryParse(Console.ReadLine(), out size);
            //} while (!flag || size <= 0);

            //int[] arr = new int[size];

            //for (int i = 0; i < size; i++)
            //{
            //    bool flag2;
            //    do
            //    {
            //        Console.WriteLine($"enter numbers in array: {i + 1}");
            //        flag2 = int.TryParse(Console.ReadLine(), out arr[i]);
            //    } while (!flag2);
            //}

            //int max, min;
            //MinMaxArray(ref arr, out max, out min);

            //Console.WriteLine($"max num in array: {max}");
            //Console.WriteLine($"min num in array: {min}");
            #endregion

            #region 15-Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //static int Factorial (int num)
            //{
            //    int result = 1;
            //    for (int i = 1; i <= num; i++)
            //    {
            //        result *= i;
            //    }
            //    return result;
            //}

            //int num;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("enter number to calculate factorial: ");
            //    flag = int.TryParse(Console.ReadLine(), out num);
            //} while (!flag);

            //Console.WriteLine(Factorial(num));
            #endregion

            #region 16-Create a function named "ChangeChar" to modify a letter in a certain position(0 based) of a string, replacing it with a different letter
            //static string ChangeChar(string str, int position, char newChar)
            //{
            //    if (position < 0 || position > str.Length)
            //        throw new ArgumentOutOfRangeException(nameof(position), "position is out of range");

            //    char[] chars = str.ToCharArray();
            //    chars[position] = newChar;
            //    return new string(chars);
            //}

            //Console.WriteLine(ChangeChar("moaz", 3, 'h'));
            
            #endregion

        }
    }
}
