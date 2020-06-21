using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch6page273v2
{
    public partial class Form1 : Form
    {
        MySubClass subclass;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            subclass = new MySubClass("Test baseclass ting", 53);
        }
    }
}
