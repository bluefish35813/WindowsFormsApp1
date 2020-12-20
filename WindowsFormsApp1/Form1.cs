using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int sl = 3;
        public int st = 3;
        public int point = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            this.TopMost = true;
            this.Bounds = new Rectangle(10, 10, 600, 600);
            panel2.Top = panel1.Bottom - (panel1.Bottom / 10);
            golabel.Visible = false;
            wlabel.Visible = false;
            rbutton.Visible = false;
            PictureBox[] arr = new PictureBox[24];
            arr[0] = pictureBox1;
            arr[1] = pictureBox2;
            arr[2] = pictureBox3;
            arr[3] = pictureBox4;
            arr[4] = pictureBox5;
            arr[5] = pictureBox6;
            arr[6] = pictureBox7;
            arr[7] = pictureBox8;
            arr[8] = pictureBox9;
            arr[9] = pictureBox10;
            arr[10] = pictureBox11;
            arr[11] = pictureBox12;
            arr[12] = pictureBox13;
            arr[13] = pictureBox14;
            arr[14] = pictureBox15;
            arr[15] = pictureBox16;
            arr[16] = pictureBox17;
            arr[17] = pictureBox18;
            arr[18] = pictureBox19;
            arr[19] = pictureBox20;
            arr[20] = pictureBox21;
            arr[21] = pictureBox22;
            arr[22] = pictureBox23;
            arr[23] = pictureBox24;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Left = Cursor.Position.X - (panel2.Width / 2);
            panel4.Left += sl;
            panel4.Top += st;
            if (panel4.Bottom >= panel2.Top && panel4.Bottom <= panel2.Bottom && panel4.Left >= panel2.Left && panel4.Right <= panel2.Right)
            {
                st = -st;
                plabel.Text = point.ToString();

            }
            if (panel4.Left <= panel1.Left)
            {
                sl = -sl;
            }
            if (panel4.Right >= panel1.Right)
            {
                sl = -sl;
            }
            if (panel4.Top <= panel1.Top)
            {
                st = -st;
            }
            if (panel4.Bottom >= panel1.Bottom)
            {
                timer1.Enabled = false;
                golabel.Visible = true;
                rbutton.Visible = true;
            }
            if (point == 24)
            {
                timer1.Enabled = false;
                wlabel.Visible = true;
                rbutton.Visible = true;
            }
         
            PictureBox[] arr = new PictureBox[24];
            arr[0] = pictureBox1;
            arr[1] = pictureBox2;
            arr[2] = pictureBox3;
            arr[3] = pictureBox4;
            arr[4] = pictureBox5;
            arr[5] = pictureBox6;
            arr[6] = pictureBox7;
            arr[7] = pictureBox8;
            arr[8] = pictureBox9;
            arr[9] = pictureBox10;
            arr[10] = pictureBox11;
            arr[11] = pictureBox12;
            arr[12] = pictureBox13;
            arr[13] = pictureBox14;
            arr[14] = pictureBox15;
            arr[15] = pictureBox16;
            arr[16] = pictureBox17;
            arr[17] = pictureBox18;
            arr[18] = pictureBox19;
            arr[19] = pictureBox20;
            arr[20] = pictureBox21;
            arr[21] = pictureBox22;
            arr[22] = pictureBox23;
            arr[23] = pictureBox24;
            for (int i = 0; i < 24; i++)
            {
                if (arr[i].Visible && panel4.Bounds.IntersectsWith(arr[i].Bounds))
                {

                    arr[i].Visible = false;
                    st = -st;
                    point++;
                    plabel.Text = point.ToString();
                }
            }

        }

        private void rbutton_Click(object sender, EventArgs e)
        {
            panel4.Top = 50;
            panel4.Left = 50;
            sl = 2;
            st = 2;
            point = 0;
            plabel.Text = "0";
            timer1.Enabled = true;
            golabel.Visible = false;
            wlabel.Visible = false;
            rbutton.Visible = false;
            PictureBox[] arr = new PictureBox[24];
            arr[0] = pictureBox1;
            arr[1] = pictureBox2;
            arr[2] = pictureBox3;
            arr[3] = pictureBox4;
            arr[4] = pictureBox5;
            arr[5] = pictureBox6;
            arr[6] = pictureBox7;
            arr[7] = pictureBox8;
            arr[8] = pictureBox9;
            arr[9] = pictureBox10;
            arr[10] = pictureBox11;
            arr[11] = pictureBox12;
            arr[12] = pictureBox13;
            arr[13] = pictureBox14;
            arr[14] = pictureBox15;
            arr[15] = pictureBox16;
            arr[16] = pictureBox17;
            arr[17] = pictureBox18;
            arr[18] = pictureBox19;
            arr[19] = pictureBox20;
            arr[20] = pictureBox21;
            arr[21] = pictureBox22;
            arr[22] = pictureBox23;
            arr[23] = pictureBox24;
            for (int i = 0; i < 24; i++)
            {
                arr[i].Visible = true;
            }
            panel4.Location = new Point(300,300);
            

        }
    }
}
