using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Codewars_fundamentals
{
    //Required Data I

    public class Kata
    {
        public static object[] CountSel(int[] lst)
        {
            int[] result = new int[] { 0, 0, 0, 0 };

            result[0] = lst.Length;


            return new object[0];
        }

        static void Main()
        {
            Console.WriteLine(CountSel(new[] { 4, 4, 2, -3, 1, 4, 3, 2, 0, -5, 2, -2, -2, -5 }));
            Console.ReadKey();
        }
    }





    //Highest number with two prime factors

    //public class Highest2Factors
    //{
    //    public static long[] HighestBiPrimeFac(long p1, long p2, long n)
    //    {
    //        // your code
    //        long[] rez = new long[] { 0, 0, 0 };
    //        for (int i = 1; i <= 20; i++)
    //            for (int j = 1; j <= 20; j++)
    //            {
    //                var tmp = (long)(Math.Pow(p1, i) * Math.Pow(p2, j));
    //                if (tmp <= n && tmp > rez[0]) { rez[0] = tmp; rez[1] = i; rez[2] = j; }
    //            }
    //        return rez;

    //    }

    //    //public class Str
    //    //{
    //    //    public long Result { get; set; }
    //    //    public long K1 { get; set; }
    //    //    public long K2 { get; set; }
    //    //}

    //    //public static string HighestBiPrimeFac(long p1, long p2, long n)
    //    //{
    //    //    List<Str> output = new List<Str>();

    //    //    if ( n < 100000)
    //    //    {
    //    //        for (long k2 = 1; k2 < n; k2++)
    //    //        {
    //    //            for (long k1 = 1; k1 < n; k1++)
    //    //            {
    //    //                var result = (long)(Math.Pow(p1, k1) * Math.Pow(p2, k2));
    //    //                if (result <= n && result > 0)
    //    //                {
    //    //                    output.Add(new Str() { Result = result, K1 = k1, K2 = k2 });
    //    //                }
    //    //                else
    //    //                    break;
    //    //            }
    //    //        }
    //    //    }

    //    //    else
    //    //    {
    //    //        for (long k2 = 1; k2 < p2; k2++)
    //    //        {
    //    //            for (long k1 = 1; k1 < p2; k1++)
    //    //            {
    //    //                var result = (long)(Math.Pow(p1, k1) * Math.Pow(p2, k2));
    //    //                if (result <= n && result > 0)
    //    //                {
    //    //                    output.Add(new Str() { Result = result, K1 = k1, K2 = k2 });
    //    //                }
    //    //                else
    //    //                    break;
    //    //            }
    //    //        }
    //    //    }            

    //    //    var outputResult = output.OrderByDescending(s => s.Result).ToList();

    //    //    long[] Res = { outputResult[0].Result, outputResult[0].K1, outputResult[0].K2 };

    //    //    //return Res;
    //    //    return string.Join(",", Res);
    //    //}

    //    static void Main()
    //    {
    //        Console.WriteLine(HighestBiPrimeFac(2, 3, 50));
    //        Console.WriteLine(HighestBiPrimeFac(5, 11, 1000));
    //        Console.WriteLine(HighestBiPrimeFac(3, 13, 5000));
    //        Console.WriteLine(HighestBiPrimeFac(5, 7, 5000));
    //        Console.WriteLine(HighestBiPrimeFac(2, 31, 50000));
    //        Console.WriteLine(HighestBiPrimeFac(103, 631, 4451183533));
    //        Console.ReadKey();
    //    }
    //}





    //Sort the Odd

    //public class Kata
    //{
    //    public static string SortArray(int[] array)
    //    {
    //        List<int> outputSort = new List<int> { };
    //        List<int> outputOdd = new List<int> { };

    //        if (array == null)
    //        {
    //            return null;
    //        }
    //        else
    //        {
    //            for (int i = 0; i < array.Length; i++)
    //            {
    //                if (array[i] % 2 == 1)
    //                    outputOdd.Add(array[i]);                    
    //            }
    //            outputOdd.Sort();
    //            int j = 0;

    //            for (int i = 0; i < array.Length;)
    //            {
    //                if (array[i] % 2 == 1)
    //                    {
    //                        outputSort.Add(outputOdd[j]);
    //                        i++;
    //                        j++;
    //                    }
    //                    else
    //                    {
    //                        outputSort.Add(array[i]);
    //                        i++;
    //                    }                            

    //            }

    //            return string.Join(",", outputSort);
    //        }            
    //    }

    //    static void Main()
    //    {
    //        Console.WriteLine(SortArray(new int[] { 5, 3, 2, 8, 1, 4 }));
    //        Console.ReadKey();
    //    }
    //}





    //Disease Spread

    //class Epidem
    //{
    //    public static int Epidemic(int tm, int n, int s0, int i0, double b, double a)
    //    {
    //        int result = 0;
    //        List<double> suspect = new List<double> { s0 };
    //        List<double> infect = new List<double> { i0 };
    //        List<double> recover = new List<double> { 0 };
    //        double dt = (double)tm / n;

    //        for (int i = 0; i < tm; i++)
    //        {
    //            for (int j = 1; j < n+1;)
    //            {                    
    //                suspect.Add((suspect[j - 1] - dt * b * suspect[j - 1] * infect[j - 1]));
    //                infect.Add((infect[j - 1] + dt * (b * suspect[j - 1] * infect[j - 1] - a * infect[j - 1])));
    //                recover.Add((recover[j - 1] + dt * infect[j - 1] * a));

    //                if (infect[j] > 0)
    //                {
    //                    j++;
    //                }
    //                else break;                    
    //            }                
    //        }
    //        result = (int)infect.Max();

    //        return result;
    //    }

    //    static void Main()
    //    {
    //        Console.WriteLine(Epidemic(14, 336, 996, 2, 0.00206, 0.41));
    //        Console.ReadKey();
    //    }
    //}





    //How much hex is the fish

    //public class Kata
    //{
    //    public static int FisHex(string name)
    //    {


    //        return 0;
    //    }

    //    static void Main()
    //    {
    //        Console.WriteLine(FisHex("redlionfish"));
    //        Console.ReadKey();
    //    }
    //}





    //Binary to Text (ASCII) Conversion

    //public static class Kata
    //{
    //    public static string BinaryToString(string binary)
    //    {
    //        if (binary.Length == 0)
    //        {
    //            return "";
    //        }
    //        else
    //        {
    //            var text = new StringBuilder();

    //            for (int i = 0; i < binary.Length; i += 8)
    //            {
    //                string section = binary.Substring(i, 8);
    //                int ascii = 0;
    //                ascii = Convert.ToInt32(section, 2);
    //                text.Append((char)ascii);
    //            }

    //            return text.ToString();
    //        }

    //    }

    //    static void Main()
    //    {
    //        Console.WriteLine(BinaryToString("0100100001100101011011000110110001101111"));
    //        Console.ReadKey();
    //    }
    //}





    //PatternCraft - Decorator

    //public interface IMarine
    //{
    //    int Damage { get; set; }
    //    int Armor { get; set; }
    //}

    //public class Marine : IMarine
    //{
    //    public Marine(int damage, int armor)
    //    {
    //        Damage = damage;
    //        Armor = armor;
    //    }

    //    public int Damage { get; set; }
    //    public int Armor { get; set; }
    //}

    //public class MarineWeaponUpgrade : IMarine
    //{
    //    private IMarine marine;

    //    public MarineWeaponUpgrade(IMarine marine)
    //    {
    //        marine.Damage++;     
    //        this.marine = marine;
    //        //++this.marine.Damage;
    //    }

    //    public int Damage { get { return this.marine.Damage; } set { } }

    //    public int Armor { get { return this.marine.Armor; } set {  } }
    //}

    //public class MarineArmorUpgrade : IMarine
    //{
    //    private IMarine marine;

    //    public MarineArmorUpgrade(IMarine marine)
    //    {
    //        marine.Armor++;
    //        this.marine = marine;
    //        //++this.marine.Armor;
    //    }

    //    public int Damage { get { return this.marine.Damage; } set { } }

    //    public int Armor { get { return this.marine.Armor; } set {  } }
    //}

    //public class DecoratorDemo
    //{
    //    static void Main()
    //    {
    //        IMarine marine = new Marine(15, 1);
    //        //int a = new MarineWeaponUpgrade(marine).Damage;
    //        //int b = new MarineWeaponUpgrade(marine).Damage;

    //        marine = new MarineWeaponUpgrade(marine);
    //        marine = new MarineWeaponUpgrade(marine);
    //        marine = new MarineArmorUpgrade(marine);

    //        Console.WriteLine(marine.Damage);
    //        Console.WriteLine(marine.Armor);

    //        Console.ReadKey();
    //    }
    //}





    //PatternCraft - State

    //public interface IUnit
    //{
    //    IUnitState State { get; set; }
    //    bool CanMove { get; set; }
    //    int Damage { get; set; }
    //}

    //public interface IUnitState
    //{
    //    bool CanMove { get; set; }
    //    int Damage { get; set; }
    //}

    //public class SiegeState : IUnitState
    //{
    //    public SiegeState()
    //    {
    //        CanMove = false;
    //        Damage = 20;
    //    }

    //    public bool CanMove { get; set; }
    //    public int Damage { get; set; }
    //}

    //public class TankState : IUnitState
    //{
    //    public TankState()
    //    {           
    //        CanMove = true;
    //        Damage = 5;
    //    }

    //    public bool CanMove { get; set; }
    //    public int Damage { get; set; }
    //}

    //public class Tank : IUnit
    //{
    //    public Tank()
    //    {
    //        State = new TankState();
    //    }

    //    public IUnitState State { get; set; }

    //    public bool CanMove { get { return State.CanMove; }  set { } }
    //    public int Damage { get { return State.Damage; } set { } }
    //}

    //public class TankModeTest
    //{
    //    static void Main()
    //    {
    //        IUnit tank = new Tank();

    //        Console.WriteLine(tank.CanMove);
    //        //Console.WriteLine(tank.Damage);

    //        tank.State = new SiegeState();

    //        //Console.WriteLine(tank.CanMove);
    //        Console.WriteLine(tank.Damage);

    //        Console.ReadKey();
    //    }
    //}





    //PatternCraft - Visitor

    //public interface IVisitor
    //{
    //    void VisitLight(ILightUnit unit);
    //    void VisitArmored(IArmoredUnit unit);
    //}

    //public interface ILightUnit
    //{
    //    int Health { get; set; }

    //    void Accept(IVisitor visitor);
    //}

    //public interface IArmoredUnit
    //{
    //    int Health { get; set; }

    //    void Accept(IVisitor visitor);
    //}

    //public class Marine : ILightUnit
    //{
    //    public Marine()
    //    {
    //        this.Health = 100;
    //    }

    //    public int Health { get; set; }

    //    public void Accept(IVisitor visitor)
    //    {
    //        Health -= 25;
    //    }
    //}

    //public class Marauder : IArmoredUnit
    //{        
    //    public Marauder()
    //    {
    //        this.Health = 125;
    //    }

    //    public int Health { get; set; }

    //    public void Accept(IVisitor visitor)
    //    {
    //        Health -= 32;
    //    }
    //}

    //public class TankBullet : IVisitor
    //{
    //    public void VisitLight(ILightUnit unit)
    //    {
    //        unit.Health -= 25;
    //    }

    //    public void VisitArmored(IArmoredUnit unit)
    //    {
    //        unit.Health -= 32;
    //    }
    //}

    //public class VisitDemo
    //{
    //    static void Main()
    //    {
    //        IVisitor bullet = new TankBullet();
    //        ILightUnit light = new Marine();

    //        light.Accept(bullet);

    //        Console.WriteLine(light.Health);

    //        IVisitor bullet1 = new TankBullet();
    //        IArmoredUnit armored = new Marauder();

    //        bullet.VisitArmored(armored);

    //        Console.WriteLine(armored.Health);

    //        Console.ReadKey();
    //    }
    //}




    //PatternCraft - Adapter

    //public class Target
    //{
    //    public int Health { get; set; }
    //}
    //public interface IUnit
    //{
    //    void Attack(Target target);
    //}

    //public class Marine : IUnit
    //{
    //    public void Attack(Target target)
    //    {
    //        target.Health -= 6;
    //    }
    //}

    //public class Zealot : IUnit
    //{
    //    public void Attack(Target target)
    //    {
    //        target.Health -= 8;
    //    }
    //}

    //public class Zergling : IUnit
    //{
    //    public void Attack(Target target)
    //    {
    //        target.Health -= 5;
    //    }
    //}

    //public class Mario
    //{
    //    public int jumpAttack()
    //    {
    //        Console.WriteLine("Mamamia!");
    //        return 3;
    //    }
    //}

    //public class MarioAdapter : IUnit
    //{
    //    private Mario mario;

    //    public MarioAdapter(Mario mario)
    //    {
    //        this.mario = mario;
    //    }

    //    public void Attack(Target target)
    //    {
    //        target.Health -= mario.jumpAttack();
    //    }
    //}

    //public class MarioTest
    //{
    //    static void Main()
    //    {
    //        var marioAdapter = new MarioAdapter(new Mario());
    //        var target = new Target { Health = 33 };

    //        marioAdapter.Attack(target);

    //        Console.WriteLine(target.Health);

    //        Console.ReadKey();
    //    }
    //}



    //PatternCraft - Strategy

    //public interface IUnit
    //{
    //    int Position { get; set; }
    //    void Move();
    //    IMoveBehavior MoveBehavior { get; set; }
    //}

    //public interface IMoveBehavior
    //{
    //    void Move(IUnit unit);
    //}

    //public class Fly : IMoveBehavior
    //{
    //    public void Move(IUnit unit)
    //    {
    //        unit.Position += 10;
    //    }
    //}

    //public class Walk : IMoveBehavior
    //{
    //    public void Move(IUnit unit)
    //    {
    //        unit.Position += 1;
    //    }
    //}

    //public class Viking : IUnit
    //{
    //    public Viking()
    //    {
    //        Position = 0;
    //        MoveBehavior = new Walk();            
    //    }

    //    public IMoveBehavior MoveBehavior { get; set; }

    //    public int Position { get; set; }

    //    public void Move()
    //    {
    //        MoveBehavior.Move(this);
    //    }
    //}

    //public class VikingMoveTest
    //{
    //    static void Main()
    //    {
    //        IUnit viking = new Viking();

    //        viking.Move();
    //        Console.WriteLine(viking.Position);

    //        viking.MoveBehavior = new Fly();
    //        viking.Move();

    //        Console.WriteLine(viking.Position);
    //        Console.ReadKey();
    //    }
    //}





    //Braking well

    //public class Braking
    //{

    //    public static double Dist(double v, double mu)        // suppose reaction time is 1
    //    {
    //        double dist = 0.0;

    //        v = v * 1000 / 3600;

    //        dist = ((v * v) / (2 * mu * 9.81));

    //        dist += (v * 1);

    //        return dist;
    //    }
    //    public static double Speed(double d, double mu)       // suppose reaction time is 1
    //    {
    //        double speed = 0.0;
    //        double disc = 0.0;
    //        double s1 = 0.0;
    //        double s2 = 0.0;

    //        disc = Math.Pow(2 * mu * 9.81, 2) - 4 * (-2 * mu * 9.81 * d);

    //        if (disc > 0 || disc == 0)
    //        {
    //            s1 = (-(2 * mu * 9.81) + Math.Sqrt(disc)) / (2 * 1);
    //            s2 = (-(2 * mu * 9.81) - Math.Sqrt(disc)) / (2 * 1);  
    //        }

    //        if ( s1 > 0)
    //        {
    //            speed = s1;
    //        }
    //        else
    //        {
    //            speed = s2;
    //        }

    //        //speed = Math.Sqrt(2 * mu * 9.81 * d);

    //        speed = speed * 3600.0 / 1000.0;

    //        return speed;
    //    }

    //    static void Main()
    //    {
    //        Console.WriteLine(Dist(100, 0.7));
    //        Console.WriteLine(Speed(83.9598760937531, 0.7)); //dist	83.9598760937531  56.182098315975317

    //        Console.ReadKey();
    //    }
    //}





    //Ermahgerd

    //public class Kata
    //{
    //    public static string Ermahgerd(string text)
    //    {
    //        string output = text.ToUpper();

    //        output = output.Replace("E", "ER");
    //        output = output.Replace("A", "ER");
    //        output = output.Replace("I", "ER");
    //        output = output.Replace("O", "ER");
    //        output = output.Replace("U", "ER");
    //        output = output.Replace("MY", "MAH");
    //        output = output.Replace("ERH", "ER");
    //        output = output.Replace("RRR", "R");
    //        output = output.Replace("ERER", "ER");
    //        output = output.Replace("RR", "R");

    //        string pattern = @"\BER\b";
    //        string target = @"";

    //        Regex regex = new Regex(pattern);

    //        output = regex.Replace(output, target);

    //        return output;
    //    }

    //    static void Main()
    //    {
    //        Console.WriteLine(Ermahgerd("my name is ohmygod girl and I love codewars!"));
    //        Console.ReadKey();
    //    }
    //}





    //You are a cube

    //public class Kata
    //{
    //    public static bool YouAreACube(int value)
    //    {
    //        int result = (int)Math.Pow(value, 1.0/3);
    //        if (result * result * result == value | (result + 1) * (result + 1) * (result + 1) == value)
    //        {
    //            return true;
    //        }
    //        else
    //            return false;
    //    }

    //    static void Main()
    //    {
    //        Console.WriteLine(YouAreACube(9));
    //        Console.ReadKey();
    //    }
    //}





    //TDD Area Calculations

    //public class TwoDShape
    //{
    //    double priWidth;
    //    double priHeight;

    //    public double Width
    //    {
    //        get { return priWidth; }
    //        set { priWidth = value < 0 ? -value : value; }
    //    }

    //    public double Height
    //    {
    //        get { return priHeight; }
    //        set { priHeight = value < 0 ? -value : value; }
    //    }

    //    public TwoDShape()
    //    {
    //        Width = Height = 0.0;
    //    }

    //    public TwoDShape(double W, double H)
    //    {
    //        Width = W;
    //        Height = H;
    //    }

    //    public TwoDShape(double x)
    //    {
    //        Width = Height = x;
    //    }

    //    public TwoDShape(TwoDShape obj)
    //    {
    //        Width = obj.Width;
    //        Height = obj.Height;
    //    }

    //    public virtual double Area()
    //    {
    //        return Width * Height;
    //    }        
    //}

    //class Triangle : TwoDShape
    //{
    //    public Triangle()
    //    {

    //    }

    //    public Triangle(double W, double H) : base(W, H)
    //    {            

    //    }

    //    public Triangle(double x) : base(x)
    //    {

    //    }

    //    public override double Area()
    //    {
    //        return Width * Height / 2;
    //    }

    //    public Triangle(Triangle obj) : base(obj)
    //    {

    //    }        
    //}

    //class Rectangle : TwoDShape
    //{
    //    public Rectangle(double W, double H) : base(W, H)
    //    {

    //    }

    //    public Rectangle(Rectangle obj) : base(obj)
    //    {

    //    }        
    //}

    //class Square : TwoDShape
    //{        
    //    public Square(double s) : base(s)
    //    {

    //    }

    //    public Square(Square obj) : base(obj)
    //    {

    //    }

    //    public override double Area()
    //    {
    //        return Width * Width;
    //    }
    //}

    //class Circle : TwoDShape
    //{
    //    public Circle(double x) : base(x)
    //    {

    //    }

    //    public Circle(Circle obj) : base(obj)
    //    {

    //    }

    //    public override double Area()
    //    {
    //        return Math.PI * Width * Width;
    //    }
    //}

    //public class Calculator
    //{
    //    public double GetTotalArea(params TwoDShape[] areas)
    //    {
    //        double totalArea = 0;
    //        for (int i = 0; i < areas.Length; i++)
    //        {
    //            totalArea += areas[i].Area();
    //        }
    //        return Math.Round(totalArea,2);
    //    }
    //}

    //class TwoDShapeDemo
    //{
    //    static void Main()
    //    {
    //        Calculator calc = new Calculator();

    //        TwoDShape[] shapes = new TwoDShape[6];

    //        shapes[0] = new Triangle(8.0, 12.0);
    //        shapes[1] = new Square(10);
    //        shapes[2] = new Rectangle(10, 4);
    //        shapes[3] = new Triangle(7.0);
    //        shapes[4] = new TwoDShape(10, 10);
    //        shapes[5] = new Circle(5);

    //        for (int i = 0; i < shapes.Length; i++)
    //        {
    //            Console.WriteLine("Square of object is: " + shapes[i].Area());
    //            Console.WriteLine();
    //        }

    //        TwoDShape[] shapes1 = { new Triangle(8.0, 12.0), new Square(10), new Rectangle(10, 4), new Triangle(7.0), new TwoDShape(10, 10), new Circle(5) };

    //        for (int i = 0; i < shapes1.Length; i++)
    //        {
    //            Console.WriteLine("Square of object is: " + shapes1[i].Area());
    //            Console.WriteLine();
    //        }

    //        Console.WriteLine(calc.GetTotalArea(shapes1));

    //        Console.WriteLine(calc.GetTotalArea(new Triangle(8.0, 12.0), new Square(10), new Rectangle(10, 4), new Triangle(7.0), new TwoDShape(10, 10), new Circle(5)));

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
    //        if (k > strarr.Length || k <= 0)
    //        {
    //            return "";
    //        }

    //        else
    //        {
    //            List<Str> list = new List<Str>();
    //            string output = "";


    //            for (int i = 0; i <= strarr.Length - k; i++)
    //            {
    //                string str1 = "";
    //                for (int g = i; g < k + i; g++)
    //                {
    //                    str1 += string.Join("", strarr[g]);
    //                }
    //                list.Add(new Str() { str = str1, length = str1.Length });
    //            }

    //            var result = list.OrderByDescending(s => s.length).ToList();

    //            output = result[0].str;

    //            return output;
    //        }


    //        //List<Str> list = new List<Str>();
    //        //string output = "";

    //        //for (int i = 0; i < strarr.Length; i++)
    //        //{                
    //        //    list.Add(new Str() { str = strarr[i], length = strarr[i].Length });
    //        //}

    //        //var result = list.OrderByDescending(s => s.length).ThenByDescending(s => s.str).ToList();

    //        //int j = 0;

    //        //for (int i = 0; i < result.Count-1; i++)
    //        //{
    //        //    if (result[i].str != result[i + 1].str && j < k)
    //        //    {
    //        //        output += string.Join("", result[i].str);
    //        //        j++;
    //        //    }
    //        //}

    //        //return output;
    //    }

    //    static void Main()
    //    {
    //        String[] myKeys = { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" };
    //        Console.WriteLine(LongestConsec(myKeys, 2));

    //        String[] myKeys1 = { "itvayloxrp", "wkppqsztdkmvcuwvereiupccauycnjutlv", "vweqilsfytihvrzlaodfixoyxvyuyvgpck" };
    //        Console.WriteLine(LongestConsec(myKeys1, 2));

    //        String[] myKeys2 = { };
    //        Console.WriteLine(LongestConsec(myKeys2, -2));

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
