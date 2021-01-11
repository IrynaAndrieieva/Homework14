namespace Homework14
{
    using System;
    using System.IO;
    using System.Reflection;


    public class FileService
    {
        public delegate void FileEntries(string message);

        public event FileEntries Notify;

        public static int ID { get; set; }

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
                sw.WriteLine(string.Format("{0}: {1}: {2}", DateTime.Now.ToLongTimeString(), typeLog, message) + ID);
            }


        }

        public void Take()
        {
            if (ID == 10)
            {
                Notify?.Invoke($"At the moment in the file {ID}");   // 2.Вызов события
            }
        }
    }
}