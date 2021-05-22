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

namespace 拼图游戏
{
    public partial class Form_Main : Form
    {
        PictureBox[] pictureList = null;
        SortedDictionary<string, Bitmap> pictureLocationDict = new SortedDictionary<string, Bitmap>();
        Point[] pointList = null;
        SortedDictionary<string, PictureBox> pictureBoxLocationDict = new SortedDictionary<string, PictureBox>();
        int second = 0;
        int time = 0;
        int step = 0;
        PictureBox currentPictureBox = null;
        PictureBox haveToPictureBox = null;
        Point oldLocation = Point.Empty;
        Point newLocation = Point.Empty;
        Point mouseDownPoint = Point.Empty;
        Rectangle rect = Rectangle.Empty;
        bool isDrag = false;
        public string originalpicpath;
        /// <summary>
        /// 每个方向上要切割成的块数
        /// </summary>
        private int ImgNumbers
        {
            get
            {
                return (int)this.numericUpDown1.Value;
            }
        }
        /// <summary>
        /// 要切割成的正方形图片边长
        /// </summary>
        private int SideLength
        {
            get
            {
                return 600 / this.ImgNumbers;
            }
        }
        private void InitRandomPictureBox()
        {
            pnl_Picture.Controls.Clear();
            pictureList = new PictureBox[ImgNumbers * ImgNumbers];
            pointList = new Point[ImgNumbers * ImgNumbers];
            for(int i=0;i<this.ImgNumbers;i++)
            {
                for(int j = 0; j < this.ImgNumbers; j++)
                {
                    PictureBox pic = new PictureBox();
                    pic.Name = "pictureBox" + (j + i * ImgNumbers + 1).ToString();
                    pic.Location = new Point(j * SideLength, i * SideLength);
                    pic.Size = new Size(SideLength, SideLength);
                    pic.Visible = true;
                    pic.BorderStyle = BorderStyle.FixedSingle;
                    pic.MouseDown += new MouseEventHandler(pictureBox_MouseDown);
                    pic.MouseMove += new MouseEventHandler(pictureBox_MouseMove);
                    pic.MouseUp += new MouseEventHandler(pictureBox_MouseUp);
                    pnl_Picture.Controls.Add(pic);
                    pictureList[j + i * ImgNumbers] = pic;
                    pointList[j + i * ImgNumbers] = new Point(j * SideLength, i * SideLength);
                }
            }
        }
        public void Flow (string path,bool disorder)
        {
            InitRandomPictureBox();
            Image bm = CutPicture.Resize(path, 600, 600);
            CutPicture.BitMapList = new List<Bitmap>();
            for (int y=0;y<600;y+=SideLength)
            {
                for(int x=0;x<600;x+=SideLength)
                {
                    Bitmap temp = CutPicture.Cut(bm, x, y, SideLength, SideLength);
                    CutPicture.BitMapList.Add(temp);
                }
            }
            ImportBitMap(disorder);
        }
        public void ImportBitMap(bool disorder)
        {
            try
            {
                int i = 0;
                foreach(PictureBox item in pictureList)
                {
                    Bitmap temp = CutPicture.BitMapList[i];
                    item.Image = temp;
                    i++;
                }
                if (disorder)
                {
                    ResetPictureLocation();
                }
            }
            catch(Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
        public void ResetPictureLocation()
        {
            Point[] temp = DisOrderLocation();
            int i = 0;
            foreach (PictureBox item in pictureList)
            {
                item.Location = temp[i];
                i++;
            }
        }
        public Point[] DisOrderLocation()
        {
            Point[] tempArray = (Point[])pointList.Clone();
            for (int i = tempArray.Length - 1; i > 0; i--)
            {
                Random rand = new Random();
                int p = rand.Next(i);
                Point temp = tempArray[p];
                tempArray[p] = tempArray[i];
                tempArray[i] = temp;
            }
            return tempArray;
        }
        public void InitGame()
        {
            if (!Directory.Exists(Application.StartupPath.ToString() + "\\Picture"))
            {
                Directory.CreateDirectory(Application.StartupPath.ToString() + "\\Picture");
                Properties.Resources.艾斯.Save(Application.StartupPath.ToString() + "\\Picture\\1.jpg");
                Properties.Resources.海绵宝宝.Save(Application.StartupPath.ToString() + "\\Picture\\2.jpg");
                Properties.Resources.皮卡丘.Save(Application.StartupPath.ToString() + "\\Picture\\3.jpg");
                Properties.Resources.小熊.Save(Application.StartupPath.ToString() + "\\Picture\\4.jpg");
            }
            Random r = new Random();
            int i = r.Next(4);
            originalpicpath = Application.StartupPath.ToString() + "\\Picture\\" + (i+1).ToString() + ".jpg";
            Flow(originalpicpath, true);
            step = 0;
            lab_step.Text = step.ToString();
        }
        public Form_Main()
        {
            InitializeComponent();
            InitGame();
        }
        public PictureBox GetPictureBoxByLocation(int x,int y)
        {
            PictureBox pic = null;
            foreach(PictureBox item in pictureList)
            {
                if (x > item.Location.X && y > item.Location.Y && item.Location.X + SideLength > x && item.Location.Y + SideLength > y)
                {
                    pic = item;
                }
            }
            return pic;
        }
        public PictureBox GetPictureBoxByHashCode(string hascode)
        {
            PictureBox pic = null;
            foreach (PictureBox item in pictureList)
            {
                if (hascode == item.GetHashCode().ToString())
                {
                    pic = item;
                }
            }
            return pic;
        }
        private void pictureBox_MouseDown(object sender,MouseEventArgs e)
        {
            oldLocation = new Point(e.X, e.Y);
            currentPictureBox = GetPictureBoxByHashCode(sender.GetHashCode().ToString());
            MoseDown(currentPictureBox, sender, e);
        }
        public void MoseDown (PictureBox pic,object sender,MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                oldLocation = e.Location;
                rect = pic.Bounds;
            }
        }
        private void pictureBox_MouseMove(object sender,MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrag = true;
                rect.Location = getPointToForm(new Point(e.Location.X - oldLocation.X, e.Location.Y - oldLocation.Y));
                this.Refresh();
            }
        }
        private Point getPointToForm(Point p)
        {
            return this.PointToClient(pnl_Picture.PointToScreen(p));
        }
        private void pictureBox_MouseUp(object sender,MouseEventArgs e)
        {
            oldLocation = new Point(currentPictureBox.Location.X, currentPictureBox.Location.Y);
            if (oldLocation.X + e.X > 600 || oldLocation.Y + e.Y > 600 || oldLocation.X + e.X < 0 || oldLocation.Y + e.Y < 0)
            {
                return;
            }
            haveToPictureBox = GetPictureBoxByLocation(oldLocation.X + e.X, oldLocation.Y + e.Y);
            newLocation = new Point(haveToPictureBox.Location.X, haveToPictureBox.Location.Y);
            haveToPictureBox.Location = oldLocation;
            PictureMouseUp(currentPictureBox, sender, e);
            step++;
            lab_step.Text = step.ToString();
            if (Judge())
            {
                timer1.Stop();
                MessageBox.Show("恭喜拼图成功！");
                second = 0;
                time = 0;
                step = 0;
                lab_step.Text = step.ToString();
                lab_time.Text = second.ToString();
            }
        }
        public void PictureMouseUp(PictureBox pic,object sender,MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (isDrag)
                {
                    isDrag = false;
                    pic.Location = newLocation;
                    this.Refresh();
                }
                reset();
            }
        }
        private void reset()
        {
            mouseDownPoint = Point.Empty;
            rect = Rectangle.Empty;
            isDrag = false;
        }
        public bool Judge()
        {
            bool result = true;
            int i = 0;
            foreach(PictureBox item in pictureList)
            {
                if (item.Location != pointList[i])
                {
                    result = false;
                }
                i++;
            }
            return result;
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Form_Main_Load(object sender, EventArgs e)
        {

        }
        private void btn_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog new_picture = new OpenFileDialog();
            if (new_picture.ShowDialog() == DialogResult.OK)
            {
                originalpicpath = new_picture.FileName;
                CutPicture.PicturePath = new_picture.FileName;
                Flow(CutPicture.PicturePath, true);
                step = 0;
                lab_step.Text = step.ToString();
            }
        }

