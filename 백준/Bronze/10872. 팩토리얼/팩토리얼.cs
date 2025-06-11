namespace AlgorithmPractice
{
    internal class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            int answer = 1;

            for (int i = num; i >= 1; i--)
            {
                answer *= i;
            }

            Console.WriteLine(answer);
        }
    }
}