using pbl3.BLL;
using pbl3.GUI;
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
    public partial class CFManageTree : Form
    {
        public CFManageTree()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource=  Tree_BLL.Instance.GetTrees();
        }

        private void guna2DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TreeDetail tree = new TreeDetail(guna2DataGridView1.SelectedRows[0].Cells["TreeID"].Value.ToString());
            tree.ShowDialog();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AddTree f = new AddTree();
            f.ShowDialog();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            List<int> selectedIds = new List<int>();

            foreach (DataGridViewRow row in guna2DataGridView1.SelectedRows)
            {
                if (row.Cells["TreeID"].Value != null && int.TryParse(row.Cells["TreeID"].Value.ToString(), out int id))
                {
                    selectedIds.Add(id);
                }
            }
            Tree_BLL.Instance.DeleteTree(selectedIds);
            MessageBox.Show("Đã xoá thành công !");
            // Sẽ thay thế bằng hàm reload
            guna2DataGridView1.DataSource = Tree_BLL.Instance.GetTrees();
            guna2DataGridView1.Refresh();


        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AddTree formtree = new AddTree(guna2DataGridView1.SelectedRows[0].Cells["TreeID"].Value.ToString());
            formtree.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = Tree_BLL.Instance.GetSearchTrees(searchTerm.Text);
        }
    }
}
