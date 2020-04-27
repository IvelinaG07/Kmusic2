using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    
    public partial class Form2 : Form
    {OleDbDataReader list;
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader list1;
        OleDbConnection con1;
        OleDbCommand cmd1;
        string a;

        public Form2(Form3 form3)
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Заглавие");
            comboBox1.Items.Add("Времетраене");
            comboBox1.Items.Add("Изпълнител");
            comboBox1.Items.Add("Година");
            comboBox1.Items.Add("Жанр");
            label2.Text = "Заглавие       Времетраене       Изпълнител       Година       Жанр";
            /*
            con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\iseto\Desktop\domashni\WindowsFormsApp5\usp.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Pesni";
            list = cmd.ExecuteReader();
            label2.Text= "Заглавие       Времетраене       Изпълнител       Година       Жанр";
            while (list.Read())
            {
               
                listBox1.Items.Add(list["Zaglavie"] + "         " + list["Vreme"] + "           "  + list["Izpulnitel"] + "         " + list["Godina"] + "          " + list["Tip"].ToString());


            }
            con.Close();*/
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            a = textBox1.Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           switch (comboBox1.SelectedIndex)

            {       case 0:
                    listBox1.Items.Clear();
                    if (textBox1.Text== "Въведете търсената дума")
                    {
                        MessageBox.Show("Моля въведете име на песента!");
                        return;
                    }
                    con1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ivelina\Downloads\WindowsFormsApp5\WindowsFormsApp5\usp.accdb");
                    cmd1 = new OleDbCommand();
                    con1.Open();
                    cmd1.Connection = con1;
                    
                    cmd1.CommandText = "SELECT * FROM Pesni where Zaglavie LIKE '%" + textBox1.Text + "%'";
                    list1 = cmd1.ExecuteReader();
                    label2.Text = "Заглавие       Времетраене       Изпълнител       Година       Жанр";
                    while (list1.Read())
                    {

                        listBox1.Items.Add(list1["Zaglavie"] + "         " + list1["Vreme"] + "           " + list1["Izpulnitel"] + "         " + list1["Godina"] + "          " + list1["Tip"].ToString());


                    }
                    con1.Close();
                    break;
                case 1:
                    listBox1.Items.Clear();
                    if (textBox1.Text == "Въведете търсената дума")
                    {
                        MessageBox.Show("Моля въведете времетраене na песента!");
                        return;
                    }
                    con1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ivelina\Downloads\WindowsFormsApp5\WindowsFormsApp5\usp.accdb");
                    cmd1 = new OleDbCommand();
                    con1.Open();
                    cmd1.Connection = con1;

                    cmd1.CommandText = "SELECT * FROM Pesni where Vreme LIKE '%" + textBox1.Text + "%'";
                    list1 = cmd1.ExecuteReader();
                    label2.Text = "Заглавие       Времетраене       Изпълнител       Година       Жанр";
                    while (list1.Read())
                    {

                        listBox1.Items.Add(list1["Zaglavie"] + "         " + list1["Vreme"] + "           " + list1["Izpulnitel"] + "         " + list1["Godina"] + "          " + list1["Tip"].ToString());

                    }
                    con1.Close(); ; break;
                case 2:
                    listBox1.Items.Clear();
                    if (textBox1.Text == "Въведете търсената дума")
                    {
                        MessageBox.Show("Моля въведете изпълнител na песента!");
                        return;
                    }
                    con1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ivelina\Downloads\WindowsFormsApp5\WindowsFormsApp5\usp.accdb");
                    cmd1 = new OleDbCommand();
                    con1.Open();
                    cmd1.Connection = con1;

                    cmd1.CommandText = "SELECT * FROM Pesni where Izpulnitel LIKE '%" + textBox1.Text + "%'";
                    list1 = cmd1.ExecuteReader();
                    label2.Text = "Заглавие       Времетраене       Изпълнител       Година       Жанр";
                    while (list1.Read())
                    {

                        listBox1.Items.Add(list1["Zaglavie"] + "         " + list1["Vreme"] + "           " + list1["Izpulnitel"] + "         " + list1["Godina"] + "          " + list1["Tip"].ToString());


                    }
                    con1.Close(); ; break;
                case 3:
                    listBox1.Items.Clear();
                    if (textBox1.Text == "Въведете търсената дума")
                    {
                        MessageBox.Show("Моля въведете година na песента!");
                        return;
                    }
                    con1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ivelina\Downloads\WindowsFormsApp5\WindowsFormsApp5\usp.accdb");
                    cmd1 = new OleDbCommand();
                    con1.Open();
                    cmd1.Connection = con1;

                    cmd1.CommandText = "SELECT * FROM Pesni where Godina LIKE '%" + textBox1.Text + "%'"; ;
                    list1 = cmd1.ExecuteReader();
                   
                    while (list1.Read())
                    {

                        listBox1.Items.Add(list1["Zaglavie"] + "         " + list1["Vreme"] + "           " + list1["Izpulnitel"] + "         " + list1["Godina"] + "          " + list1["Tip"].ToString());

                    }
                    con1.Close(); ; break;
                case 4:
                    listBox1.Items.Clear();
                    if (textBox1.Text == "Въведете търсената дума")
                    {
                        MessageBox.Show("Моля въведете жанр na песента!");
                        return;
                    }
                    con1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ivelina\Downloads\WindowsFormsApp5\WindowsFormsApp5\usp.accdb");
                    cmd1 = new OleDbCommand();
                    con1.Open();
                    cmd1.Connection = con1;

                    cmd1.CommandText = "SELECT * FROM Pesni where Tip LIKE '%" + textBox1.Text + "%'";
                    list1 = cmd1.ExecuteReader();
                    label2.Text = "Заглавие       Времетраене       Изпълнител       Година       Жанр";
                    while (list1.Read())
                    {

                        listBox1.Items.Add(list1["Zaglavie"] + "         " + list1["Vreme"] + "           " + list1["Izpulnitel"] + "         " + list1["Godina"] + "          " + list1["Tip"].ToString());


                    }
                    con1.Close(); ; break;
            }
        }
        private void SearchText_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Въведете търсената дума")
            { textBox1.Text = "";
                textBox1.ForeColor = Color.Black;

            }
        }

        private void SearchText_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Въведете търсената дума";
                textBox1.ForeColor = Color.Gray;

            }
        }

    }
}
