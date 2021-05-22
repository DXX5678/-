using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace 学生通讯录
{
    public class StudentInfoBLL
    {
        private static string _basePath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"/xml/Students.xml";
        ///<summary>
        ///创建学生XML文档
        ///</summary>>
        public static void CreateStudentXml()
        {
            if (!Directory.Exists("xml"))
            {
                Directory.CreateDirectory("xml");
            }
            XDocument studentDoc = new XDocument();
            XDeclaration xDeclaration = new XDeclaration("1.0", "utg- 8", "yes");
            studentDoc.Declaration = xDeclaration;
            XElement xElement = new XElement("studentcontract");
            studentDoc.Add(xElement);
            studentDoc.Save(_basePath);
        }
        ///<summary>
        ///增加学生信息
        ///</summary>
        public static bool AddStudentInfo(StudentInfo param)
        {
            XElement xml = XElement.Load(_basePath);
            XElement studentXml = new XElement("student");
            studentXml.Add(new XAttribute("studentid", param.StudentId));
            studentXml.Add(new XElement("name", param.Name));
            studentXml.Add(new XElement("sex", param.Sex));
            studentXml.Add(new XElement("age", param.Age));
            studentXml.Add(new XElement("birthdate", param.BirthDate.ToString("yyyy-MM-dd")));
            studentXml.Add(new XElement("phone", param.Phone));
            studentXml.Add(new XElement("homeaddress", param.HomeAddress));
            studentXml.Add(new XElement("email", param.Email));
            studentXml.Add(new XElement("profession", param.Profession));
            xml.Add(studentXml);
            xml.Save(_basePath);
            return true;
        }
        ///<summary>
        ///修改学生信息
        ///</summary>
        public static bool UpdateStudentInfo(StudentInfo param)
        {
            bool result = false;
            if (param.StudentId > 0)
            {
                XElement xml = XElement.Load(_basePath);
                XElement studentXml=(from db in xml.Descendants("student") where db.Attribute("studentid").Value == param.StudentId.ToString() select db).Single();
                studentXml.SetElementValue("name", param.Name);
                studentXml.SetElementValue("sex", param.Sex);
                studentXml.SetElementValue("age", param.Age.ToString());
                studentXml.SetElementValue("birthdate", param.BirthDate.ToString("yyyy-MM-dd"));
                studentXml.SetElementValue("phone", param.Phone);
                studentXml.SetElementValue("homeaddress", param.HomeAddress);
                studentXml.SetElementValue("email", param.Email);
                studentXml.SetElementValue("profession", param.Profession);
                xml.Save(_basePath);
                result = true;
            }
            return result;
        }
        ///<summary>
        ///删除学生信息
        /// </summary>
        public static bool DeleteStudentInfo(int studentid)
        {
            bool result = false;
            if(studentid>0)
            {
                XElement xml = XElement.Load(_basePath);
                XElement studentXml = (from db in xml.Descendants("student") where db.Attribute("studentid").Value == studentid.ToString() select db).Single();
                studentXml.Remove();
                xml.Save(_basePath);
                result = true;
            }
            return result;
        }
        ///<summary>
        ///查询全部学生列表
        /// </summary>
        public static List<StudentInfo> GetAllStudentInfo()
        {
            List<StudentInfo> studentList = new List<StudentInfo>();
            XElement xml = XElement.Load(_basePath);
            var studentVar = xml.Descendants("student");
            studentList = (from student in studentVar
                           select new StudentInfo
                           {
                               StudentId = Int32.Parse(student.Attribute("studentid").Value),
                               Name = student.Element("name").Value,
                               Age = Int32.Parse(student.Element("age").Value),
                               Sex = student.Element("sex").Value,
                               BirthDate = DateTime.Parse(student.Element("birthdate").Value),
                               Phone = student.Element("phone").Value,
                               HomeAddress = student.Element("homeaddress").Value,
                               Email = student.Element("email").Value,
                               Profession = student.Element("profession").Value
                           }).ToList();
            return studentList;
        }
        ///<summary>
        ///根据学号查询学生信息
        /// </summary>
        public static StudentInfo GetStudentInfo(int studentid)
        {
            StudentInfo studentinfo = new StudentInfo();
            XElement xml = XElement.Load(_basePath);
            studentinfo = (from student in xml.Descendants("student")
                           where student.Attribute("studentid").Value == studentid.ToString()
                           select new StudentInfo
                           {
                               StudentId = Int32.Parse(student.Attribute("studentid").Value),
                               Name = student.Element("name").Value,
                               Age = Int32.Parse(student.Element("age").Value),
                               Sex = student.Element("sex").Value,
                               BirthDate = DateTime.Parse(student.Element("birthdate").Value),
                               Phone = student.Element("phone").Value,
                               HomeAddress = student.Element("homeaddress").Value,
                               Email = student.Element("email").Value,
                               Profession = student.Element("profession").Value
                           }).Single();
            return studentinfo;
        }
        ///<summary>
        ///获取列表（查询）
        /// </summary>
        /// <param name="param">参数条件</param>
        /// <returns>学生列表</returns>
        public static List<StudentInfo> GetStudentInfoList(StudentInfo param)
        {
            List<StudentInfo> studentList = new List<StudentInfo>();
            XElement xml = XElement.Load(_basePath);
            var studentVar = xml.Descendants("student");
            if(param.StudentId!=0)
            {
                studentVar = xml.Descendants("student").Where(a => a.Attribute("studentid").Value == param.StudentId.ToString());
            }
            if(!String.IsNullOrEmpty(param.Name))
            {
                studentVar = xml.Descendants("student").Where(a => a.Element("name").Value == param.Name);
            }
            if (!String.IsNullOrEmpty(param.Sex))
            {
                studentVar = xml.Descendants("student").Where(a => a.Element("sex").Value == param.Sex);
            }
            if (param.Age!=0)
            {
                studentVar = xml.Descendants("student").Where(a => a.Element("age").Value == Convert.ToString(param.Age));
            }
            if (!String.IsNullOrEmpty(param.Phone))
            {
                studentVar = xml.Descendants("student").Where(a => a.Element("phone").Value == param.Phone);
            }
            if (!String.IsNullOrEmpty(param.Email))
            {
                studentVar = xml.Descendants("student").Where(a => a.Element("email").Value == param.Email);
            }
            if (!String.IsNullOrEmpty(param.HomeAddress))
            {
                studentVar = xml.Descendants("student").Where(a => a.Element("homeaddress").Value == param.HomeAddress);
            }
            if (!String.IsNullOrEmpty(param.Profession))
            {
                studentVar = xml.Descendants("student").Where(a => a.Element("profession").Value == param.Profession);
            }
            if (param.StudentId != 0)
            {
                studentVar = xml.Descendants("student").Where(a => a.Attribute("studentid").Value == param.StudentId.ToString());
            }
            if (!String.IsNullOrEmpty(param.Name))
            {
                studentVar = xml.Descendants("student").Where(a => a.Element("name").Value == param.Name);
            }
            if (!String.IsNullOrEmpty(param.Sex))
            {
                studentVar = xml.Descendants("student").Where(a => a.Element("sex").Value == param.Sex);
            }
            if (param.Age != 0)
            {
                studentVar = xml.Descendants("student").Where(a => a.Element("age").Value == Convert.ToString(param.Age));
            }
            if (!String.IsNullOrEmpty(param.Phone))
            {
                studentVar = xml.Descendants("student").Where(a => a.Element("phone").Value == param.Phone);
            }
            if (!String.IsNullOrEmpty(param.Email))
            {
                studentVar = xml.Descendants("student").Where(a => a.Element("email").Value == param.Email);
            }
            if (!String.IsNullOrEmpty(param.HomeAddress))
            {
                studentVar = xml.Descendants("student").Where(a => a.Element("homeaddress").Value == param.HomeAddress);
            }
            if (!String.IsNullOrEmpty(param.Profession))
            {
                studentVar = xml.Descendants("student").Where(a => a.Element("profession").Value == param.Profession);
            }
            studentList = (from student in studentVar
                           select new StudentInfo
                           {
                               StudentId = Int32.Parse(student.Attribute("studentid").Value),
                               Name = student.Element("name").Value,
                               Age = Int32.Parse(student.Element("age").Value),
                               Sex = student.Element("sex").Value,
                               BirthDate = DateTime.Parse(student.Element("birthdate").Value),
                               Phone = student.Element("phone").Value,
                               HomeAddress = student.Element("homeaddress").Value,
                               Email = student.Element("email").Value,
                               Profession = student.Element("profession").Value
                           }).ToList();
            return studentList;
        }
        ///<summary>
        ///获取列表（查询）
        /// </summary>
        /// <param name="param">参数条件</param>
        /// <returns>学生列表</returns>
        public static List<StudentInfo> GetStudentInfoList1(StudentInfo param,int i,int j)
        {
            List<StudentInfo> studentList = new List<StudentInfo>();
            XElement xml = XElement.Load(_basePath);
            var studentVar = xml.Descendants("student");
            switch (i)
            {
                case 0: studentVar = xml.Descendants("student").Where(a => a.Attribute("studentid").Value == param.StudentId.ToString());break;
                case 1: studentVar = xml.Descendants("student").Where(a => a.Element("name").Value == param.Name);break;
                case 2: studentVar = xml.Descendants("student").Where(a => a.Element("sex").Value == param.Sex);break;
                case 3: studentVar = xml.Descendants("student").Where(a => a.Element("age").Value == Convert.ToString(param.Age));break;
                case 4: studentVar = xml.Descendants("student").Where(a => a.Element("phone").Value == param.Phone);break;
                case 5: studentVar = xml.Descendants("student").Where(a => a.Element("email").Value == param.Email);break;
                case 6: studentVar = xml.Descendants("student").Where(a => a.Element("homeaddress").Value == param.HomeAddress);break;
                case 7: studentVar = xml.Descendants("student").Where(a => a.Element("profession").Value == param.Profession);break;
            }
           switch(j)
            {
                case -1:break;
                case 0: studentVar = xml.Descendants("student").Where(a => a.Attribute("studentid").Value == param.StudentId.ToString()); break;
                case 1: studentVar = xml.Descendants("student").Where(a => a.Element("name").Value == param.Name); break;
                case 2: studentVar = xml.Descendants("student").Where(a => a.Element("sex").Value == param.Sex); break;
                case 3: studentVar = xml.Descendants("student").Where(a => a.Element("age").Value == Convert.ToString(param.Age)); break;
                case 4: studentVar = xml.Descendants("student").Where(a => a.Element("phone").Value == param.Phone); break;
                case 5: studentVar = xml.Descendants("student").Where(a => a.Element("email").Value == param.Email); break;
                case 6: studentVar = xml.Descendants("student").Where(a => a.Element("homeaddress").Value == param.HomeAddress); break;
                case 7: studentVar = xml.Descendants("student").Where(a => a.Element("profession").Value == param.Profession); break;
            }
            studentList = (from student in studentVar
                           select new StudentInfo
                           {
                               StudentId = Int32.Parse(student.Attribute("studentid").Value),
                               Name = student.Element("name").Value,
                               Age = Int32.Parse(student.Element("age").Value),
                               Sex = student.Element("sex").Value,
                               BirthDate = DateTime.Parse(student.Element("birthdate").Value),
                               Phone = student.Element("phone").Value,
                               HomeAddress = student.Element("homeaddress").Value,
                               Email = student.Element("email").Value,
                               Profession = student.Element("profession").Value
                           }).ToList();
            return studentList;
        }
    }
}
