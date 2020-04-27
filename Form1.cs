using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        music b = new music();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addbutton1_Click(object sender, EventArgs e)
        {
            Conn c = new Conn();
           
            {
                if (textBox1.Text == "Въведете  име на песен")
                {
                    MessageBox.Show("Моля въведете име на песента!");
                    return;

                }
                if (textBox2.Text == "Въведете времетраене ( формат:  3:30)")
                {
                    MessageBox.Show("Моля въведете времетраене на песента!");
                    return;

                }
                string t = textBox2.Text;
                if (t.Length == 4 || t.Length == 5 && t.Contains(':') || t.Contains(';'))
                {
                    int s;
                    int m;
                    if (t.Length == 4)
                    {
                        int.TryParse(t.Substring(0, 1), out m);
                        int.TryParse(t.Substring(2, 2), out s);
                    }
                    else {
                        int.TryParse(t.Substring(0, 2), out m);
                        int.TryParse(t.Substring(3, 2), out s);
                    }
                    if ( m < 0 || s < 0 || s > 60)
                {
                        MessageBox.Show("Моля въведете валидно времетраене на песента!");
                        return;
                    }
                }
                else {
                    MessageBox.Show("Моля въведете валидно времетраене на песента!");
                    return;
                }
                if (textBox3.Text == "Въведи име")
                {
                    MessageBox.Show("Моля въведете име на певец/група!");
                    return;

                }
              
               string a = textBox4.Text;
                if (a.Length != 4)
                    {
                        MessageBox.Show("Моля въведете валидна година!");
                        return;
                    }
                try
                {
                    int temp = Convert.ToInt32(textBox4.Text);
                }
                catch (Exception h)
                {
                    MessageBox.Show("Моля въведете валидна година!");
                }
                if (textBox4.Text == "Въведете година ( формат: 2020)")
                {
                    MessageBox.Show("Моля въведете година на песента!");
                    return;

                }
                if (textBox5.Text == "Въведете жанр")
                {
                    MessageBox.Show("Моля въведете жанр на песента!");
                    return;

                }

                c.Zaglavie = textBox1.Text;
                c.Vreme = textBox2.Text;
                c.Izpulnitel = textBox3.Text;
                c.Godina = textBox4.Text;
                c.Tip = textBox5.Text;

                b.Insert(c);

                 MessageBox.Show("Песента е добавена.");

            }
         
            
            textBox1.Text = "Въведете  име на песен";
            textBox2.Text = "Въведете времетраене ( формат:  3:30)";
            textBox3.Text = "Въведи име";
            textBox4.Text = "Въведете година ( формат: 2020)";
            textBox5.Text = "Въведете жанр";
            textBox1.ForeColor = Color.Gray;
            textBox2.ForeColor = Color.Gray;
            textBox3.ForeColor = Color.Gray;
            textBox4.ForeColor = Color.Gray;
            textBox5.ForeColor = Color.Gray;
        
            }
        /*
        private void button1_Click(object sender, EventArgs e)
        {
           // Form2 frm = new Form2(this);
            //frm.Show();
        }
        */
              
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Въведете  име на песен";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Въведете  име на песен")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Въведете времетраене ( формат:  3:30)";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Въведете времетраене ( формат:  3:30)")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Въведи име";
                textBox3.ForeColor = Color.Gray;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Въведи име")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Въведете година ( формат: 2020)";
                textBox4.ForeColor = Color.Gray;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Въведете година ( формат: 2020)")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Въведете жанр";
                textBox5.ForeColor = Color.Gray;
            }

        }

    private void textBox5_Enter(object sender, EventArgs e)
        {
        if (textBox5.Text == "Въведете жанр")
        {
            textBox5.Text = "";
            textBox5.ForeColor = Color.Black;

        }
    }

           }
}
