using BO;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Panel_Swap : Form
    {
        ClassBo bo = new ClassBo();
        int temp,p;
        Student[] s = new Student[4];
        Point a = new Point(81, 42);
        Point b = new Point(423, 42);
        Point c = new Point(81, 257);
        Point d = new Point(423, 257);
        
        Point pan1 = new Point(0,1);
        Point pan2 = new Point(0,2);
        Point pan3 = new Point(0,3);
        Point pan4 = new Point(0,4);
        
      
        public Panel_Swap()
        {
            InitializeComponent();

        }

        public void setStudent(Student[] sp)
        {
            this.s = sp;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            temp = 1;
            pan1 = panel1.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            temp = 0;
            bo.swap(panel1, panel1, panel2, panel3, panel4, pan1);
           
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (temp == 1)
            {
                panel1.Location = new Point(Cursor.Position.X - 200, Cursor.Position.Y - 200);
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            temp = 2;
            pan2 = panel2.Location;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            temp = 0;
            bo.swap(panel2, panel1, panel2, panel3, panel4, pan2);
          
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (temp == 2)
            {
                panel2.Location = new Point(Cursor.Position.X - 200, Cursor.Position.Y - 200);
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            temp = 3;
            pan3 = panel3.Location;
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            temp = 0;
            bo.swap(panel3, panel1, panel2, panel3, panel4, pan3);
           
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (temp == 3)
            {
                panel3.Location = new Point(Cursor.Position.X - 200, Cursor.Position.Y - 200);
            }
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            temp = 4;
            pan4 = panel4.Location;
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            temp = 0;
            bo.swap(panel4, panel1, panel2, panel3, panel4, pan4);
           
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (temp == 4)
            {
                panel4.Location = new Point(Cursor.Position.X - 200, Cursor.Position.Y - 200);
            }
        }

        private void Panel_Swap_Load(object sender, EventArgs e)
        {
            label13.Text = s[0].name;
            label14.Text = s[0].id;
            label15.Text = s[0].discipline;

            label16.Text = s[1].name;
            label17.Text = s[1].id;
            label18.Text = s[1].discipline;

            label19.Text = s[2].name;
            label20.Text = s[2].id;
            label21.Text = s[2].discipline;

            label22.Text = s[3].name;
            label23.Text = s[3].id;
            label24.Text = s[3].discipline;
        }
    }
}
