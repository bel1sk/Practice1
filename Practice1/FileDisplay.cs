using System;
using System.Collections.Generic;

namespace FileManagerImitation
{
    public class FileDisplay
    {
        private List<FileItem> files;

        public FileDisplay(List<FileItem> files)
        {
            this.files = files;
        }

        public void RenderFiles()
        {
            int row = 3; // Стартовая строка для вывода файлов
            int columnWidth = 17; // Ширина колонки для имени файла в левой панели
            int filesPerColumn = 23; // Количество файлов в одной колонке

            // Настройка начальных позиций для колонок
            int firstColumnStart = 2; // Начальная позиция для первой колонки
            int secondColumnStart = 21; // Начальная позиция для второй колонки
            int thirdColumnStart = 41; // Начальная позиция для третьей колонки

            // Отображение файлов в левой панели (3 колонки)
            for (int i = 0; i < files.Count; i++)
            {
                // Сокращение длинного имени файла
                string name = files[i].Name.Length > 12 ? files[i].Name.Substring(0, 7) + "~" + files[i].Name.Substring(files[i].Name.LastIndexOf('.')) : files[i].Name;

                // Определяем цвет для каталогов и файлов
                if (files[i].IsDirectory)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan; // Каталоги отображаем другим цветом
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }

                // Вычисляем колонку и строку для файла
                int column = i / filesPerColumn; // Колонка, в которой будет отображён файл
                int columnStartPosition;

                // Определяем начальную позицию в зависимости от колонки
                switch (column)
                {
                    case 0:
                        columnStartPosition = firstColumnStart;
                        break;
                    case 1:
                        columnStartPosition = secondColumnStart;
                        break;
                    case 2:
                        columnStartPosition = thirdColumnStart;
                        break;
                    default:
                        continue; // Игнорируем файлы, если больше чем 3 колонки
                }

                int currentRow = 3 + (i % filesPerColumn); // Позиция по строкам

                // Отображаем имя файла в соответствующей колонке
                Console.SetCursorPosition(columnStartPosition, currentRow);
                Console.Write(name.PadRight(columnWidth));


                // Если файл должен отображаться в правой колонке, выводим его детали
                if (column == 0) // Файлы только из первой колонки попадают в правую панель
                {
                    Console.SetCursorPosition(61, currentRow);
                    Console.Write(name.PadRight(15));
                    Console.SetCursorPosition(82, currentRow);
                    Console.Write(files[i].Size > 0 ? files[i].Size.ToString() : "");
                    Console.SetCursorPosition(94, currentRow);
                    Console.Write(files[i].Date);
                    Console.SetCursorPosition(109, currentRow);
                    Console.Write(files[i].Time);
                }
            }

            Console.ResetColor(); // Сбрасываем цвет
        }
    }
}