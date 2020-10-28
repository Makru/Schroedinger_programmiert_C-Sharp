using System;

namespace Array_CSharp_8
{
    class Program
    {
        static void Main(string[] args) {
            int[] myArr = new[] { 1, 2, 3, 4, 5 };
            int[] arr2 = myArr[..];
            arr2[2] = 35;
            int[] sncdArr = myArr[1..^2];
            sncdArr[0] = 42;
            Console.WriteLine(String.Join(", ", myArr[..]));
            Console.WriteLine(String.Join(", ", myArr[1..]));
            Console.WriteLine(String.Join(", ", myArr[..2]));
            Console.WriteLine(String.Join(", ", myArr[..^2]));
            Console.WriteLine(String.Join(", ", myArr[1..^1]));

            Range myRange = 1..^2;
            Console.WriteLine("StartIdx: " + myRange.Start.Value);
            Console.WriteLine("EndIdx: " + myRange.End.Value);
            Console.WriteLine("EndIndex von Hinten beginnend? " + myRange.End.FromEnd);
            Range myRange2 = Range.FromStart(new Index(2, false));
            Range myRange3 = Range.FromStart(2);
            Range myRange4 = Range.ToEnd(new Index(2, true));
            Range myRange5 = ..^2;
            Range myRange6 = Range.Create(1, 2);
            Range myRange7 = Range.ToEnd(2);
            Console.WriteLine(myRange4.End.Value == myRange5.End.Value && myRange4.End.FromEnd == myRange5.End.FromEnd);
            int[] slicedArr = myArr[myRange];
            Console.WriteLine(String.Join(", ", myArr[myRange]));

            // Mehrdimensionale Arrays
            int[][] myJaggedArr = new int[10][];

            // Übung 1
            int[] arr = { 42, 21, 4711, 0815, 1337 };
            int[] arr4 = arr[..3];
            int[] arr3 = arr[^1..];

            Console.WriteLine(String.Join(", ", arr[^2..^1]));    //815
            Console.WriteLine(String.Join(", ", arr[1..2]));    // 21
             Console.ReadKey();

        }
    }
}
