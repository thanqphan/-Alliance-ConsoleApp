class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap path cua folder:");
        string pathOfFolder = Console.ReadLine();

        List<string> imageFiles = GetImageFiles(pathOfFolder);
        Console.WriteLine("Danh sach File Anh:");
        foreach (var file in imageFiles)
        {
            Console.WriteLine(file);
        }

    }
    public static List<string> GetImageFiles(string pathOfFolder)
    {
        if (string.IsNullOrEmpty(pathOfFolder) || !Directory.Exists(pathOfFolder))
        {
            Console.WriteLine("Path folder khong hop le - khong ton tai!");
        }

        string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".bmp", ".gif", ".tiff", ".webp" };

        List<string> imageFiles = new List<string>();
        string[] allFiles = Directory.GetFiles(pathOfFolder, "*.*", SearchOption.AllDirectories);

        foreach (var file in allFiles)
        {
            string extension = Path.GetExtension(file).ToLower();
            if (Array.Exists(imageExtensions, ext => ext == extension))
                imageFiles.Add(file);
        }

        return imageFiles;
    }
}
