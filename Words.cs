using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BebeApp
{
    public partial class Words : Form
    {
        public Words()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllLines("Words.txt", Main.verbs);
            Close();
        }
        
        private void Words_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = Main.verbs;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newWordForm = new NewWord(this);

            newWordForm.Show();
        }

        public void UpdateListBox()
        {
            listBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main.verbs.Remove((string)listBox1.SelectedItem);
        }
    }
}
