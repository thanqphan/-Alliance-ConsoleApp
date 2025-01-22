using System.Globalization;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string[] names = {
            "Nguyễn  vAn Thanh",
            " trần   thị Nhung.",
            "Huỳnh Thúc Điền.",
            "Lê van  NaM"
        };

        Console.WriteLine("Data Dep:");
        foreach (var name in names)
        {
            Console.WriteLine(FormatName(name));
        }
    }

    public static string FormatName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            return "--Ten Loi--";

        name = Regex.Replace(name, @"[^\p{L}\s]", "");

        var formattedName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(
            name.ToLower().Trim()
                .Replace("  ", " ")
        );

        return formattedName;
    }
}
