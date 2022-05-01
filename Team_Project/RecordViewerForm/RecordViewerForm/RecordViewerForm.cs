using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordViewerForm
{
    public partial class recordViewerForm : Form
    {
        protected int TextBoxCount { get; set; } = 2;

        public enum TextBoxIndices { PlayerName, Score }
        public recordViewerForm()
        {
            InitializeComponent();
        }

        public void ClearTextBoxes()
        {
            foreach (Control guiControl in Controls)
            {
                (guiControl as TextBox)?.Clear();
            }
        }

        public void SetTextBoxValues(string[] values)
        {
            if (values.Length != TextBoxCount)
            {
                throw (new ArgumentException(
                $"There must be {TextBoxCount} strings in the array",
                nameof(values)));
            }
            else
            {
                nameTextBox.Text = values[(int)TextBoxIndices.PlayerName];
                scoreTextBox.Text = values[(int)TextBoxIndices.Score];
            }
        }
        public string[] GetTextBoxValues()
        {
            return new string[] { nameTextBox.Text, scoreTextBox.Text, };
        }
    }
}
