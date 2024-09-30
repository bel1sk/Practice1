using System;

namespace FileManagerImitation
{
    public class FileManagerUI
    {
        public void RenderBaseInterface()
        {
            Console.Clear();
            Console.WindowWidth = 120;
            Console.WindowHeight = 30;

            DrawBorders();
            DrawLabels();
            DrawColumnDividers();
        }

        private void DrawBorders()
        {
            // Верхняя граница
            Console.SetCursorPosition(0, 0);
            Console.Write("┌");
            Console.Write(new string('─', 58));
            Console.Write("┬");
            Console.Write(new string('─', 58));
            Console.Write("┐");

            // test

            Console.SetCursorPosition(0, 2);
            Console.Write(new string('─', 118));

            Console.SetCursorPosition(0, 26);
            Console.Write(new string('─', 118));

            // Боковые границы и линии
            for (int i = 1; i < 28; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("│");

                Console.SetCursorPosition(59, i);
                Console.Write("│");

                Console.SetCursorPosition(118, i);
                Console.Write("│");
            }

            // Нижняя граница
            Console.SetCursorPosition(0, 28);
            Console.Write("└");
            Console.Write(new string('─', 58));
            Console.Write("┴");
            Console.Write(new string('─', 58));
            Console.Write("┘");

            // Разделитель между панелями
            Console.SetCursorPosition(59, 0);
            Console.Write("┬");
            Console.SetCursorPosition(59, 28);
            Console.Write("┴");
        }

        private void DrawLabels()
        {
            // Заголовки верхних частей панели
            Console.SetCursorPosition(26, 0);
            Console.Write("C:\\ Имя");

            Console.SetCursorPosition(83, 0);
            Console.Write("C:\\ Имя");

            Console.SetCursorPosition(2, 1);
            Console.Write("C:↓ Имя");

            Console.SetCursorPosition(28, 1);
            Console.Write("Имя");

            Console.SetCursorPosition(48, 1);
            Console.Write("Имя");

            Console.SetCursorPosition(68, 1);
            Console.Write("Имя");

            Console.SetCursorPosition(82, 1);
            Console.Write("Размер");
            //test

            Console.SetCursorPosition(96, 1);
            Console.Write("Дата");

            Console.SetCursorPosition(109, 1);
            Console.Write("Время");

            Console.SetCursorPosition(1, 27);
            Console.Write("..");

            Console.SetCursorPosition(34, 27);
            Console.Write(">КАТАЛОГ< 11.10.02  19:48");

            Console.SetCursorPosition(60, 27);
            Console.Write("..");

            Console.SetCursorPosition(93, 27);
            Console.Write(">КАТАЛОГ< 11.10.02  19:48");

            // Нижняя панель с командами
            string[] commands = {
                "1Помощь   ", "2Вызов   ", "3Чтение   ", "4Правка   ", "5Копия   ",
                "6Новая   ", "7Переимен-ть   ", "8Удаление   ", "9Меню   ", "10Выход   "
            };

            int offset = 1;

            for (int i = 0; i < commands.Length; i++)
            {
                Console.SetCursorPosition(offset, 29);
                Console.Write(commands[i]);
                offset += commands[i].Length + 2;
            }
        }

        private void DrawColumnDividers()
        {
            // Левый разделитель - делит на 3 части
            for (int i = 0; i < 27; i++)
            {
                Console.SetCursorPosition(19, i);
                Console.Write("│");

                Console.SetCursorPosition(39, i);
                Console.Write("│");
            }

            // Правый разделитель - делит на 4 части
            for (int i = 0; i < 27; i++)
            {
                Console.SetCursorPosition(78, i);
                Console.Write("│");

                Console.SetCursorPosition(91, i);
                Console.Write("│");
                Console.SetCursorPosition(104, i);
                Console.Write("│");
            }
        }
    }
}