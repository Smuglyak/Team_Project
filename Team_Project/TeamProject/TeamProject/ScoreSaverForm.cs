using System;
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
    public partial class ScoreSaverForm : recordViewerForm
    {
        private StreamWriter fileWriter;
        public ScoreSaverForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string[] values = GetTextBoxValues();

            if (!string.IsNullOrEmpty(values[(int)TextBoxIndices.PlayerName]))
            {
                try
                {
                        var playerRecord = new PlayerRecord(values[(int)TextBoxIndices.PlayerName],
                            int.Parse(values[(int)TextBoxIndices.Score]));

                        fileWriter.WriteLine(
                                $"{playerRecord.PlayerName},{playerRecord.Score}");
                }
                catch (IOException)
                {
                    MessageBox.Show("Error Writing to File", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Format", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ClearTextBoxes();
        }
        private void viewButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            using (var fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false;
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }
            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid File Name", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        var output = new FileStream(fileName,
                            FileMode.OpenOrCreate, FileAccess.Write);
                        fileWriter = new StreamWriter(output);
                        viewButton.Enabled = false;
                        saveButton.Enabled = true;
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error opening file", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        
        private void closeButton_Click(object sender, EventArgs e)
        {
            try
            {
                fileWriter?.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Cannot close file", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Application.Exit();
        }

        private void backToGameButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
