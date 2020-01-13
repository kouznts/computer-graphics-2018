using System.Drawing;

namespace Lab
{
    public static class Painting
    {
        public static void PaintWithModedRecursivePrimingAlg(Bitmap image, Color oldColor, Color newColor, int x, int y)
        {
            image.SetPixel(x, y, newColor); // закрашиваем текущий пиксел

            //  заполняем все точки по х вправо, пока не упрёмся в границу:
            int i = 1;
            if (x >= 0)
            {
                while (image.GetPixel(x + i, y).ToArgb() == oldColor.ToArgb() && x + i + 1 < image.Width)
                {
                    image.SetPixel(x + i, y, newColor);
                    i++;
                }
            }
            int xRight = x + i - 1; // запоминаем правую крайнюю точку

            i = 1;
            if (x < image.Width)
            {
                while (image.GetPixel(x - i, y).ToArgb() == oldColor.ToArgb() && x - i > 0)
                {
                    image.SetPixel(x - i, y, newColor);
                    i++;
                }
            }
            int xLeft = x - i + 1;

            bool isRightmost = false;
            bool isLeftmost = false;

            // проверяем отрезок между левой и правой точкой сверху и снизу: 
            if (y > 0 && y + 1 < image.Height)  // проверяем выход за границу y
            {
                for (i = xLeft; i <= xRight; i++)
                {
                    //  ищем в нём правые точки:
                    if (image.GetPixel(i, y + 1).ToArgb() == oldColor.ToArgb())
                    {
                        isRightmost = true;     // если цвет подходит -- отмечаем
                    }
                    else
                    {
                        if (isRightmost)        // если цвет не подходит и isRightmost -- это правая граница и вызываем в ней рекурсию
                        {
                            PaintWithModedRecursivePrimingAlg(image, oldColor, newColor, i - 1, y + 1);
                            isRightmost = false;
                        }
                    }

                    if (image.GetPixel(i, y - 1).ToArgb() == oldColor.ToArgb())
                    {
                        isLeftmost = true;
                    }
                    else
                    {
                        if (isLeftmost)
                        {
                            PaintWithModedRecursivePrimingAlg(image, oldColor, newColor, i - 1, y - 1);
                            isLeftmost = false;
                        }
                    }
                }
            }

            //  в конце мы проверяем, если флаги true -- значит есть отрезок, в котором не дошли до крайних правой и левой точек:
            if (isRightmost)
                PaintWithModedRecursivePrimingAlg(image, oldColor, newColor, xRight, y + 1); // в зависимости от флага запускаем процедуру сверху или снизу
            if (isLeftmost)
                PaintWithModedRecursivePrimingAlg(image, oldColor, newColor, xRight, y - 1);
        }
   
        public static void PaintWithRecursivePrimingAlg(Bitmap image, Color oldColor, Color newColor, int x, int y)
        {
            image.SetPixel(x, y, newColor);

            //  для точек сверху, снизу, слева, справа от текущей:
            for (int i = -1; i <= 1; i += 2)
            {
                if ((x + i - 1 > 0) && 
                    (x + i + 1 < image.Width) && 
                    (y + i - 1 > 0) && 
                    (y + i + 1 < image.Height))
                {
                    if ((image.GetPixel(x + i, y).ToArgb() == oldColor.ToArgb()))
                        PaintWithRecursivePrimingAlg(image, oldColor, newColor, x + i, y);
                    if ((image.GetPixel(x, y + i).ToArgb() == oldColor.ToArgb()))
                        PaintWithRecursivePrimingAlg(image, oldColor, newColor, x, y + i);
                }
            }
        }
    }
}
