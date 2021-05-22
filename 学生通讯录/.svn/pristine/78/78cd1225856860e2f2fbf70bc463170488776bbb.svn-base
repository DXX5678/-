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
    public partial class Form_Add : Form
    {
        public Form_Add()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            StudentInfo studentinfo = new StudentInfo();
            studentinfo.StudentId = Int32.Parse(txt_studengid.Text);
            studentinfo.Name = txt_name.Text;
            if(rb_man.Checked)
            {
                studentinfo.Sex = "男";
            }
            else if(rb_woman.Checked)
            {
                studentinfo.Sex = "女";
            }
            studentinfo.Age = Int32.Parse(txt_age.Text);
            studentinfo.BirthDate = DateTime.Parse(dt_birthdate.Text);
            studentinfo.Phone = txt_phone.Text;
            studentinfo.Email = txt_email.Text;
            studentinfo.HomeAddress = txt_homeaddress.Text;
            studentinfo.Profession = txt_profession.Text;
            if(StudentInfoBLL.AddStudentInfo(studentinfo))
            {
                MessageBox.Show("添加学生信息成功！");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
