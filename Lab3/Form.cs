using System;
using System.Windows.Forms;
using System.Drawing;

namespace Lab
{
    public partial class Form : System.Windows.Forms.Form
    {
        enum Tools
        {
            Brush,
            BresenhamLine,
            BresenhamCircle,
            CurveInParamWay,
            ModedRecursivePrimingPaintAlg,
            RecursivePrimingPaintAlg
        }

        #region объявление и инициализация переменных
        Bitmap image, tempImage;

        int pixelSize;
        Color pixelColor, oldPixelColor;
        Pen pen;

        Tools tool;
        bool isDrawMode;

        Point start, end;
        int r1, r2, w1, w2;
        #endregion /объявление и инициализация переменных

        public Form()
        {
            InitializeComponent();

            image = new Bitmap(pb.Size.Width, pb.Size.Height);
            tempImage = (Bitmap)image.Clone();

            pixelSize = Drawing.MIN_PIXEL_SIZE;
            pixelColor = Drawing.DEFAULT_COLOR;
            pen = new Pen(pixelColor, pixelSize);

            palette.BackColor = pixelColor;
            tsbBrush.Checked = true;
            toolStripCombobox.SelectedIndex = 0;

            tool = Tools.Brush;
            isDrawMode = false;

            r1 = trackbarR1.Value;
            r2 = trackbarR2.Value;
            w1 = trackbarW1.Value;
            w2 = trackbarW2.Value;
        }

        #region события мышки
        private void pb_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawMode = true;

            start.X = e.X;
            start.Y = e.Y;

            oldPixelColor = image.GetPixel(start.X, start.Y);
            if (oldPixelColor.ToArgb() != pixelColor.ToArgb())
            {
                switch (tool)
                {
                    case Tools.ModedRecursivePrimingPaintAlg:
                        Painting.PaintWithModedRecursivePrimingAlg(image, oldPixelColor, pixelColor, start.X, start.Y);
                        pb.Image = image;
                        break;

                    case Tools.RecursivePrimingPaintAlg:
                        Painting.PaintWithRecursivePrimingAlg(image, oldPixelColor, pixelColor, start.X, start.Y);
                        pb.Image = image;
                        break;
                    default:
                        break;
                }
            }

            tempImage = (Bitmap)image.Clone();
        }

        private void pb_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawMode = false;

            image = (Bitmap)tempImage.Clone();
        }

        private void pb_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawMode)
                return;

            end.X = e.X;
            end.Y = e.Y;

            pb.Invalidate();
            pb.Update(); // запускает событие Paint()
        }

        private void pb_Paint(object sender, PaintEventArgs e)
        {
            if (tempImage == null)
                return;

            if (tool != Tools.Brush)
                tempImage = (Bitmap)image.Clone();

            Graphics gr = Graphics.FromImage(tempImage);
            switch (tool)
            {
                case Tools.Brush:
                    Drawing.DrawPixel(gr, pixelSize, pixelColor, end.X, end.Y);
                    break;

                case Tools.BresenhamLine:
                    Drawing.DrawBresenhamLine(gr, pixelSize, pixelColor, start.X, start.Y, end.X, end.Y);
                    break;

                case Tools.BresenhamCircle:
                    Drawing.DrawBresenhamCircle(gr, pixelSize, pixelColor, start.X, start.Y, Convert.ToInt32(Math.Sqrt(Math.Pow(end.X - start.X, 2) + Math.Pow(end.Y - start.Y, 2))));
                    break;

                case Tools.CurveInParamWay:
                    Drawing.DrawCurveInParamWay(gr, pixelSize, pixelColor, end.X, end.Y, r1, r2, w1, w2);
                    break;

                default:
                    break;
            }

            e.Graphics.DrawImageUnscaled(tempImage, 0, 0);
            gr.Dispose();
        }
        #endregion

        #region события кнопок тулстрипа
        private void toolStrip_ClickedTool(object sender)
        {
            tsbBrush.Checked = false;
            tsbBresenhamLine.Checked = false;
            tsbBresenhamCircle.Checked = false;
            tsbCurveInParamWay.Checked = false;
            tsbModedRecursivePrimingPaintAlg.Checked = false;

            ToolStripButton tsbClicked = sender as ToolStripButton;
            tsbClicked.Checked = true;
            tool = (Tools)tsbClicked.MergeIndex;
        }

        private void tsbPalette_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                palette.BackColor = colorDialog1.Color;
                pixelColor = colorDialog1.Color;
                pen = new Pen(pixelColor, pixelSize);
            }
        }

        private void tsbBrush_Click(object sender, EventArgs e)
        {
            toolStrip_ClickedTool(sender);
        }

        private void tsbBresenhamLine_Click(object sender, EventArgs e)
        {
            toolStrip_ClickedTool(sender);
        }

        private void tsbBresenhamCircle_Click(object sender, EventArgs e)
        {
            toolStrip_ClickedTool(sender);
        }

        private void tsbCurveInParamWay_Click(object sender, EventArgs e)
        {
            toolStrip_ClickedTool(sender);
        }

        private void tsbModedRecursivePrimingPaintAlg_Click(object sender, EventArgs e)
        {
            toolStrip_ClickedTool(sender);
        }

        private void tsbRecursivePrimingPaintAlg_Click(object sender, EventArgs e)
        {
            toolStrip_ClickedTool(sender);
        }

        private void tsbCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pixelSize = int.Parse(toolStripCombobox.SelectedItem.ToString().Remove(1));
            pen = new Pen(pixelColor, pixelSize);
        }
        #endregion

        #region события трекбаров
        // для рисования кривых параметрически:
        private void trackbarR1_Scroll(object sender, EventArgs e)
        {
            r1 = trackbarR1.Value;
        }

        private void trackbarR2_Scroll(object sender, EventArgs e)
        {
            r2 = trackbarR2.Value;
        }

        private void trackbarW1_Scroll(object sender, EventArgs e)
        {
            w1 = trackbarW1.Value;
        }

        private void trackbarW2_Scroll(object sender, EventArgs e)
        {
            w2 = trackbarW2.Value;
        }
        #endregion
    }
}