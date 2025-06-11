using System.Text;

namespace AlgorithmPractice
{
    internal class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                sb.AppendLine(i.ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}