namespace Overview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            bool isNumber = false;
            bool isExit = false;
            Console.WriteLine("Welcome to sort algorithm manager!");
            while (!isExit)
            {
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Please select the algorithm you want to use (0 to exit):");
                    Console.WriteLine("1. Bubble Sort");
                    Console.WriteLine("2. Selection Sort");
                    Console.WriteLine("3. Insertion Sort");
                    Console.WriteLine("4. Merge Sort");
                    Console.WriteLine("5. Quick Sort");
                    Console.WriteLine("6. Heap Sort");
                    Console.Write("Your choice: ");
                    isNumber = int.TryParse(Console.ReadLine(), out choice);
                    if(choice == 0)
                    {
                        isExit = true;
                        break;
                    }
                } while (!isNumber || !(1 <= choice) || !(choice <= 6));

                if (!isExit)
                {
                    Console.Write("Enter max size of the array to sort:");
                    int size = int.Parse(Console.ReadLine());
                    AlgorithmManager manager = new AlgorithmManager(choice, size);

                    manager.Sort();
                    manager.Report();
                }
            }
            Console.WriteLine("\n\nExit!");
        }
    }
}
