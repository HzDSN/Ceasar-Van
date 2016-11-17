using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        Username username;

        enum Username
        {
            Student,
            Teacher,
            Admin
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1 != null)
            {
                if (radioButton1.Checked)
                {
                    MessageBox.Show("你确定选择 学生 权限吗？", "权限");
                    username = Username.Student;

                    this.Text = "学生界面";
                }
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2 != null)
            {
                if (radioButton2.Checked)
                {
                    MessageBox.Show("你确定选择 老师 权限吗？", "权限");
                    username = Username.Teacher;
                    this.Text = "老师界面";
                }
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3 != null)
            {
                if (radioButton3.Checked)
                {
                    MessageBox.Show("你确定选择 管理员 权限吗？", "权限");
                    username = Username.Admin;
                    this.Text = "管理员界面";
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (username == Username.Student && textBox1.Text == "student" && textBox2.Text == "123456")
            {
                textBox3.Text = "同学，你好。你选择的是：" + "\r\n";
                textBox3.Text = textBox3.Text + getClassName();
            }
            else if (username == Username.Teacher && textBox1.Text == "teacher" && textBox2.Text == "123456")
            {
                textBox3.Text = "老师，你好。你选择的是：" + "\r\n";
                textBox3.Text = textBox3.Text + getClassName();
            }
            else if (username == Username.Admin && textBox1.Text == "admin" && textBox2.Text == "123456")
            {
                textBox3.Text = "管理员，你好。你选择的是：" + "\r\n";
                textBox3.Text = textBox3.Text + getClassName();
            }
            else
            {
                MessageBox.Show("您的操作有错误。请仔细阅读使用说明后重试。","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private string getClassName()
        {
            string className=string.Empty ;
            if (checkBox1.Checked )
            {
                className = className + checkBox1.Text + "，";
            }
            if (checkBox2.Checked)
            {
                className = className + checkBox2.Text + "，";
            }
            if (checkBox3.Checked)
            {
                className = className + checkBox3.Text + "，";
            }
            if(className.Length>0 && className.Substring(className.Length - 1)=="，")
            {
                className = className.Substring(0, className.Length - 1);
            }
            return className;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point p = label5.Location;
            p.Y = p.Y - 10;
            if (p.Y < -label5.Height)
            {
                p.Y = this.Height + label5.Height;
            }
            label5.Location = p;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
