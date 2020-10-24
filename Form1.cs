using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNV;


namespace QLNV
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nhanvien nv1 = new nhanvien();
            nv1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb_id.Text= logincs.ID_USER.ToString();
            lb_level.Text = logincs.LEVEL.ToString();
            lb_user.Text = logincs.USERNAME.ToString();
            if(Convert.ToInt32(logincs.ID_USER.ToString()) == 3)
            {
                button4.Enabled = true;
            }    
        }

        private void lb_level_Click(object sender, EventArgs e)
        {

        }

        private void lb_id_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
