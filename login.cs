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

namespace CGS_windows
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if(textBox1.Text == "")
            //{
            //    MessageBox.Show("enter username");
            //}
            //else if (textBox2.Text == "")
            //{
            //    MessageBox.Show("enter password");
            //}
            //else if (textBox1.Text == "admin" && textBox2.Text == "123")
            //{
            //    MessageBox.Show("login success");
            //    this.Hide();
            //    Form mainform = new mainForm();
            //    mainform.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("invalid");
            //}

            bool flag = false;
            using (StreamReader sr = new StreamReader(@"C:\Users\mosik\source\C2\CGS_windows\login.txt"))
            {
                while (sr.Peek() >= 0)
                {
                    string str;
                    string[] strArray;
                    str = sr.ReadLine();

                    strArray = str.Split(',');

                    if (strArray[0] == textBox1.Text && strArray[1] == textBox2.Text)
                    {
                        flag = true;
                        
                    }
                }
                    if (flag == true)
                    {
                        MessageBox.Show("login success");
                        this.Hide();
                        Form mainform = new mainForm();
                        mainform.ShowDialog();
                    }
                    else if (textBox1.Text == "")
                    {
                        MessageBox.Show("enter username");
                    }
                    else if (textBox2.Text == "")
                    {
                        MessageBox.Show("enter password");
                    }
                    else
                    {
                        MessageBox.Show("invalid, wrong username or password");
                    }

                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
