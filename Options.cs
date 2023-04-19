using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Options : Form
    {
        enum ThemeColor
        {
            Primary,
            Secondary,
            Tertiary,
            Text
        }
        Dictionary<ThemeColor, Color> Light = new Dictionary<ThemeColor, Color>();
        Dictionary<ThemeColor, Color> Dark = new Dictionary<ThemeColor, Color>();
        public Options()
        {
            InitializeComponent();

            Light = new Dictionary<ThemeColor, Color>() {
                { ThemeColor.Primary, Color.WhiteSmoke },
                { ThemeColor.Secondary, Color.Silver },
                { ThemeColor.Tertiary, Color.White },
                { ThemeColor.Text, Color.Black }
           };
            Dark = new Dictionary<ThemeColor, Color>() {
                { ThemeColor.Primary, Color.DimGray },
                { ThemeColor.Secondary, Color.DimGray },
                { ThemeColor.Tertiary, Color.Black },
                { ThemeColor.Text, Color.White }
           };
        }

        private void Options_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.instance.tim1.Enabled = true;
            Form1.instance.pl1.Visible = false;
            Form1.instance.pl2.Visible = true;
            Form1.instance.pl3.Visible = false;
        }
        private void ChangeTheme(Color primaryColor, Color secondaryColor, Color tertiaryColor)
        {
            // Change background color of buttons           
            button1.BackColor = primaryColor;
            button2.BackColor = primaryColor;
            button3.BackColor = primaryColor;
            button4.BackColor = primaryColor;
            button5.BackColor = primaryColor;

            this.BackColor = tertiaryColor;

            Form1.instance.BackColor = tertiaryColor;
            Form1.instance.btn11.BackColor = primaryColor;
            Form1.ButtonColor = primaryColor;   


        }
        private void ChangeTextColor(Color textColor)
        {
            // Change color of text
            button1.ForeColor = textColor;
            button2.ForeColor = textColor;
            button3.ForeColor = textColor;
            button4.ForeColor = textColor;
            button5.ForeColor = textColor;
            Form1.instance.btn11.ForeColor = textColor;
            Form1.ButtonTekstColor = textColor;
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeTheme(Dark[ThemeColor.Primary], Dark[ThemeColor.Secondary], Dark[ThemeColor.Tertiary]);
            ChangeTextColor(Dark[ThemeColor.Text]);        
        }

        private void Options_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Options_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void Options_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangeTheme(Light[ThemeColor.Primary], Light[ThemeColor.Secondary], Light[ThemeColor.Tertiary]);
            ChangeTextColor(Light[ThemeColor.Text]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.instance.tim1.Enabled = false;
            Form1.instance.pl1.Visible = false;
            Form1.instance.pl2.Visible = true;
            Form1.instance.pl3.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1.instance.tim1.Enabled = false;
            Form1.instance.pl1.Visible = true;
            Form1.instance.pl2.Visible = false;
            Form1.instance.pl3.Visible = false;
        }
    }
}
