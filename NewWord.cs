using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BebeApp
{
    public partial class NewWord : Form
    {
        private Words _wordsForm;

        public NewWord(Words wordsForm)
        {
            InitializeComponent();
            _wordsForm = wordsForm;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main.verbs.AllowNew = true;
            Main.verbs.Add(textBox1.Text);
            Close();
            _wordsForm.UpdateListBox();
        }
    }
}
