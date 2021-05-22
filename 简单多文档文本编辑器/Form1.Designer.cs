
using Microsoft.Azure.Amqp;

namespace 简单多文档文本编辑器
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.关闭CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出EoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edittoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤销CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.恢复RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字体SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字体颜色CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口层叠ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水平平铺ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.垂直平铺ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.撤销ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.恢复ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.左对齐ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.居中ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.右对齐ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.字体ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.字体颜色ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tSCbBoxFontName = new System.Windows.Forms.ToolStripComboBox();
            this.粗体ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.斜体ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.下划线ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.查找和替换SToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filetoolStripMenuItem,
            this.edittoolStripMenuItem,
            this.windowtoolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filetoolStripMenuItem
            // 
            this.filetoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建NToolStripMenuItem,
            this.打开OToolStripMenuItem,
            this.保存SToolStripMenuItem,
            this.另存为RToolStripMenuItem,
            this.toolStripSeparator8,
            this.关闭CToolStripMenuItem,
            this.退出EoolStripMenuItem});
            this.filetoolStripMenuItem.Name = "filetoolStripMenuItem";
            this.filetoolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.filetoolStripMenuItem.Text = "文件";
            // 
            // 新建NToolStripMenuItem
            // 
            this.新建NToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.新建NToolStripMenuItem.Name = "新建NToolStripMenuItem";
            this.新建NToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.新建NToolStripMenuItem.Text = "新建";
            this.新建NToolStripMenuItem.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // 打开OToolStripMenuItem
            // 
            this.打开OToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem";
            this.打开OToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.打开OToolStripMenuItem.Text = "打开";
            this.打开OToolStripMenuItem.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // 保存SToolStripMenuItem
            // 
            this.保存SToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem";
            this.保存SToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.保存SToolStripMenuItem.Text = "保存";
            this.保存SToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(134, 6);
            // 
            // 关闭CToolStripMenuItem
            // 
            this.关闭CToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.关闭CToolStripMenuItem.Name = "关闭CToolStripMenuItem";
            this.关闭CToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.关闭CToolStripMenuItem.Text = "关闭";
            this.关闭CToolStripMenuItem.Click += new System.EventHandler(this.关闭CToolStripMenuItem_Click);
            // 
            // 退出EoolStripMenuItem
            // 
            this.退出EoolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.退出EoolStripMenuItem.Name = "退出EoolStripMenuItem";
            this.退出EoolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.退出EoolStripMenuItem.Text = "退出";
            this.退出EoolStripMenuItem.Click += new System.EventHandler(this.退出EoolStripMenuItem_Click);
            // 
            // edittoolStripMenuItem
            // 
            this.edittoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.撤销CToolStripMenuItem,
            this.恢复RToolStripMenuItem,
            this.剪切CToolStripMenuItem,
            this.复制CToolStripMenuItem,
            this.粘贴PToolStripMenuItem,
            this.字体SToolStripMenuItem,
            this.字体颜色CToolStripMenuItem});
            this.edittoolStripMenuItem.Name = "edittoolStripMenuItem";
            this.edittoolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.edittoolStripMenuItem.Text = "编辑";
            // 
            // 撤销CToolStripMenuItem
            // 
            this.撤销CToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.撤销CToolStripMenuItem.Name = "撤销CToolStripMenuItem";
            this.撤销CToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.撤销CToolStripMenuItem.Text = "撤销";
            this.撤销CToolStripMenuItem.Click += new System.EventHandler(this.撤销ToolStripButton_Click);
            // 
            // 恢复RToolStripMenuItem
            // 
            this.恢复RToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.恢复RToolStripMenuItem.Name = "恢复RToolStripMenuItem";
            this.恢复RToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.恢复RToolStripMenuItem.Text = "恢复";
            this.恢复RToolStripMenuItem.Click += new System.EventHandler(this.恢复ToolStripButton_Click);
            // 
            // 剪切CToolStripMenuItem
            // 
            this.剪切CToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.剪切CToolStripMenuItem.Name = "剪切CToolStripMenuItem";
            this.剪切CToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.剪切CToolStripMenuItem.Text = "剪切";
            this.剪切CToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // 复制CToolStripMenuItem
            // 
            this.复制CToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.复制CToolStripMenuItem.Name = "复制CToolStripMenuItem";
            this.复制CToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.复制CToolStripMenuItem.Text = "复制";
            this.复制CToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // 粘贴PToolStripMenuItem
            // 
            this.粘贴PToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.粘贴PToolStripMenuItem.Name = "粘贴PToolStripMenuItem";
            this.粘贴PToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.粘贴PToolStripMenuItem.Text = "粘贴";
            this.粘贴PToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripButton_Click);
            // 
            // 字体SToolStripMenuItem
            // 
            this.字体SToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.字体SToolStripMenuItem.Name = "字体SToolStripMenuItem";
            this.字体SToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.字体SToolStripMenuItem.Text = "字体";
            this.字体SToolStripMenuItem.Click += new System.EventHandler(this.字体ToolStripButton_Click);
            // 
            // 字体颜色CToolStripMenuItem
            // 
            this.字体颜色CToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.字体颜色CToolStripMenuItem.Name = "字体颜色CToolStripMenuItem";
            this.字体颜色CToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.字体颜色CToolStripMenuItem.Text = "字体颜色";
            this.字体颜色CToolStripMenuItem.Click += new System.EventHandler(this.字体颜色ToolStripButton_Click);
            // 
            // windowtoolStripMenuItem
            // 
            this.windowtoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.窗口层叠ToolStripMenuItem,
            this.水平平铺ToolStripMenuItem,
            this.垂直平铺ToolStripMenuItem});
            this.windowtoolStripMenuItem.Name = "windowtoolStripMenuItem";
            this.windowtoolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.windowtoolStripMenuItem.Text = "窗口";
            // 
            // 窗口层叠ToolStripMenuItem
            // 
            this.窗口层叠ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.窗口层叠ToolStripMenuItem.Name = "窗口层叠ToolStripMenuItem";
            this.窗口层叠ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.窗口层叠ToolStripMenuItem.Text = "窗口层叠";
            this.窗口层叠ToolStripMenuItem.Click += new System.EventHandler(this.窗口层叠ToolStripMenuItem_Click);
            // 
            // 水平平铺ToolStripMenuItem
            // 
            this.水平平铺ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.水平平铺ToolStripMenuItem.Name = "水平平铺ToolStripMenuItem";
            this.水平平铺ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.水平平铺ToolStripMenuItem.Text = "水平平铺";
            this.水平平铺ToolStripMenuItem.Click += new System.EventHandler(this.水平平铺ToolStripMenuItem_Click);
            // 
            // 垂直平铺ToolStripMenuItem
            // 
            this.垂直平铺ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.垂直平铺ToolStripMenuItem.Name = "垂直平铺ToolStripMenuItem";
            this.垂直平铺ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.垂直平铺ToolStripMenuItem.Text = "垂直平铺";
            this.垂直平铺ToolStripMenuItem.Click += new System.EventHandler(this.垂直平铺ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator,
            this.撤销ToolStripButton,
            this.恢复ToolStripButton,
            this.toolStripSeparator10,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.左对齐ToolStripButton,
            this.居中ToolStripButton,
            this.右对齐ToolStripButton,
            this.toolStripSeparator9,
            this.字体ToolStripButton,
            this.字体颜色ToolStripButton,
            this.tSCbBoxFontName,
            this.粗体ToolStripButton,
            this.斜体ToolStripButton,
            this.下划线ToolStripButton,
            this.toolStripSeparator11,
            this.查找和替换SToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 28);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.ToolTipText = "新建文件";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.ToolTipText = "打开文件";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.ToolTipText = "保存文件";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 28);
            // 
            // 撤销ToolStripButton
            // 
            this.撤销ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.撤销ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("撤销ToolStripButton.Image")));
            this.撤销ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.撤销ToolStripButton.Name = "撤销ToolStripButton";
            this.撤销ToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.撤销ToolStripButton.Text = "toolStripButton1";
            this.撤销ToolStripButton.ToolTipText = "撤销";
            this.撤销ToolStripButton.Click += new System.EventHandler(this.撤销ToolStripButton_Click);
            // 
            // 恢复ToolStripButton
            // 
            this.恢复ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.恢复ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("恢复ToolStripButton.Image")));
            this.恢复ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.恢复ToolStripButton.Name = "恢复ToolStripButton";
            this.恢复ToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.恢复ToolStripButton.Text = "恢复";
            this.恢复ToolStripButton.Click += new System.EventHandler(this.恢复ToolStripButton_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 28);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.cutToolStripButton.Text = "C&ut";
            this.cutToolStripButton.ToolTipText = "剪切";
            this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.copyToolStripButton.Text = "&Copy";
            this.copyToolStripButton.ToolTipText = "复制";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.pasteToolStripButton.Text = "&Paste";
            this.pasteToolStripButton.ToolTipText = "粘贴";
            this.pasteToolStripButton.Click += new System.EventHandler(this.pasteToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // 左对齐ToolStripButton
            // 
            this.左对齐ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.左对齐ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("左对齐ToolStripButton.Image")));
            this.左对齐ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.左对齐ToolStripButton.Name = "左对齐ToolStripButton";
            this.左对齐ToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.左对齐ToolStripButton.Text = "左对齐";
            this.左对齐ToolStripButton.Click += new System.EventHandler(this.左对齐ToolStripButton_Click);
            // 
            // 居中ToolStripButton
            // 
            this.居中ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.居中ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("居中ToolStripButton.Image")));
            this.居中ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.居中ToolStripButton.Name = "居中ToolStripButton";
            this.居中ToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.居中ToolStripButton.Text = "居中";
            this.居中ToolStripButton.Click += new System.EventHandler(this.居中ToolStripButton_Click);
            // 
            // 右对齐ToolStripButton
            // 
            this.右对齐ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.右对齐ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("右对齐ToolStripButton.Image")));
            this.右对齐ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.右对齐ToolStripButton.Name = "右对齐ToolStripButton";
            this.右对齐ToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.右对齐ToolStripButton.Text = "右对齐";
            this.右对齐ToolStripButton.Click += new System.EventHandler(this.右对齐ToolStripButton_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 28);
            // 
            // 字体ToolStripButton
            // 
            this.字体ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.字体ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("字体ToolStripButton.Image")));
            this.字体ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.字体ToolStripButton.Name = "字体ToolStripButton";
            this.字体ToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.字体ToolStripButton.Text = "字体";
            this.字体ToolStripButton.Click += new System.EventHandler(this.字体ToolStripButton_Click);
            // 
            // 字体颜色ToolStripButton
            // 
            this.字体颜色ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.字体颜色ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("字体颜色ToolStripButton.Image")));
            this.字体颜色ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.字体颜色ToolStripButton.Name = "字体颜色ToolStripButton";
            this.字体颜色ToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.字体颜色ToolStripButton.Text = "字体颜色";
            this.字体颜色ToolStripButton.Click += new System.EventHandler(this.字体颜色ToolStripButton_Click);
            // 
            // tSCbBoxFontName
            // 
            this.tSCbBoxFontName.Name = "tSCbBoxFontName";
            this.tSCbBoxFontName.Size = new System.Drawing.Size(160, 28);
            this.tSCbBoxFontName.ToolTipText = "字体下拉框";
            this.tSCbBoxFontName.TextChanged += new System.EventHandler(this.tSCbBoxFontName_TextChanged);
            // 
            // 粗体ToolStripButton
            // 
            this.粗体ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.粗体ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("粗体ToolStripButton.Image")));
            this.粗体ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.粗体ToolStripButton.Name = "粗体ToolStripButton";
            this.粗体ToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.粗体ToolStripButton.Text = "toolStripButton1";
            this.粗体ToolStripButton.ToolTipText = "粗体";
            this.粗体ToolStripButton.Click += new System.EventHandler(this.粗体ToolStripButton_Click);
            // 
            // 斜体ToolStripButton
            // 
            this.斜体ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.斜体ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("斜体ToolStripButton.Image")));
            this.斜体ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.斜体ToolStripButton.Name = "斜体ToolStripButton";
            this.斜体ToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.斜体ToolStripButton.Text = "toolStripButton2";
            this.斜体ToolStripButton.ToolTipText = "斜体";
            this.斜体ToolStripButton.Click += new System.EventHandler(this.斜体ToolStripButton_Click);
            // 
            // 下划线ToolStripButton
            // 
            this.下划线ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.下划线ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("下划线ToolStripButton.Image")));
            this.下划线ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.下划线ToolStripButton.Name = "下划线ToolStripButton";
            this.下划线ToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.下划线ToolStripButton.Text = "toolStripButton3";
            this.下划线ToolStripButton.ToolTipText = "下划线";
            this.下划线ToolStripButton.Click += new System.EventHandler(this.下划线ToolStripButton_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 28);
            // 
            // 查找和替换SToolStripButton
            // 
            this.查找和替换SToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.查找和替换SToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("查找和替换SToolStripButton.Image")));
            this.查找和替换SToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.查找和替换SToolStripButton.Name = "查找和替换SToolStripButton";
            this.查找和替换SToolStripButton.Size = new System.Drawing.Size(29, 25);
            this.查找和替换SToolStripButton.Text = "查找和替换";
            this.查找和替换SToolStripButton.Click += new System.EventHandler(this.查找和替换SToolStripButton_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // 另存为RToolStripMenuItem
            // 
            this.另存为RToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.另存为RToolStripMenuItem.Name = "另存为RToolStripMenuItem";
            this.另存为RToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.另存为RToolStripMenuItem.Text = "另存为";
            this.另存为RToolStripMenuItem.Click += new System.EventHandler(this.另存为RToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "简单多文档文本编辑器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton 粗体ToolStripButton;
        private System.Windows.Forms.ToolStripButton 斜体ToolStripButton;
        private System.Windows.Forms.ToolStripButton 下划线ToolStripButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem filetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edittoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 窗口层叠ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水平平铺ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 垂直平铺ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem 退出EoolStripMenuItem;
        public  System.Windows.Forms.ToolStripComboBox tSCbBoxFontName;
        private System.Windows.Forms.ToolStripButton 左对齐ToolStripButton;
        private System.Windows.Forms.ToolStripButton 居中ToolStripButton;
        private System.Windows.Forms.ToolStripButton 右对齐ToolStripButton;
        private System.Windows.Forms.ToolStripButton 字体ToolStripButton;
        private System.Windows.Forms.ToolStripButton 字体颜色ToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem 撤销CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 恢复RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 剪切CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴PToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton 撤销ToolStripButton;
        private System.Windows.Forms.ToolStripButton 恢复ToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem 字体SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字体颜色CToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton 查找和替换SToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem 另存为RToolStripMenuItem;
    }
}

