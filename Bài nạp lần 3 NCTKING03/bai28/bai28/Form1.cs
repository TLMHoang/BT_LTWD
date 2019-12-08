using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (picOff.Visible == true)
            {
                btnTurnOrOff.Text = txtName.Text + ". Tun on the light, please!";
            }
            else
            {
                btnTurnOrOff.Text = txtName.Text + ". Tun off the light, please!";
            }

        }

        private void btnTurnOrOff_Click(object sender, EventArgs e)
        {
            if(picOff.Visible==true)
            {
                picOn.Visible = true;
                picOff.Visible = false;
                btnTurnOrOff.Text = btnTurnOrOff.Text.Replace("on", "off");
            }
            else
            {
                picOn.Visible = false;
                picOff.Visible = true;
                btnTurnOrOff.Text = btnTurnOrOff.Text.Replace("off", "on");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn muốn thoát chương trình?", "Thoát"
                , MessageBoxButtons.YesNo,
                MessageBoxIcon.Error);
            if(DialogResult.Yes==a)
            {
                Close();    
            }
        }
    }
}
