namespace Overview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            bool isNumber = false;
            Console.WriteLine("Welcome to sort algorithm manager!");
            
            do
            {
                Console.WriteLine("Please select the algorithm you want to use:");
                Console.WriteLine("1. Bubble Sort");
                Console.WriteLine("2. Selection Sort");
                Console.WriteLine("3. Insertion Sort");
                Console.WriteLine("4. Merge Sort");
                Console.WriteLine("5. Quick Sort");
                Console.WriteLine("6. Heap Sort");
                Console.Write("Your choice: ");
                isNumber = int.TryParse(Console.ReadLine(), out choice);
            } while (!isNumber && !(1 <= choice && choice <= 6));

            AlgorithmManager manager = new AlgorithmManager(choice);

            manager.Sort();
            manager.Report();
        }
    }
}
