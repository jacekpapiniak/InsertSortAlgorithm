namespace InsertSortAlgorithm;

public static class InsertSort
{
    private const int LeftBoundary = -1;
    private static readonly IEnumerable<int> SortableNumbers = new[] {10, 8, 1, 4, 3, 9, 2, 5, 7, 6};

    public static void Main()
    {
        Console.WriteLine($"Before sort: {PrintCollection(SortableNumbers)}");
        var result = Sort(SortableNumbers.ToList());
        Console.WriteLine($"Sorted: {PrintCollection(result)}");
    }

    public static IEnumerable<int> Sort(IList<int> toSort)
    {
        for (var keyIndex = 1;
             keyIndex < toSort.Count;
             keyIndex++) // j = 1 as we start with second element in the collection
        {
            var key = toSort[keyIndex];
            var compareIndex =
                keyIndex - 1; //Compare to element on the left. This gives a range <1,j-1> where j is Key's position

            while (compareIndex > LeftBoundary && toSort[compareIndex] > key)
            {
                toSort[compareIndex + 1] = toSort[compareIndex]; // Replace key with position to it's left
                compareIndex -= 1; //check element further to the left
            }

            toSort[compareIndex + 1] = key;
        }

        return toSort;
    }

    private static string PrintCollection(IEnumerable<int> collection) => string.Join(" ", collection);
}