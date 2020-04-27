using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace WindowsFormsApp5
{
    public partial class Form4 : Form
    {
        music b = new music();
        private Form5 Form5;
        public Form4(Form5 form5)
        {
            InitializeComponent();
        }

        public Form4()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            groupBox3.Visible = true;
            groupBox2.Visible = false;
            listBox1.Visible = false;
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Conn c = new Conn();
            {
                c.Email = textBox1.Text;
                c.Parola = textBox2.Text;
                b.Delete(c);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conn c = new Conn();
            {
                c.Ime = textBox3.Text;
                c.Potrebitelsko = textBox4.Text;
                c.Email = textBox5.Text;
                c.Parola = textBox6.Text;
                b.Insert2(c);
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Моля въведете име!");
                return;
            }
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Моля въведете потребителско име!");
                return;
            }
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Моля въведете парола!");
                return;
            }
          
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Моля въведете email!");
                return;
            }
            if (textBox7.Text.Length == 0)
            {
                MessageBox.Show("Моля въведете парола");
                textBox7.Clear();
                textBox6.Clear();
                return;
            }
            if (textBox6.Text != textBox7.Text)
            {
                MessageBox.Show("Паролата е грешна");
                textBox7.Clear();
                textBox6.Clear();
                return;
            }

            else
            {
                if (textBox6.Text.Length < 8)
                {
                    MessageBox.Show("Моля въведете повече от 8 символа");
                    textBox7.Clear();
                    textBox6.Clear();
                    return;
                }
            }
            MessageBox.Show("Добре дошли!");
        }

            OleDbConnection conn;
            OleDbCommand cmd2;
            OleDbDataReader dr2;
        public object SelectedItem { get; set; }
       
        private void button1_Click(object sender, EventArgs e)
        {

            string usr = textBox1.Text;
            string psw = textBox2.Text;
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ivelina\Downloads\WindowsFormsApp5\WindowsFormsApp5\usp.accdb");
            cmd2 = new OleDbCommand();
            conn.Open();
            cmd2.Connection = conn;
            cmd2.CommandText = "SELECT * FROM Registraciq where Email='" + textBox1.Text + "' AND Parola='" + textBox2.Text + "'";
            dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                MessageBox.Show("Добре дошли!");
            }
            else
            {
                MessageBox.Show("Email или паролата не са коректни!");
            }

            conn.Close();


        }

              private void button5_Click(object sender, EventArgs e)
        {
            string usr = textBox1.Text;
            string psw = textBox2.Text;
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ivelina\Downloads\WindowsFormsApp5\WindowsFormsApp5\usp.accdb");
            cmd2 = new OleDbCommand();
            conn.Open();
            cmd2.Connection = conn;
            cmd2.CommandText = "SELECT * FROM Registraciq where Email='" + textBox8.Text + "' AND Parola='" + textBox9.Text + "'";
            dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {

                Conn c = new Conn();
                {
                    c.Email = textBox8.Text;
                    c.Parola = textBox10.Text;

                    if (textBox10.Text != textBox11.Text)
                    {
                        MessageBox.Show("Паролата е грешна");
                        textBox10.Clear();
                        textBox11.Clear();
                        return;
                    }

                    else
                    {
                        if (textBox10.Text.Length < 8)
                        {
                            MessageBox.Show("Моля въведете повече от 8 символа");
                            textBox10.Clear();
                            textBox11.Clear();
                            return;
                        }
                    }
                    b.Update(c);
                }
            }
            else
            {
                MessageBox.Show("Email или паролата не са коректни!");
            }

            conn.Close();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            listBox1.Visible = false;
        }
       
        private void button7_Click(object sender, EventArgs e)
        {
            string path1 = "save.txt";
            File.AppendAllLines(path1, new[] { "" });

            listBox1.Visible = true;
            groupBox3.Visible = false;
            groupBox2.Visible = false;
            listBox1.DataSource = File.ReadAllLines("save.txt");
            if (listBox1.Text == null)
            {
                MessageBox.Show("Плейлиста е празен!");
            }
                       
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
