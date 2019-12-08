using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHo_Click(object sender, EventArgs e)
        {
            lblHoten.Text = txtHoLot.Text;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblHoten.Text = txtTen.Text;
        }

        private void btnHoTen_Click(object sender, EventArgs e)
        {
            lblHoten.Text = txtHoLot.Text +" "+ txtTen.Text;
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
           DialogResult a = MessageBox.Show("Bạn có muốn thoát chương trình?","Thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(a==DialogResult.Yes)
            {
                Close();
            }
            
           
        }
    }
}
