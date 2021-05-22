using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 学生通讯录
{
    public partial class Form_Main : Form
    {
        void initContracts()
        {
            if(File.Exists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase+@"/xml/Students.xml"))
            {
                dataGridView1.DataSource = StudentInfoBLL.GetAllStudentInfo();
            }
            else
            {
                StudentInfoBLL.CreateStudentXml();
                dataGridView1.DataSource = StudentInfoBLL.GetAllStudentInfo();
            }
            dataGridView1.Columns[0].HeaderText = "学生编号";
            dataGridView1.Columns[1].HeaderText = "学生姓名";
            dataGridView1.Columns[2].HeaderText = "学生性别";
            dataGridView1.Columns[3].HeaderText = "学生年龄";
            dataGridView1.Columns[4].HeaderText = "出生日期";
            dataGridView1.Columns[5].HeaderText = "手机号码";
            dataGridView1.Columns[6].HeaderText = "家庭地址";
            dataGridView1.Columns[7].HeaderText = "电子邮箱";
            dataGridView1.Columns[8].HeaderText = "专    业";
        }
        public Form_Main()
        {
            InitializeComponent();
            initContracts();
        }
        private void toolStrip_add_Click(object sender,EventArgs e)
        {
            Form_Add formadd = new Form_Add();
            formadd.ShowDialog();
            initContracts();
        }
        private void toolStrip_edit_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count==1)
            {
                int selectrow = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                Form_Edit formedit = new Form_Edit();
                formedit.studentid_edit = selectrow;
                formedit.ShowDialog();
                initContracts();
            }
            else
            {
                MessageBox.Show("请选中一行后再点击编辑按钮！");
            }
        }
        private void toolStrip_delete_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                if(MessageBox.Show("确认要删除此学生信息？","确认信息",MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2)==DialogResult.Yes)
                {
                    int selectrow = Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    if(StudentInfoBLL.DeleteStudentInfo(selectrow))
                    {
                        MessageBox.Show("删除学生信息成功！");
                    }
                    else
                    {
                        MessageBox.Show("删除学生信息失败，请检查是否选中学生信息！");
                    }
                    initContracts();
                }
            }
            else
            {
                MessageBox.Show("请选中一行后再点击删除按钮！");
            }
        }
        private void toolStrip_search_Click(object sender, EventArgs e)
        {
            Form_Search formsearch = new Form_Search();
            formsearch.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            StudentInfo Rchose = new StudentInfo();

            switch (e.Node.Tag.ToString())
            {

                case "0": dataGridView1.DataSource = StudentInfoBLL.GetAllStudentInfo(); break;
                case "1":
                    Rchose.Profession = treeView1.SelectedNode.Text;
                    dataGridView1.DataSource = StudentInfoBLL.GetStudentInfoList(Rchose);
                    break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void toolStrip_reserve_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.InitialDirectory = @"C:\\";
            savefile.RestoreDirectory = true;
            savefile.Filter = "(*.xml)|*.xml";
            savefile.FileName = "Students备份" + System.DateTime.Now.ToString("yyyyMMddHHmmss");
            savefile.DefaultExt = ".xml";
            if(savefile.ShowDialog()==DialogResult.OK)
            {
                String filepath = savefile.FileName.ToString();
                try
                {
                    String path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"/xml/Students.xml";
                    File.Copy(path, filepath, true);
                    MessageBox.Show("备份成功！", "成功", MessageBoxButtons.OK);
                }
                catch (Exception)
                {
                    MessageBox.Show("未知异常！", "异常", MessageBoxButtons.OK);
                }
            }
        }
        private void toolStrip_recover_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.InitialDirectory = @"C:\\";
            openfile.Filter = "(*.xml)|*.xml";
            openfile.DefaultExt = ".xml";
            openfile.RestoreDirectory = true;
            if(openfile.ShowDialog()==DialogResult.OK)
            {
                String filepath = openfile.FileName.ToString();
                try
                {
                    String extension = Path.GetExtension(openfile.FileName);
                    if(extension!=".xml")
                    {
                        MessageBox.Show("请选择.xml后缀文件");
                    }
                    else
                    {
                        if (!File.Exists(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"/xml/Students.xml"))
                        {
                            StudentInfoBLL.CreateStudentXml();
                        }
                        String path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"/xml/Students.xml";
                        File.Copy(filepath, path, true);
                        MessageBox.Show("恢复成功！", "成功", MessageBoxButtons.OK);
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("未知异常！", "异常", MessageBoxButtons.OK);
                }
            }
        }
    }
}
