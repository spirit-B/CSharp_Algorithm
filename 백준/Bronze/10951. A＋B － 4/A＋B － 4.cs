using System.Text;

namespace AlgorithmPractice
{
    internal class Program
    {
        static void Main()
        {
            List<string> inputs = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input)) break;
                else
                {
                    inputs.Add(input);
                }
            }

            foreach (var str in inputs)
            {
                string[] chars = str.Split(" ");
                int sum = int.Parse(chars[0]) + int.Parse(chars[1]);
                Console.WriteLine(sum);
            }
        }
    }
}