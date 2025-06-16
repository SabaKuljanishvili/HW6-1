namespace HW6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ============ Task 1 ============
            Console.WriteLine(" ============ Task 1 ============");
            Console.WriteLine("Task 1: Sort an unsorted 1D array in ascending order");

            int[] array = { 5, 1, 3, 2, 4 };

            Array.Sort(array); // Sort in ascending order

            Console.WriteLine("Sorted array:");
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("\n");

            // ============ Task 2 ============
            Console.WriteLine(" ============ Task 2 ============");
            Console.WriteLine("Task 2: Calculate the average of the array elements");

            int[] numbers = { 10, 20, 30, 40, 55, 63,32 };

            double average = numbers.Average();

            Console.WriteLine($"The average of the array elements is: {average}");

            Console.WriteLine();

            // ============ Task 3 ============
            Console.WriteLine(" ============ Task 3 ============");
            Console.WriteLine("Task 3: Count how many times a number appears in a jagged array");

            int[][] jaggedArray = new int[][]
            {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6, 7, 8 },
            new int[] { 6, 7, 8, 9, 2 }
            };

            Console.Write("Enter a number to search: ");
            int numberToFind = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    if (jaggedArray[i][j] == numberToFind)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine($"The number {numberToFind} appears {count} time(s) in the jagged array.");
        }
    }
}
