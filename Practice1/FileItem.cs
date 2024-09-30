using System;

namespace FileManagerImitation
{
    public class FileItem
    {
        public string Name { get; }
        public int Size { get; }
        public string Date { get; }
        public string Time { get; }
        public bool IsDirectory { get; }

        public FileItem(string name, int size, string date, string time, bool isDirectory)
        {
            Name = name;
            Size = size;
            Date = date;
            Time = time;
            IsDirectory = isDirectory;
        }
    }
}