using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked) 
            {
                textBox2.UseSystemPasswordChar = true;
                checkBox1.Text = "Göster";
            }

           else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                textBox2.UseSystemPasswordChar = false;
                checkBox1.Text = "Gizle";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
