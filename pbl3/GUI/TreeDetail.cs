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
    public partial class TreeDetail : Form
    {
        public TreeDetail()
        {
            InitializeComponent();
        }

        public TreeDetail(String id)
        {

            InitializeComponent();
            //Tree tree = _TreeBLL.GetTreeByID(Convert.ToInt32(id));
            Tree tree = Tree_BLL.Instance.getTreeByID(id);
            txbID.Text = tree.TreeID.ToString();
            txbName.Text = tree.TreeName;
            cbxClimate.Text = "Chua co du lieu";
            cbxType.Text = "Chua co du lieu";
            txbDetail.Text = tree.TreeDescription;
           

            //lay anh


            Byte[] data = new Byte[0];
            data = (Byte[])(tree.Picture);
            MemoryStream mem = new MemoryStream(data);
            pictureBox1.Image = Image.FromStream(mem);
            txbDetail.Enabled = false;
            txbID.Enabled = false;
            cbxClimate.Enabled = false;
            txbName.Enabled = false;
            cbxType.Enabled = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
