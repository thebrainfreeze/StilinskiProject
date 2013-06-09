using System;
using System.IO;
using System.Data.OleDb;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stilinksi_Project
{
    public partial class form_enroll : Form
    {
        public form_enroll()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Uname_Leave(object sender, EventArgs e)
        {
            string connectionString;
            DataTable users = new DataTable();
            connectionString = "provider=microsoft.jet.oledb.4.0;data source=" + Directory.GetCurrentDirectory() + "\\Stilinski.mdb;";
            if (txt_Uname.Text.Length != 0)
            {
                using (OleDbConnection connection =
                           new OleDbConnection(connectionString))
                {
                    OleDbDataAdapter adapter = new OleDbDataAdapter("Select * From Users WHERE Username = '" + txt_Uname.Text + "'", connection);

                    try
                    {
                        connection.Open();
                        adapter.Fill(users);
                        if (users.Rows.Count == 0)
                        {
                            uname_Warning.Visible = false;
                        }
                        else
                        {
                            uname_Warning.Visible = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        //uname_Warning.Visible = true; 
                    }
                    // The connection is automatically closed when the  
                    // code exits the using block. 
                }
            }
        }

        private void txt_Pword1_Leave(object sender, EventArgs e)
        {
            if ((txt_Pword2.Text.Length != 0) && (txt_Pword1.Text.Length != 0))
            {
                if (txt_Pword2.Text != txt_Pword1.Text)
                {
                    pword_Warning.Visible = true;
                }
                else
                {
                    pword_Warning.Visible = false;
                }
            }
        }

        private void txt_Pword2_Leave(object sender, EventArgs e)
        {
            if ((txt_Pword2.Text.Length != 0) && (txt_Pword1.Text.Length != 0))
            {
                if (txt_Pword2.Text != txt_Pword1.Text)
                {
                    pword_Warning.Visible = true;
                }
                else
                {
                    pword_Warning.Visible = false;
                }
            }
        }

        private void box_Gender_Leave(object sender, EventArgs e)
        {
            if ((box_Gender.Text.ToLower() != "male") && (box_Gender.Text.ToLower() != "female"))
            {
                box_Gender.Text = "Male";
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if ((txt_Fname.Text.Length != 0) && (txt_Sname.Text.Length != 0) && (pword_Warning.Visible == false) &&
                (uname_Warning.Visible == false) && (box_Gender.Text.Length != 0) && (box_Gender.Text.Length != 0))
            {
                using (OleDbConnection connection = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=" + Directory.GetCurrentDirectory() + "\\Stilinski.mdb;"))
                {
                    // The insertSQL string contains a SQL statement that 
                    // inserts a new row in the source table.
                    string quizID = "**************";
                    OleDbCommand command = new OleDbCommand("Insert into Users (FirstName, LastName, UName, PWord, Gender, Bday, Country, QuizID) Values ('" + txt_Fname.Text + "','" + txt_Sname.Text + "','" + txt_Uname.Text + "','" + txt_Pword1.Text + "','" + box_Gender.Text + "','" + date_bday.Value + "','" + box_Country.Text + "','" + quizID + "')");
                    // Set the Connection to the new OleDbConnection.
                    command.Connection = connection;

                    // Open the connection and execute the insert command. 
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    // The connection is automatically closed when the 
                    // code exits the using block.
                }

                frm_Dashboard dash = new frm_Dashboard(txt_Uname.Text);
                dash.Show();
                this.Hide();
            }
        }

        private void Frm_Enroll_Load(object sender, EventArgs e)
        {

        }

        private void form_enroll_Load(object sender, EventArgs e)
        {

        }

    }
}
