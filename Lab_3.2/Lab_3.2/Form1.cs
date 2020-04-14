using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetOpacity_Click(object sender, EventArgs e)
        {
            if (this.Opacity != 1)
                this.Opacity = 1;
            else
                this.Opacity = 0.5;
        }

        private void SetBackgroundColor_Click(object sender, EventArgs e)
        {
            if (this.BackColor != Color.Silver)
                this.BackColor = Color.Silver;
            else
                this.BackColor = Color.Yellow;
        }

        private void btnSayHelloWorld_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void btnSetOfActions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я супермегакнопка, \nі цього мене не позбавиш!");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
                this.btnSetOfActions.Click += new System.EventHandler(this.SetOpacity_Click);
            else
                this.btnSetOfActions.Click -= new System.EventHandler(this.SetOpacity_Click);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                this.btnSetOfActions.Click += new System.EventHandler(this.SetBackgroundColor_Click);
            else
                this.btnSetOfActions.Click -= new System.EventHandler(this.SetBackgroundColor_Click);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                this.btnSetOfActions.Click += new System.EventHandler(this.btnSayHelloWorld_Click);
            else
                this.btnSetOfActions.Click -= new System.EventHandler(this.btnSayHelloWorld_Click);
        }
    }
}
