class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap size cua array:");
        int size = int.Parse(Console.ReadLine());
        if (size <= 0)
            return;
        int[] a = new int[size];

        Console.WriteLine("Nhap phan tu cua array:");
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine($"Phan tu thu {i + 1}:");
            a[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Nhap phan tu can tim:");
        int n = int.Parse(Console.ReadLine());

        bool result = CheckNumInArray(a, size, n);
        Console.WriteLine(result);
    }
    public static bool CheckNumInArray(int[] A, int size, int n)
    {
        for (int i = 0; i < size; i++)
        {
            if (A[i] == n)
                return true;
        }
        return false;
    }
}