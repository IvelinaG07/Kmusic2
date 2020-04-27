
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
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using WMPLib;
using System.IO;

namespace WindowsFormsApp5
{
    public partial class Form5 : Form
    {
        public static string SetValueForText2 = "";
        OleDbConnection con1;
        OleDbCommand cmd1;
        OleDbDataReader dr1;
        private Stream sPath;

        public object SelectedItem { get; set; }

        


        public Form5()
        {
            
            InitializeComponent();

        }
        
       
        private void Form5_Load(object sender, EventArgs e)
        {
                       

            con1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ivelina\Downloads\WindowsFormsApp5\WindowsFormsApp5\usp.accdb");
            cmd1 = new OleDbCommand();
            con1.Open();
            cmd1.Connection = con1;
            cmd1.CommandText = "SELECT * FROM Pesni";
            dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {
                listBox1.Items.Add(dr1["Zaglavie"] + "  -  " + dr1["Izpulnitel"] + "  -  " + dr1["Godina"] + "  -  " + dr1["Tip"] + "  -  " + dr1["Vreme"]);
                
            }
           
             con1.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {

                case 0:
                    const string P = "Dua Lipa - Break My Heart (Official Video).mp3";
                    axWindowsMediaPlayer1.URL = P; break;
                 
                case 1:
                    const string Q = "Dua Lipa - Physical (Official Video).mp3";
                    axWindowsMediaPlayer1.URL = Q; break;
                case 2:
                    const string L = "Queen - Under Pressure (Official Video).mp3";
                    axWindowsMediaPlayer1.URL = L; break;
                case 3:
                    const string T = "The Rolling Stones - Start Me Up - Official Promo.mp3";
                    axWindowsMediaPlayer1.URL = T; break;
                case 4:
                    const string E = "Eminem - Lose Yourself [HD].mp3";
                    axWindowsMediaPlayer1.URL = E; break;
                case 5:
                    const string D = "Ed Sheeran - Perfect (Official Music Video).mp3";
                    axWindowsMediaPlayer1.URL = D; break;
                case 6:
                    const string S = "Post Malone - Sunflower.mp3";
                    axWindowsMediaPlayer1.URL = S; break;
                case 7:
                    const string C = "Ciara - Level Up.mp3";
                    axWindowsMediaPlayer1.URL = C; break;
                case 8:
                    const string G = "Gary B.B. Coleman - The Sky is Crying.mp3";
                    axWindowsMediaPlayer1.URL = G; break;
                case 9:
                    const string H = "Hit the road Jack!.mp3";
                    axWindowsMediaPlayer1.URL = H; break;
                    }
            }

        private void button3_Click(object sender, EventArgs e)
        {
            const string sPath = "save.txt";

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            foreach (var item in listBox2.Items)
            {
                SaveFile.WriteLine(item);
            }

            SaveFile.Close();

            MessageBox.Show("Плейлиста е запазен!");


        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        internal void button1_Click(string text)
        {
            throw new NotImplementedException();
        }
    }
}

