using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Lab
{
    public static class Drawing
    {
        public static readonly int MIN_PIXEL_SIZE = 1;
        public static readonly Color DEFAULT_COLOR = Color.Black;

        public static void DrawPixel(Graphics gr, int size, Color color, int x, int y)
        {
            gr.SmoothingMode = SmoothingMode.None;
            gr.FillRectangle(new SolidBrush(color), x, y, size, size);
        }

        public static void DrawBresenhamLine(Graphics gr, int size, Color color, int x1, int y1, int x2, int y2)
        {
            int x, y;
            int dx, dy;
            int sx, sy;
            int moveByDx, moveByDy;
            int err, corrErr;
            int until;

            dx = x2 - x1;
            dy = y2 - y1;

            // определяем, в какую сторону нужно будет сдвигаться:
            sx = Math.Sign(dx); // если dx < 0 (отрезок идёт справа налево по иксу), то incx будет равен -1
            sy = Math.Sign(dy); // аналогично, если отрезок идёт снизу вверх по игрек

            dx = Math.Abs(dx);
            dy = Math.Abs(dy);

            // определяем наклон отрезка:
            if (dx > dy)
            {
                /* если dx > dy, то значит отрезок вытянут вдоль оси икс (т.е. он скорее длинный, чем высокий);
                 * значит в цикле нужно будет идти по икс (until = dx), 
                 * значит протягивать прямую по иксу надо в соответствии с тем, 
                 * что слева направо и справа налево она идёт (pdx = sx), 
                 * при этом по игрек такой сдвиг отсутствует */
                moveByDx = sx;
                moveByDy = 0;
                corrErr = dy;
                until = dx;
            }
            else // случай, когда прямая скорее высокая, чем длинная (т.е. вытянута по оси игрек)
            {
                moveByDx = 0;
                moveByDy = sy;
                corrErr = dx;
                until = dy; // тогда в цикле будем двигаться по игрек
            }

            x = x1;
            y = y1;
            err = until / 2;

            // ставим первую точку, все последующие точки возможно надо сдвигать:
            DrawPixel(gr, size, color, x, y);


            for (int i = 0; i < until; i++) //идём по всем точкам, начиная со второй и до последней
            {
                err -= corrErr;

                if (err < 0)
                {
                    err += until;

                    x += sx;        // сдвинуть прямую вверх или вниз, если цикл проходит по иксам
                    y += sy;        // сдвинуть прямую влево или вправо, если цикл проходит по игрек
                }
                else
                {
                    x += moveByDx;  /* продолжить тянуть прямую дальше,
                                     * т. е. сдвинуть влево или вправо, если цикл идёт по иксу */
                    y += moveByDy;  // сдвинуть вверх или вниз
                }

                DrawPixel(gr, size, color, x, y);
            }
        }

        /* основная идея -- регистрация средних значений погрешностей 
         * между идеальным положением каждой точки и той позицией на экране дисплея, 
         * в которой она действительно отображается 
         * 
         * две идеи, позволяющие ускорить построение окружности: 
         * 1) нет необходимости строить всю окружность, 
         * достаточно построить некоторую ее часть и
         * последовательным применением преобразований симметрии получить из нее полную окружность, 
         * 2) корректирования положения следующей точки с помощью погрешности */
        public static void DrawBresenhamCircle(Graphics gr, int size, Color color, int x0, int y0, int r)
        {
            int x = 0;
            int y = r;

            int d = 3 - 3 * r; // погрешность следующей точки после начальной

            while (y >= x)
            {
                // выводим 8 симметричных точек:
                DrawPixel(gr, size, color, x + x0, y + y0);
                DrawPixel(gr, size, color, x + x0, -y + y0);
                DrawPixel(gr, size, color, -x + x0, y + y0);
                DrawPixel(gr, size, color, -x + x0, -y + y0);
                DrawPixel(gr, size, color, y + x0, x + y0);
                DrawPixel(gr, size, color, y + x0, -x + y0);
                DrawPixel(gr, size, color, -y + x0, x + y0);
                DrawPixel(gr, size, color, -y + x0, -x + y0);

                if (d > 0)
                {
                    d = d + 4 * (x - y) + 10;
                    y = y - 1;
                }
                else
                {
                    d = d + 4 * x + 6;
                }

                x = x + 1;
            }
        }

        /* использует представление кривой в виде пары функций, 
         * зависящих от параметра t [0 .. 2 * PI]:
         * x = x0 + R1 * cos (w1 * t);
         * y = y0 + R2 * cos (w2 * t) */
        public static void DrawCurveInParamWay(Graphics gr, int size, Color color, int x0, int y0, int r1, int r2, int w1, int w2)
        {
            Point p1 = new Point(
                Convert.ToInt32(x0 + r1 * Math.Cos(w1 * 1 * Math.PI / 180)),
                Convert.ToInt32(y0 + r2 * Math.Sin(w2 * 1 * Math.PI / 180)));
            Point p2 = p1;

            for (double t = 2; t <= 360 + 1; t++)
            {
                p2.X = Convert.ToInt32(x0 + r1 * Math.Cos(w1 * t * Math.PI / 180));
                p2.Y = Convert.ToInt32(y0 + r2 * Math.Sin(w2 * t * Math.PI / 180));

                DrawBresenhamLine(gr, size, color, p1.X, p1.Y, p2.X, p2.Y);

                p1 = p2;
            }
        }
    }
}