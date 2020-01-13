using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace Lab2
{
    public partial class Form : System.Windows.Forms.Form
    {
        int numbOfClicks;
        Bitmap image;
        Turtle turtle;
        Grammar grammar;

        public Form()
        {
            InitializeComponent();

            numbOfClicks = -1;
            image = new Bitmap(pb.ClientRectangle.Width, pb.ClientRectangle.Height);
            turtle = new Turtle();
            grammar = new Grammar(Grammar.AXIOM, Grammar.RULE, Grammar.RULE_X, Grammar.RULE_Y, Grammar.ANGLE);
        }

        private void rbStepLen1_CheckedChanged(object sender, EventArgs e)
        {
            turtle.TrailLen = Turtle.MIN_TRAIL_LEN;
        }

        private void rbStepLen2_CheckedChanged(object sender, EventArgs e)
        {
            turtle.TrailLen = Turtle.MAX_TRAIL_LEN;
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            if (numbOfClicks == -1)
                image = new Bitmap(pb.ClientRectangle.Width, pb.ClientRectangle.Height);
            numbOfClicks++;

            if (numbOfClicks > Grammar.MAX_STEPS)
            {
                MessageBox.Show("Максимальное доступное количество шагов: " + Grammar.MAX_STEPS + ".", "Предупреждение");
            }
            else
            {
                pb.Refresh();
                btnBuild.Text = "построить " + "(текущий шаг " + numbOfClicks + " )";

                grammar.CurrStep = numbOfClicks;

                pb.Invalidate();
                pb.Update();
            }
        }

        private void pb_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = Graphics.FromImage(image);

            turtle.Draw(grammar, graphics, new PointF(pb.Width / 2, pb.Height), Turtle.NORTH);

            e.Graphics.DrawImageUnscaled(image, 0, 0);
            graphics.Dispose();
        }
    }
}