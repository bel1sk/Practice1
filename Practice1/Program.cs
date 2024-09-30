using System;
using System.Text;
using System.Collections.Generic;

namespace FileManagerImitation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Создание списка файлов
            List<FileItem> files = new List<FileItem>
            {
                new FileItem("MyFileWithLongName.txt", 123456, "11.10.02", "19:48", false),
                new FileItem("readme.txt", 2048, "12.08.20", "09:15", false),
                new FileItem("Documents", 0, "05.06.21", "15:30", true),
                new FileItem("program.cs", 512, "01.01.23", "12:00", false),
                new FileItem("data.bin", 1234, "23.09.19", "23:11", false),
                new FileItem("Projects", 0, "02.04.18", "08:45", true),
                new FileItem("notes.txt", 512, "05.10.21", "12:45", false),
                new FileItem("presentation.pptx", 1048576, "13.07.20", "09:30", false),
                new FileItem("backup.zip", 512000, "02.08.22", "16:22", false),
                new FileItem("backup.zip", 512000, "02.08.22", "16:22", false),
                new FileItem("backup.zip", 512000, "02.08.22", "16:22", false),
                new FileItem("backup.zip", 512000, "02.08.22", "16:22", false),
                new FileItem("backup.zip", 512000, "02.08.22", "16:22", false),
                new FileItem("backup.zip", 512000, "02.08.22", "16:22", false),
                new FileItem("backup.zip", 512000, "02.08.22", "16:22", false),
                new FileItem("backup.zip", 512000, "02.08.22", "16:22", false),
                new FileItem("backup.zip", 512000, "02.08.22", "16:22", false),
                new FileItem("backup.zip", 512000, "02.08.22", "16:22", false),
                new FileItem("backup.zip", 512000, "02.08.22", "16:22", false),
                new FileItem("backup.zip", 512000, "02.08.22", "16:22", false),
                new FileItem("backup.zip", 512000, "02.08.22", "16:22", false),
                new FileItem("backup.zip", 512000, "02.08.22", "16:22", false),
                new FileItem("backup.zip", 512000, "02.08.22", "16:22", false),
                new FileItem("backup.zip", 512000, "02.08.22", "16:22", false),
                new FileItem("backup.zip", 512000, "02.08.22", "16:22", false),
                new FileItem("backup.zip", 512000, "02.08.22", "16:22", false),
                new FileItem("backup.zip", 512000, "02.08.22", "16:22", false)
            };

            // Создание экземпляров интерфейса и отображения файлов
            FileManagerUI ui = new FileManagerUI();
            FileDisplay fileDisplay = new FileDisplay(files);

            // Отображение интерфейса и файлов
            ui.RenderBaseInterface();
            fileDisplay.RenderFiles();

            // Ожидание для визуализации интерфейса
            Console.ReadKey();
        }
    }
}