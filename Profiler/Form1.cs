using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profiler
{
    public partial class Form1 : Form
    {

        String First_Name = "";
        String Last_Name = "";
        String  Phone ;
        String email = "";
        String University_no = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.First_Name = this.textBox1.Text;
            this.Last_Name = this.textBox2.Text;
            this.University_no = this.textBox3.Text;
            this.Phone = this.textBox4.Text;
            this.email = this.textBox5.Text;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hey ! "+this.First_Name +" "+ this.Last_Name + " with " + this.University_no + " Registered on " + this.Phone + "with Email " +  this.email, "Registered!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
