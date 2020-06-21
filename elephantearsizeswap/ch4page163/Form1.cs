using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch4page163
{
    public partial class Form1 : Form
    {
        Elephant lucinda;
        Elephant lloyd;
        

        public Form1()
        {
            InitializeComponent();
            lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elephant placeholder;
            placeholder = lucinda;
            lucinda = lloyd;
            lloyd = placeholder;

            MessageBox.Show("Objects swapped!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lloyd.TellMe("Hi!", lucinda);
            lloyd.SpeakTo(lucinda, "Hello");
            lloyd = lucinda;
            lloyd.EarSize = 4321;
            lloyd.WhoAmI();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Elephant george = new Elephant() { Name = "George", EarSize = 33 };
            lucinda.Name = "Lucy";
            MessageBox.Show(lucinda.Name + " " + george.Name);
            george = lucinda;
            MessageBox.Show(lucinda.Name + " " + george.Name);

        }
    }
}
