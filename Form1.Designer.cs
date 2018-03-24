namespace Dithering
{
    partial class Form1
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kBox = new System.Windows.Forms.ComboBox();
            this.loadImage = new System.Windows.Forms.Button();
            this.matrixBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.RadioButton();
            this.random = new System.Windows.Forms.RadioButton();
            this.loadFilter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loadQuantization = new System.Windows.Forms.Button();
            this.sizeKBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kgBox = new System.Windows.Forms.TextBox();
            this.kbBox = new System.Windows.Forms.TextBox();
            this.krBox = new System.Windows.Forms.TextBox();
            this.medianCut = new System.Windows.Forms.RadioButton();
            this.uniform = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.originalButton = new System.Windows.Forms.Button();
            this.grayPhoto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(524, 405);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1260, 411);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kBox);
            this.panel1.Controls.Add(this.loadImage);
            this.panel1.Controls.Add(this.matrixBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.error);
            this.panel1.Controls.Add(this.random);
            this.panel1.Controls.Add(this.loadFilter);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(1063, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 405);
            this.panel1.TabIndex = 3;
            // 
            // kBox
            // 
            this.kBox.FormattingEnabled = true;
            this.kBox.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16"});
            this.kBox.Location = new System.Drawing.Point(34, 120);
            this.kBox.Name = "kBox";
            this.kBox.Size = new System.Drawing.Size(49, 21);
            this.kBox.TabIndex = 8;
            // 
            // loadImage
            // 
            this.loadImage.Location = new System.Drawing.Point(10, 10);
            this.loadImage.Margin = new System.Windows.Forms.Padding(10);
            this.loadImage.Name = "loadImage";
            this.loadImage.Size = new System.Drawing.Size(74, 71);
            this.loadImage.TabIndex = 4;
            this.loadImage.Text = "Load Image";
            this.loadImage.UseVisualStyleBackColor = true;
            this.loadImage.Click += new System.EventHandler(this.loadImage_Click);
            // 
            // matrixBox
            // 
            this.matrixBox.FormattingEnabled = true;
            this.matrixBox.Items.AddRange(new object[] {
            "F&S",
            "B",
            "St",
            "Sr",
            "A"});
            this.matrixBox.Location = new System.Drawing.Point(11, 259);
            this.matrixBox.Name = "matrixBox";
            this.matrixBox.Size = new System.Drawing.Size(72, 21);
            this.matrixBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "diffusion matrix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "k";
            // 
            // error
            // 
            this.error.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(18, 191);
            this.error.Margin = new System.Windows.Forms.Padding(10);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(47, 17);
            this.error.TabIndex = 3;
            this.error.TabStop = true;
            this.error.Text = "Error";
            this.error.UseVisualStyleBackColor = true;
            this.error.CheckedChanged += new System.EventHandler(this.error_CheckedChanged);
            // 
            // random
            // 
            this.random.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.random.AutoSize = true;
            this.random.Location = new System.Drawing.Point(18, 154);
            this.random.Margin = new System.Windows.Forms.Padding(10);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(65, 17);
            this.random.TabIndex = 1;
            this.random.TabStop = true;
            this.random.Text = "Random";
            this.random.UseVisualStyleBackColor = true;
            this.random.CheckedChanged += new System.EventHandler(this.random_CheckedChanged);
            // 
            // loadFilter
            // 
            this.loadFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadFilter.Location = new System.Drawing.Point(10, 324);
            this.loadFilter.Margin = new System.Windows.Forms.Padding(10);
            this.loadFilter.Name = "loadFilter";
            this.loadFilter.Size = new System.Drawing.Size(74, 71);
            this.loadFilter.TabIndex = 4;
            this.loadFilter.Text = "Load Dithering";
            this.loadFilter.UseVisualStyleBackColor = true;
            this.loadFilter.Click += new System.EventHandler(this.loadFilter_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.Location = new System.Drawing.Point(22, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dithering";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(533, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(524, 405);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.loadQuantization);
            this.panel2.Controls.Add(this.sizeKBox);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.kgBox);
            this.panel2.Controls.Add(this.kbBox);
            this.panel2.Controls.Add(this.krBox);
            this.panel2.Controls.Add(this.medianCut);
            this.panel2.Controls.Add(this.uniform);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.originalButton);
            this.panel2.Controls.Add(this.grayPhoto);
            this.panel2.Location = new System.Drawing.Point(1163, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(94, 405);
            this.panel2.TabIndex = 4;
            // 
            // loadQuantization
            // 
            this.loadQuantization.Location = new System.Drawing.Point(10, 324);
            this.loadQuantization.Margin = new System.Windows.Forms.Padding(10);
            this.loadQuantization.Name = "loadQuantization";
            this.loadQuantization.Size = new System.Drawing.Size(74, 71);
            this.loadQuantization.TabIndex = 13;
            this.loadQuantization.Text = "Load Quantization";
            this.loadQuantization.UseVisualStyleBackColor = true;
            this.loadQuantization.Click += new System.EventHandler(this.loadQuantization_Click);
            // 
            // sizeKBox
            // 
            this.sizeKBox.Location = new System.Drawing.Point(10, 293);
            this.sizeKBox.Name = "sizeKBox";
            this.sizeKBox.Size = new System.Drawing.Size(74, 20);
            this.sizeKBox.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 26);
            this.label10.TabIndex = 11;
            this.label10.Text = "Size k of \r\nthe colour palette";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "kb";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "kg";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "kr";
            // 
            // kgBox
            // 
            this.kgBox.Location = new System.Drawing.Point(26, 173);
            this.kgBox.Name = "kgBox";
            this.kgBox.Size = new System.Drawing.Size(65, 20);
            this.kgBox.TabIndex = 7;
            // 
            // kbBox
            // 
            this.kbBox.Location = new System.Drawing.Point(26, 199);
            this.kbBox.Name = "kbBox";
            this.kbBox.Size = new System.Drawing.Size(65, 20);
            this.kbBox.TabIndex = 6;
            // 
            // krBox
            // 
            this.krBox.Location = new System.Drawing.Point(26, 147);
            this.krBox.Name = "krBox";
            this.krBox.Size = new System.Drawing.Size(65, 20);
            this.krBox.TabIndex = 5;
            // 
            // medianCut
            // 
            this.medianCut.AutoSize = true;
            this.medianCut.Location = new System.Drawing.Point(10, 228);
            this.medianCut.Name = "medianCut";
            this.medianCut.Size = new System.Drawing.Size(79, 17);
            this.medianCut.TabIndex = 4;
            this.medianCut.TabStop = true;
            this.medianCut.Text = "Median Cut";
            this.medianCut.UseVisualStyleBackColor = true;
            this.medianCut.CheckedChanged += new System.EventHandler(this.medianCut_CheckedChanged);
            // 
            // uniform
            // 
            this.uniform.AutoSize = true;
            this.uniform.Location = new System.Drawing.Point(10, 124);
            this.uniform.Name = "uniform";
            this.uniform.Size = new System.Drawing.Size(61, 17);
            this.uniform.TabIndex = 3;
            this.uniform.TabStop = true;
            this.uniform.Text = "Uniform";
            this.uniform.UseVisualStyleBackColor = true;
            this.uniform.CheckedChanged += new System.EventHandler(this.uniform_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-2, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Colour Quantization";
            // 
            // originalButton
            // 
            this.originalButton.Location = new System.Drawing.Point(10, 48);
            this.originalButton.Name = "originalButton";
            this.originalButton.Size = new System.Drawing.Size(74, 33);
            this.originalButton.TabIndex = 1;
            this.originalButton.Text = "Original";
            this.originalButton.UseVisualStyleBackColor = true;
            this.originalButton.Click += new System.EventHandler(this.originalButton_Click);
            // 
            // grayPhoto
            // 
            this.grayPhoto.Location = new System.Drawing.Point(10, 10);
            this.grayPhoto.Margin = new System.Windows.Forms.Padding(10);
            this.grayPhoto.Name = "grayPhoto";
            this.grayPhoto.Size = new System.Drawing.Size(74, 33);
            this.grayPhoto.TabIndex = 0;
            this.grayPhoto.Text = "Gray Scaled";
            this.grayPhoto.UseVisualStyleBackColor = true;
            this.grayPhoto.Click += new System.EventHandler(this.grayPhoto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "GRAY SCALED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(761, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CHANGED";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 462);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1300, 500);
            this.MinimumSize = new System.Drawing.Size(1300, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loadImage;
        private System.Windows.Forms.RadioButton random;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton error;
        private System.Windows.Forms.Button loadFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox matrixBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox kBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button originalButton;
        private System.Windows.Forms.Button grayPhoto;
        private System.Windows.Forms.Button loadQuantization;
        private System.Windows.Forms.TextBox sizeKBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kgBox;
        private System.Windows.Forms.TextBox kbBox;
        private System.Windows.Forms.TextBox krBox;
        private System.Windows.Forms.RadioButton medianCut;
        private System.Windows.Forms.RadioButton uniform;
    }
}

