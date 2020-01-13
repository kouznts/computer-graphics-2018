using System;
using System.Windows.Forms;
using System.Drawing;

namespace Lab4
{
    public partial class Form1 : Form
    {
        enum Algs
        {
            Grayscale,
            Monochrome,
            DetectEdges
        }

        private Bitmap oldImage;
        private Bitmap newImage;
        private Algs currAlg;
        private byte threshold1, threshold2;

        public Form1()
        {
            InitializeComponent();

            openFileDialog1.Filter = ".jpg|*.jpg";
            saveFileDialog1.Filter = ".jpg|*.jpg";

            currAlg = Algs.Grayscale;
            rbGrayscale.Checked = true;

            threshold1 = 100;
            threshold2 = 100;
            tbMonochromeThreshold.Text = threshold1.ToString();
            tbDetectEdgesThreshold.Text = threshold2.ToString();
        }

        private void btnOpenAndConvertImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                oldImage = new Bitmap(openFileDialog1.FileName);
                pbOldImage.Image = oldImage;
                newImage = (Bitmap)oldImage.Clone();

                switch (currAlg)
                {
                    case Algs.Grayscale:
                        Grayscale();
                        break;

                    case Algs.Monochrome:
                        Monochrome();
                        break;

                    case Algs.DetectEdges:
                        DetectEdges();
                        break;
                }

                if (newImage != null)
                    pbNewImage.Image = newImage;
            }
        }

        private void Grayscale()
        {
            ImageConversion.Grayscale(newImage);
        }

        private void Monochrome()
        {
            try
            {
                if (!byte.TryParse(tbMonochromeThreshold.Text, out threshold1))
                    throw new Exception();
                ImageConversion.Monochrome(newImage, threshold1);
            }
            catch
            {
                if (pbOldImage.Image != null)
                {
                    pbOldImage.Image.Dispose();
                    pbOldImage.Image = null;
                }
                if (pbNewImage.Image != null)
                {
                    newImage = null;
                    pbNewImage.Image.Dispose();
                    pbNewImage.Image = null;
                }

                tbMonochromeThreshold.Text = threshold1.ToString();
                MessageBox.Show("Введите значение от 0 до 255", "Ошибка");
            }
        }

        private void DetectEdges()
        {
            try
            {
                if (!byte.TryParse(tbDetectEdgesThreshold.Text, out threshold2))
                    throw new Exception();
                ImageConversion.DetectEdges(newImage, threshold2);
            }
            catch
            {
                if (pbOldImage.Image != null)
                {
                    pbOldImage.Image.Dispose();
                    pbOldImage.Image = null;
                }
                if (pbNewImage.Image != null)
                {
                    newImage = null;
                    pbNewImage.Image.Dispose();
                    pbNewImage.Image = null;
                }

                tbMonochromeThreshold.Text = threshold1.ToString();
                MessageBox.Show("Введите значение от 0 до 255", "Ошибка");
            }
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                newImage.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void rbGrayscale_CheckedChanged(object sender, EventArgs e)
        {
            currAlg = Algs.Grayscale;
        }

        private void rbMonochrome_CheckedChanged(object sender, EventArgs e)
        {
            currAlg = Algs.Monochrome;
        }

        private void rbDetectEdges_CheckedChanged(object sender, EventArgs e)
        {
            currAlg = Algs.DetectEdges;
        }

        private void tbMonochromeThreshold_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void tbDetectEdgesThreshold_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}