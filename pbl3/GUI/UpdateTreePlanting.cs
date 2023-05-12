using pbl3.BLL;
using pbl3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3.GUI
{
    public partial class UpdateTreePlanting : Form
    {
        public UpdateTreePlanting()
        {
            InitializeComponent();
        }
        public UpdateTreePlanting(Planting planting)
        {
            InitializeComponent();
            UserNamelb.Text = planting.UserName;
            TreeIDlb.Text = planting.TreeID.ToString();
            Tree treePlanting = Tree_BLL.Instance.getTreeByID(planting.TreeID.ToString());
            TreeNamelb.Text = treePlanting.TreeName;
            guna2NumericUpDown1.Value = Convert.ToDecimal(planting.NumberPlanted);
            guna2DateTimePicker1.Value = planting.DatePlanted.Value;
            guna2PictureBox1.Image = Image.FromStream(new MemoryStream(treePlanting.Picture));
            

        }

        private void UpdateTreePlanting_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Planting_BLL.Instance.DeleteTreePlanting(UserNamelb.Text, Convert.ToInt32(TreeIDlb.Text));
            MessageBox.Show("Đã xoá cây khỏi vườn");
            this.Dispose();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Planting planting = new Planting();
            planting.TreeID = Convert.ToInt32(TreeIDlb.Text);
            planting.UserName = UserNamelb.Text;
            planting.DatePlanted = guna2DateTimePicker1.Value;
            planting.NumberPlanted = Convert.ToInt32(guna2NumericUpDown1.Value);
            planting.Fertilize = guna2DateTimePicker2.Value;
            planting.Water = guna2DateTimePicker3.Value;
            if(Planting_BLL.Instance.UpdateTreePlanting(planting))
            {
                MessageBox.Show("Cập nhật thành công");

            }
            else
            {
                MessageBox.Show("lỗi");
            } 
                
            this.Dispose();
        }
    }
}
