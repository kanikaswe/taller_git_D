using System.Diagnostics.CodeAnalysis;

namespace xd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int result = Sum(2, 3);
            string nombrexd = nombre("jorge", "aguilar");
        }
        public static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }
        public static string nombre(string name, string lastname)
        {
            return name + lastname;
        }
    }
}