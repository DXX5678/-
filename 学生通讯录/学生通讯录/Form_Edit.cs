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
    public partial class Form_Edit : Form
    {
        public int studentid_edit=0;

        public Form_Edit()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void rd_woman_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void initControl()
        {
            StudentInfo studentinfo = StudentInfoBLL.GetStudentInfo(studentid_edit);
            if(studentinfo!=null)
            {
                txt_studengid.Text = studentinfo.StudentId.ToString();
                txt_name.Text = studentinfo.Name;
                if(studentinfo.Sex=="男")
                {
                    rb_man.Checked = true;
                    rb_woman.Checked = false;
                }
                else
                {
                    rb_woman.Checked = true;
                    rb_man.Checked = false;
                }
                txt_age.Text = studentinfo.Age.ToString();
                dt_birthdate.Text = studentinfo.BirthDate.ToString();
                txt_phone.Text = studentinfo.Phone;
                txt_email.Text = studentinfo.Email;
                txt_homeaddress.Text = studentinfo.HomeAddress;
                txt_profession.Text = studentinfo.Profession;
            }
        }
        private void Form_Edit_Load(object sender,EventArgs e)
        {
            initControl();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            StudentInfo studentinfo = StudentInfoBLL.GetStudentInfo(studentid_edit);
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
            if (StudentInfoBLL.UpdateStudentInfo(studentinfo))
            {
                MessageBox.Show("修改学生信息成功！");
            }
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
