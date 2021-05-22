
namespace 简单多文档文本编辑器
{
    partial class 查找和替换
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
            this.查找 = new System.Windows.Forms.Label();
            this.替换 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.txt_replace = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_replace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 查找
            // 
            this.查找.AutoSize = true;
            this.查找.Location = new System.Drawing.Point(49, 30);
            this.查找.Name = "查找";
            this.查找.Size = new System.Drawing.Size(69, 20);
            this.查找.TabIndex = 0;
            this.查找.Text = "查找内容";
            // 
            // 替换
            // 
            this.替换.AutoSize = true;
            this.替换.Location = new System.Drawing.Point(49, 97);
            this.替换.Name = "替换";
            this.替换.Size = new System.Drawing.Size(69, 20);
            this.替换.TabIndex = 1;
            this.替换.Text = "替换内容";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(168, 30);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(282, 27);
            this.txt_search.TabIndex = 2;
            // 
            // txt_replace
            // 
            this.txt_replace.Location = new System.Drawing.Point(168, 97);
            this.txt_replace.Name = "txt_replace";
            this.txt_replace.Size = new System.Drawing.Size(282, 27);
            this.txt_replace.TabIndex = 3;
            // 
            // btn_search
            // 
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search.Location = new System.Drawing.Point(88, 159);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(132, 47);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "查找下一处";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_replace
            // 
            this.btn_replace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_replace.Location = new System.Drawing.Point(305, 159);
            this.btn_replace.Name = "btn_replace";
            this.btn_replace.Size = new System.Drawing.Size(132, 47);
            this.btn_replace.TabIndex = 5;
            this.btn_replace.Text = "替换字符";
            this.btn_replace.UseVisualStyleBackColor = true;
            this.btn_replace.Click += new System.EventHandler(this.btn_replace_Click);
            // 
            // 查找和替换
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 218);
            this.Controls.Add(this.btn_replace);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_replace);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.替换);
            this.Controls.Add(this.查找);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "查找和替换";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查找和替换";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 查找;
        private System.Windows.Forms.Label 替换;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.TextBox txt_replace;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_replace;
    }
}