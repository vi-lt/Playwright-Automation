namespace PlaywrightTests.Setup
{
    public class FilesAndDirectory
    {
        public static Task DeleteAllFilesInFolder(string folderName)
        {
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string folder = appDirectory.Substring(0, appDirectory.IndexOf("\\bin")) + folderName;
            Console.WriteLine(folder);
            if (Directory.Exists(folder))
            {
                string[] filePaths = Directory.GetFiles(folder);
                if (filePaths.Length > 0)
                {
                    foreach (string filePath in filePaths)
                    {
                        File.Delete(filePath);
                    }
                }
            }

            return Task.CompletedTask;
        }
    }
}
