using System;
using System.Drawing;

namespace Lab4
{
    public static class ImageConversion
    {
        public static void Grayscale(Bitmap image)
        {
            Color currColor;

            for (int row = 0; row < image.Width; row++)
            {
                for (int col = 0; col < image.Height; col++)
                {
                    currColor = image.GetPixel(row, col);

                    byte grayCoeff = (byte)(currColor.R + .59 * currColor.G + .11 * currColor.B);

                    image.SetPixel(row, col, Color.FromArgb(grayCoeff, grayCoeff, grayCoeff));
                }
            }
        }

        public static void Monochrome(Bitmap image, byte threshold)
        {
            Grayscale(image);

            Color currColor;
            for (int row = 0; row < image.Width; row++)
            {
                for (int col = 0; col < image.Height; col++)
                {
                    currColor = image.GetPixel(row, col);

                    byte averageShads = (byte)((currColor.R));

                    image.SetPixel(row, col, averageShads <= threshold ? Color.Black : Color.White);
                }
            }
        }

        public static void DetectEdges(Bitmap image, byte threshold)
        {
            Color i1j0, i0j1, i0j0;
            byte gradedR, gradedG, gradedB;

            for (int row = 0; row < image.Width - 1; row++)
            {
                for (int col = 0; col < image.Height - 1; col++)
                {
                    i1j0 = image.GetPixel(row + 1, col);
                    i0j1 = image.GetPixel(row, col + 1);
                    i0j0 = image.GetPixel(row, col);

                    gradedR = GetGradedR(i0j0.R, i1j0.R, i0j1.R, threshold);
                    gradedG = GetGradedR(i0j0.G, i1j0.G, i0j1.G, threshold);
                    gradedB = GetGradedR(i0j0.B, i1j0.B, i0j1.B, threshold);

                    image.SetPixel(row, col, Color.FromArgb(gradedR, gradedG, gradedB));
                }
            }
        }

        private static byte GetGradedR(byte i0j0, byte i1j0, byte i0j1, int threshold)
        {
            int gradedR = (int)Math.Round(Math.Sqrt(Math.Pow(i1j0 - i0j0, 2) + Math.Pow(i0j1 - i0j0, 2)));

            if (gradedR <= threshold)
                gradedR = byte.MaxValue;
            else
                gradedR = byte.MinValue;

            return (byte)gradedR;
        }
    }
}