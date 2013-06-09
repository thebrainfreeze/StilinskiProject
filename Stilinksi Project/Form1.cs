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
   
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string connectionString;
            DataTable users = new DataTable();
            connectionString = "provider=microsoft.jet.oledb.4.0;data source=" + Directory.GetCurrentDirectory() + "\\Stilinski.mdb;";
            using (OleDbConnection connection =
                       new OleDbConnection(connectionString))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter("Select * From Users WHERE UName = '" + txt_Uname.Text + "' AND PWord = '" + txt_Pword.Text + "'", connection);

                try
                {
                    connection.Open();
                    adapter.Fill(users);
                    if (users.Rows.Count > 0)
                    {
                        // login 
                        //MessageBox.Show("archie");
                        frm_Dashboard f_dash = new frm_Dashboard(txt_Uname.Text);
                        f_dash.Show();
                        this.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                // The connection is automatically closed when the  
                // code exits the using block. 
            } 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_enroll ff = new form_enroll();
            ff.Show();
            this.Visible = false;
        }
    }
}
