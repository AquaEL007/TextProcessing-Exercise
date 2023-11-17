namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();

            string fileName = string.Empty;
            string fileExtension = string.Empty;

            int lastSeparatorIndex = filePath.LastIndexOf('\\');
            int extentionIndex = filePath.LastIndexOf('.');

            if (lastSeparatorIndex != -1 && extentionIndex != -1 && lastSeparatorIndex < extentionIndex )
            {
                fileName = filePath.Substring(lastSeparatorIndex + 1, extentionIndex - lastSeparatorIndex - 1);
                fileExtension = filePath.Substring(extentionIndex + 1);
            }

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");

        }
    }
}