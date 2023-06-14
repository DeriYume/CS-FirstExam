namespace FirstExam
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  
             *  Generate 321 random numbers in range [-100, 100]. 
             *  Output in the console:
             *  -	Highest and lowest number
             *  -	The sum of the numbers divisible by 3 without a remainder
             *  -	The product of all the odd numbers 
             */

            int sum = 0;
            int pr = 1;
            int lowest = 0;
            int highest = 0;

            Random rnd = new Random();
            int[] rng = new int[321];

            for (int i = 0; i < 321; i++)
            {
                rng[i] = rnd.Next(-100, 101);
                Console.WriteLine(rng[i]);

                if (lowest > rng[i]) lowest = rng[i];
                if (highest < rng[i]) highest = rng[i];

                if (rng[i] % 3 == 0) sum += rng[i];

                if (rng[i] % 2 == 1) pr *= rng[i];
            }

            Console.WriteLine("Lowest number: {0}", lowest);
            Console.WriteLine("Highest number: {0}", highest);
            Console.WriteLine("Sum: {0}", sum);
            Console.WriteLine("Product: {0}", pr);
            Console.WriteLine("Press enter to close the program");
            string input = Console.ReadLine();
        }
    }
}
