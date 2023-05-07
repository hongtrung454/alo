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

namespace pbl3
{
    public partial class cfPIC : Form
    {
        public cfPIC(string user)
        {
            InitializeComponent();

            GetCBB();
            GUI(Account_BLL.Instance.GetAccountByUserName(user));
        }
        public void GetCBB()
        {
            foreach (CBBItem a in UserLocation_BLL.Instance.GetCBBItems())
            {
                cbbLocation.Items.Add(a);
            }
        }
        public void GUI(Account acc)
        {
            txtUsername.Text = acc.UserName;
            txtFullname.Text = acc.DisplayName;
            cbbLocation.Text = UserLocation_BLL.Instance.GetLocationNameByUserLocationId(Convert.ToInt32(acc.UserLocationID));
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
