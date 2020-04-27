using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    class music
    {
        OleDbConnection connection;
        OleDbCommand command;
        private void ConnectTo()
        {
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ivelina\Downloads\WindowsFormsApp5\WindowsFormsApp5\usp.accdb");
            //      connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ivelina\Desktop\usp.accdb");
            command = connection.CreateCommand();
        }
        public music()
        {
            ConnectTo();
        }

        public void Insert(Conn c)
        {
            try
            {

                command.CommandText = "INSERT INTO Pesni (Zaglavie, Izpulnitel, Godina,Tip,Vreme) VALUES ('" + c.Zaglavie + "' , '" + c.Izpulnitel + "' , '" + c.Godina + "' , '" + c.Tip + "' , '" + c.Vreme +  "')";
                command.CommandType = CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Невалидни данни!");
                

            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();

                }
            }
        }

        public void Insert2(Conn c)
        {
            try
            {

                command.CommandText = "INSERT INTO Registraciq ([Ime], Potrebitelsko, Parola,Email) VALUES ('" + c.Ime + "' , '" + c.Potrebitelsko + "' , '" + c.Parola + "' , '" + c.Email + "')";
                command.CommandType = CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Невалидни данни!");


            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();

                }
            }
        }

        public void Delete(Conn c)
        {

            try
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = ("DELETE FROM Registraciq  where Email= '" + c.Email + "' ");
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
                MessageBox.Show("Изтрит!");
                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Некоректен email!" + ex);
            }

        }

        public void Update(Conn c)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "update Registraciq set Parola= '" + c.Parola + "'  WHERE Email= '" + c.Email + "' ";
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                MessageBox.Show("Паролата е сменена!");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Некоректни данни! Моля въведете отново!" + ex);

            }

        }
        public void InsertS(Conn c)
        {
            try
            {

                command.CommandText = "INSERT INTO Suobshteniq (EmailS, Suobshtenie) VALUES ('" + c.EmailS + "' , '" + c.Suobshtenie +  "')";
                command.CommandType = CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Невалидни данни!");


            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();

                }
            }
        }
    }
}

    

