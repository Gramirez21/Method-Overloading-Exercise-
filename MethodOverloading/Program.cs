using System.ComponentModel.Design;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine(Add(1, 0, true));

        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static  string Add(int num1, int num2, bool isMoney)

        {
            
            int i = num1 + num2;
            if (isMoney == true && i > 1) 
            {
                return $"{i} dollars";
            }
            else if (isMoney == true &&  i == 1)
            {
                return $"{i} dollar";
            }
            else
            {
                return $"{i}";
            }
                
            
        }

    }
}
