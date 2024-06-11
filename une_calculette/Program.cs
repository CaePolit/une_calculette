using System;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading.Channels;

class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("first operand: ");
            string entre1 = Console.ReadLine();
            float x;
            bool success1 = float.TryParse(entre1, out x);
            // Console.WriteLine($"{x.GetType().Name}"); // rappel: single == separé par . | float separé par ,
            while (!(success1))
            {
                Console.WriteLine("Not a float, enter a float please");
                Console.Write("first operand: ");
                entre1 = Console.ReadLine();
            }
            Console.Write("second operand: ");
            string entre2 = Console.ReadLine();
            float y;
            bool success2 = float.TryParse(entre2, out y);
            while (!(success2))
            {
                Console.WriteLine("Not a float, enter a float please");
                Console.Write("second operand: ");
                entre2 = Console.ReadLine();
            }
            Console.WriteLine("Available operations: Add - Subtract - Multiply - Divide - Modulo");
            Console.Write("which operation you choose?: ");
            string entre3 = Console.ReadLine();
            while ((IsOperation(entre3)) == "no")
            {
                Console.WriteLine("ERROR: incorrect operand. Please type one of the followings operands: ");
                Console.WriteLine("Add - Subtract - Multiply - Divide - Modulo");
                Console.Write("which operation you choose?");
                entre3 = Console.ReadLine();
            }
            if (entre3 == "Add")
            {
                float r = StaticAdd(x, y);  
                Console.WriteLine(entre1+" + "+entre2+" = "+r);
            }
            else if (entre3 == "Subtract")
            {
                float r = StaticSubtract(x, y);
                Console.WriteLine(entre1 + " - " + entre2 + " = " + r);
            }
            else if (entre3 == "Multiply")
            {
                float r = StaticMultiply(x, y);
                Console.WriteLine(entre1 + " * " + entre2 + " = " + r);
            }
            else if (entre3 == "Divide")
            {
                float r = StaticDivide(x, y);
                Console.WriteLine(entre1 + " / " + entre2 + " = " + r);
            }
            else
            {
                float r = StaticModulo(x, y);
                Console.WriteLine(entre1 + " % " + entre2 + " = " + r);
            }
        }
    }
    public static string IsOperation(string entre)
    {
        string[] options = { "Add", "Subtract", "Multiply", "Divide", "Modulo" };
        bool existe = Array.Exists(options, element => element == entre);
        if (existe)
        {
            return "yes";
        }
        else
        {
            return "no";
        }
    }

    public static float StaticAdd(float x, float y)
    {
        float result = x + y;
        return result;
    }

    public static float StaticSubtract(float x, float y)
    {
        float result = x - y;
        return result;
    }
    public static float StaticMultiply(float x, float y)
    {
        float result = x * y;
        return result;
    }
    public static float StaticDivide(float x, float y)
    {
        float result = x / y;
        return result;
    }
    public static float StaticModulo(float x, float y)
    {
        float result = x % y;
        return result;
    }
}