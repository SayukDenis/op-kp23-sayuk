using System;
class Percolation
{
    static void Main(String[] args)
    {
        int[,] array;
        int n = 0;
    }
    static int[,] init(int n) { }
    static int[,] Open(int row, int col, int[,] array) { return null; }
    static bool isOpen(int row, int col, int[,] array) { return true; }
    static bool isFull(int row, int col, int[,] array) { return true; }
    static int numberOfOpenSites(int[,] array) { return 0; }
    static bool percolates(int[,] array) { return true; }
    static void print(int[,] array) { }
    static int[,] Result(int[,] array) { return null; }
    static void testcase()
    {
        int[,] testArray1 = { { 0, 2, 2, 2 }, { 1, 1, 2, 1 }, { 1, 1, 1, 2 }, { 1, 1, 2, 2 } };
        bool isFullTest1and1Test1 = true;
        bool isOpenTest1and1Test1 = true;
        int numberOfOpenSites1 = 9;
        bool percoclates1 = true;
        int[,] testArray1Traversal1 = Result(testArray1);
        if (isFullTest1and1Test1 == isFull(1, 1, testArray1Traversal1) || isOpenTest1and1Test1 == isOpen(1, 1, testArray1Traversal1) || numberOfOpenSites1 == numberOfOpenSites(testArray1Traversal1) || percoclates1 == percolates(testArray1Traversal1))
        {
            Console.WriteLine("Test 1 Passed");
        }
        else
        {
            Console.WriteLine("Test 1 not Passed");
        }
        int[,] testArray2 = { { 0, 0, 2, 0 }, { 1, 2, 2, 1 }, { 1, 2, 2, 1 }, { 1, 2, 1, 1 } };
        bool isFullTest1and1Test2 = false;
        bool isOpenTest1and1Test2 = false;
        int numberOfOpenSites2 = 10;
        bool percoclates2 = true;
        int[,] testArray1Traversal2 = Result(testArray1);
        if (isFullTest1and1Test2 == isFull(1, 1, testArray1Traversal2) || isOpenTest1and1Test2 == isOpen(1, 1, testArray1Traversal2) || numberOfOpenSites2 == numberOfOpenSites(testArray1Traversal2) || percoclates2 == percolates(testArray1Traversal2))
        {
            Console.WriteLine("Test 2 Passed");
        }
        else
        {
            Console.WriteLine("Test 2 not Passed");
        }
        int[,] testArray3 = { { 0, 2, 0, 2 }, { 1, 2, 1, 2 }, { 1, 1, 2, 1 }, { 2, 2, 1, 2 } };
        bool isFullTest1and1Test3 = false;
        bool isOpenTest1and1Test3 = false;
        int numberOfOpenSites3 = 8;
        bool percoclates3 = false;
        int[,] testArray1Traversal3 = Result(testArray1);
        if (isFullTest1and1Test3 == isFull(1, 1, testArray1Traversal3) || isOpenTest1and1Test3 == isOpen(1, 1, testArray1Traversal3) || numberOfOpenSites3 == numberOfOpenSites(testArray1Traversal3) || percoclates3 == percolates(testArray1Traversal3))
        {
            Console.WriteLine("Test 3 Passed");
        }
        else
        {
            Console.WriteLine("Test 3 not Passed");
        }
    }
}