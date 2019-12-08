using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult x = MessageBox.Show("Bạn có muốn thoát không?",
                "thoát chương trình.",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (x==DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xin Chào!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đây là nội dung", "Tiêu đề",MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đây là nội dung", "Tiêu đề",
                MessageBoxButtons.OK
                , MessageBoxIcon.Error);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult click4 = MessageBox.Show("Bạn có muốn xóa hay không?",
                "Xóa ",
                MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if(click4==DialogResult.Yes)
            {
                MessageBox.Show("Bạn chọn yes","yes");
            }
            else if(click4==DialogResult.No)
            {
                MessageBox.Show("Bạn chọn no", "no");
            }
            else if(click4==DialogResult.Cancel)
            {
                MessageBox.Show("Bạn chọn cancel", "cancel");
            }
        }
    }
}
