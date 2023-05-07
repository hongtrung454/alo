using pbl3.BLL;
using pbl3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl3.GUI
{
    public partial class AddTree : Form
    {
        public AddTree()
        {
            InitializeComponent();
        }
        public AddTree(String id)
        {
            InitializeComponent();
            txbID.Text = id;
            txbID.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Image pimg = pictureBox1.Image;
            ImageConverter Converter = new ImageConverter();
            var ImageConver = Converter.ConvertTo(pimg, typeof(byte[]));
            Tree tree = new Tree();
            tree.TreeName = txbName.Text;
            tree.TreeDescription = txbDetail.Text;
            tree.Picture = (byte[])ImageConver;
            // add
            if (txbID.Enabled == true)
            {
                Tree_BLL.Instance.InsertTree(tree);
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                tree.TreeID = Convert.ToInt32(txbID.Text);
                Tree_BLL.Instance.UpdateTree(tree);
                MessageBox.Show("Cập nhật thành công!");

            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdlg = new OpenFileDialog();
            ofdlg.Title = "Open Image";
            ofdlg.Filter = "Image file(*.PNG;*.JPG;*.GIF) |*.PNG;*.JPG;*.GIF";

            if (ofdlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofdlg.FileName);
            }
        }
    }
}
