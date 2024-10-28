namespace FactorialProgram
{
    class Program
    { 
        public static void Main(string[] args) 
        {
            Console.WriteLine("Enter Any Number");
            int num=Convert.ToInt32(Console.ReadLine());

            int fact = 1;

            for (int i = 1; i <= num; i++)
            { 
                fact=fact*i;
            }

            Console.WriteLine(fact);

        }
    }
}