using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4GUI
{
    public partial class Form1 : Form
    {
        List<Gadjets> GadjetsList = new List<Gadjets>();
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.GadjetsList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3) 
                {
                    case 0:
                        this.GadjetsList.Add(Noutbuk.Generate());
                        break;
                    case 1:
                        this.GadjetsList.Add(Planshet.Generate());
                        break;
                    case 2:
                        this.GadjetsList.Add(Smartfon.Generate());
                        break;

                }
            }
            ShowInfo();
        }
            private void ShowInfo()
            {
                int noutbukCount = 0;
                int planshetCount = 0;
                int smartfonCount = 0;
                foreach (var gadjet in this.GadjetsList)
                {
                    if (gadjet is Noutbuk)
                    {
                        noutbukCount += 1;
                    }
                    else if (gadjet is Planshet)
                    {
                        planshetCount += 1;
                    }
                    else if (gadjet is Smartfon)
                    {
                        smartfonCount += 1;
                    }
                }
                richTextBox2.Text = "Нтбк\tПлншт\tСмртфн";
                richTextBox2.Text += "\n";
                richTextBox2.Text += String.Format("{0}\t{1}\t{2}", noutbukCount, planshetCount, smartfonCount);
            }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.GadjetsList.Count == 0)
            {
                richTextBox1.Text = "Пусто Q_Q";
                return;
            }
            var fruit = this.GadjetsList[0];
            this.GadjetsList.RemoveAt(0);
            richTextBox1.Text = fruit.GetInfo();
            ShowInfo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
