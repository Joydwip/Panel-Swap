using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Input_Form : Form
    {
        Student[] s = new Student[4];
        
        

        int i = 0;
        public Input_Form()
        {
            InitializeComponent();
            for(int k=0; k<4; k++)
            {
                s[k] = new Student();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s[i] = new Student();
            if (i < 3)
            {
                label_header.Text = "Entar the information of student " + (i + 2) + ":";
                s[i].name = textBox1.Text;
                s[i].id = textBox2.Text;
                s[i].discipline = textBox3.Text;
               
                i++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                

            }
            else
            {
                s[i].name = textBox1.Text;
                s[i].id = textBox2.Text;
                s[i].discipline = textBox3.Text;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                label_header.Text = "Press Show Button...";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel_Swap p = new Panel_Swap();
            p.setStudent(s);
            p.Show();
           
        }
    }
}
