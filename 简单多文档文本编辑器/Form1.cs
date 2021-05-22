using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Drawing.Text;

namespace 简单多文档文本编辑器
{
    public partial class Form1 : Form
    {
        private int _Num = 1;
        private int FindPosition = 0;
        private bool flag = false;
        private string originalpath;
        private string style;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //获取系统所有字体，并将字体名称显示在下拉框中
            tSCbBoxFontName.Items.Clear();
            InstalledFontCollection ifc = new InstalledFontCollection();
            FontFamily[] ffs = ifc.Families;
            foreach (FontFamily ff in ffs)
                tSCbBoxFontName.Items.Add(ff.GetName(1));
            LayoutMdi(MdiLayout.Cascade);
            Text = "多文档文本编辑器";
            WindowState = FormWindowState.Maximized;
        }

        private void 窗口层叠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                LayoutMdi(MdiLayout.Cascade);
                this.窗口层叠ToolStripMenuItem.Checked = true;
                this.垂直平铺ToolStripMenuItem.Checked = false;
                this.水平平铺ToolStripMenuItem.Checked = false;
            }
        }

        private void 水平平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
            this.窗口层叠ToolStripMenuItem.Checked = false;
            this.垂直平铺ToolStripMenuItem.Checked = false;
            this.水平平铺ToolStripMenuItem.Checked = true;
        }

        private void 垂直平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
            this.窗口层叠ToolStripMenuItem.Checked = false;
            this.垂直平铺ToolStripMenuItem.Checked = true;
            this.水平平铺ToolStripMenuItem.Checked = false;
        }

        private void NewDoc()
        {
            FrmDoc fd = new FrmDoc();
            fd.MdiParent = this;
            fd.Text = "文档"+_Num;
            fd.WindowState = FormWindowState.Maximized;
            fd.Show();
            fd.Activate();
            _Num++;
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            NewDoc();
            tSCbBoxFontName.Text = ((FrmDoc)this.ActiveMdiChild).rTBDoc.Font.Name;
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.Filter = "RTF格式(* .rtf)|* .rtf|文本文件(* .txt)|* .txt|所有文件(* .*)|* .*";
            openfiledialog1.Multiselect = false;
            if (openfiledialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    NewDoc();
                    _Num--;
                    if (openfiledialog1.FilterIndex == 1)
                    {
                        ((FrmDoc)this.ActiveMdiChild).rTBDoc.LoadFile(openfiledialog1.FileName,RichTextBoxStreamType.RichText);
                        tSCbBoxFontName.Text = ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectionFont.Name;
                        ((FrmDoc)this.ActiveMdiChild).rtb.Text = ((FrmDoc)this.ActiveMdiChild).rTBDoc.Text;
                        ((FrmDoc)this.ActiveMdiChild).no = true;
                        originalpath = openfiledialog1.FileName;
                        style = openfiledialog1.FileName.Substring(openfiledialog1.FileName.LastIndexOf(".")+1);
                    }
                    else
                    {
                        ((FrmDoc)this.ActiveMdiChild).rTBDoc.LoadFile(openfiledialog1.FileName, RichTextBoxStreamType.PlainText);
                        tSCbBoxFontName.Text = ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectionFont.Name;
                        ((FrmDoc)this.ActiveMdiChild).rtb.Text = ((FrmDoc)this.ActiveMdiChild).rTBDoc.Text;
                        ((FrmDoc)this.ActiveMdiChild).no = true;
                        originalpath = openfiledialog1.FileName;
                        style = openfiledialog1.FileName.Substring(openfiledialog1.FileName.LastIndexOf(".") + 1);
                    }
                    ((FrmDoc)this.ActiveMdiChild).Text = openfiledialog1.FileName;
                }
                catch
                {
                    MessageBox.Show("打开失败！","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            openfiledialog1.Dispose();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                if(((FrmDoc)this.ActiveMdiChild).no == false)
                {
                    SaveFileDialog savefiledialog1 = new SaveFileDialog();
                    savefiledialog1.Filter = "RTF格式(* .rtf)|* .rtf|文本文件(* .txt)|* .txt";
                    if (savefiledialog1.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            if (savefiledialog1.FilterIndex == 1)
                            {
                                ((FrmDoc)this.ActiveMdiChild).rTBDoc.SaveFile(savefiledialog1.FileName, RichTextBoxStreamType.RichNoOleObjs);
                                ((FrmDoc)this.ActiveMdiChild).no = true;
                                ((FrmDoc)this.ActiveMdiChild).rtb.Text = ((FrmDoc)this.ActiveMdiChild).rTBDoc.Text;
                            }
                            else
                            {
                                ((FrmDoc)this.ActiveMdiChild).rTBDoc.SaveFile(savefiledialog1.FileName, RichTextBoxStreamType.PlainText);
                                ((FrmDoc)this.ActiveMdiChild).no = true;
                                ((FrmDoc)this.ActiveMdiChild).rtb.Text = ((FrmDoc)this.ActiveMdiChild).rTBDoc.Text;
                            }
                            ((FrmDoc)this.ActiveMdiChild).Text = savefiledialog1.FileName;
                            MessageBox.Show("保存成功！", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                        catch
                        {
                            MessageBox.Show("保存失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    savefiledialog1.Dispose();
                }
                else
                {
                    try
                    {
                        if(style== "rtf")
                        {
                            ((FrmDoc)this.ActiveMdiChild).rTBDoc.SaveFile(originalpath, RichTextBoxStreamType.RichNoOleObjs);
                            ((FrmDoc)this.ActiveMdiChild).no = true;
                            ((FrmDoc)this.ActiveMdiChild).rtb.Text = ((FrmDoc)this.ActiveMdiChild).rTBDoc.Text;
                        }
                        else
                        {
                            ((FrmDoc)this.ActiveMdiChild).rTBDoc.SaveFile(originalpath, RichTextBoxStreamType.PlainText);
                            ((FrmDoc)this.ActiveMdiChild).no = true;
                            ((FrmDoc)this.ActiveMdiChild).rtb.Text = ((FrmDoc)this.ActiveMdiChild).rTBDoc.Text;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("保存失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void 关闭CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                if (((FrmDoc)this.ActiveMdiChild).no == false)
                {
                    if (MessageBox.Show("是否要保存当前文档？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        SaveFileDialog savefiledialog1 = new SaveFileDialog();
                        savefiledialog1.Filter = "RTF格式(* .rtf)|* .rtf|文本文件(* .txt)|* .txt";
                        if (savefiledialog1.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                if (savefiledialog1.FilterIndex == 1)
                                {
                                    ((FrmDoc)this.ActiveMdiChild).rTBDoc.SaveFile(savefiledialog1.FileName, RichTextBoxStreamType.RichNoOleObjs);
                                    ((FrmDoc)this.ActiveMdiChild).no = true;
                                    ((FrmDoc)this.ActiveMdiChild).rtb.Text = ((FrmDoc)this.ActiveMdiChild).rTBDoc.Text;
                                }
                                else
                                {
                                    ((FrmDoc)this.ActiveMdiChild).rTBDoc.SaveFile(savefiledialog1.FileName, RichTextBoxStreamType.PlainText);
                                    ((FrmDoc)this.ActiveMdiChild).no = true;
                                    ((FrmDoc)this.ActiveMdiChild).rtb.Text = ((FrmDoc)this.ActiveMdiChild).rTBDoc.Text;
                                }
                                MessageBox.Show("保存成功！", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                            }
                            catch
                            {
                                MessageBox.Show("保存失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        savefiledialog1.Dispose();
                    }
                    ((FrmDoc)this.ActiveMdiChild).Close();
                    return;
                }
                if (((FrmDoc)this.ActiveMdiChild).no ==true&& ((FrmDoc)this.ActiveMdiChild).rtb.Text!= ((FrmDoc)this.ActiveMdiChild).rTBDoc.Text)
                {
                    if(MessageBox.Show("是否要保存当前文档？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        try
                        {
                            if (style == "rtf")
                                ((FrmDoc)this.ActiveMdiChild).rTBDoc.SaveFile(originalpath, RichTextBoxStreamType.RichNoOleObjs);
                            else
                                ((FrmDoc)this.ActiveMdiChild).rTBDoc.SaveFile(originalpath, RichTextBoxStreamType.PlainText);
                        }
                        catch
                        {
                            MessageBox.Show("保存失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        ((FrmDoc)this.ActiveMdiChild).Close();
                        return;
                    }
                }
                if (MessageBox.Show("确定要关闭当前文档？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    ((FrmDoc)this.ActiveMdiChild).Close();
                }
            }
        }

        private void 退出EoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出应用程序？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                foreach(FrmDoc fd in this.MdiChildren)
                {
                    fd.Close();
                }
                Application.Exit();
            }
        }

        private void tSCbBoxFontName_TextChanged(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                RichTextBox tempRTB = new RichTextBox();//用于保存被选中文本的副本
                int RtbStart = ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectionStart;
                int len = ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectionLength;
                int tempRtbStart = 0;
                Font font = ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectionFont;
                if (len <= 0 && null != font)
                {
                    ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectionFont = new Font(tSCbBoxFontName.Text, font.Size, font.Style);
                    return;
                }
                tempRTB.Rtf = ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectedRtf;
                for (int i = 0; i < len; i++)//逐个设置字体
                {
                    tempRTB.Select(tempRtbStart + i, 1);
                    tempRTB.SelectionFont = new Font(tSCbBoxFontName.Text, tempRTB.SelectionFont.Size, tempRTB.SelectionFont.Style);
                }
                //将副本内容插入到原型中
                tempRTB.Select(tempRtbStart, len);
                ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectedRtf = tempRTB.SelectedRtf;
                ((FrmDoc)this.ActiveMdiChild).rTBDoc.Select(RtbStart, len);
                ((FrmDoc)this.ActiveMdiChild).rTBDoc.Focus();
                ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectionFont = tempRTB.SelectionFont;
                tempRTB.Dispose();
            }
        }

        private void ChangeRTBFontStyle(RichTextBox rtb,FontStyle style)
        {
            if(style!=FontStyle.Bold&& style!=FontStyle.Italic&&style!=FontStyle.Underline)
            {
                throw new System.InvalidProgramException("字体格式错误");
            }
            RichTextBox tempRTB = new RichTextBox();
            int curRtbStart = rtb.SelectionStart;
            int len = rtb.SelectionLength;
            int tempRtbStart = 0;
            Font font = rtb.SelectionFont;
            if (len <= 0 && font != null)
            {
                if (style == FontStyle.Bold && font.Bold || style == FontStyle.Italic && font.Italic || style == FontStyle.Underline && font.Underline)
                {
                    rtb.Font = new Font(font, font.Style ^ style);
                }
                else if(style == FontStyle.Bold && !font.Bold || style == FontStyle.Italic && !font.Italic || style == FontStyle.Underline && !font.Underline)
                {
                    rtb.Font = new Font(font, font.Style | style);
                }
                return;
            }
            tempRTB.Rtf = rtb.SelectedRtf;
            tempRTB.Select(len - 1, 1);
            Font tempFont = (Font)tempRTB.SelectionFont.Clone();
            for(int i = 0; i < len; i++)
            {
                tempRTB.Select(tempRtbStart + i, 1);
                if (style==FontStyle.Bold&& tempFont.Bold||style==FontStyle.Italic&&tempFont.Italic||style==FontStyle.Underline&&tempFont.Underline)
                {
                    tempRTB.SelectionFont = new Font(tempRTB.SelectionFont, tempRTB.SelectionFont.Style ^ style);
                }
                else if(style == FontStyle.Bold && !tempFont.Bold || style == FontStyle.Italic && !tempFont.Italic || style == FontStyle.Underline && !tempFont.Underline)
                {
                    tempRTB.SelectionFont = new Font(tempRTB.SelectionFont, tempRTB.SelectionFont.Style | style);
                }
            }
            tempRTB.Select(tempRtbStart, len);
            rtb.SelectedRtf = tempRTB.SelectedRtf;
            rtb.Select(curRtbStart, len);
            rtb.Focus();
            tempRTB.Dispose();
        }

        private void 粗体ToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                ChangeRTBFontStyle(((FrmDoc)this.ActiveMdiChild).rTBDoc, FontStyle.Bold);
            }
        }

        private void 斜体ToolStripButton_Click(object sender, EventArgs e)
        {
            if(this.MdiChildren.Count() > 0)
            {
                ChangeRTBFontStyle(((FrmDoc)this.ActiveMdiChild).rTBDoc, FontStyle.Italic);
            }
        }

        private void 下划线ToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() > 0)
            {
                ChangeRTBFontStyle(((FrmDoc)this.ActiveMdiChild).rTBDoc, FontStyle.Underline);
            }
        }

        private void 左对齐ToolStripButton_Click(object sender, EventArgs e)
        {
            ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void 居中ToolStripButton_Click(object sender, EventArgs e)
        {
            ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void 右对齐ToolStripButton_Click(object sender, EventArgs e)
        {
            ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void 撤销ToolStripButton_Click(object sender, EventArgs e)
        {
            ((FrmDoc)this.ActiveMdiChild).rTBDoc.Undo();
        }

        private void 恢复ToolStripButton_Click(object sender, EventArgs e)
        {
            ((FrmDoc)this.ActiveMdiChild).rTBDoc.Redo();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            ((FrmDoc)this.ActiveMdiChild).rTBDoc.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            ((FrmDoc)this.ActiveMdiChild).rTBDoc.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            ((FrmDoc)this.ActiveMdiChild).rTBDoc.Paste();
        }

        private void 字体ToolStripButton_Click(object sender, EventArgs e)
        {
            FontDialog fontdialog = new FontDialog();
            if (fontdialog.ShowDialog() == DialogResult.OK)
            {
                ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectionFont = fontdialog.Font;
                tSCbBoxFontName.Text = fontdialog.Font.Name;
            }
        }

        private void 字体颜色ToolStripButton_Click(object sender, EventArgs e)
        {
            ColorDialog colordialog = new ColorDialog();
            if (colordialog.ShowDialog() == DialogResult.OK)
            {
                ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectionColor = colordialog.Color;
            }
        }

        public void FindTextString(string FindString)
        {
            if (FindPosition >= ((FrmDoc)this.ActiveMdiChild).rTBDoc.Text.Length)
            {
                MessageBox.Show("已到文本底部", "提示", MessageBoxButtons.OK);
                FindPosition = 0;
                flag = false;
                return;
            }
            FindPosition = ((FrmDoc)this.ActiveMdiChild).rTBDoc.Find(FindString, FindPosition, RichTextBoxFinds.MatchCase);
            if (FindPosition == -1 && flag == true)
            {
                MessageBox.Show("已到文本底部", "提示", MessageBoxButtons.OK);
                FindPosition = 0;
                flag = false;
                return;
            }
            if (FindPosition == -1&&flag==false)
            {
                MessageBox.Show("已到文本底部，未查找到该字符内容！", "提示", MessageBoxButtons.OK);
                FindPosition = 0;
                flag = false;
                return;
            }
            else
            {
                flag = true;
                ((FrmDoc)this.ActiveMdiChild).rTBDoc.Focus();
                FindPosition += FindString.Length;
            }
        }

        public void ReplaceTextString(string ReplaceString)
        {
            if (((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectedText.Length != 0)
            {
                ((FrmDoc)this.ActiveMdiChild).rTBDoc.SelectedText = ReplaceString;
            }
        }

        private void 查找和替换SToolStripButton_Click(object sender, EventArgs e)
        {
            FindPosition = 0;
            查找和替换 FindReplace = new 查找和替换(this);
            FindReplace.Show();

        }

        private void 另存为RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefiledialog1 = new SaveFileDialog();
            savefiledialog1.Title = "另存为";
            savefiledialog1.Filter = "RTF格式(* .rtf)|* .rtf|文本文件(* .txt)|* .txt";
            if (savefiledialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (savefiledialog1.FilterIndex == 1)
                    {
                        ((FrmDoc)this.ActiveMdiChild).rTBDoc.SaveFile(savefiledialog1.FileName, RichTextBoxStreamType.RichNoOleObjs);
                        ((FrmDoc)this.ActiveMdiChild).no = true;
                        ((FrmDoc)this.ActiveMdiChild).rtb.Text = ((FrmDoc)this.ActiveMdiChild).rTBDoc.Text;
                    }
                    else
                    {
                        ((FrmDoc)this.ActiveMdiChild).rTBDoc.SaveFile(savefiledialog1.FileName, RichTextBoxStreamType.PlainText);
                        ((FrmDoc)this.ActiveMdiChild).no = true;
                        ((FrmDoc)this.ActiveMdiChild).rtb.Text = ((FrmDoc)this.ActiveMdiChild).rTBDoc.Text;
                    }
                    MessageBox.Show("保存成功！", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                catch
                {
                    MessageBox.Show("保存失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            savefiledialog1.Dispose();
        }
    }
}
