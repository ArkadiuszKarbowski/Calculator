using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    
    public partial class Form1 : Form
    {
        double Result;
        ArrayList operation = new ArrayList();
        bool check;
        
        public static Form1 instance;
        public Panel pl1, pl2, pl3;
        public Timer tim1;
        public Button btn11;
        public Label lbl1;
        private int _ticks;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            pl1 = panel1 as Panel;
            pl2 = panel2 as Panel;
            pl3 = panel3 as Panel;
            tim1 = timer1 as Timer;
            btn11 = button11 as Button;
            lbl1 = lbl1 as Label;
            
            
        }
        
        private void NumberClick(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (check)
            {
                check = false;
                ResultLabel.Text = "0";
            }

            if (ResultLabel.Text == "0")
                ResultLabel.Text = b.Text;
            else
                ResultLabel.Text += b.Text;
        }   
        
        private void OpertatorClick(object sender, EventArgs e)
        {
            Button b = sender as Button;
            Result = double.Parse(ResultLabel.Text);
            operation.Add(b.Text);
            ResultLabel.Text += b.Text;
            check = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < operation.Count; i++)
            try
            {
                switch (operation[i])
                {
                    case "+":
                        ResultLabel.Text = (Result + double.Parse(ResultLabel.Text)).ToString();
                        Result = 0;
                        break;
                    case "-":
                        ResultLabel.Text = (Result - double.Parse(ResultLabel.Text)).ToString();
                        Result = 0;
                        break;
                    case "×":
                        ResultLabel.Text = (Result * double.Parse(ResultLabel.Text)).ToString();
                        Result = 0;
                        break;
                    case "÷":
                        ResultLabel.Text = (Result / double.Parse(ResultLabel.Text)).ToString();
                        Result = 0;
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            ResultLabel.Text = "0";
            Result = 0;
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (ResultLabel.Text.Length > 1)
                ResultLabel.Text = ResultLabel.Text.Substring(0, ResultLabel.Text.Length - 1);
            else
                ResultLabel.Text = "0";
        }

        

        private void button11_Click(object sender, EventArgs e)
        {
            Options Opt = new Options();
            Opt.ShowDialog();
        }
        public void RefData(object sender, EventArgs e)
        {             
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        { 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks--;
            label1.Text = (_ticks).ToString();
            if (_ticks <= 0)
            {
                _ticks = 10;
            }

        }

        private void button22_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            if (check)
            {
                check = false;
                ResultLabel.Text = "0";
            }
            int iterations = random.Next(1, 3);

            for (int i = 0; i < iterations; i++) 
            if (ResultLabel.Text == "0")
                ResultLabel.Text = random.Next(0,10).ToString();
            else
                ResultLabel.Text += random.Next(0, 10).ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (check)
            {
                check = false;
                ResultLabel.Text = "0";
            }

            if (ResultLabel.Text == "0")
                ResultLabel.Text = _ticks.ToString();
            else
                ResultLabel.Text += _ticks.ToString();
        }
    }
}
