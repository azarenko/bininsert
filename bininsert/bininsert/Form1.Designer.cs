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
            this.sourceEnd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._sourceLenRB = new System.Windows.Forms.RadioButton();
            this._sourceStartRB = new System.Windows.Forms.RadioButton();
            this.insert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.destinationStart = new System.Windows.Forms.TextBox();
            this.sourceLength = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sourceStart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this._autoOriCalib = new System.Windows.Forms.TextBox();
            this._autoModCalib = new System.Windows.Forms.TextBox();
            this._autoOriFull = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this._autoModFull = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this._autoCopy = new System.Windows.Forms.Button();
            this._autoSelOriCal = new System.Windows.Forms.Button();
            this._autoSelModCal = new System.Windows.Forms.Button();
            this._autoSelOriFull = new System.Windows.Forms.Button();
            this._autoSelModFull = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceFilePath
            // 
            this.sourceFilePath.Location = new System.Drawing.Point(120, 15);
            this.sourceFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.sourceFilePath.Name = "sourceFilePath";
            this.sourceFilePath.Size = new System.Drawing.Size(468, 22);
            this.sourceFilePath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source file:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination file:";
            // 
            // destinationFilePath
            // 
            this.destinationFilePath.Location = new System.Drawing.Point(120, 47);
            this.destinationFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.destinationFilePath.Name = "destinationFilePath";
            this.destinationFilePath.Size = new System.Drawing.Size(468, 22);
            this.destinationFilePath.TabIndex = 2;
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(598, 12);
            this.openFile.Margin = new System.Windows.Forms.Padding(4);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(52, 28);
            this.openFile.TabIndex = 4;
            this.openFile.Text = "...";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(598, 44);
            this.saveFile.Margin = new System.Windows.Forms.Padding(4);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(52, 28);
            this.saveFile.TabIndex = 5;
            this.saveFile.Text = "...";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sourceEnd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this._sourceLenRB);
            this.groupBox1.Controls.Add(this._sourceStartRB);
            this.groupBox1.Controls.Add(this.insert);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.destinationStart);
            this.groupBox1.Controls.Add(this.sourceLength);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.sourceStart);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(7, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(643, 182);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // sourceEnd
            // 
            this.sourceEnd.Location = new System.Drawing.Point(185, 54);
            this.sourceEnd.Margin = new System.Windows.Forms.Padding(4);
            this.sourceEnd.Name = "sourceEnd";
            this.sourceEnd.Size = new System.Drawing.Size(132, 22);
            this.sourceEnd.TabIndex = 10;
            this.sourceEnd.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Source end position 0x";
            // 
            // _sourceLenRB
            // 
            this._sourceLenRB.AutoSize = true;
            this._sourceLenRB.Checked = true;
            this._sourceLenRB.Location = new System.Drawing.Point(11, 87);
            this._sourceLenRB.Name = "_sourceLenRB";
            this._sourceLenRB.Size = new System.Drawing.Size(17, 16);
            this._sourceLenRB.TabIndex = 8;
            this._sourceLenRB.TabStop = true;
            this._sourceLenRB.UseVisualStyleBackColor = true;
            // 
            // _sourceStartRB
            // 
            this._sourceStartRB.AutoSize = true;
            this._sourceStartRB.Location = new System.Drawing.Point(11, 57);
            this._sourceStartRB.Name = "_sourceStartRB";
            this._sourceStartRB.Size = new System.Drawing.Size(17, 16);
            this._sourceStartRB.TabIndex = 7;
            this._sourceStartRB.UseVisualStyleBackColor = true;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(10, 147);
            this.insert.Margin = new System.Windows.Forms.Padding(4);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(100, 28);
            this.insert.TabIndex = 6;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Destination start index 0x";
            // 
            // destinationStart
            // 
            this.destinationStart.Location = new System.Drawing.Point(170, 113);
            this.destinationStart.Margin = new System.Windows.Forms.Padding(4);
            this.destinationStart.Name = "destinationStart";
            this.destinationStart.Size = new System.Drawing.Size(132, 22);
            this.destinationStart.TabIndex = 4;
            this.destinationStart.Text = "0";
            // 
            // sourceLength
            // 
            this.sourceLength.Location = new System.Drawing.Point(145, 83);
            this.sourceLength.Margin = new System.Windows.Forms.Padding(4);
            this.sourceLength.Name = "sourceLength";
            this.sourceLength.Size = new System.Drawing.Size(132, 22);
            this.sourceLength.TabIndex = 3;
            this.sourceLength.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Source length 0x";
            // 
            // sourceStart
            // 
            this.sourceStart.Location = new System.Drawing.Point(160, 24);
            this.sourceStart.Margin = new System.Windows.Forms.Padding(4);
            this.sourceStart.Name = "sourceStart";
            this.sourceStart.Size = new System.Drawing.Size(132, 22);
            this.sourceStart.TabIndex = 1;
            this.sourceStart.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Source start position 0x";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(674, 315);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.sourceFilePath);
            this.tabPage1.Controls.Add(this.saveFile);
            this.tabPage1.Controls.Add(this.destinationFilePath);
            this.tabPage1.Controls.Add(this.openFile);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(666, 286);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manual";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this._autoSelModFull);
            this.tabPage2.Controls.Add(this._autoSelOriFull);
            this.tabPage2.Controls.Add(this._autoSelModCal);
            this.tabPage2.Controls.Add(this._autoSelOriCal);
            this.tabPage2.Controls.Add(this._autoCopy);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this._autoModFull);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this._autoOriFull);
            this.tabPage2.Controls.Add(this._autoModCalib);
            this.tabPage2.Controls.Add(this._autoOriCalib);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(666, 286);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Automatic";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // _autoOriCalib
            // 
            this._autoOriCalib.Location = new System.Drawing.Point(161, 3);
            this._autoOriCalib.Name = "_autoOriCalib";
            this._autoOriCalib.Size = new System.Drawing.Size(427, 22);
            this._autoOriCalib.TabIndex = 0;
            // 
            // _autoModCalib
            // 
            this._autoModCalib.Location = new System.Drawing.Point(161, 34);
            this._autoModCalib.Name = "_autoModCalib";
            this._autoModCalib.Size = new System.Drawing.Size(427, 22);
            this._autoModCalib.TabIndex = 1;
            // 
            // _autoOriFull
            // 
            this._autoOriFull.Location = new System.Drawing.Point(161, 62);
            this._autoOriFull.Name = "_autoOriFull";
            this._autoOriFull.Size = new System.Drawing.Size(427, 22);
            this._autoOriFull.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Original calibration file:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Modified calibration file:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Original full file:";
            // 
            // _autoModFull
            // 
            this._autoModFull.Location = new System.Drawing.Point(161, 90);
            this._autoModFull.Name = "_autoModFull";
            this._autoModFull.Size = new System.Drawing.Size(427, 22);
            this._autoModFull.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Modified full file:";
            // 
            // _autoCopy
            // 
            this._autoCopy.Location = new System.Drawing.Point(161, 118);
            this._autoCopy.Name = "_autoCopy";
            this._autoCopy.Size = new System.Drawing.Size(344, 23);
            this._autoCopy.TabIndex = 8;
            this._autoCopy.Text = "Copy data";
            this._autoCopy.UseVisualStyleBackColor = true;
            this._autoCopy.Click += new System.EventHandler(this._autoCopy_Click);
            // 
            // _autoSelOriCal
            // 
            this._autoSelOriCal.Location = new System.Drawing.Point(595, 2);
            this._autoSelOriCal.Name = "_autoSelOriCal";
            this._autoSelOriCal.Size = new System.Drawing.Size(63, 23);
            this._autoSelOriCal.TabIndex = 9;
            this._autoSelOriCal.Text = "...";
            this._autoSelOriCal.UseVisualStyleBackColor = true;
            this._autoSelOriCal.Click += new System.EventHandler(this._autoSelOriCal_Click);
            // 
            // _autoSelModCal
            // 
            this._autoSelModCal.Location = new System.Drawing.Point(594, 30);
            this._autoSelModCal.Name = "_autoSelModCal";
            this._autoSelModCal.Size = new System.Drawing.Size(63, 23);
            this._autoSelModCal.TabIndex = 10;
            this._autoSelModCal.Text = "...";
            this._autoSelModCal.UseVisualStyleBackColor = true;
            this._autoSelModCal.Click += new System.EventHandler(this._autoSelModCal_Click);
            // 
            // _autoSelOriFull
            // 
            this._autoSelOriFull.Location = new System.Drawing.Point(594, 58);
            this._autoSelOriFull.Name = "_autoSelOriFull";
            this._autoSelOriFull.Size = new System.Drawing.Size(63, 23);
            this._autoSelOriFull.TabIndex = 11;
            this._autoSelOriFull.Text = "...";
            this._autoSelOriFull.UseVisualStyleBackColor = true;
            this._autoSelOriFull.Click += new System.EventHandler(this._autoSelOriFull_Click);
            // 
            // _autoSelModFull
            // 
            this._autoSelModFull.Location = new System.Drawing.Point(594, 86);
            this._autoSelModFull.Name = "_autoSelModFull";
            this._autoSelModFull.Size = new System.Drawing.Size(63, 23);
            this._autoSelModFull.TabIndex = 12;
            this._autoSelModFull.Text = "...";
            this._autoSelModFull.UseVisualStyleBackColor = true;
            this._autoSelModFull.Click += new System.EventHandler(this._autoSelModFull_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 315);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Bin Insert by Azarenko S.A.";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox sourceEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton _sourceLenRB;
        private System.Windows.Forms.RadioButton _sourceStartRB;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _autoOriFull;
        private System.Windows.Forms.TextBox _autoOriCalib;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox _autoModFull;
        private System.Windows.Forms.Button _autoSelOriCal;
        private System.Windows.Forms.Button _autoCopy;
        private System.Windows.Forms.Button _autoSelModFull;
        private System.Windows.Forms.Button _autoSelOriFull;
        private System.Windows.Forms.Button _autoSelModCal;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox _autoModCalib;
    }
}

