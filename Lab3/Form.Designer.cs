namespace Lab
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.palette = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBrush = new System.Windows.Forms.ToolStripButton();
            this.tsbBresenhamLine = new System.Windows.Forms.ToolStripButton();
            this.tsbBresenhamCircle = new System.Windows.Forms.ToolStripButton();
            this.tsbCurveInParamWay = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModedRecursivePrimingPaintAlg = new System.Windows.Forms.ToolStripButton();
            this.tsbRecursivePrimingPaintAlg = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripCombobox = new System.Windows.Forms.ToolStripComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.gbCurveSettings = new System.Windows.Forms.GroupBox();
            this.labelHelp3 = new System.Windows.Forms.Label();
            this.labelHelp2 = new System.Windows.Forms.Label();
            this.labelHelp1 = new System.Windows.Forms.Label();
            this.trackbarW2 = new System.Windows.Forms.TrackBar();
            this.labelW2 = new System.Windows.Forms.Label();
            this.trackbarW1 = new System.Windows.Forms.TrackBar();
            this.labelW1 = new System.Windows.Forms.Label();
            this.trackbarR2 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.labelR1 = new System.Windows.Forms.Label();
            this.trackbarR1 = new System.Windows.Forms.TrackBar();
            this.pb = new System.Windows.Forms.PictureBox();
            this.toolStrip.SuspendLayout();
            this.gbCurveSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarW2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarW1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarR1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.palette,
            this.toolStripSeparator1,
            this.tsbBrush,
            this.tsbBresenhamLine,
            this.tsbBresenhamCircle,
            this.tsbCurveInParamWay,
            this.toolStripSeparator2,
            this.tsbModedRecursivePrimingPaintAlg,
            this.tsbRecursivePrimingPaintAlg,
            this.toolStripSeparator3,
            this.toolStripCombobox});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(684, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // palette
            // 
            this.palette.BackColor = System.Drawing.Color.Black;
            this.palette.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.palette.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.palette.Name = "palette";
            this.palette.Size = new System.Drawing.Size(23, 22);
            this.palette.Text = "палитра";
            this.palette.Click += new System.EventHandler(this.tsbPalette_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbBrush
            // 
            this.tsbBrush.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBrush.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBrush.MergeIndex = 0;
            this.tsbBrush.Name = "tsbBrush";
            this.tsbBrush.Size = new System.Drawing.Size(23, 22);
            this.tsbBrush.Text = "кисть";
            this.tsbBrush.Click += new System.EventHandler(this.tsbBrush_Click);
            // 
            // tsbBresenhamLine
            // 
            this.tsbBresenhamLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBresenhamLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBresenhamLine.MergeIndex = 1;
            this.tsbBresenhamLine.Name = "tsbBresenhamLine";
            this.tsbBresenhamLine.Size = new System.Drawing.Size(23, 22);
            this.tsbBresenhamLine.Text = "линия Брезенхэма";
            this.tsbBresenhamLine.Click += new System.EventHandler(this.tsbBresenhamLine_Click);
            // 
            // tsbBresenhamCircle
            // 
            this.tsbBresenhamCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBresenhamCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBresenhamCircle.MergeIndex = 2;
            this.tsbBresenhamCircle.Name = "tsbBresenhamCircle";
            this.tsbBresenhamCircle.Size = new System.Drawing.Size(23, 22);
            this.tsbBresenhamCircle.Text = "круг Брезенхэма";
            this.tsbBresenhamCircle.Click += new System.EventHandler(this.tsbBresenhamCircle_Click);
            // 
            // tsbCurveInParamWay
            // 
            this.tsbCurveInParamWay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCurveInParamWay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCurveInParamWay.MergeIndex = 3;
            this.tsbCurveInParamWay.Name = "tsbCurveInParamWay";
            this.tsbCurveInParamWay.Size = new System.Drawing.Size(23, 22);
            this.tsbCurveInParamWay.Text = "кривая, заданная параметрически";
            this.tsbCurveInParamWay.Click += new System.EventHandler(this.tsbCurveInParamWay_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbModedRecursivePrimingPaintAlg
            // 
            this.tsbModedRecursivePrimingPaintAlg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModedRecursivePrimingPaintAlg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModedRecursivePrimingPaintAlg.MergeIndex = 4;
            this.tsbModedRecursivePrimingPaintAlg.Name = "tsbModedRecursivePrimingPaintAlg";
            this.tsbModedRecursivePrimingPaintAlg.Size = new System.Drawing.Size(23, 22);
            this.tsbModedRecursivePrimingPaintAlg.Text = "модифицированный рекурсивный алгоритм с «затравкой»";
            this.tsbModedRecursivePrimingPaintAlg.Click += new System.EventHandler(this.tsbModedRecursivePrimingPaintAlg_Click);
            // 
            // tsbRecursivePrimingPaintAlg
            // 
            this.tsbRecursivePrimingPaintAlg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRecursivePrimingPaintAlg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRecursivePrimingPaintAlg.MergeIndex = 6;
            this.tsbRecursivePrimingPaintAlg.Name = "tsbRecursivePrimingPaintAlg";
            this.tsbRecursivePrimingPaintAlg.Size = new System.Drawing.Size(23, 22);
            this.tsbRecursivePrimingPaintAlg.Text = "рекурсивный алгоритм с «затравкой»";
            this.tsbRecursivePrimingPaintAlg.Click += new System.EventHandler(this.tsbRecursivePrimingPaintAlg_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripCombobox
            // 
            this.toolStripCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripCombobox.Items.AddRange(new object[] {
            "2 пикселя",
            "4 пикселя",
            "8 пикселей"});
            this.toolStripCombobox.Name = "toolStripCombobox";
            this.toolStripCombobox.Size = new System.Drawing.Size(121, 25);
            this.toolStripCombobox.SelectedIndexChanged += new System.EventHandler(this.tsbCombobox_SelectedIndexChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Bitmap File(*.bmp)|*.bmp|GIF File(*.gif)|*.gif|JPEG File(*.jpg)|*.jpg|TIF File(*." +
    "tif)|*.tif|PNG File(*.png)|*.png";
            this.saveFileDialog1.Title = "сохранить картинку как...";
            // 
            // gbCurveSettings
            // 
            this.gbCurveSettings.Controls.Add(this.labelHelp3);
            this.gbCurveSettings.Controls.Add(this.labelHelp2);
            this.gbCurveSettings.Controls.Add(this.labelHelp1);
            this.gbCurveSettings.Controls.Add(this.trackbarW2);
            this.gbCurveSettings.Controls.Add(this.labelW2);
            this.gbCurveSettings.Controls.Add(this.trackbarW1);
            this.gbCurveSettings.Controls.Add(this.labelW1);
            this.gbCurveSettings.Controls.Add(this.trackbarR2);
            this.gbCurveSettings.Controls.Add(this.label2);
            this.gbCurveSettings.Controls.Add(this.labelR1);
            this.gbCurveSettings.Controls.Add(this.trackbarR1);
            this.gbCurveSettings.Location = new System.Drawing.Point(0, 28);
            this.gbCurveSettings.Name = "gbCurveSettings";
            this.gbCurveSettings.Size = new System.Drawing.Size(116, 500);
            this.gbCurveSettings.TabIndex = 7;
            this.gbCurveSettings.TabStop = false;
            this.gbCurveSettings.Text = "рисование кривой";
            // 
            // labelHelp3
            // 
            this.labelHelp3.AutoSize = true;
            this.labelHelp3.Location = new System.Drawing.Point(3, 376);
            this.labelHelp3.Name = "labelHelp3";
            this.labelHelp3.Size = new System.Drawing.Size(94, 65);
            this.labelHelp3.TabIndex = 10;
            this.labelHelp3.Text = "фигура Лиссажу,\r\nесли:\r\n* R1 != R2,\r\n* W1 != W2\r\n ";
            // 
            // labelHelp2
            // 
            this.labelHelp2.AutoSize = true;
            this.labelHelp2.Location = new System.Drawing.Point(3, 324);
            this.labelHelp2.Name = "labelHelp2";
            this.labelHelp2.Size = new System.Drawing.Size(76, 52);
            this.labelHelp2.TabIndex = 9;
            this.labelHelp2.Text = "эллипс, если:\r\n* R1 != R2,\r\n* W1= W2\r\n ";
            // 
            // labelHelp1
            // 
            this.labelHelp1.AutoSize = true;
            this.labelHelp1.Location = new System.Drawing.Point(3, 272);
            this.labelHelp1.Name = "labelHelp1";
            this.labelHelp1.Size = new System.Drawing.Size(100, 52);
            this.labelHelp1.TabIndex = 8;
            this.labelHelp1.Text = "окружность, если:\r\n* R1 = R2,\r\n* W1 = W2\r\n ";
            // 
            // trackbarW2
            // 
            this.trackbarW2.Location = new System.Drawing.Point(6, 224);
            this.trackbarW2.Minimum = 1;
            this.trackbarW2.Name = "trackbarW2";
            this.trackbarW2.Size = new System.Drawing.Size(104, 45);
            this.trackbarW2.TabIndex = 7;
            this.trackbarW2.Value = 1;
            this.trackbarW2.Scroll += new System.EventHandler(this.trackbarW2_Scroll);
            // 
            // labelW2
            // 
            this.labelW2.AutoSize = true;
            this.labelW2.Location = new System.Drawing.Point(9, 208);
            this.labelW2.Name = "labelW2";
            this.labelW2.Size = new System.Drawing.Size(24, 13);
            this.labelW2.TabIndex = 6;
            this.labelW2.Text = "W2";
            // 
            // trackbarW1
            // 
            this.trackbarW1.Location = new System.Drawing.Point(6, 160);
            this.trackbarW1.Minimum = 1;
            this.trackbarW1.Name = "trackbarW1";
            this.trackbarW1.Size = new System.Drawing.Size(104, 45);
            this.trackbarW1.TabIndex = 5;
            this.trackbarW1.Value = 1;
            this.trackbarW1.Scroll += new System.EventHandler(this.trackbarW1_Scroll);
            // 
            // labelW1
            // 
            this.labelW1.AutoSize = true;
            this.labelW1.Location = new System.Drawing.Point(9, 144);
            this.labelW1.Name = "labelW1";
            this.labelW1.Size = new System.Drawing.Size(24, 13);
            this.labelW1.TabIndex = 4;
            this.labelW1.Text = "W1";
            // 
            // trackbarR2
            // 
            this.trackbarR2.Location = new System.Drawing.Point(6, 96);
            this.trackbarR2.Maximum = 500;
            this.trackbarR2.Minimum = 1;
            this.trackbarR2.Name = "trackbarR2";
            this.trackbarR2.Size = new System.Drawing.Size(104, 45);
            this.trackbarR2.TabIndex = 3;
            this.trackbarR2.Value = 1;
            this.trackbarR2.Scroll += new System.EventHandler(this.trackbarR2_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "R2";
            // 
            // labelR1
            // 
            this.labelR1.AutoSize = true;
            this.labelR1.Location = new System.Drawing.Point(9, 16);
            this.labelR1.Name = "labelR1";
            this.labelR1.Size = new System.Drawing.Size(21, 13);
            this.labelR1.TabIndex = 1;
            this.labelR1.Text = "R1";
            // 
            // trackbarR1
            // 
            this.trackbarR1.Location = new System.Drawing.Point(6, 32);
            this.trackbarR1.Maximum = 500;
            this.trackbarR1.Minimum = 1;
            this.trackbarR1.Name = "trackbarR1";
            this.trackbarR1.Size = new System.Drawing.Size(104, 45);
            this.trackbarR1.TabIndex = 0;
            this.trackbarR1.Value = 1;
            this.trackbarR1.Scroll += new System.EventHandler(this.trackbarR1_Scroll);
            // 
            // pb
            // 
            this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb.BackColor = System.Drawing.SystemColors.Window;
            this.pb.Location = new System.Drawing.Point(122, 28);
            this.pb.MaximumSize = new System.Drawing.Size(500, 500);
            this.pb.MinimumSize = new System.Drawing.Size(500, 500);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(500, 500);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            this.pb.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_Paint);
            this.pb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_MouseDown);
            this.pb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_MouseMove);
            this.pb.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_MouseUp);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.gbCurveSettings);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.pb);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Графический редактор";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.gbCurveSettings.ResumeLayout(false);
            this.gbCurveSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarW2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarW1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarR2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarR1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton palette;
        private System.Windows.Forms.ToolStripButton tsbBrush;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolStripCombobox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton tsbBresenhamLine;
        private System.Windows.Forms.ToolStripButton tsbBresenhamCircle;
        private System.Windows.Forms.GroupBox gbCurveSettings;
        private System.Windows.Forms.TrackBar trackbarR1;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.TrackBar trackbarW2;
        private System.Windows.Forms.Label labelW2;
        private System.Windows.Forms.TrackBar trackbarW1;
        private System.Windows.Forms.Label labelW1;
        private System.Windows.Forms.TrackBar trackbarR2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelR1;
        private System.Windows.Forms.ToolStripButton tsbCurveInParamWay;
        private System.Windows.Forms.Label labelHelp3;
        private System.Windows.Forms.Label labelHelp2;
        private System.Windows.Forms.Label labelHelp1;
        private System.Windows.Forms.ToolStripButton tsbModedRecursivePrimingPaintAlg;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbRecursivePrimingPaintAlg;
    }
}