using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using InsertSortAlgorithm;
using NUnit.Framework;

namespace InsertSortTests;

public class Tests
{
    private static readonly IEnumerable<int> SortableNumbers = new[] {10, 8, 1, 4, 3, 9, 2, 5, 7, 6};

    [Test]
    public void InsertSort_Sort_ReturnExpectedSorted_Collection()
    {
        InsertSort.Sort(SortableNumbers.ToList()).Should().BeEquivalentTo(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10});
    }
}