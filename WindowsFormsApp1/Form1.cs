using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int sl = 4;
        public int st = 4;
        public int point = 0;
        public int count = 0;
        public int num = -1;
        public int num2 = -1;
        public int num3 = -1;
        int[] breaks = new int[24];

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
            nlevel.Visible = false;
            resbutton.Visible = false;
            int levcount = count + 1;
            string levc = levcount.ToString();
            lnumlab.Text = levc;
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
            set();
            
        }

        private void set()
        {
            for (int b = 0; b < 24; b++)
            {
                breaks[b] = 1;
            }
        }
        private void setn()
        {
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
            int levcount = count + 1;
            string levc = levcount.ToString();
            lnumlab.Text = levc;
            for (int i = 0; i < 24; i++)
            {
                if (arr[i].BackColor == Color.White)
                {
                    breaks[i] = 2;
                }
                if (arr[i].BackColor == Color.Pink)
                {
                    breaks[i] = 3;
                }
            }
            if (count >= 1)
            {
                Random rnd = new Random();
                for (int i = 0; i < 1;)
                {
                    num = rnd.Next(0, 24);
                    if (arr[num].BackColor == Color.Purple) {
                        breaks[num] = 2;
                        arr[num].BackColor = Color.White;
                        i++;
                    }
                }
                for (int i = 0; i < 1;)
                {
                    num2 = rnd.Next(0, 24);
                    if (arr[num2].BackColor == Color.Purple)
                    {
                        breaks[num2] = 2;
                        arr[num2].BackColor = Color.White;
                        i++;
                    }
                }
                if (count % 2 == 0)
                {
                    for (int i = 0; i < 1;)
                    {
                        num3 = rnd.Next(0, 24);
                        if (arr[num3].BackColor == Color.Purple)
                        {
                            breaks[num3] = 3;
                            arr[num3].BackColor = Color.Pink;
                            i++;
                        }
                    }
                }
            }
            
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
                levlabel.Visible = false;
                lnumlab.Visible = false;
                pabutton.Visible = false;
                resbutton.Visible = false;
                golabel.Visible = true;
                rbutton.Visible = true;
                count = 0;
            }
            if (point == 24 && count < 9)
            {
                timer1.Enabled = false;
                pabutton.Visible = false;
                resbutton.Visible = false;
                nlevel.Visible = true;
            }
            if (point == 24 && count == 9)
            {
                timer1.Enabled = false;
                levlabel.Visible = false;
                lnumlab.Visible = false;
                pabutton.Visible = false;
                resbutton.Visible = false;
                wlabel.Visible = true;
                nlevel.Visible = false;
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
                    if (breaks[i] > 1)
                    {
                        breaks[i]--;
                    }
                    else 
                    {
                        arr[i].Visible = false;
                        point++;
                        plabel.Text = point.ToString();
                    }
                    st = -st;
                }
            }

        }

        private void rbutton_Click(object sender, EventArgs e)
        {
            panel4.Top = 50;
            panel4.Left = 50;
            sl = 4;
            st = 4;
            point = 0;
            plabel.Text = "0";
            timer1.Enabled = true;
            golabel.Visible = false;
            wlabel.Visible = false;
            rbutton.Visible = false;
            levlabel.Visible = true;
            lnumlab.Text = "1";
            lnumlab.Visible = true;
            pabutton.Visible = true;
            resbutton.Visible = false;
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
                arr[i].BackColor = Color.Purple;
            }
            panel4.Location = new Point(300,300);
            set();

        }

        private void nlevel_Click(object sender, EventArgs e)
        {
            panel4.Top = 50;
            panel4.Left = 50;
            sl = 4;
            st = 4;
            point = 0;
            count++;
            plabel.Text = "0";
            timer1.Enabled = true;
            golabel.Visible = false;
            wlabel.Visible = false;
            rbutton.Visible = false;
            nlevel.Visible = false;
            pabutton.Visible = true;
            resbutton.Visible = false;
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
            panel4.Location = new Point(300, 300);
            set();
            setn();
        }

        private void pabutton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            pabutton.Visible = false;
            resbutton.Visible = true;
        }

        private void resbutton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            pabutton.Visible = true;
            resbutton.Visible = false;
        }
    }
}
