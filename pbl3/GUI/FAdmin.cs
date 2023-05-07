using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3
{
    public partial class FAdmin : Form
    {
        public FAdmin()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnManageList_Click(object sender, EventArgs e)
        {
            openChildForm(new CFManageTree());
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            openChildForm(new CFManageUser());
        }
    }
}
