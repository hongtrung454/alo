
namespace pbl3.GUI
{
    partial class AddTree
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxClimate = new MetroFramework.Controls.MetroComboBox();
            this.cbxType = new MetroFramework.Controls.MetroComboBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbDetail = new System.Windows.Forms.RichTextBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Mô tả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Khí hậu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Loại: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên: ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(388, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 50);
            this.button3.TabIndex = 21;
            this.button3.Text = "CANCEL";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 50);
            this.button2.TabIndex = 20;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 50);
            this.button1.TabIndex = 19;
            this.button1.Text = "SELECT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(482, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 286);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // cbxClimate
            // 
            this.cbxClimate.FormattingEnabled = true;
            this.cbxClimate.ItemHeight = 24;
            this.cbxClimate.Location = new System.Drawing.Point(339, 104);
            this.cbxClimate.Name = "cbxClimate";
            this.cbxClimate.Size = new System.Drawing.Size(121, 30);
            this.cbxClimate.TabIndex = 17;
            //this.cbxClimate.UseSelectable = true;
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.ItemHeight = 24;
            this.cbxType.Location = new System.Drawing.Point(110, 101);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 30);
            this.cbxType.TabIndex = 16;
            //this.cbxType.UseSelectable = true;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(110, 54);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(350, 22);
            this.txbName.TabIndex = 15;
            // 
            // txbDetail
            // 
            this.txbDetail.Location = new System.Drawing.Point(110, 204);
            this.txbDetail.Name = "txbDetail";
            this.txbDetail.Size = new System.Drawing.Size(350, 131);
            this.txbDetail.TabIndex = 14;
            this.txbDetail.Text = "";
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(110, 13);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(100, 22);
            this.txbID.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID:";
            // 
            // AddTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbxClimate);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbDetail);
            this.Name = "AddTree";
            this.Text = "AddTree";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroComboBox cbxClimate;
        private MetroFramework.Controls.MetroComboBox cbxType;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.RichTextBox txbDetail;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label1;
    }
}