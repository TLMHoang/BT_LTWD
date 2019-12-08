using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            this.WindowState = FormWindowState.Normal;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.Text = "Black";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("bạn muốn thoát");
        }
    }
}
