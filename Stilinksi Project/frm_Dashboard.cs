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
    
  
    public partial class frm_Dashboard : Form
    {
        public frm_Dashboard(string Username)
        {
            InitializeComponent();
            uname = Username;
        }
        public string uname;
        public void frm_Dashboard_Load(object sender, EventArgs e)
        {
           // pictureBox4.Visible = false;
            //pictureBox5.Visible = false;
            //button1.Visible = false;
            //button2.Visible = false;
            //label3.Visible = false;
            //label4.Visible = false;
            //label5.Visible = false;
            //label6.Visible = false;
            string connectionString;
            DataTable users = new DataTable();
            connectionString = "provider=microsoft.jet.oledb.4.0;data source=" + Directory.GetCurrentDirectory() + "\\Stilinski.mdb;";
            using (OleDbConnection connection =
                       new OleDbConnection(connectionString))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter("Select * From Users WHERE UName = '" + uname + "'", connection);

                try
                {
                    connection.Open();
                    adapter.Fill(users);
                    foreach (DataRow row in users.Rows)
                    {
                        lbl_FName.Text = row["FirstName"].ToString();
                        lbl_Stat.Text = row["Status"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                // The connection is automatically closed when the  
                // code exits the using block.
                chkStatus();
            }

            
        }
        public void chkStatus() 
        {
            if (lbl_Stat.Text == "Newbie")
            {
                box_Menu1.Image = global::Stilinksi_Project.Properties.Resources.screenv2_newuser_02;
                box_Menu2.Image = global::Stilinksi_Project.Properties.Resources.screenv2_newuser_04;
                box_Menu3.Image = global::Stilinksi_Project.Properties.Resources.screenv2_newuser_06;
                this.box_Menu1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
                this.box_Menu1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
                this.box_Menu2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
                this.box_Menu2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
                this.box_Menu3.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
                this.box_Menu3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
                box_Menu4.Visible = false;
                box_Menu5.Visible = false;
                box_Menu6.Visible = false;
            }
            else
            {
 
            }
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            box_Menu1.Image = global::Stilinksi_Project.Properties.Resources.achievements_hover_02;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            box_Menu1.Image = global::Stilinksi_Project.Properties.Resources.screenv2_newuser_02;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            box_Menu2.Image = global::Stilinksi_Project.Properties.Resources.buttons_hover_07;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            box_Menu2.Image = global::Stilinksi_Project.Properties.Resources.screenv2_newuser_04;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            box_Menu3.Image = global::Stilinksi_Project.Properties.Resources.buttons_hover_04;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            box_Menu3.Image = global::Stilinksi_Project.Properties.Resources.screenv2_newuser_06;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            form_diagnostics mbox = new form_diagnostics(uname);
            mbox.Show();
            this.Hide();
        }

        private void rectangleShape4_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //form_ArrangeFlashCards f_AfCard = new form_ArrangeFlashCards();
            //f_AfCard.Show();
            //this.Visible = false;
        }

        private void box_Menu4_Click(object sender, EventArgs e)
        {
            Form2 tutor = new Form2();
            tutor.Show();
            this.Hide();
        }

       /* private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            button1.Visible = true;
            button2.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            int x = 0, y = 0, a = 0, b = 0, c = 0;

            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;

            pictureBox3.Size = new System.Drawing.Size(232, 252);
            pictureBox4.Size = new System.Drawing.Size(232, 252);

            Random d = new Random();

            x = d.Next(0, 20);
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            



            pictureBox1.Image = imageList1.Images[x];

            a = x / 10;
            c = x % 10;
            a = a * 10;
            b = a + 9;
            y = d.Next(a, b);
            pictureBox2.Image = imageList1.Images[y];





            if (x > y)
            {
                label3.Visible = true;
                label3.Text = ">";
                label5.Text = ">";

            }
            else if (x < y)
            {
                label3.Visible = true;
                label3.Text = "<";
                label5.Text = ">";
            }
            else if (y == x)
            {
                label3.Visible = true;
                label3.Text = "=";
                label5.Text = ">";
            }
            if (x < 10)
            {
                x = a + c + 1;
            }
            else
            {
                x = (a + c + 1) - a * (x / 10);
            }

            //x++;
            a = y / 10;
            c = y % 10;
            a = a * 10;
            y = (a + c + 1);

            if (y < 10)
            {
                y = a + c + 1;
            }
            else
            {
                y = (a + c + 1) - a * (y / 10);
            }

            label4.Text = x.ToString();
            label6.Text = y.ToString();
            button1.Visible = false;
            button2.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
           // label2.Text = x.ToString();
           // label3.Text = y.ToString();
            
            button1.Visible = true;
            button2.Visible = false;
            label4.Visible = true;
            label3.Visible = true;
            label5.Visible = true;
            label6.Visible = true;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }*/


    }
}
