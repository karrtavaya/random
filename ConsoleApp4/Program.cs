namespace ConsoleApp4
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            int[] array = new int[25];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(25);
                Console.WriteLine(array[i]);
            }
            int sum = 0;
            for (int c = 0; c<5; c++)
            {
                sum = array[c] + sum;

            }
            Console.WriteLine("сумма = {0}", sum);
        }
    }
}
        