﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using RecordViewerForm;

namespace TeamProject
{
    public partial class ScoreViewerForm : recordViewerForm
    {
        private StreamReader fileReader;
        public ScoreViewerForm()
        {
            InitializeComponent();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }
            if (result == DialogResult.OK)
            {
                ClearTextBoxes();
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid File Name", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        FileStream input = new FileStream(
                                    fileName, FileMode.Open, FileAccess.Read);
                        fileReader = new StreamReader(input);
                        viewButton.Enabled = false;
                        nextButton.Enabled = true;
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error reading from file",
                                    "File Error", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            try
            {
                var inputRecord = fileReader.ReadLine();
                if (inputRecord != null)
                {
                    string[] inputFields = inputRecord.Split(',');
                    SetTextBoxValues(inputFields);
                }
                else
                {
                    fileReader.Close();
                    viewButton.Enabled = true;
                    ClearTextBoxes();
                    MessageBox.Show("No more records in file", string.Empty,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Error Reading from File", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void backToGameButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
