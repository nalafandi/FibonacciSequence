namespace FibonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] farray = new int[25];
            farray[0] = 0;
            farray[1] = 1;

            for (int i = 0; i < 25; i++)
            {
                if (i >= 2)
                {
                    farray[i] = farray[i - 2] + farray[i - 1];
                }
                Console.WriteLine(farray[i]);                
            }


        }
    }
}