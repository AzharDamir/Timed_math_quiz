using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuTo2
{
    public partial class Form1 : Form
    {
        public int timeleft;
        public int a, b, c, d, g, h, i, f;
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            timeleft = 30;
            Random r = new Random();
             a = r.Next(10);
             b = r.Next(10);
             c = r.Next(10);
             d = r.Next(10);
             g = r.Next(10);
             f = r.Next(10);
             h = r.Next(10);
             i = r.Next(10)+1;
            l1.Text = a.ToString();
            l2.Text = b.ToString();
            l3.Text = c.ToString();
            l4.Text = d.ToString();
            l5.Text = f.ToString();
            l6.Text = g.ToString();
            l7.Text = h.ToString();
            l8.Text = i.ToString();

            timer1.Start();

            Check.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Stop();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timeleft>0)
            {
            timeleft--;
            timeLabel.Text = timeleft.ToString();
            }
            if (timeleft == 0)
            {
               // Check.Enabled=false;
                Start.Enabled = true;
                timer1.Stop();
                timeLabel.Text = "Your time Finished";
            }
        }

        private void Check_Click(object sender, EventArgs e)
        {
            Check.Enabled = false;
            Start.Enabled = true;
            timer1.Stop();

            int add = a + b;
            int sous = c - d;
            int mult = f * g;
            int div = h / i;
            if (B1.Text == add.ToString() && B2.Text == sous.ToString() && B3.Text == mult.ToString() && B4.Text == div.ToString()) 
            {
                timer1.Stop();
                timeLabel.Text = "YOU WIN!";
            }else
            {
            if(!(B1.Text == add.ToString()))
            {
                MessageBox.Show("You have an error on addition!!");
                
            }
            if (!(B2.Text == sous.ToString()))
            {
                MessageBox.Show("You have an error on Soustraction!");
                
            }
            if (!(B3.Text == mult.ToString()))
            {
                MessageBox.Show("You have an error on multiplication!");
               
            }
            if (!(B4.Text == div.ToString()))
            {
                MessageBox.Show("You have an error on division");
            }
            }
           

        }
    }
}
