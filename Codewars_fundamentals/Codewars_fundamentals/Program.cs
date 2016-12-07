using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_fundamentals
{
    //TDD Area Calculations
    //What is this shit anyway?!

    //public class AreaCount
    //{
    //    //private Calculator sut = new Calculator();

    //    public static double Tringle(double h, double w)
    //    {
    //        return w * h / 2;
    //    }
    //    public static double Square(double h)
    //    {
    //        return h * h;
    //    }
    //    public static double Rectangle(double h, double w)
    //    {
    //        return h * w;
    //    }
    //    public static double Cicle(double r)
    //    {
    //        return Math.PI * r * r;
    //    }
    //    public static double GetTotalArea(double[] areas)
    //    {
    //        double totalArea = 0;
    //        for (int i = 0; i < areas.Length; i++)
    //        {
    //            totalArea += areas[i];
    //        }
    //        return totalArea;
    //    }

    //    static void Main()
    //    {
    //        double[] areas = {new Rectangle(10,20), 
    //        Console.WriteLine(GetTotalArea(new recta));
    //        Console.ReadKey();
    //    }
    //}





    //Speed control
    
    //public class GpsSpeed
    //{
    //    public static int Gps(int s, double[] x)
    //    {
    //        int maxSpeed = 0;

    //        if (x.Length <= 1)
    //        {
    //            maxSpeed = 0;
    //        }

    //        else
    //        {
    //            double[] speed = new double[x.Length - 1];
    //            for (int i = 0; i < speed.Length; i++)
    //            {
    //                speed[i] = ((x[i + 1] - x[i]) / s)*3600;
    //            }
    //            maxSpeed = Convert.ToInt32(speed.Max());
    //        }

    //        return maxSpeed;
    //    }

    //    static void Main()
    //    {
    //        double[] x = new double[] { 0.0 };
    //        Console.WriteLine(Gps(15, x));
    //        Console.ReadKey();
    //    }
    //}





    //Turtoise racing

    //public class Tortoise
    //{
    //    public static string Race(int v1, int v2, int g)
    //    {
    //        if (v1 >= v2)
    //            return null;
    //        else
    //        {
    //            var ts = System.TimeSpan.FromSeconds((g * 3600) / (v2 - v1));
    //            return new[] { ts.Hours, ts.Minutes, ts.Seconds };

    //            //int[] time = new int[3];

    //            //double speed1 = Convert.ToDouble(v1) / 3600;
    //            //double speed2 = Convert.ToDouble(v2) / 3600;

    //            //double mile1 = g;
    //            //double mile2 = 0;

    //            //int h = 0;
    //            //int m = 0;
    //            //int s = 0;

    //            //for (h = 0; ;)
    //            //{
    //            //    for (m = 0; m < 60;)
    //            //    {
    //            //        for (s = 0; s < 60; )
    //            //        {
    //            //            mile1 += speed1;
    //            //            mile2 += speed2;

    //            //            if (mile1 > mile2)
    //            //                s++;
    //            //            else
    //            //                break;
    //            //        }
    //            //        if (mile1 > mile2)
    //            //            m++;
    //            //        else
    //            //            break;
    //            //    }
    //            //    if (mile1 > mile2)
    //            //        h++;
    //            //    else
    //            //        break;
    //            //}

    //            //time[0] = h;
    //            //time[1] = m;
    //            //time[2] = s;

    //            //return string.Join(",", time);
    //        }            
    //    }

    //    static void Main()
    //    {
    //        Console.WriteLine(Race(80, 100, 40));
    //        Console.ReadKey();
    //    }
    //}





    //Zebulan's Nightmare

    //public class Kata
    //{
    //    public static string ZebulansNightmare(string functionName)
    //    {
    //        string[] str = functionName.Split('_');
    //        for (int i = 1; i < str.Length; i++)
    //        {
    //            str[i] = str[i].Substring(0, 1).ToUpper() + str[i].Substring(1, str[i].Length - 1).ToLower();
    //        }

    //        return string.Join("", str);
    //    }

    //    static void Main()
    //    {
    //        Console.WriteLine(ZebulansNightmare("trolling_is_fun"));
    //        Console.ReadKey();
    //    }
    //}





    //Fibonacci, Tribonacci and friends

    //public class Xbonacci
    //{
    //    public double[] xbonacci(double[] signature, int n)
    //    {
    //        if (n == 0)
    //        {
    //            double[] result = new double[0];
    //            return result;
    //        }
    //        else
    //        {
    //            double[] result = new double[n];

    //            if (n < signature.Length)
    //            {
    //                for (int i = 0; i < n; i++)
    //                {
    //                    result[i] = signature[i];
    //                }
    //                return result;
    //            }
    //            else
    //            {
    //                for (int i = 0; i < signature.Length; i++)
    //                {
    //                    result[i] = signature[i];
    //                }

    //                for (int i = signature.Length; i < result.Length; i++)
    //                {
    //                    for (int j = signature.Length; j > 0; j--)
    //                        result[i] += result[i - j];
    //                }
    //                return result;
    //            }
    //        }
    //    }
    //}

    //    public static string Tribonacci(double[] signature, int n)
    //    {
    //        double[] result = new double[n];
    //        if (n < signature.Length)
    //        {
    //            for (int i = 0; i < n; i++)
    //            {
    //                result[i] = signature[i];
    //            }
    //            return string.Join(",", result);
    //        }
    //        else
    //        {
    //            for (int i = 0; i < signature.Length; i++)
    //            {
    //                result[i] = signature[i];
    //            }

    //            for (int i = signature.Length; i < result.Length; i++)
    //            {
    //                for (int j = signature.Length; j > 0; j--)
    //                    result[i] += result[i-j];
    //            }
    //            return string.Join(",", result);
    //        }

    //    }

    //    static void Main()
    //    {
    //        double[] var = new double[] { 1, 19, 14, 3, 10, 11, 16, 1, 5, 15, 12, 18, 7, 10, 7, 9, 13, 17 };

    //        Console.WriteLine(Tribonacci(var, 66));
    //        Console.ReadKey();
    //    }
    //}





    //Tribonacci Sequence
    //It should work with random inputs too
    //Expected is <System.Double[39]>, actual is <System.String>
    //Values differ at index[0]
    //Expected: 7.0d
    //But was:  '7'

    //public class Xbonacci
    //{
    //    public static string Tribonacci(double[] signature, int n)
    //    {
    //        double[] result = new double[n];
    //        if (n == 0)
    //        {
    //            return Convert.ToDouble(0);
    //        }
    //        if (n < signature.Length)
    //        {
    //            for (int i = 0; i < n; i++)
    //            {
    //                result[i] = signature[i];
    //            }
    //            return string.Join(",", result);
    //        }
    //        else
    //        {
    //            for (int i = 0; i < signature.Length; i++)
    //            {
    //                result[i] = signature[i];
    //            }

    //            for (int i = signature.Length; i < result.Length; i++)
    //            {
    //                result[i] = result[i - 3] + result[i - 2] + result[i - 1];
    //            }
    //            return string.Join(",", result);
    //        }

    //    }

    //    static void Main()
    //    {
    //        double[] var = new double[] { 13, 8, 18 };

    //        Console.WriteLine(Tribonacci(var, 2));
    //        Console.ReadKey();
    //    }
    //}





    //Are they the same?

    //class AreTheySame
    //{
    //    public static bool comp(int[] a, int[] b)
    //    {
    //        if (a == null || b == null)
    //            return false;
    //        if (a.Length == b.Length)
    //        {
    //            Array.Sort(a);
    //            Array.Sort(b);
    //            for (int i = 0; i < a.Length;)
    //            {
    //                if (a[i].ToString() == null || b[i].ToString() == null)
    //                    return false;
    //                if (Math.Pow(a[i], 2) == b[i])
    //                {
    //                    i++;
    //                }
    //                else
    //                    return false;
    //            }
    //            return true;
    //        }
    //        else
    //            return false;
    //    }

    //    static void Main()
    //    {
    //        int[] a = null;
    //        int[] b = null;

    //        Console.WriteLine(comp(a, b));
    //        Console.ReadKey();
    //    }
    //}





    //Data Reverse

    //namespace Main
    //{
    //    public class Kata
    //    {
    //        public static string DataReverse(int[] data)
    //        {
    //            int[] dataReverse = data.Reverse().ToArray();
    //            int[] output = new int[data.Length];

    //            for (int i = 0; i < data.Length; )
    //            {
    //                foreach (int j in dataReverse.Skip(i).Take(8).Reverse().ToArray())
    //                {
    //                    output[i] = j;
    //                    i++;
    //                }

    //            }

    //            return string.Join(",", output);
    //        }
    //        static void Main()
    //        {
    //            int[] data1 = new int[32] { 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0 };
    //            Console.WriteLine(DataReverse(data1));
    //            Console.ReadKey();
    //        }
    //    }
    //}





    //Sum of numbers from 0 to n

    //public class SequenceSum
    //{
    //    public static string ShowSequence(int n)
    //    {
    //        if (n == 0)
    //        {
    //            return "0=0";
    //        }
    //        if (n < 0)
    //        {
    //            return string.Concat(n, "<0");
    //        }
    //        else
    //        {
    //            int z = 0;
    //            int y = 0;
    //            List<string> str = new List<string>();
    //            str.Add("0");
    //            string output;
    //            while (z != n)
    //            {
    //                z += 1;
    //                str.Add(z.ToString());
    //                y += z;
    //            }
    //            output = string.Join("+", str);
    //            output = string.Concat(output, " = ", y);
    //            return output;
    //        }

    //    }
    //    static void Main()
    //    {
    //        Console.WriteLine(ShowSequence(6));
    //        Console.ReadKey();
    //    }
    //}





    //Find the smallest

    //public class ToSmallest
    //{
    //    public static long[] Smallest(long n)
    //    {

    //    }

    //    static void Main()
    //    {

    //    }
    //}





    //Bouncing Balls

    //public class BouncingBall
    //{

    //    public static int bouncingBall(double h, double bounce, double window)
    //    {
    //        int bb = -1;

    //        if (h > 0 && bounce > 0 && bounce < 1 && window < h)
    //        {
    //            do
    //            {
    //                h *= bounce;
    //                bb+=2;
    //            } while (h > window);

    //            return bb;
    //        }
    //        else
    //            return -1;            
    //    }

    //    static void Main()
    //    {
    //        Console.WriteLine(bouncingBall(30.0, 0.66, 1.5));
    //        Console.ReadKey();
    //    }
    //}





    //Number climber
    //3 =  2*1 + 1
    //6 =  2*3
    //13 = 2*6 + 1

    //public class Kata
    //{
    //    public static List<int> Climb(int n)
    //    {
    //        List<Int32> numSeq = new List<int>();
    //        int k = n;

    //        if (n == 1)
    //        {
    //            numSeq.Add(k);
    //        }
    //        if (n == 2)
    //        {
    //            numSeq.Add(k);
    //            numSeq.Add(1);
    //        }
    //        if (n > 2)
    //        {                
    //            numSeq.Add(k);
    //            do
    //            {
    //                k /= 2;
    //                numSeq.Add(k);
    //            } while (k != 1);
    //        }
    //        numSeq.Reverse();
    //        return numSeq;
    //    }
    //    static void Main()
    //    {
    //        Console.WriteLine(Climb(13));
    //        Console.Read();
    //    }
    //}





    //Find the stray number

    //class Solution
    //{
    //    public static int Stray(int[] numbers)
    //    {
    //        Array.Sort(numbers);
    //        return numbers[0] == numbers[1] ? numbers.Last() : numbers.First();
    //        //int stray = 0;

    //        //for (int i = 0; i < numbers.Length - 1; i++)
    //        //{
    //        //    if (numbers[i] == numbers[i + 1] && numbers[i] != numbers[numbers.Length - 1])
    //        //    {
    //        //        stray = numbers[numbers.Length - 1];
    //        //        break;
    //        //    }
    //        //    else if (numbers[i] != numbers[i + 1] && numbers[i] == numbers[numbers.Length - 1])
    //        //    {
    //        //        stray = numbers[i + 1];
    //        //        break;
    //        //    }
    //        //    else if (numbers[i] != numbers[i + 1] && numbers[i + 1] == numbers[numbers.Length - 1])
    //        //    {
    //        //        stray = numbers[i];
    //        //        break;
    //        //    }

    //        //}

    //        //return stray;
    //    }

    //    static void Main()
    //    {
    //        int[] input = new int[] { 1, 1, 1, 2 };
    //        Console.WriteLine(Stray(input));
    //        Console.ReadKey();
    //    }
    //}

    //Dubstep
    //WUBWUB_WUB_WUBWUB_

    //public class Dubstep
    //{
    //    public static string SongDecoder(string input)
    //    {
    //        StringBuilder output = new StringBuilder(input);

    //        output.Replace("WUB", " ");
    //        int i = 0;

    //        do
    //        {
    //            if (output[i] == ' ' && output[i + 1] == ' ')
    //            {
    //                output.Remove(i, 1);
    //            }
    //            else
    //            {
    //                i++;
    //            }
    //        }
    //        while (i < output.Length-1);

    //        if (output[0] == ' ')
    //            output.Remove(0, 1);

    //        if (output[output.Length-1] == ' ')
    //            output.Remove(output.Length - 1, 1);

    //        return output.ToString();

    //    }

    //    static void Main()
    //    {
    //        Console.WriteLine(SongDecoder(Console.ReadLine()));
    //        Console.ReadKey();
    //    }
    //}





    //ConsecutiveStrings

    //public class LongestConsecutives
    //{
    //    public class Str
    //    {
    //        public string str { get; set; }
    //        public int length { get; set; }
    //    }

    //    public static String LongestConsec(string[] strarr, int k)
    //    {
    //        List<Str> list = new List<Str>();
    //        string output = null;

    //        for (int i = 0; i < strarr.Length; i++)
    //        {                
    //            list.Add(new Str() { str = strarr[i], length = strarr[i].Length });
    //        }

    //        var result = list.OrderByDescending(s => s.length).ThenBy(s => s.str).ToArray();

    //        for (int i = 0; i < k-1; i++)
    //        {
    //            if (result[i] != result[i + 1])
    //                output += result[i];
    //        }

    //        //foreach (Str s in result)
    //        //    output = string.Join("", s, 0, k);

    //        return output;

    //        //string output = null;
    //        //if (strarr.Length == 0 || k > strarr.Length || k <= 0)
    //        //{
    //        //    output = "";
    //        //}
    //        //else
    //        //{
    //        //    string temp = null;
    //        //    for (int write = 0; write < strarr.Length; write++)
    //        //    {
    //        //        for (int sort = 0; sort < strarr.Length - 1; sort++)
    //        //        {
    //        //            if (strarr[sort].Count() > strarr[sort + 1].Count())
    //        //            {
    //        //                temp = strarr[sort + 1];
    //        //                strarr[sort + 1] = strarr[sort];
    //        //                strarr[sort] = temp;
    //        //            }
    //        //        }
    //        //    }

    //            //    output = strarr[strarr.Length - 1];
    //            //    if (k >= 1)
    //            //    {
    //            //        int i = strarr.Length - 2;
    //            //        int j = 1;

    //            //        do
    //            //        {
    //            //            if (strarr[i] != strarr[i + 1])
    //            //            {
    //            //                if ((strarr[i].ToCharArray()[0] < strarr[i + 1].ToCharArray()[0]) & (strarr[i].ToCharArray().Length == strarr[i + 1].ToCharArray().Length))
    //            //                {
    //            //                    output += strarr[i];
    //            //                }
    //            //                if ((strarr[i].ToCharArray()[0] > strarr[i + 1].ToCharArray()[0]) & (strarr[i].ToCharArray().Length == strarr[i + 1].ToCharArray().Length))
    //            //                {
    //            //                    output += strarr[i + 1];
    //            //                }
    //            //                //else
    //            //                //{
    //            //                //    output += strarr[i];
    //            //                //}
    //            //                j++;
    //            //            }
    //            //            i--;
    //            //        }
    //            //        while (j != k);
    //            //    }
    //            //}
    //            //return output;
    //    }

    //    static void Main()
    //    {
    //        String[] myKeys = { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" };
    //        Console.WriteLine(LongestConsec(myKeys, 2));
    //        Console.ReadKey();
    //    }
    //}





    //Number of people in bus

    //public class Kata
    //{
    //    public static int Number(List<int[]> peopleListInOut)
    //    {
    //        int finalCount = 0;
    //        for (int i = 0; i < peopleListInOut.Count; i++)
    //        {
    //            finalCount += peopleListInOut[i][0];
    //            finalCount -= peopleListInOut[i][1];
    //        }
    //        return finalCount;
    //    }

    //    static void Main()
    //    {
    //        List<int[]> peopleList = new List<int[]>() { new[] { 10, 0 }, new[] { 3, 5 }, new[] { 5, 8 } };
    //        Console.WriteLine(Number(peopleList).ToString());
    //        Console.ReadKey();
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

    //            string[] str1 = new string[str.Length];

    //            for (var i = 0; i < str.Length; i++)
    //            {
    //                str1[i] = (str[i] + "" + str[i]);
    //            }

    //            return string.Join("",str1);

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
    //        int i = 0;
    //        List<long> sumdigpow = new List<long>();

    //        do
    //        {
    //            long digitcount = 0;
    //            int count = 0;
    //            string str = a.ToString();

    //            for (int j = 0; j < str.Length; j++)
    //            {
    //                long s = Int32.Parse(str[j].ToString());
    //                count++;
    //                s = Convert.ToInt64(Math.Pow(Convert.ToDouble(s), count));
    //                digitcount += s;
    //            }
    //            if (digitcount == a)
    //                sumdigpow.Add(a);


    //            a++;
    //            i++;

    //        } while (a <= b);

    //        return sumdigpow.ToArray();

    //    }

    //    static void Main()
    //    {
    //        long a = Convert.ToInt64(Console.ReadLine());
    //        long b = Convert.ToInt64(Console.ReadLine());
    //            string xyz = "";
    //            for (int i = 0; i < SumDigPow(a, b).Length; i++)
    //            {
    //                xyz += SumDigPow(a, b)[i].ToString();
    //                xyz += ", ";
    //            }
    //                Console.WriteLine(xyz);
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
