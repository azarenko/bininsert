using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace bininsert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sourceFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                destinationFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (!File.Exists(sourceFilePath.Text)) return;
            if (!File.Exists(destinationFilePath.Text)) return;

            try
            {
                using (FileStream source = new FileStream(sourceFilePath.Text, FileMode.Open))
                using (FileStream destination = new FileStream(destinationFilePath.Text, FileMode.Open))
                {
                    int sourceStartIndex = int.Parse(sourceStart.Text, System.Globalization.NumberStyles.HexNumber);
                    int destinationStartIndex = int.Parse(destinationStart.Text, System.Globalization.NumberStyles.HexNumber);
                    int length = int.Parse(sourceLength.Text, System.Globalization.NumberStyles.HexNumber);

                    byte[] buffer = new byte[length];

                    source.Seek(sourceStartIndex, SeekOrigin.Begin);
                    source.Read(buffer, 0, length);

                    source.Seek(sourceStartIndex, SeekOrigin.Begin);
                    destination.Write(buffer, 0, length);
                }
                MessageBox.Show("Complited", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }
    }
}
