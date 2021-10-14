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

namespace BebeApp
{
    public partial class Main : Form
    {
        //List<string> verbs = new List<string> {"Резать", "Завидовать", "Убить", "Бриться", "Тратить", 
        //    "Играть", "Воевать", "Предавать", "Прыгать", "Склоняться", "Просыпаться", "Страдать", 
        //    "Отодвигать", "Переделывать", "Улучшать", "Пережить", "Учить", "Подарить" };

        public static BindingList<string> verbs = new BindingList<string>();
        
        List<string> who = new List<string> { "io", "tu", "voi(f)", "voi(m)", "noi(f)", 
            "noi(m)", "lei/lui", "loro(f)", "loro(m)" };
        
        List<string> when = new List<string> { 
            "Congiuntivo imperfetto", 
            "Ind. passato prossimo", 
            "Indicativo presente", 
            "Ind. trapassato prossimo", 
            "Indicativo imperfetto", 
            "Ind. futuro semplice", 
            "Participio passato", 
            "Ind. futuro anteriore", 
            "Congiuntivo passato", 
            "Congiuntivo trapassato", 
            "Imperativo", 
            "Congiuntivo presente" };


        Random rand = new Random(); 
        
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in File.ReadAllLines("Words.txt"))
            {
                verbs.Add(item);
            }
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = verbs[rand.Next(verbs.Count)];
            this.label2.Text = who[rand.Next(who.Count)];
            this.label3.Text = when[rand.Next(when.Count)];
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var wordsForm = new Words();

            wordsForm.Show();
        }
    }
}
