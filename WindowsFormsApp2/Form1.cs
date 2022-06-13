using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void open_Click(object sender, EventArgs e)
        {
            RichTextBox.open();
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog ;
            SaveFileDialog.Filter = "Text file (.rtf)|*.rtf";
        }

        private void copy_Click(object sender, EventArgs e)
        {
            RichTextBox.copy();
        }

        private void past_Click(object sender, EventArgs e)
        {
            RichTextBox.past();
        }

        private void color_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = richTextBoxl.ForeColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void font_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = richTextBox1.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.Font = fontDialogl.Font;
        }

        private void selectall_Click(object sender, EventArgs e)
        {
            RichTextBox.Selectall();
        }

        private void New_Click(object sender, EventArgs e)
        {
            RichTextBox.new ();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
