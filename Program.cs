namespace StrategySort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int> { 66, 23, 17, 9, 1 };

            Console.WriteLine("Before bubbel sorting:");
            PrintList(data);

            Sorter sorter = new Sorter();
            sorter.SetSortStrategy(new BubbleSortStrategy());
            sorter.Sort(data);  // Sorting using Bubble Sort
            Console.WriteLine("After bubbel sorting:");
            PrintList(data);

            sorter.SetSortStrategy(new QuickSortStrategy());
            sorter.Sort(data);  // Sorting using Quick Sort
        }
        static void PrintList(List<int> list)
        {
            foreach (int num in list)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}