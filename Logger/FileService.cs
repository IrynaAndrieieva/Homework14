﻿namespace Homework14
{
    using Homework14.Logger;
    using System;
    using System.IO;
    using System.Reflection;


    public class FileService
    {
        public delegate void FileEntries(string message);

        public static event FileEntries Notify;       

        public static void WriteLine(string typeLog, string message)
        {
            
            string dirpath = @"D:\Log";
            DirectoryInfo dirInfo = new DirectoryInfo(dirpath);

            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }           

            string writePath = @"D:\Log\Log.txt";

            int Id = 0;

            for (Id = 0; Id < 11; Id++)
            {
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(string.Format("{0}: {1}: {2}", DateTime.Now.ToLongTimeString(), typeLog, message) + Id);
                }
            }
            if (Id == 10)
            {
                Notify?.Invoke($"At the moment in the file {Id}");   // 2.Вызов события
            }

        }       
    }
}