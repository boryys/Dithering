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
            this.matrix = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.RadioButton();
            this.random = new System.Windows.Forms.RadioButton();
            this.loadFilter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1160, 411);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kBox);
            this.panel1.Controls.Add(this.loadImage);
            this.panel1.Controls.Add(this.matrix);
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
            // matrix
            // 
            this.matrix.FormattingEnabled = true;
            this.matrix.Items.AddRange(new object[] {
            "F&S",
            "B",
            "St",
            "Sr",
            "A"});
            this.matrix.Location = new System.Drawing.Point(11, 259);
            this.matrix.Name = "matrix";
            this.matrix.Size = new System.Drawing.Size(72, 21);
            this.matrix.TabIndex = 7;
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
            this.ClientSize = new System.Drawing.Size(1184, 462);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1200, 500);
            this.MinimumSize = new System.Drawing.Size(1200, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ComboBox matrix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox kBox;
    }
}

