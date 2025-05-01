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
            if (!File.Exists(sourceFilePath.Text))
            {
                ShowError("Source file not found");
                return;
            }
            if (!File.Exists(destinationFilePath.Text))
            {
                ShowError("Destination file not found");
                return;
            }

            try
            {
                using (FileStream source = new FileStream(sourceFilePath.Text, FileMode.Open))
                using (FileStream destination = new FileStream(destinationFilePath.Text, FileMode.Open))
                {
                    int sourceStartIndex = int.Parse(sourceStart.Text, System.Globalization.NumberStyles.HexNumber);
                    int sourceEndIndex = int.Parse(sourceEnd.Text, System.Globalization.NumberStyles.HexNumber);
                    int destinationStartIndex = int.Parse(destinationStart.Text, System.Globalization.NumberStyles.HexNumber);
                    int length = int.Parse(sourceLength.Text, System.Globalization.NumberStyles.HexNumber);

                    if (_sourceStartRB.Checked)
                    {
                        length = sourceEndIndex - sourceStartIndex;
                    }

                    byte[] buffer = new byte[length];

                    source.Seek(sourceStartIndex, SeekOrigin.Begin);
                    source.Read(buffer, 0, length);

                    destination.Seek(destinationStartIndex, SeekOrigin.Begin);
                    destination.Write(buffer, 0, length);
                }

                ShowInfo("Completed");
            }
            catch (Exception exp)
            {
                ShowError(exp.Message);
            }
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowInfo(string message)
        {
            MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void _autoCopy_Click(object sender, EventArgs e)
        {
            string oriCalib = _autoOriCalib.Text;
            string modCalib = _autoModCalib.Text;
            string oriFull = _autoOriFull.Text;
            string modFull = _autoModFull.Text;

            if (!File.Exists(oriCalib))
            {
                ShowError("Original calibration files not found");
                return;
            }

            if (!File.Exists(modCalib))
            {
                ShowError("Modified calibration files not found");
                return;
            }

            if (!File.Exists(oriFull))
            {
                ShowError("Original full files not found");
                return;
            }

            try
            {
                using (FileStream oriCalibFs = new FileStream(oriCalib, FileMode.Open))
                using (FileStream modCalibFs = new FileStream(modCalib, FileMode.Open))
                using (FileStream oriFullFs = new FileStream(oriFull, FileMode.Open))
                using (FileStream modFullFs = new FileStream(modFull, FileMode.OpenOrCreate))
                {
                    while (oriCalibFs.Position < oriCalibFs.Length)
                    {
                        int ori = oriCalibFs.ReadByte();
                        int mod = modCalibFs.ReadByte();

                        if (ori != mod)
                        {
                            oriFullFs.ReadByte();
                            modFullFs.WriteByte((byte)mod);
                        }
                        else
                        {
                            modFullFs.WriteByte((byte)oriFullFs.ReadByte());
                        }
                    }
                }

                ShowInfo("Completed");
            }
            catch (Exception exp)
            {
                ShowError(exp.Message);
            }
        }

        private void _autoSelOriCal_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _autoOriCalib.Text = openFileDialog1.FileName;
            }
        }

        private void _autoSelModCal_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _autoModCalib.Text = openFileDialog1.FileName;
            }
        }

        private void _autoSelOriFull_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _autoOriFull.Text = openFileDialog1.FileName;
            }
        }

        private void _autoSelModFull_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _autoModFull.Text = saveFileDialog1.FileName;
            }
        }
    }
}
