using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap tieng meow keu:");
        string x = Console.ReadLine();

        if (string.IsNullOrEmpty(x))
        {
            Console.WriteLine("Chuoi khong hop le!");
            return;
        }

        bool result = IsMeowSound(x);
        Console.WriteLine(result);
    }

    public static bool IsMeowSound(string x)
    {
        string pattern = "meow";
        int currentPatternIndex = 0;

        foreach (char currentChar in x)
        {
            if (currentChar == pattern[currentPatternIndex])
                continue;
            else if (currentPatternIndex < pattern.Length - 1 && currentChar == pattern[currentPatternIndex + 1])
                currentPatternIndex++;
            else
                return false;
        }

        return currentPatternIndex == pattern.Length - 1;
    }
}
