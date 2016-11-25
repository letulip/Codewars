using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_fundamentals
{
    //Dubstep
    //WUBWUB_WUB_WUBWUB_

    public class Dubstep
    {
        public static string SongDecoder(string input)
        {
            
        }

        static void Main()
        {
            Console.WriteLine(SongDecoder(Console.ReadLine()));
            Console.ReadKey();
        }
    }

    //ConsecutiveStrings

    //public class LongestConsecutives
    //{

    //    public static String LongestConsec(string[] strarr, int k)
    //    {
    //        int max = 0;
    //        int maxCount = 0;
    //        string longest = null;

    //        foreach (string str in strarr)
    //        {
    //            if (str.Count() > max)
    //            {
    //                max = str.Count();
    //                maxCount++;
    //            }
    //        }

    //        longest += strarr[max];

    //        return longest;
    //    }
    //}





    //Number of people in bus

    //public class Kata
    //{
    //    public static int Number(List<int[]> peopleListInOut)
    //    {
    //        int[] passangers = new int[2];


    //    }
    //}





    //Vowel Count

    //public static class Kata
    //{
    //    public static int GetVowelCount(string str)
    //    {
    //        int vowelCount = 0;

    //        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

    //        foreach (char ch in str)
    //        {
    //            for (int i = 0; i < vowels.Length; i++)
    //            {
    //                if (ch == vowels[i])
    //                    vowelCount++;
    //            }
    //        }

    //        return vowelCount;
    //    }
    //}





    //Count by X
    //how to output array containings?

    //public static class Kata
    //{
    //    public static int[] CountBy(int x, int n)
    //    {
    //        int[] z = new int[n];
    //        for (int i = 0; i < z.Length; i++)
    //        {
    //            z[i] = (i+1)* x;
    //        }
    //        return z;
    //    }

    //    static void Main()
    //    {
    //        int x = Convert.ToInt32 (Console.ReadLine());
    //        int n = Convert.ToInt32(Console.ReadLine());
    //        Console.WriteLine(CountBy(x,n));
    //        Console.ReadKey();
    //    }
    //}





    //Personalized message

    //public class Kata
    //{
    //    public static string Greet(string name, string owner)
    //    {
    //        string greeteng = null;
    //        if (name == owner)
    //            return "Hello boss";
    //        else
    //            return "Hello guest";
    //    }
    //}





    //Grade book

    //public class Kata
    //{
    //    public static char GetGrade(int s1, int s2, int s3)
    //    {
    //        int score = s1 + s2 + s3;
    //        if (score >= 270)
    //            return 'A';
    //        if (score >= 240)
    //            return 'B';
    //        if (score >= 210)
    //            return 'C';
    //        if (score >= 180)
    //            return 'D';
    //        else
    //            return 'F';
    //    }
    //}





    //Number in words

    //public class Kata
    //{
    //    public static string SwitchItUp(int number)
    //    {
    //        string num = null;
    //        switch (number)
    //        {
    //            case 0:
    //                num = "zero";
    //                break;
    //            case 1:
    //                num = "one";
    //                break;
    //            case 2:
    //                num = "two";
    //                break;
    //            case 3:
    //                num = "three";
    //                break;
    //            case 4:
    //                num = "four";
    //                break;
    //            case 5:
    //                num = "five";
    //                break;
    //            case 6:
    //                num = "six";
    //                break;
    //            case 7:
    //                num = "seven";
    //                break;
    //            case 8:
    //                num = "eight";
    //                break;
    //            case 9:
    //                num = "nine";
    //                break;
    //        }
    //        return num;
    //    }
    //    static void Main()
    //    {
    //        Console.WriteLine(SwitchItUp(Convert.ToInt32(Console.ReadLine())));
    //        Console.ReadKey();
    //    }
    //}





    //XOR Logical operator

    //public class Kata
    //{
    //    public static bool Xor(bool a, bool b)
    //    {

    //        return a ^ b;
    //    }
    //}





    //Math

    //public static class Program
    //{
    //    public static double basicOp(char op, double val1, double val2)
    //    {
    //        double result=0;

    //        if (op == '+')
    //            result = val1 + val2;
    //        if (op == '-')
    //            result = val1 - val2;
    //        if (op == '*')
    //            result = val1 * val2;
    //        if (op == '/')
    //            result = val1 / val2;

    //        return result;
    //    }
    //}





    //double char

    //public class Kata
    //{
    //    public static string DoubleChar(string str)
    //    {
    //        if (str.Length > 0)
    //        {
    //            string[] str1 = new string[str.Length*2];

    //            for (var i = 0; i < str.Length; i++)
    //            {
    //                str1[i] = (str[i] + "" + str[i]);
    //            }

    //            return Convert.ToString(str1);

    //            //works in console only!

    //            //char[] str1 = new char[str.Length * 2];

    //            //for (var i = 0; i < str.Length; i++)
    //            //{
    //            //    Console.Write(str[i] + "" + str[i]);
    //            //}

    //            //string str2 = new string(str1);

    //            //return Convert.ToString(str1);
    //        }
    //        else
    //            return String.Empty;

    //    }
    //    static void Main()
    //    {
    //        Console.WriteLine(DoubleChar(Console.ReadLine()));
    //        Console.ReadKey();
    //    }
    //}





    //Jaden Casing Strings

    //public static class JadenCase
    //{
    //    public static string ToJadenCase(this string phrase)
    //    {
    //        if (phrase.Length > 0)
    //        {
    //            string[] str = phrase.Split(' ');

    //            for (int i = 0; i < str.Length; i++)
    //            {
    //                if (str[i].Length > 1)
    //                    str[i] = str[i].Substring(0, 1).ToUpper() + str[i].Substring(1, str[i].Length - 1).ToLower();
    //                else str[i] = str[i].ToUpper();
    //            }
    //            return string.Join(" ", str);
    //        }
    //        else
    //            return String.Empty;
    //    }

    //    static void Main()
    //    {
    //        Console.WriteLine(ToJadenCase(Console.ReadLine()));
    //        Console.ReadKey();
    //    }
    //}





    //Transportation on vacation

    //public class RentalCar
    //{

    //    public static int RentalCarCost(int days)
    //    {
    //        int cost = 40;
    //        if (days < 3)
    //            return days * cost;
    //        if (days < 7)
    //            return days * cost - 20;
    //        if (days >= 7)
    //            return days * cost - 50;
    //        else
    //            return 0;
    //    }

    //    static void Main()
    //    {
    //        Console.WriteLine(RentalCarCost(Convert.ToInt32(Console.ReadLine())));

    //        Console.ReadKey();
    //    }
    //}





    //Number And Sum Its Digits Raised To The Consecutive Powers from a to b
    //89 = 8^1 + 9^2
    //135 = 1^1 + 3^2 + 5^3

    //public class RaisedSumDigits
    //{
    //    public static long[] SumDigPow(long a, long b)
    //    {



    //        //while (a<=b)
    //        //{

    //        //    for (int i = 0; i < number.Length; i++)
    //        //    {
    //        //        digits[i] = Convert.ToInt64(Math.Pow(digits[i], (i + 1)));
    //        //        sumdigits += digits[i];
    //        //        if (sumdigits == a)
    //        //            sumdigpow[i] = a;
    //        //    }

    //        //    a++;
    //        //}

    //    }

    //    static void Main()
    //    {
    //        long a = Convert.ToInt64(Console.ReadLine());
    //        long b = Convert.ToInt64(Console.ReadLine());
    //        Console.WriteLine(SumDigPow(a,b));
    //        Console.ReadKey();
    //    }
    //}





    //Next perfect square

    //public class NextPerfSqr
    //{
    //    public static long FindNextSquare(long num)
    //    {
    //        int number;

    //        bool result = Int32.TryParse(Convert.ToString( Math.Sqrt(num)), out number);
    //        if (result)
    //        {
    //            return (long)Math.Pow((Math.Sqrt(num) + 1), 2);
    //        }
    //        else
    //        {
    //            return -1;
    //        }

    //    }

    //    static void Main()
    //    {
    //        Console.WriteLine( FindNextSquare (Convert.ToInt64(Console.ReadLine())));
    //        Console.ReadKey();
    //    }
    //}





    //Sum of the first nth term of Series: 1 + 1/4 + 1/7 + 1/10 + 1/13 + 1/16 +...
    //1/1+3*0 1/1+3*1 1/1+3*2 1/1+3*3

    //public class NthSeries
    //{

    //    public static string seriesSum(int value)
    //    {
    //        double sum = 0;

    //        for (double i = 0; i < value; i++)
    //        {
    //            sum += (1 / (1 + 3 * i));
    //        }
    //        return sum.ToString("F2");
    //    }

    //    static void Main()
    //    {

    //        Console.WriteLine(seriesSum(5));
    //        Console.ReadKey();
    //    }
    //}





    //MIDDLE CHARACTER OF WORD RETURN

    //public class Kata
    //{
    //    public static string GetMiddle(string s)
    //    {
    //        var chars = s.ToCharArray();

    //        if (chars.Length > 0)
    //        {
    //            if (chars.Length % 2 == 0)
    //            {
    //                s = Convert.ToString(chars[chars.Length / 2 - 1] + "" + chars[chars.Length / 2]);
    //            }

    //            if (chars.Count() % 2 == 1)
    //            {
    //                s = Convert.ToString(chars[s.Length / 2]);
    //            }
    //        }

    //        return s;
    //    }

    //    static void Main()
    //    {
    //        string str1 = GetMiddle("middle");
    //        Console.WriteLine(str1);
    //        string str2 = GetMiddle("teste");
    //        Console.WriteLine(str2);
    //        Console.ReadKey();
    //    }
    //}





    //AlTeRnAtInG CaSe

    //public static class StringExt
    //{

    //    public static string ToAlternatingCase(this string s)
    //    {
    //        //foreach (char ch in s)
    //        //{
    //        //    if (ch > 'Z')
    //        //    {
    //        //        s = s.Replace(ch, char.ToUpper(ch));
    //        //    }

    //        //    if (ch <= 'Z')
    //        //    {
    //        //        s = s.Replace(ch, char.ToLower(ch));
    //        //    }
    //        //}

    //        StringBuilder sb = new StringBuilder(s);

    //        for (int i = 0; i < sb.Length; i++)
    //        {
    //            if (Char.IsLower(sb[i]) == true)
    //                sb[i] = Char.ToUpper(sb[i]);
    //            else if (Char.IsUpper(sb[i]) == true)
    //                sb[i] = Char.ToLower(sb[i]);
    //        }
    //        return sb.ToString();
    //    }

    //    static void Main()
    //    {
    //        string str = ToAlternatingCase("aXsdFg zhjKl;123");
    //        Console.WriteLine(str);
    //        string str1 = ToAlternatingCase("hello world");
    //        Console.WriteLine(str1);
    //        string str2 = ToAlternatingCase("Hello World");
    //        Console.WriteLine(str2);
    //        string str3 = ToAlternatingCase("hElLo WoRlD");
    //        Console.WriteLine(str3);
    //        string str4 = ToAlternatingCase("HELLO WORLD");
    //        Console.WriteLine(str4);
    //        Console.ReadKey();
    //    }
    //}





    //LONGEST ORDERED STRING

    //class Program
    //{
    //    public static string Longest(string s1, string s2)
    //    {
    //        var chars1 = s1.ToCharArray();
    //        var chars2 = s2.ToCharArray();

    //        //chars1 = chars1.ToArray();
    //        //chars2 = chars2.ToArray();

    //        var chars3 = chars1.Union(chars2).Distinct().OrderBy(x => x).ToArray();

    //        //foreach (var ch in chars3)
    //        //{
    //        //    if (ch != ' ')
    //        //        Console.Write(ch);
    //        //}

    //        return string.Join("", chars3);

    //    }

    //    static void Main()
    //    {
    //        //string s1 = "ywusqpomkihgecba";
    //        //string s2 = "zxvutrpnlkgihfbd";

    //        string s1 = "loopingis funbutdan gerous";
    //        string s2 = "lessdange rousthan coding";

    //        Longest(s1, s2);

    //        //var chars1 = s1.ToCharArray();
    //        //var chars2 = s2.ToCharArray();

    //        //chars1 = chars1.OrderBy(a => a).ToArray();
    //        //chars2 = chars2.OrderBy(a => a).ToArray();

    //        //var chars3 = chars1.Union(chars2).Distinct().OrderBy(x => x).ToArray();

    //        //foreach (var ch in chars3)
    //        //    Console.Write(ch);

    //        Console.ReadKey();
    //    }
    //}
}
