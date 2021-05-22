using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 简单多文档文本编辑器
{
    public partial class 查找和替换 : Form
    {
        Form1 form1;
        public 查找和替换(Form1 form)
        {
            InitializeComponent();
            form1 = form;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_search.Text.Length != 0)
            {
                form1.FindTextString(txt_search.Text);
            }
            else
            {
                MessageBox.Show("查找内容不能为空！", "提示", MessageBoxButtons.OK);
            }
        }

        private void btn_replace_Click(object sender, EventArgs e)
        {
            if (txt_replace.TextLength != 0)
            {
                form1.ReplaceTextString(txt_replace.Text);
            }
            else
            {
                MessageBox.Show("替换内容不能为空！", "提示", MessageBoxButtons.OK);
            }
        }
    }
}
