using System.Globalization;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap size cua mang:");
        int size = int.Parse(Console.ReadLine());

        int[] A = new int[size];
        Console.WriteLine("Nhap cac phan tu cua mang:");
        string[] input = Console.ReadLine().Split(' ');

        for (int i = 0; i < size; i++)
        {
            A[i] = int.Parse(input[i]);
        }

        Console.WriteLine("Nhap fromIndex:");
        int fromIndex = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhap toIndex:");
        int toIndex = int.Parse(Console.ReadLine());

        int[] result = DeleteRangeInArray(A, fromIndex, toIndex);

        Console.WriteLine("Result:");
        Console.WriteLine(string.Join(", ", result));

    }
    public static int[] DeleteRangeInArray(int[] A, int fromIndex, int toIndex)
    {
        if (A == null || fromIndex < 0 || toIndex >= A.Length || fromIndex > toIndex)
        {
            Console.WriteLine("Input bi loi!");
            return [];
        }

        for (int i = fromIndex; i <= toIndex; i++)
        {
            A = DeleteIndexInArray(A, fromIndex);
        }

        return A;
    }

    public static int[] DeleteIndexInArray(int[] A, int index)
    {
        if (A == null || index < 0 || index >= A.Length)
        {
            Console.WriteLine("Index bi loi!");
            return [];
        }

        int[] result = new int[A.Length - 1];
        for (int i = 0, j = 0; i < A.Length; i++)
        {
            if (i != index)
            {
                result[j++] = A[i];
            }
        }

        return result;
    }
}
