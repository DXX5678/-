using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生通讯录
{
    public partial class Form_Search : Form
    {
        public Form_Search()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            int i; int j=-1;
            if(cb_searchitem.Text==string.Empty)
            {
                dataGridView1.DataSource = StudentInfoBLL.GetAllStudentInfo();
                InitHeadTitle();
            }
            else
            {
                if (txt_searchtext.Text != string.Empty)
                {
                    StudentInfo studentsearch = new StudentInfo();
                    i = cb_searchitem.SelectedIndex;
                    switch (cb_searchitem.SelectedIndex)
                    {
                        case 0:studentsearch.StudentId = Int32.Parse(txt_searchtext.Text);break;
                        case 1:studentsearch.Name = txt_searchtext.Text;break;
                        case 2:studentsearch.Sex = txt_searchtext.Text;break;
                        case 3:studentsearch.Age = Convert.ToInt32(txt_searchtext.Text);break;
                        case 4:studentsearch.Phone = txt_searchtext.Text;break;
                        case 5:studentsearch.Email = txt_searchtext.Text;break;
                        case 6:studentsearch.HomeAddress = txt_searchtext.Text;break;
                        case 7:studentsearch.Profession = txt_searchtext.Text;break;
                    }
                    if(cb_searchitem1.Text != string.Empty)
                    {
                        if (txt_searchtext1.Text != string.Empty)
                        {
                            j = cb_searchitem1.SelectedIndex;
                            switch (cb_searchitem1.SelectedIndex)
                            {
                                case 0: studentsearch.StudentId = Int32.Parse(txt_searchtext1.Text); break;
                                case 1: studentsearch.Name = txt_searchtext1.Text; break;
                                case 2: studentsearch.Sex = txt_searchtext1.Text; break;
                                case 3: studentsearch.Age = Convert.ToInt32(txt_searchtext1.Text); break;
                                case 4: studentsearch.Phone = txt_searchtext1.Text; break;
                                case 5: studentsearch.Email = txt_searchtext1.Text; break;
                                case 6: studentsearch.HomeAddress = txt_searchtext1.Text; break;
                                case 7: studentsearch.Profession = txt_searchtext1.Text; break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("请输入要查询的" + cb_searchitem1.Text);
                            return;
                        }
                    }
                    dataGridView1.DataSource = StudentInfoBLL.GetStudentInfoList1(studentsearch,i,j);
                    InitHeadTitle();
                }
                else
                {
                    MessageBox.Show("请输入要查询的"+cb_searchitem.Text);
                }
            }
        }
        void InitHeadTitle()
        {
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

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
