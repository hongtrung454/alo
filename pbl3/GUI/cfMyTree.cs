using Guna.UI2.WinForms;
using pbl3.BLL;
using pbl3.DTO;
using pbl3.GUI;
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

namespace pbl3
{
    public partial class cfMyTree : Form
    {
        private Account _acc;
        public cfMyTree()
        {
            InitializeComponent();
            guna2VScrollBar1.Value = flowLayoutPanel1.VerticalScroll.Value;
            guna2VScrollBar1.Minimum = flowLayoutPanel1.VerticalScroll.Minimum;
            guna2VScrollBar1.Maximum = flowLayoutPanel1.VerticalScroll.Maximum;
        }
        public cfMyTree(Account acc)
        {
            this._acc = acc;
            InitializeComponent();
            guna2VScrollBar1.Value = flowLayoutPanel1.VerticalScroll.Value;
            guna2VScrollBar1.Minimum = flowLayoutPanel1.VerticalScroll.Minimum;
            guna2VScrollBar1.Maximum = flowLayoutPanel1.VerticalScroll.Maximum;
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            guna2VScrollBar1.Minimum = flowLayoutPanel1.VerticalScroll.Minimum;
            guna2VScrollBar1.Maximum = flowLayoutPanel1.VerticalScroll.Maximum;

            List<UserTree_DTO> l1 = new List<UserTree_DTO>();
            l1 = Planting_BLL.Instance.GetUserPlanting(_acc);
            var x1 = l1.ToArray();


            for (int i = 0; i < x1.Length; i++)
            {
                Guna2Panel pn = new Guna2Panel();
                pn.Size = new Size(200, 400);
                pn.BackColor = Color.White;

                Guna2PictureBox ptb = new Guna2PictureBox();
                ptb.Size = new Size(155, 220);
                ptb.Location = new Point(15, 2);
                ptb.Image = Image.FromStream(new MemoryStream(x1[i].Picture));
                ptb.SizeMode = PictureBoxSizeMode.Zoom;

                Guna2HtmlLabel lb = new Guna2HtmlLabel();
                lb.Location = new Point(0, 215);
                lb.Size = new Size(101, 17);
                lb.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                lb.Text = (x1[i].TreeName).ToString();
                lb.Anchor = AnchorStyles.None;
                lb.TextAlignment = ContentAlignment.MiddleCenter;
                pn.AutoScroll = false;
                lb.AutoSize = false;
                lb.Size = pn.Size;

                Guna2Button btn = new Guna2Button();
                btn.Location = new Point(20, 250);
                btn.Size = new Size(61, 40);
                btn.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                btn.Text = "Tưới nước";
                btn.FillColor = Color.FromArgb(94, 148, 255);
                btn.ForeColor = Color.White;
                btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
                btn.Cursor = Cursors.Hand;
                //btn.Name = lb.Text;
                pn.Name = x1[i].TreeID.ToString() ;


                Guna2Button btn1 = new Guna2Button();
                btn1.Location = new Point(110, 250);
                btn1.Size = new Size(61, 40);
                btn1.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                btn1.Text = "Bón phân";
                btn1.FillColor = Color.FromArgb(94, 148, 255);
                btn1.ForeColor = Color.White;
                btn1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                btn1.Cursor = Cursors.Hand;
                btn1.Name = lb.Text;

                Guna2Button btn2 = new Guna2Button();
                btn2.Location = new Point(10, 10);
                btn2.Size = new Size(60, 30);
                btn2.Font = new Font("Tahoma", 8, FontStyle.Bold);
                btn2.Text = "Chi tiết";
                btn2.TextAlign = HorizontalAlignment.Center;
                btn2.FillColor = Color.FromArgb(94, 148, 255);
                btn2.ForeColor = Color.Black;
                btn2.Cursor = Cursors.Hand;
                btn2.Visible = true;
                btn2.Name = x1[i].TreeID.ToString();



                pn.Controls.Add(btn);
                pn.Controls.Add(btn1);
                pn.Controls.Add(btn2);
                pn.Controls.Add(lb);
                pn.Controls.Add(ptb);

                //pn.DoubleClick +=
                //pn.DoubleClick += Pn_DoubleClick;
                btn2.Click += DetailButton_Click;
                flowLayoutPanel1.Controls.Add(pn);
            }
        }

        private void DetailButton_Click(object sender, EventArgs e)
        {
            Planting planting = Planting_BLL.Instance.GetOnePlanting(_acc, ((Guna2Button)sender).Name);
            UpdateTreePlanting f = new UpdateTreePlanting(planting);
            f.Show();
            //throw new NotImplementedException();
        }

        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            flowLayoutPanel1.VerticalScroll.Value = guna2VScrollBar1.Value;
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FAddTreeUser f = new FAddTreeUser(_acc);
            f.ShowDialog();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }
    }
}
