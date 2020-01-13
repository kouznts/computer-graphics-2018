namespace Lab2
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBuild = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.PictureBox();
            this.rbStepLen1 = new System.Windows.Forms.RadioButton();
            this.rbStepLen2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuild
            // 
            this.btnBuild.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuild.Location = new System.Drawing.Point(12, 406);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(776, 32);
            this.btnBuild.TabIndex = 0;
            this.btnBuild.Text = "построить";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // pb
            // 
            this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb.BackColor = System.Drawing.Color.White;
            this.pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb.Location = new System.Drawing.Point(12, 12);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(776, 368);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb.TabIndex = 2;
            this.pb.TabStop = false;
            this.pb.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_Paint);
            // 
            // rbStepLen1
            // 
            this.rbStepLen1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbStepLen1.AutoSize = true;
            this.rbStepLen1.Checked = true;
            this.rbStepLen1.Location = new System.Drawing.Point(12, 383);
            this.rbStepLen1.Name = "rbStepLen1";
            this.rbStepLen1.Size = new System.Drawing.Size(92, 17);
            this.rbStepLen1.TabIndex = 3;
            this.rbStepLen1.TabStop = true;
            this.rbStepLen1.Text = "длина шага 3";
            this.rbStepLen1.UseVisualStyleBackColor = true;
            this.rbStepLen1.CheckedChanged += new System.EventHandler(this.rbStepLen1_CheckedChanged);
            // 
            // rbStepLen2
            // 
            this.rbStepLen2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbStepLen2.AutoSize = true;
            this.rbStepLen2.Location = new System.Drawing.Point(103, 383);
            this.rbStepLen2.Name = "rbStepLen2";
            this.rbStepLen2.Size = new System.Drawing.Size(92, 17);
            this.rbStepLen2.TabIndex = 4;
            this.rbStepLen2.Text = "длина шага 5";
            this.rbStepLen2.UseVisualStyleBackColor = true;
            this.rbStepLen2.CheckedChanged += new System.EventHandler(this.rbStepLen2_CheckedChanged);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbStepLen2);
            this.Controls.Add(this.rbStepLen1);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.btnBuild);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form";
            this.Text = "Лабораторная работа №2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.RadioButton rbStepLen1;
        private System.Windows.Forms.RadioButton rbStepLen2;
    }
}