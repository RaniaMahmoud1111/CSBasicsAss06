using System.ComponentModel;
using System.Xml.Linq;

namespace CSBasicsAss06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

            // // first Reference type parameters : means it will stored in both stack and heap ,
            // // here passing by value : means pass a copy of the reference . 
            // //passing by reference : means pass the original reference .

            // // the difference between (two types of the passing ) not appear if (the passed reference and the original reference )access or modify the same object 
            // // so i will provide a clear example to show the difference 
            //  // example 
            //  static long SumMyElements(int[] arr)
            // {long sum = 0;
            //     arr = new int[] {100,200,300};
            //     for (int i = 0; i < arr?.Length; i++)
            //     {
            //         sum += arr[i];
            //     }
            //     return sum;
            // }

            // int[] nums = { 1, 2, 3 };
            //long res= SumMyElements(nums);// pass by value : pass the reference to that array not the array it self 
            // Console.WriteLine(res);//600
            // Console.WriteLine(nums[0]);//1

            // static long SumMyElements2( ref int[] arr)
            // {
            //     long sum = 0;
            //     arr = new int[] { 100, 200, 300 };
            //     for (int i = 0; i < arr?.Length; i++)
            //     {
            //         sum += arr[i];
            //     }
            //     return sum;
            // }

            // int[] nums2 = { 1, 2, 3 };

            // long res2 = SumMyElements2(ref nums2 );// pass by reference : pass the array it self 
            // Console.WriteLine(res2);//600
            // Console.WriteLine(nums2[0]);//100 and the old values of the array become garbge after assign new arr in the function above 


            #endregion


            #region 2 - Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //// using out parameters 
            //static void  GetSumAndSub1(int n1, int n2,out long sum, out int sub)
            //{
            //     sum = n1 + n2;
            //      sub = n1 - n2;
            //}

            //// onther way using anonymous object 

            //static object GetSumAndSub2(int n1,int n2)
            //{ long sum = n1+ n2;
            //    int sub = n1 - n2;
            //    return new { sum, sub };
            //}


            //// another way using the tuple 

            //static (long , int) GetSumAndSub3(int n1, int n2)
            //{
            //    long sum = n1 + n2;
            //    int sub = n1 - n2;
            //    return ( sum, sub );
            //}

            #endregion

        
        
        
        
        
        }
    }
}
