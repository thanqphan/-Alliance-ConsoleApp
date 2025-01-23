class Program
{
    static void Main(string[] args)
    {
        //giảm lần truy cập db ; giảm lỗi khi khong tìm được data department
        var listStaff = [];
        //lấy toàn bộ id department hiện có từ list staff
        var departmentIds = listStaff.Select(s => s.DepartmentId).Distinct().ToList();
        //lấy toàn bộ thtin department trong 1 lần
        var departments = departmentIds.Select(id => GetDepartmentInfo(id)).ToDictionary(dep => dep.Id, dep => dep);

        foreach (var s in listStaff)
        {
            if (departments.ContainsKey(s.DepartmentId))
                s.DepartmentName = departments[s.DepartmentId].Name;
            else
                s.DepartmentName = "Unknown"; 
        }

    }
    public static List<string> GetDepartmentInfo(string pathOfFolder)
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
