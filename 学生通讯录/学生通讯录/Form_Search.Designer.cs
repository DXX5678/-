
namespace 学生通讯录
{
    partial class Form_Search
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cb_searchitem = new System.Windows.Forms.ComboBox();
            this.txt_searchtext = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb_searchitem1 = new System.Windows.Forms.ComboBox();
            this.txt_searchtext1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "查找项目";
            // 
            // cb_searchitem
            // 
            this.cb_searchitem.FormattingEnabled = true;
            this.cb_searchitem.Items.AddRange(new object[] {
            "学生编号",
            "学生姓名",
            "学生性别",
            "学生年龄",
            "手机号码",
            "电子邮箱",
            "家庭住址",
            "专业"});
            this.cb_searchitem.Location = new System.Drawing.Point(98, 12);
            this.cb_searchitem.Name = "cb_searchitem";
            this.cb_searchitem.Size = new System.Drawing.Size(155, 28);
            this.cb_searchitem.TabIndex = 1;
            // 
            // txt_searchtext
            // 
            this.txt_searchtext.Location = new System.Drawing.Point(277, 13);
            this.txt_searchtext.Name = "txt_searchtext";
            this.txt_searchtext.Size = new System.Drawing.Size(198, 27);
            this.txt_searchtext.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(938, 7);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(79, 37);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(1060, 6);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(78, 38);
            this.bt_close.TabIndex = 4;
            this.bt_close.Text = "关闭";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1150, 399);
            this.dataGridView1.TabIndex = 5;
            // 
            // cb_searchitem1
            // 
            this.cb_searchitem1.FormattingEnabled = true;
            this.cb_searchitem1.Items.AddRange(new object[] {
            "学生编号",
            "学生姓名",
            "学生性别",
            "学生年龄",
            "手机号码",
            "电子邮箱",
            "家庭住址",
            "专业"});
            this.cb_searchitem1.Location = new System.Drawing.Point(509, 12);
            this.cb_searchitem1.Name = "cb_searchitem1";
            this.cb_searchitem1.Size = new System.Drawing.Size(173, 28);
            this.cb_searchitem1.TabIndex = 6;
            // 
            // txt_searchtext1
            // 
            this.txt_searchtext1.Location = new System.Drawing.Point(705, 12);
            this.txt_searchtext1.Name = "txt_searchtext1";
            this.txt_searchtext1.Size = new System.Drawing.Size(192, 27);
            this.txt_searchtext1.TabIndex = 7;
            // 
            // Form_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1150, 450);
            this.Controls.Add(this.txt_searchtext1);
            this.Controls.Add(this.cb_searchitem1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_searchtext);
            this.Controls.Add(this.cb_searchitem);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form_Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_searchitem;
        private System.Windows.Forms.TextBox txt_searchtext;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_searchitem1;
        private System.Windows.Forms.TextBox txt_searchtext1;
    }
}