        private void btn_Changepic_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int i = r.Next(4);
            originalpicpath = Application.StartupPath.ToString() + "\\Picture\\" + (i+1).ToString() + ".jpg";
            Flow(originalpicpath, true);
            step = 0;
            lab_step.Text = step.ToString();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Flow(originalpicpath, true);
            step = 0;
            lab_step.Text = step.ToString();
        }

        private void btn_Originalpic_Click(object sender, EventArgs e)
        {
            Form_Original original = new Form_Original();
            original.picpath = originalpicpath;
            original.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Counttime()
        {
            lab_time.Text = second.ToString();
            lab_step.Text = step.ToString();
            timer1.Start();
        }
        private void btn_challenge_Click(object sender, EventArgs e)
        {
            time = (int)numericUpDown2.Value;
            second = 0;
            step = 0;
            Counttime();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            lab_time.Text = second.ToString();
            if (second == time)
            {
                timer1.Stop();
                MessageBox.Show("挑战失败！");
                time = 0;
                second = 0;
                step = 0;
                lab_time.Text = second.ToString();
                lab_step.Text = step.ToString();
            }
        }
        private void finish()
        {
            timer1.Stop();
            time = 0;
            second = 0;
            step = 0;
            lab_step.Text = step.ToString();
            lab_time.Text = second.ToString();
        }
        private void btn_stop_Click(object sender, EventArgs e)
        {
            finish();
            Flow(originalpicpath, true);
        }
    }
}
