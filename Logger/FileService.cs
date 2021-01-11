namespace Homework14
{
    using System;
    using System.IO;
    using System.Reflection;

    
    public class FileService
    {       
        public static void WriteLine(string typeLog, string message)
        {
            string dirpath = @"D:\Log";
            DirectoryInfo dirInfo = new DirectoryInfo(dirpath);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            string writePath = @"D:\Log\Log.txt";

            // создание тхт файла
            using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(string.Format("{0}: {1}: {2}", DateTime.Now.ToLongTimeString(), typeLog, message));
            }
        }
    }
}
