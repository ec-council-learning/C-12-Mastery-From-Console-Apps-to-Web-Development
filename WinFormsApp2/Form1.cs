namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private string currentFilePath = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            currentFilePath = null;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Read the contents of the file into a stream
                    var fileStream = openFileDialog1.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        // Display the content in the text box
                        textBox1.Text = reader.ReadToEnd();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            currentFilePath = openFileDialog1.FileName;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
                {
                    writer.Write(textBox1.Text);
                }
            }
            currentFilePath = saveFileDialog1.FileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                saveAsToolStripMenuItem_Click(sender, e);  // Call the Save As functionality
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(currentFilePath))
                {
                    writer.Write(textBox1.Text);
                }
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void fontStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }

        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }
        }
    }
}
