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
    public partial class FAddTreeUser : Form
    {
        private Account _acc;
        public FAddTreeUser()
        {
            InitializeComponent();
        }
        public FAddTreeUser(Account acc)
        {
            this._acc = acc;
            InitializeComponent();
        }

        private void FAddTreeUser_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = Tree_BLL.Instance.GetTrees();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Planting info = new Planting();
            info.TreeID = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells["TreeID"].Value.ToString());
            info.UserName = _acc.UserName;
            info.NumberPlanted = Convert.ToInt32(guna2NumericUpDown1.Value.ToString());
            info.DatePlanted = guna2DateTimePicker1.Value;
            Planting_BLL.Instance.InsertPlanting(info);

        }
    }
}
