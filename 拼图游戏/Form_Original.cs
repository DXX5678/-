using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 拼图游戏
{
    public partial class Form_Original : Form
    {
        private PictureBox pd_Original;

        public Form_Original()
        {
            InitializeComponent();
        }
        private void Form_Original_Load(object sender,EventArgs e)
        {
            pd_Original.Image = CutPicture.Resize(picpath, 600, 600);
        }
        public string picpath { get; internal set; }

        private void InitializeComponent()
        {
            this.pd_Original = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pd_Original)).BeginInit();
            this.SuspendLayout();
            // 
            // pd_Original
            // 
            this.pd_Original.Location = new System.Drawing.Point(12, 12);
            this.pd_Original.Name = "pd_Original";
            this.pd_Original.Size = new System.Drawing.Size(600, 600);
            this.pd_Original.TabIndex = 0;
            this.pd_Original.TabStop = false;
            // 
            // Form_Original
            // 
            this.ClientSize = new System.Drawing.Size(626, 624);
            this.Controls.Add(this.pd_Original);
            this.MaximizeBox = false;
            this.Name = "Form_Original";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "原图";
            this.Load += new System.EventHandler(this.Form_Original_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pd_Original)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
