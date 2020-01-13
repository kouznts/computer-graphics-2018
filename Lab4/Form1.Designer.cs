namespace Lab4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region код, автоматически созданный конструктором форм Windows
        private void InitializeComponent()
        {
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenAndConvertImage = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.rbGrayscale = new System.Windows.Forms.RadioButton();
            this.rbMonochrome = new System.Windows.Forms.RadioButton();
            this.rbDetectEdges = new System.Windows.Forms.RadioButton();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.tbDetectEdgesThreshold = new System.Windows.Forms.TextBox();
            this.tbMonochromeThreshold = new System.Windows.Forms.TextBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.pbOldImage = new System.Windows.Forms.PictureBox();
            this.pbNewImage = new System.Windows.Forms.PictureBox();
            this.gbSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOldImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOpenAndConvertImage
            // 
            this.btnOpenAndConvertImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpenAndConvertImage.Location = new System.Drawing.Point(9, 460);
            this.btnOpenAndConvertImage.MaximumSize = new System.Drawing.Size(0, 25);
            this.btnOpenAndConvertImage.MinimumSize = new System.Drawing.Size(200, 25);
            this.btnOpenAndConvertImage.Name = "btnOpenAndConvertImage";
            this.btnOpenAndConvertImage.Size = new System.Drawing.Size(200, 25);
            this.btnOpenAndConvertImage.TabIndex = 5;
            this.btnOpenAndConvertImage.Text = "Открыть и преоборазовать";
            this.btnOpenAndConvertImage.UseVisualStyleBackColor = true;
            this.btnOpenAndConvertImage.Click += new System.EventHandler(this.btnOpenAndConvertImage_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveImage.Location = new System.Drawing.Point(507, 460);
            this.btnSaveImage.MaximumSize = new System.Drawing.Size(0, 25);
            this.btnSaveImage.MinimumSize = new System.Drawing.Size(200, 25);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(200, 25);
            this.btnSaveImage.TabIndex = 6;
            this.btnSaveImage.Text = "Сохранить";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // rbGrayscale
            // 
            this.rbGrayscale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbGrayscale.AutoSize = true;
            this.rbGrayscale.Checked = true;
            this.rbGrayscale.Location = new System.Drawing.Point(6, 19);
            this.rbGrayscale.Name = "rbGrayscale";
            this.rbGrayscale.Size = new System.Drawing.Size(113, 17);
            this.rbGrayscale.TabIndex = 1;
            this.rbGrayscale.TabStop = true;
            this.rbGrayscale.Text = "В оттенки серого";
            this.rbGrayscale.UseVisualStyleBackColor = true;
            this.rbGrayscale.CheckedChanged += new System.EventHandler(this.rbGrayscale_CheckedChanged);
            // 
            // rbMonochrome
            // 
            this.rbMonochrome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbMonochrome.AutoSize = true;
            this.rbMonochrome.Location = new System.Drawing.Point(125, 19);
            this.rbMonochrome.Name = "rbMonochrome";
            this.rbMonochrome.Size = new System.Drawing.Size(104, 17);
            this.rbMonochrome.TabIndex = 2;
            this.rbMonochrome.Text = "В монохромное";
            this.rbMonochrome.UseVisualStyleBackColor = true;
            this.rbMonochrome.CheckedChanged += new System.EventHandler(this.rbMonochrome_CheckedChanged);
            // 
            // rbDetectEdges
            // 
            this.rbDetectEdges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbDetectEdges.AutoSize = true;
            this.rbDetectEdges.Location = new System.Drawing.Point(270, 19);
            this.rbDetectEdges.Name = "rbDetectEdges";
            this.rbDetectEdges.Size = new System.Drawing.Size(131, 17);
            this.rbDetectEdges.TabIndex = 6;
            this.rbDetectEdges.Text = "Выделение контуров";
            this.rbDetectEdges.UseVisualStyleBackColor = true;
            this.rbDetectEdges.CheckedChanged += new System.EventHandler(this.rbDetectEdges_CheckedChanged);
            // 
            // gbSettings
            // 
            this.gbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSettings.Controls.Add(this.tbDetectEdgesThreshold);
            this.gbSettings.Controls.Add(this.tbMonochromeThreshold);
            this.gbSettings.Controls.Add(this.rbGrayscale);
            this.gbSettings.Controls.Add(this.rbDetectEdges);
            this.gbSettings.Controls.Add(this.rbMonochrome);
            this.gbSettings.Location = new System.Drawing.Point(9, 404);
            this.gbSettings.MaximumSize = new System.Drawing.Size(600, 50);
            this.gbSettings.MinimumSize = new System.Drawing.Size(610, 50);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(610, 50);
            this.gbSettings.TabIndex = 0;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Преобразования";
            // 
            // tbDetectEdgesThreshold
            // 
            this.tbDetectEdgesThreshold.Location = new System.Drawing.Point(407, 19);
            this.tbDetectEdgesThreshold.MaxLength = 3;
            this.tbDetectEdgesThreshold.Name = "tbDetectEdgesThreshold";
            this.tbDetectEdgesThreshold.Size = new System.Drawing.Size(29, 20);
            this.tbDetectEdgesThreshold.TabIndex = 7;
            this.tbDetectEdgesThreshold.Text = "100";
            this.tbDetectEdgesThreshold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDetectEdgesThreshold_KeyPress);
            // 
            // tbMonochromeThreshold
            // 
            this.tbMonochromeThreshold.Location = new System.Drawing.Point(235, 19);
            this.tbMonochromeThreshold.MaxLength = 3;
            this.tbMonochromeThreshold.Name = "tbMonochromeThreshold";
            this.tbMonochromeThreshold.Size = new System.Drawing.Size(29, 20);
            this.tbMonochromeThreshold.TabIndex = 5;
            this.tbMonochromeThreshold.Text = "100";
            this.tbMonochromeThreshold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMonochromeThreshold_KeyPress);
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(9, 9);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer.MinimumSize = new System.Drawing.Size(405, 200);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.pbOldImage);
            this.splitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer.Panel1MinSize = 200;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.pbNewImage);
            this.splitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer.Panel2MinSize = 200;
            this.splitContainer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer.Size = new System.Drawing.Size(698, 386);
            this.splitContainer.SplitterDistance = 343;
            this.splitContainer.SplitterWidth = 5;
            this.splitContainer.TabIndex = 9;
            // 
            // pbOldImage
            // 
            this.pbOldImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbOldImage.BackColor = System.Drawing.Color.White;
            this.pbOldImage.Location = new System.Drawing.Point(0, 0);
            this.pbOldImage.MinimumSize = new System.Drawing.Size(200, 200);
            this.pbOldImage.Name = "pbOldImage";
            this.pbOldImage.Size = new System.Drawing.Size(343, 386);
            this.pbOldImage.TabIndex = 0;
            this.pbOldImage.TabStop = false;
            // 
            // pbNewImage
            // 
            this.pbNewImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbNewImage.BackColor = System.Drawing.Color.White;
            this.pbNewImage.Location = new System.Drawing.Point(0, 0);
            this.pbNewImage.MinimumSize = new System.Drawing.Size(200, 200);
            this.pbNewImage.Name = "pbNewImage";
            this.pbNewImage.Size = new System.Drawing.Size(342, 386);
            this.pbNewImage.TabIndex = 1;
            this.pbNewImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 497);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.btnOpenAndConvertImage);
            this.MinimumSize = new System.Drawing.Size(439, 350);
            this.Name = "Form1";
            this.Text = "Преобразование изображения";
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbOldImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewImage)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOpenAndConvertImage;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.RadioButton rbGrayscale;
        private System.Windows.Forms.RadioButton rbMonochrome;
        private System.Windows.Forms.RadioButton rbDetectEdges;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.PictureBox pbOldImage;
        private System.Windows.Forms.PictureBox pbNewImage;
        private System.Windows.Forms.TextBox tbMonochromeThreshold;
        private System.Windows.Forms.TextBox tbDetectEdgesThreshold;
    }
}

