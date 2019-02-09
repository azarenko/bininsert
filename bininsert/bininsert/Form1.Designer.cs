namespace bininsert
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.sourceFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.destinationFilePath = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.sourceStart = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sourceLength = new System.Windows.Forms.TextBox();
            this.destinationStart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.insert = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceFilePath
            // 
            this.sourceFilePath.Location = new System.Drawing.Point(97, 12);
            this.sourceFilePath.Name = "sourceFilePath";
            this.sourceFilePath.Size = new System.Drawing.Size(352, 20);
            this.sourceFilePath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source file:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination file:";
            // 
            // destinationFilePath
            // 
            this.destinationFilePath.Location = new System.Drawing.Point(97, 38);
            this.destinationFilePath.Name = "destinationFilePath";
            this.destinationFilePath.Size = new System.Drawing.Size(352, 20);
            this.destinationFilePath.TabIndex = 2;
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(455, 10);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(39, 23);
            this.openFile.TabIndex = 4;
            this.openFile.Text = "...";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(455, 36);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(39, 23);
            this.saveFile.TabIndex = 5;
            this.saveFile.Text = "...";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.insert);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.destinationStart);
            this.groupBox1.Controls.Add(this.sourceLength);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.sourceStart);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 106);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Source start index 0x";
            // 
            // sourceStart
            // 
            this.sourceStart.Location = new System.Drawing.Point(109, 19);
            this.sourceStart.Name = "sourceStart";
            this.sourceStart.Size = new System.Drawing.Size(100, 20);
            this.sourceStart.TabIndex = 1;
            this.sourceStart.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Source length 0x";
            // 
            // sourceLength
            // 
            this.sourceLength.Location = new System.Drawing.Point(298, 19);
            this.sourceLength.Name = "sourceLength";
            this.sourceLength.Size = new System.Drawing.Size(100, 20);
            this.sourceLength.TabIndex = 3;
            this.sourceLength.Text = "0";
            // 
            // destinationStart
            // 
            this.destinationStart.Location = new System.Drawing.Point(128, 45);
            this.destinationStart.Name = "destinationStart";
            this.destinationStart.Size = new System.Drawing.Size(100, 20);
            this.destinationStart.TabIndex = 4;
            this.destinationStart.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Destination start index 0x";
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(9, 77);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 6;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 171);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.destinationFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sourceFilePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Bin Insert by Azarenko S.A.";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sourceFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox destinationFilePath;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox destinationStart;
        private System.Windows.Forms.TextBox sourceLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sourceStart;
        private System.Windows.Forms.Label label3;
    }
}

