using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 简单多文档文本编辑器
{
    public partial class FrmDoc : Form
    {
        public RichTextBox rTBDoc;
        public bool no=false;
        public RichTextBox rtb = new RichTextBox();
        public FrmDoc()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.rTBDoc = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rTBDoc
            // 
            this.rTBDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTBDoc.Location = new System.Drawing.Point(0, 0);
            this.rTBDoc.Name = "rTBDoc";
            this.rTBDoc.Size = new System.Drawing.Size(695, 424);
            this.rTBDoc.TabIndex = 0;
            this.rTBDoc.Text = "";
            // 
            // FrmDoc
            // 
            this.ClientSize = new System.Drawing.Size(695, 424);
            this.Controls.Add(this.rTBDoc);
            this.Name = "FrmDoc";
            this.Text = "FrmDoc";
            this.Activated += new System.EventHandler(this.FrmDoc_Activated);
            this.ResumeLayout(false);

        }

        private void FrmDoc_Activated(object sender, EventArgs e)
        {
            ((Form1)this.MdiParent).tSCbBoxFontName.Text = this.rTBDoc.SelectionFont.Name;
        }
    }
}