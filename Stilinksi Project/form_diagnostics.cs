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
    public partial class form_diagnostics : Form
    {
        public form_diagnostics(string Username)
        {
            InitializeComponent();
            test_Time = 30;
            uname = Username;
        }
        public string uname;
        public int cpy = 300, test_Time, probAdd = 0, probSub = 50, probDiv = 50, probMul = 0, temp_TimerA = 0, lvl = 0, temp_TimerS = 0, temp_TimerD = 0, temp_TimerM = 0, operSign, temp_Timer;
        public int wrong3a = 0, wrong5a = 0, wrong7a = 0, wrong3s = 0, wrong5s = 0, wrong7s = 0, wrong3m = 0, wrong5m = 0, wrong7m = 0, wrong3d = 0, wrong5d = 0, wrong7d = 0, wrong7 = 0;
        public int right7a = 0, right7s = 0, right7m = 0, right7d = 0, ans = 0, lowerCap = 0, highCap = 9;
        public int items_add = 0, items_sub = 0, items_mul = 0, items_div = 0, qLvl = 0, right_add = 0, right_sub = 0, right_mul = 0, right_div = 0;
        public bool indi_TimerA = false, indi_TimerS = false, indi_TimerM = false, indi_TimerD = false, indi_Timer = false;
        public double right_Items = 0, items = 1;
        public int addSpi = 0, subSpi = 0, mulSpi = 0, divSpi = 0, items_Timer = 0;
        public int right10 = 0;
        public bool indi_addSpi = false, indi_subSpi = false, indi_mulSpi = false, indi_divSpi = false, indi_itemsTimer = false;
        public bool userAnswered = false, nonNumberEntered = false;

        private void frm_Diagnostic_Load(object sender, EventArgs e)
        {
            int lnum, rnum;
            Random rand = new Random();
            lnum = rand.Next(0, 9);
            rnum = rand.Next(0, 9);
            getOper(lnum, rnum, 0, 9);
            ans_Digits();
            tmr_Clock.Interval = 1000;
            tmr_Clock.Enabled = true;
        }

        public void getOper(int num1, int num2, int min, int max)
        {
            Random random = new Random();
            int temp;
            temp = random.Next(0, 99);
            if (lvl == 0)
            {
                if (temp >= probSub)
                {
                    lbl_Oper.Text = "-";
                    items_sub++;
                    indi_TimerS = true;
                    indi_subSpi = true;
                    if (num1 < num2)
                    {
                        do
                        {
                            num1 = random.Next(min, max);
                            num2 = random.Next(min, max);
                            ans = num1 - num2;
                        } while (num1 < num2);
                    }
                    else
                    { ans = num1 - num2; }
                    operSign = 0;
                    lbl_LeftNum.Text = Convert.ToString(num1);
                    lbl_RightNum.Text = Convert.ToString(num2);
                }
                else
                {
                    lbl_Oper.Text = "+";
                    items_add++;
                    indi_TimerA = true;
                    indi_addSpi = true;
                    ans = num2 + num1;
                    operSign = 1;
                    lbl_LeftNum.Text = Convert.ToString(num1);
                    lbl_RightNum.Text = Convert.ToString(num2);
                }
            }
            else
            {
                if (lvl == 1)
                {
                    if (temp >= probDiv)
                    {
                        lbl_Oper.Text = "/";
                        items_div++;
                        indi_TimerD = true;
                        indi_divSpi = true;
                        operSign = 2;
                    }
                    else
                    {
                        lbl_Oper.Text = "*";
                        items_mul++;
                        indi_TimerM = true;
                        indi_mulSpi = true;
                        ans = num2 * num1;
                        operSign = 3;
                        lbl_LeftNum.Text = Convert.ToString(num1);
                        lbl_RightNum.Text = Convert.ToString(num2);
                    }
                }
                else
                {
                    if (lvl == 2)
                    {
                        // for finals
                    }
                }
            }

        }
        public void incLvl()
        {
            qLvl++;
            switch (qLvl)
            {
                case 1: lowerCap = 0;
                    highCap = 99;
                    break;
                case 2: lowerCap = 10;
                    highCap = 999;
                    break;
                case 3: lowerCap = 0;
                    highCap = 999;
                    break;
                case 4:
                case 5: lowerCap = 0;
                    lvl++;
                    highCap = 9;
                    break;
                case 6: lowerCap = 10;
                    highCap = 99;
                    break;
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12: lowerCap = 0;
                    highCap = 99;
                    break;
            }

        }
        public void oper_Rand(int num1)
        {
            switch (num1)
            {
                case 0: lbl_Oper.Text = "+";
                    break;
                case 1: lbl_Oper.Text = "-";
                    break;
            }
        }
        public void ans_Digits()
        {
            if ((ans < 10))
            {
                lbl_Fnum.Show();
                lbl_Snum.Hide();
                lbl_Tnum.Hide();
                lbl_FoNum.Hide();
            }
            else
            {
                if ((ans >= 10) && (ans < 100))
                {
                    lbl_Fnum.Show();
                    lbl_Snum.Show();
                    lbl_Tnum.Hide();
                    lbl_FoNum.Hide();
                }
                else
                {
                    if ((ans >= 100) && (ans < 1000))
                    {
                        lbl_Fnum.Show();
                        lbl_Snum.Show();
                        lbl_Tnum.Show();
                        lbl_FoNum.Hide();
                    }
                    else
                    {
                        if ((ans >= 1000))
                        {
                            lbl_Fnum.Show();
                            lbl_Snum.Show();
                            lbl_Tnum.Show();
                            lbl_FoNum.Show();
                        }
                    }
                }
            }
        }
        private void enter_Ans(int key, int bspace)
        {
            if ((ans < 10))
            {
                if (lbl_Fnum.Text.Length == 0)
                {
                    if (bspace != 8)
                    {
                        lbl_Fnum.Text = Convert.ToString(key);
                        userAnswered = true;
                    }
                }
                else
                {
                    if (bspace != 8)
                    {
                        lbl_Fnum.Text = Convert.ToString(key);
                        userAnswered = true;
                    }
                    else
                    {
                        lbl_Fnum.Text = "";
                        userAnswered = false;
                    }
                }
            }
            else
            {
                if ((ans >= 10) && (ans < 100))
                {
                    if (lbl_Fnum.Text.Length == 0)
                    {
                        if (bspace != 8)
                        {
                            lbl_Fnum.Text = Convert.ToString(key);
                            userAnswered = true;
                        }
                    }
                    else
                    {
                        if (bspace != 8)
                        {
                            lbl_Snum.Text = Convert.ToString(key);
                            userAnswered = true;
                        }
                        else
                        {
                            if (lbl_Snum.Text.Length == 0)
                            {
                                lbl_Fnum.Text = "";
                                userAnswered = false;
                            }
                            else
                            {
                                lbl_Snum.Text = "";
                            }
                        }
                    }
                }
                else
                {
                    if ((ans >= 100) && (ans < 1000))
                    {
                        if (lbl_Fnum.Text.Length == 0)
                        {
                            if (bspace != 8)
                            {
                                lbl_Fnum.Text = Convert.ToString(key);
                                userAnswered = true;
                            }
                        }
                        else
                        {
                            if (lbl_Snum.Text.Length == 0)
                            {
                                if (bspace != 8)
                                {
                                    lbl_Snum.Text = Convert.ToString(key);
                                    userAnswered = true;
                                }
                                else
                                {
                                    lbl_Fnum.Text = "";
                                    userAnswered = false;
                                }
                            }
                            else
                            {
                                if (lbl_Tnum.Text.Length == 0)
                                {
                                    if (bspace != 8)
                                    {
                                        lbl_Tnum.Text = Convert.ToString(key);
                                        userAnswered = true;
                                    }
                                    else
                                    {
                                        lbl_Snum.Text = "";
                                    }
                                }
                                else
                                {
                                    if (bspace != 8)
                                    {
                                        lbl_Tnum.Text = Convert.ToString(key);
                                        userAnswered = true;
                                    }
                                    else
                                    {
                                        lbl_Tnum.Text = "";
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if ((ans >= 1000))
                        {
                            if (lbl_Fnum.Text.Length == 0)
                            {
                                if (bspace != 8)
                                {
                                    lbl_Fnum.Text = Convert.ToString(key);
                                    userAnswered = true;
                                }
                            }
                            else
                            {
                                if (lbl_Snum.Text.Length == 0)
                                {
                                    if (bspace != 8)
                                    {
                                        lbl_Snum.Text = Convert.ToString(key);
                                        userAnswered = true;
                                    }
                                    else
                                    {
                                        lbl_Fnum.Text = "";
                                        userAnswered = false;
                                    }
                                }
                                else
                                {
                                    if (lbl_Tnum.Text.Length == 0)
                                    {
                                        if (bspace != 8)
                                        {
                                            lbl_Tnum.Text = Convert.ToString(key);
                                            userAnswered = true;
                                        }
                                        else
                                        {
                                            lbl_Snum.Text = "";
                                        }
                                    }
                                    else
                                    {
                                        if (lbl_FoNum.Text.Length == 0)
                                        {
                                            if (bspace != 8)
                                            {
                                                lbl_FoNum.Text = Convert.ToString(key);
                                                userAnswered = true;
                                            }
                                            else
                                            {
                                                lbl_Tnum.Text = "";
                                            }
                                        }
                                        else
                                        {
                                            if (bspace != 8)
                                            {
                                                lbl_FoNum.Text = Convert.ToString(key);
                                                userAnswered = true;
                                            }
                                            else
                                            {
                                                lbl_FoNum.Text = "";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void tmr_Clock_Tick(object sender, EventArgs e)
        {
            test_Time--;
            int min, sec;
            if ((test_Time % 60) != 0)
            {
                min = test_Time / 60;
                sec = (test_Time - (min * 60));
                lbl_Min.Text = Convert.ToString(min);
                lbl_Sec.Text = Convert.ToString(sec);
            }
            else
            {
                min = test_Time / 60;
                lbl_Min.Text = Convert.ToString(min);
                sec = 00;
                lbl_Sec.Text = Convert.ToString(sec);
            }
            if ((min < 5))
            {
                lbl_Min.Text = "0" + lbl_Min.Text;
            }
            if (sec < 10)
            {
                lbl_Sec.Text = "0" + lbl_Sec.Text;
            }
            int tokM = 0, tokA = 0, tokS = 0, tokD = 0;
            double tok = ((right_Items / items) * 100);
            if (items_mul != 0) { tokM = (right_mul / items_mul); }
            if (items_div != 0) { tokD = (right_div / items_div); }
            if (items_add != 0) { tokA = (right_add / items_add); }
            if (items_sub != 0) { tokM = (right_sub / items_sub); }
            if (test_Time == 0 && (tok > 65))
            {
                using (OleDbConnection connection = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=" + Directory.GetCurrentDirectory() + "\\Stilinski.mdb;"))
                {
                    // The insertSQL string contains a SQL statement that  
                    // inserts a new row in the source table. 
                    OleDbCommand command = new OleDbCommand("INSERT INTO Diagnostic Values('" + DateTime.Now.Date + "','" + cpy + "','" + qLvl + "','" + addSpi + "','" + subSpi + "','" + divSpi + "','" + mulSpi + "','" + tok + "','" + tokA + "','" + tokS + "','" + tokD + "','" + tokM + "','" + uname + "')");
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

                    }
                    // The connection is automatically closed when the  
                    // code exits the using block. 
                }
                frm_Dashboard dash = new frm_Dashboard(uname);
                using (OleDbConnection connection = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=" + Directory.GetCurrentDirectory() + "\\Stilinski.mdb;"))
                {
                    // The insertSQL string contains a SQL statement that  
                    // inserts a new row in the source table. 
                    OleDbCommand command = new OleDbCommand("UPDATE Users SET Status = 'Pascal' WHERE UName='" + uname + "'");
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

                    }
                    // The connection is automatically closed when the  
                    // code exits the using block. 
                }
                dash.Visible = true;
                this.Visible = false;
            }
            else
            {
                //failed
            }
            if (indi_Timer == true)
            { temp_Timer++; }
            if (indi_TimerA == true)
            { temp_TimerA++; }
            if (indi_TimerD == true)
            { temp_TimerD++; }
            if (indi_TimerM == true)
            { temp_TimerM++; }
            if (indi_TimerS == true)
            { temp_TimerS++; }
            if (indi_addSpi == true)
            { addSpi++; }
            if (indi_subSpi == true)
            { subSpi++; }
            if (indi_divSpi == true)
            { divSpi++; }
            if (indi_mulSpi == true)
            { mulSpi++; }
            if (indi_itemsTimer == true)
            { items_Timer++; }

        }
        private void frm_Diagnostic_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event. 
            if (nonNumberEntered == false)
            {
                switch (Convert.ToInt16(e.KeyChar))
                {
                    case 48: enter_Ans(0, 0);
                        break;
                    case 49: enter_Ans(1, 0);
                        break;
                    case 50: enter_Ans(2, 0);
                        break;
                    case 51: enter_Ans(3, 0);
                        break;
                    case 52: enter_Ans(4, 0);
                        break;
                    case 53: enter_Ans(5, 0);
                        break;
                    case 54: enter_Ans(6, 0);
                        break;
                    case 55: enter_Ans(7, 0);
                        break;
                    case 56: enter_Ans(8, 0);
                        break;
                    case 57: enter_Ans(9, 0);
                        break;
                    case 8: enter_Ans(0, 8);
                        break;
                }
            }

        }

        private void frm_Diagnostic_KeyDown(object sender, KeyEventArgs e)
        {

            nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad. 
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace. 
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed. 
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                }
            }
            //If shift key was pressed, it's not a number. 
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }

        }

        public double userAns()
        {
            if (lbl_FoNum.Visible == true && lbl_FoNum.Text.Length > 0)
            {
                return ((Convert.ToDouble(lbl_Fnum.Text) * 1000) + (Convert.ToDouble(lbl_Snum.Text) * 100) + (Convert.ToDouble(lbl_Tnum.Text) * 10) + (Convert.ToDouble(lbl_FoNum.Text)));
            }
            else
            {
                if (lbl_Tnum.Visible == true && lbl_Tnum.Text.Length > 0)
                {
                    return ((Convert.ToDouble(lbl_Fnum.Text) * 100) + (Convert.ToDouble(lbl_Snum.Text) * 10) + (Convert.ToDouble(lbl_Tnum.Text)));
                }
                else
                {
                    if (lbl_Snum.Visible == true && lbl_Snum.Text.Length > 0)
                    {
                        return ((Convert.ToDouble(lbl_Fnum.Text) * 10) + (Convert.ToDouble(lbl_Snum.Text)));
                    }
                    else
                    {
                        return Convert.ToDouble(lbl_Fnum.Text);
                    }
                }
            }
        }
        public void verOper()
        {
            right10 = 0;
            indi_itemsTimer = false;
            if (temp_Timer < 30)
            {
                wrong7++;
            }
            if (wrong7 == 7)
            {
                // failed
            }
            switch (operSign)
            {
                case 0: wrong5s++; wrong7s++;
                    if (temp_TimerS <= 30)
                    {
                        wrong3s++;
                    }
                    if (wrong5s == 5)
                    {
                        probSub -= 5;
                    }
                    else
                    {
                        if (wrong5s > 5)
                        {
                            probSub -= 5;
                        }
                    }
                    if (wrong7s == 7)
                    {
                        probSub -= 5;
                    }
                    else
                    {
                        if (wrong7s > 7)
                        {
                            probSub -= 5;
                        }
                    }
                    if (wrong3s == 3)
                    {
                        probSub -= 5;
                    }
                    else
                    {
                        if (wrong3s > 3)
                        {
                            probSub -= 5;
                            temp_TimerS = 0;
                        }
                    }
                    indi_subSpi = false;
                    break;
                case 1:
                    wrong5a++; wrong7a++;
                    if (temp_TimerA <= 30)
                    {
                        wrong3a++;
                    }
                    if (wrong5a == 5)
                    {
                        probAdd -= 5;
                    }
                    else
                    {
                        if (wrong5a > 5)
                        {
                            probAdd -= 5;
                        }
                    }
                    if (wrong7a == 7)
                    {
                        probAdd -= 5;
                    }
                    else
                    {
                        if (wrong7a > 7)
                        {
                            probAdd -= 5;
                        }
                    }
                    if (wrong3a == 3)
                    {
                        probAdd -= 5;
                    }
                    else
                    {
                        if (wrong3a > 3)
                        {
                            probAdd -= 5;
                            temp_TimerA = 0;
                        }
                    }
                    indi_addSpi = false;
                    break;
                case 2:
                    wrong5d++; wrong7d++;
                    if (temp_TimerD <= 30)
                    {
                        wrong3d++;
                    }
                    if (wrong5d == 5)
                    {
                        probDiv -= 5;
                    }
                    else
                    {
                        if (wrong5d > 5)
                        {
                            probDiv -= 5;
                        }
                    }
                    if (wrong7d == 7)
                    {
                        probSub -= 5;
                    }
                    else
                    {
                        if (wrong7d > 7)
                        {
                            probDiv -= 5;
                        }
                    }
                    if (wrong3d == 3)
                    {
                        probDiv -= 5;
                    }
                    else
                    {
                        if (wrong3d > 3)
                        {
                            probDiv -= 5;
                            temp_TimerD = 0;
                        }
                    }
                    indi_divSpi = false;
                    break;
                case 3:
                    wrong5m++; wrong7m++;
                    if (temp_TimerM <= 30)
                    {
                        wrong3m++;
                    }
                    if (wrong5m == 5)
                    {
                        probMul -= 5;
                    }
                    else
                    {
                        if (wrong5m > 5)
                        {
                            probMul -= 5;
                        }
                    }
                    if (wrong7m == 7)
                    {
                        probMul -= 5;
                    }
                    else
                    {
                        if (wrong7m > 7)
                        {
                            probMul -= 5;
                        }
                    }
                    if (wrong3m == 3)
                    {
                        probMul -= 5;
                    }
                    else
                    {
                        if (wrong3m > 3)
                        {
                            probMul -= 5;
                            temp_TimerM = 0;
                        }
                    }
                    indi_mulSpi = false;
                    break;
            }
        }
        public void resetTime()
        {
            temp_Timer = 0;
            indi_itemsTimer = true;
            wrong7 = 0;
            right10++;
            if (right10 == 10 && items_Timer <= 60)
            {
                incLvl();
                right10 = 0;
                items_Timer = 0;
                indi_itemsTimer = false;
            }
            else
            {
                if (items_Timer > 60)
                {
                    items_Timer = 0;
                }
            }
            switch (operSign)
            {
                case 0: wrong5s = 0; wrong7s = 0; temp_TimerS = 0; indi_TimerS = false;
                    right7s++; right_sub++;
                    if (right7s == 5 && probSub < 50)
                    {
                        probSub -= 5;
                    }
                    else
                    {
                        if (right7s > 7 && probSub < 50)
                        {
                            probSub -= 5;
                        }
                    }
                    indi_subSpi = false;
                    break;
                case 1:
                    wrong5a = 0; wrong7a = 0; temp_TimerA = 0; indi_TimerA = false;
                    right7a++; right_add++;
                    if (right7a == 5 && probSub < 50)
                    {
                        probSub += 5;
                    }
                    else
                    {
                        if (right7a > 7 && probSub < 50)
                        {
                            probSub += 5;
                        }
                    }
                    indi_addSpi = false;
                    break;
                case 2:
                    wrong5d = 0; wrong7d = 0; temp_TimerD = 0; indi_TimerD = false;
                    right7d++; right_div++;
                    if (right7d == 5)
                    {
                        probDiv -= 5;
                    }
                    else
                    {
                        if (right7d > 7)
                        {
                            probDiv -= 5;
                        }
                    }
                    indi_divSpi = false;
                    break;
                case 3:
                    wrong5m = 0; wrong7m = 0; temp_TimerM = 0; indi_TimerM = false;
                    right7m++; right_mul++;
                    if (right7m == 5)
                    {
                        probDiv += 5;
                    }
                    else
                    {
                        if (right7m > 7)
                        {
                            probDiv += 5;
                        }
                    }
                    indi_mulSpi = false;
                    break;
            }
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            int lnum, rnum;
            tmr_Clock.Stop();
            Random rand = new Random();
            if (userAnswered == true && test_Time > 0)
            {
                if (userAns() != ans)
                {
                    verOper();
                }
                else
                {
                    resetTime();
                    right_Items++;
                }
                lnum = rand.Next(lowerCap, highCap);
                rnum = rand.Next(lowerCap, highCap);
                getOper(lnum, rnum, lowerCap, highCap);
                ans_Digits();
                lbl_Fnum.Text = "";
                lbl_Snum.Text = "";
                lbl_Tnum.Text = "";
                lbl_FoNum.Text = "";
                userAnswered = false;
                items++;
            }
            tmr_Clock.Enabled = true;

        }

    }
}
