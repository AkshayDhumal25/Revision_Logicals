// 1. WAP to find Second largest element in an array : arr[] = [12, 35, 1, 10, 34, 1, 35], without
// sorting, without using any built-in methods and without deleting duplicate elements. What will be
// the time complexity?
// using System;
// namespace logicals{
//     class Program{
//         public static void Main(string[] args){
//             int[] array = {12, 35, 1, 10, 34, 1, 35};
//             int large =0;
//             int secLarge =0;
//             for(int i =0;i<array.Length;i++){
//                 if(array[i] > large){
//                     secLarge = large;
//                     large = array[i];
//                 }
//                 if(array[i] < large && array[i] > secLarge){
//                     secLarge = array[i];
//                 }
//             }
//             Console.WriteLine(secLarge);
//         }
//     }
// }


// 2. WAP to reverse an integer without converting it to a string, without using any built-in methods.
// using System;
// namespace logicals{
//     class Program{
//         public static void Main(string[] args){
//             int n = 123;
//             int reversed = 0;
//             while(n>0){
//                 int reminder = n % 10;
//                 reversed = reversed * 10+reminder;
//                 n /= 10;
//             }
//             Console.WriteLine(reversed);
//         }
//     }
// }


// 2. Swap Values without using any variable a=10, b=12.
// using System;
// namespace logicals{
//     class Program{
//         public static void Main(string[] args){
//             int a = 10;
//             int b = 12;
//             a = a +b;
//             b = a - b;
//             a = a -b;

//             Console.WriteLine(a + " " + b);
//         }
//     }
// }

// 3. Logic for anagram program with its time complexity. (for large strings).
// using System;
// namespace logicals{
//     class Programs{
//         public static void Main(string[] args){
//             string str1 = "silent";
//             string str2 = "listem";
//             if(isAnagram(str1, str2)){
//                 Console.WriteLine("Anagram");
//             }else{
//                 Console.WriteLine("Not Anagram");
//             }
//         }

//         public static bool isAnagram(string str1, string str2){
//             if(str1.Length != str2.Length) return false;
//             int[] array = new int[255];
//             for(int i=0;i<str1.Length;i++){
//                 array[str1[i]]++;
//                 array[str2[i]]--;
//             }
//             foreach(var i in array){
//                 if(i != 0){
//                     return false;
//                 }
//             }
//             return true;

//         }
//     }
// }

// 
//4. Find the reverse of the string.
// using System;
// using System.Collections.Generic;
// using System.Linq;
// namespace logicals{
//     class Program{
//         public static void Main(string[] args){
//             string str = "Akshay";
//             string reversed = new string(str.Reverse().ToArray());
//             //reversed.ToString();

//             Console.WriteLine(reversed);
//         }
//     }
// }

// 5. WAP to find missing elements from the array?
// using System;
// using System.Linq;
// using System.Collections.Generic;
// namespace logicals{
//     class Program{
//         public static void Main(string[] args){
//             int[] array = {1,2,3,4,6,8,9,10};
//             int min = array.Min();
//             int max = array.Max();

//             var list = new List<int>(array);

//             for(int i=min;i<max;i++){
//                 if(! list.Contains(i)){
//                     Console.WriteLine(i + " ");
//                 }
//             }
//         }
//     }
// }

// 6. WAP to find the given string is Palindrome or not.
// using System;
// namespace logicals{
//     class Program{
//         public static void Main(string[] args){
//             string str = "aabba";
//             if(isPalindrome(str)){
//                 Console.WriteLine("Palindrome");
//             }else{
//                 Console.WriteLine("Not Palindrome");
//             }
//         }

//         public static bool isPalindrome(string str){
//             int left =0;
//             int right = str.Length-1;

//             while(left < right){
//                 if(str[left] != str[right]){
//                     return false;
//                 }
//                 left++;
//                 right--;

//             }
//             return true;
//         }
//     }
// }

// 7. WAP to print Fibonacci series with recursion.
// using System;
// namespace logicals{
//     class Program{
//         public static void Main(string[] args){
//             Console.WriteLine("Enter the number : ");
//             int n = Convert.ToInt32(Console.ReadLine());

//             for(int i=0;i<n;i++){
//                 Console.WriteLine(fibo(i));
//             }
//         }

//         public static int fibo(int n){
//             if(n<=1) return n;

//             return fibo(n-1)+fibo(n-2);
//         }
//     }
// }

// 11. Find prime numbers from 1 ....n
// using System;
// namespace logicals{
//     class Program{
//         public static void Main(string[] args){
//             Console.WriteLine("Enter the number :");
//             int n = Convert.ToInt32(Console.ReadLine());
//             for(int i=0;i<=n;i++){
//                 if(isPrime(i)){
//                     Console.Write(i+ " ");
//                 }
//             }
//         }
//         public static bool isPrime(int n){
//             if(n <=1) return false;
//             //if(n == 2) return true;

//             for(int i=2;i*i<=n;i++){
//                 if(n % i ==0){
//                     return false;
//                 }
//             }
//             return true;
//         }
//     }
// }



// 17. find the frequency of each and every character in a string and sort it in descending
// order.
// Input: Engineer
// Output : e3n2g1i1r1

//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            string str = "Akshay";

//            int[] count = new int[255];

//            for (int i = 0; i < str.Length; i++)
//            {
//                count[str[i]]++;
//            }

//            for (int i = 0; i < count.Length; i++)
//            {
//                if (count[i] > 0)
//                {
//                    Console.WriteLine($"{(char)i} : {count[i]}");
//                }
//            }
//        }
//    }
//}


// 19. count lowercase and uppercase
// input = &quot;Hello world!&quot;
// output = uppercase = 1, lowercase = 9
using System;
using System.Collections.Generic;
using System;
namespace logicals
{
    class Program
    {
        public static void Main(string[] args)
        {
            string str = "Hello World";
            int upperCount = 0;
            int lowerCount = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    upperCount++;
                }
                if (char.IsLower(str[i]))
                {
                    lowerCount++;
                }
            }

            Console.WriteLine($"UpperCount : {upperCount} and LowerCount : {lowerCount}");
        }
    }
}
















