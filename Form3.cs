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

namespace WindowsFormsApp5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        music b = new music();
        
        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(this);
            frm2.Show();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            button7.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox2.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            button7.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox2.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            button7.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Conn c = new Conn();
            {
                c.EmailS = textBox1.Text;
                c.Suobshtenie = richTextBox1.Text;
                b.InsertS(c);
            }
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Моля въведете email!");
                return;
            }
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("Моля напишете съобщение!");
                return;
            }
            MessageBox.Show("Благодарим Ви!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            File.Delete("save.txt");
            this.Close();
        }
    }
}
