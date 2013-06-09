using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading.Tasks;


namespace Stilinksi_Project
{
    public partial class form_Pyramid : Form
    {
        int num, ans, choice, counter = 0, userChoice, cardNum;
        int num1, opNum;
        int[] flag = new int[15];
        Random rnum = new Random();
        string toLabel, usrChoice, ans2;

        public form_Pyramid()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;
            pictureBox10.Enabled = false;
            pictureBox11.Enabled = false;
            pictureBox12.Enabled = false;
            pictureBox13.Enabled = false;
            pictureBox14.Enabled = false;
            pictureBox15.Enabled = false;
        }

        public void EraseBoard()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
        }

        public void DisplayLayer1()
        {
            lbl11.Visible = true;
            lbl12.Visible = true;
            lbl1op.Visible = true;
            lbl1eq.Visible = true;
            lbl1ans.Visible = true;

            lblChoice1.Visible = true;
            lblChoice2.Visible = true;
            lblChoice3.Visible = true;
            lblChoice4.Visible = true;

        }

        public void DisplayLayer2()
        {
            lbl21.Visible = true;
            lbl22.Visible = true;
            lbl23.Visible = true;
            lbl24.Visible = true;
            lbl2op1.Visible = true;
            lbl2op2.Visible = true;
            lbl2eq.Visible = true;

            lbl2ch1.Visible = true;
            lbl2ch2.Visible = true;
            lbl2ch3.Visible = true;
        }

        public void RemoveLayer1()
        {
            lbl11.Visible = false;
            lbl12.Visible = false;
            lbl1op.Visible = false;
            lbl1eq.Visible = false;
            lbl1ans.Visible = false;
            lblMsg.Visible = false;
            lblChoice1.Visible = false;
            lblChoice2.Visible = false;
            lblChoice3.Visible = false;
            lblChoice4.Visible = false;
        }

        public void RemoveLayer2()
        {
            lbl21.Visible = false;
            lbl22.Visible = false;
            lbl23.Visible = false;
            lbl24.Visible = false;
            lbl2op1.Visible = false;
            lbl2op2.Visible = false;
            lbl2eq.Visible = false;

            lbl2ch1.Visible = false;
            lbl2ch2.Visible = false;
            lbl2ch3.Visible = false;
            lblMsg.Visible = false;
        }

        public void RewriteBoard()
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            for (int i = 0; i < 15; i++)
            {
                if (flag[i] == 1)
                {
                    switch (i)
                    {
                        case 0: pictureBox1.Visible = false; if (pictureBox2.Visible == false) pictureBox6.Enabled = true; break;
                        case 1: pictureBox2.Visible = false; if (pictureBox1.Visible == false) pictureBox6.Enabled = true;
                            if (pictureBox3.Visible == false) pictureBox7.Enabled = true; break;
                        case 2: pictureBox3.Visible = false; if (pictureBox2.Visible == false) pictureBox7.Enabled = true;
                            if (pictureBox4.Visible == false) pictureBox8.Enabled = true; break;
                        case 3: pictureBox4.Visible = false; if (pictureBox3.Visible == false) pictureBox8.Enabled = true;
                            if (pictureBox5.Visible == false) pictureBox9.Enabled = true; break;
                        case 4: pictureBox5.Visible = false; if (pictureBox4.Visible == false) pictureBox9.Enabled = true; break;
                        case 5: pictureBox6.Visible = false; if (pictureBox7.Visible == false) pictureBox10.Enabled = true; break;
                        case 6: pictureBox7.Visible = false; if (pictureBox6.Visible == false) pictureBox10.Enabled = true;
                            if (pictureBox8.Visible == false) pictureBox11.Enabled = true; break;
                        case 7: pictureBox8.Visible = false; if (pictureBox7.Visible == false) pictureBox11.Enabled = true;
                            if (pictureBox9.Visible == false) pictureBox12.Enabled = true; break;
                        case 8: pictureBox9.Visible = false; if (pictureBox8.Visible == false) pictureBox12.Enabled = true; break;
                        case 9: pictureBox10.Visible = false; if (pictureBox11.Visible == false) pictureBox13.Enabled = true; break;
                        case 10: pictureBox11.Visible = false; if (pictureBox10.Visible == false) pictureBox13.Enabled = true;
                            if (pictureBox12.Visible == false) pictureBox14.Enabled = true; break;
                        case 11: pictureBox12.Visible = false; if (pictureBox11.Visible == false) pictureBox14.Enabled = true; break;
                        case 12: pictureBox13.Visible = false; if (pictureBox14.Visible == false) pictureBox15.Enabled = true; break;
                        case 13: pictureBox14.Visible = false; if (pictureBox13.Visible == false) pictureBox15.Enabled = true; break;
                    }
                }
            }
        }

        public void CheckChoice()
        {
            if (choice == userChoice)
            {
                lblMsg.Visible = true;
                lblMsg.Text = "Great!";
                counter++;
                if (counter < 5)
                {
                    if (cardNum >= 1 && cardNum < 6)
                    {
                        switch (lbl1op.Text)
                        {
                            case "+": TTAdd1(cardNum); break;
                            case "-": TTSub1(cardNum); break;
                            case "*": TTMul1(cardNum); break;
                            case "/": TTDiv1(cardNum); break;
                        }
                    }
                    if (cardNum >= 6 && cardNum < 10)
                    {
                        switch (opNum)
                        {
                            case 5: TTAddSub2(cardNum); break;
                            case 6: TTAddMul2(cardNum); break;
                            case 7: TTAddDiv2(cardNum); break;
                            case 8: TTSubMul2(cardNum); break;
                        }
                    }
                    if (cardNum >= 10 && cardNum < 13)
                    {
                        switch (opNum)
                        {
                            case 9: TTAddAlg3(cardNum); break;
                            case 10: TTSubAlg3(cardNum); break;
                            case 11: TTAddSubCombi(cardNum); break;
                            case 12: TTMulDiv3(cardNum); break;
                        }
                    }
                }
                else
                {
                    switch (cardNum)
                    {
                        case 1: flag[0] = 1; RemoveLayer1(); break;
                        case 2: flag[1] = 1; RemoveLayer1(); break;
                        case 3: flag[2] = 1; RemoveLayer1(); break;
                        case 4: flag[3] = 1; RemoveLayer1(); break;
                        case 5: flag[4] = 1; RemoveLayer1(); break;
                        case 6: flag[5] = 1; RemoveLayer1(); break;
                        case 7: flag[6] = 1; RemoveLayer1(); break;
                        case 8: flag[7] = 1; RemoveLayer1(); break;
                        case 9: flag[8] = 1; RemoveLayer1(); break;
                        case 10: flag[9] = 1; RemoveLayer1(); break;
                        case 11: flag[10] = 1; RemoveLayer1(); break;
                        case 12: flag[11] = 1; RemoveLayer1(); break;

                    }
                    counter = 0;
                    RewriteBoard();
                }
            }
            else
            {
                lblMsg.Visible = false;
                if (cardNum >= 1 && cardNum < 5)
                {
                    switch (lbl1op.Text)
                    {
                        case "+": TTAdd1(cardNum); break;
                        case "-": TTSub1(cardNum); break;
                        case "*": TTMul1(cardNum); break;
                        case "/": TTDiv1(cardNum); break;
                    }
                }
                if (cardNum >= 6 && cardNum < 10)
                {
                    switch (opNum)
                    {
                        case 5: TTAddSub2(cardNum); break;
                        case 6: TTAddMul2(cardNum); break;
                        case 7: TTAddDiv2(cardNum); break;
                        case 8: TTSubMul2(cardNum); break;
                    }
                }
                if (cardNum >= 10 && cardNum < 13)
                {
                    switch (opNum)
                    {
                        case 9: TTAddAlg3(cardNum); break;
                        case 10: TTSubAlg3(cardNum); break;
                        case 11: TTAddSubCombi(cardNum); break;
                        case 12: TTMulDiv3(cardNum); break;
                    }
                }
            }
        }

        public void CheckChoice2()
        {
            if (ans2 == usrChoice)
            {
                lblMsg.Visible = true;
                lblMsg.Text = "Great!";
                counter++;
                if (counter < 5)
                {
                    if (cardNum == 13 || cardNum == 14)
                    {
                        switch (opNum)
                        {
                            case 13: TTGreatLessAddMul(cardNum); break;
                            case 14: TTGreatLessSubDiv(cardNum); break;
                            case 15: TTGreatLessAll(cardNum); break;

                        }
                    }
                }
                else
                {
                    switch (cardNum)
                    {
                        case 13: flag[12] = 1; RemoveLayer2(); break;
                        case 14: flag[13] = 1; RemoveLayer2(); break;

                    }
                    counter = 0;
                    RewriteBoard();
                }
            }
            else
            {
                lblMsg.Visible = false;
                switch (opNum)
                {
                    case 13: TTGreatLessAddMul(cardNum); break;
                    case 14: TTGreatLessSubDiv(cardNum); break;
                    case 15: TTGreatLessAll(cardNum); break;

                }
            }
        }

        public void TTAdd1(int cardNum)
        {
            DisplayLayer1();
            lbl1op.Text = "+";
            lbl1eq.Text = "=";
            lbl1ans.Text = "?";

            num = rnum.Next(0, 10);
            toLabel = Convert.ToString(num);
            lbl11.Text = toLabel;
            num = rnum.Next(0, 10);
            toLabel = Convert.ToString(num);
            lbl12.Text = toLabel;

            ans = Convert.ToInt32(lbl11.Text) + Convert.ToInt32(lbl12.Text);

            choice = rnum.Next(1, 5);
            switch (choice)
            {
                case 1: lblChoice1.Text = Convert.ToString(ans);
                    lblChoice2.Text = Convert.ToString(ans + 1);
                    lblChoice3.Text = Convert.ToString(ans + 2);
                    lblChoice4.Text = Convert.ToString(ans + 3); break;
                case 2: lblChoice1.Text = Convert.ToString(ans - 1);
                    lblChoice2.Text = Convert.ToString(ans);
                    lblChoice3.Text = Convert.ToString(ans + 1);
                    lblChoice4.Text = Convert.ToString(ans + 2); break;
                case 3: lblChoice1.Text = Convert.ToString(ans - 2);
                    lblChoice2.Text = Convert.ToString(ans - 1);
                    lblChoice3.Text = Convert.ToString(ans);
                    lblChoice4.Text = Convert.ToString(ans + 1); break;
                case 4: lblChoice1.Text = Convert.ToString(ans - 3);
                    lblChoice2.Text = Convert.ToString(ans - 2);
                    lblChoice3.Text = Convert.ToString(ans - 1);
                    lblChoice4.Text = Convert.ToString(ans); break;
            }
        }

        public void TTSub1(int cardNum)
        {
            DisplayLayer1();
            lbl1op.Text = "-";
            lbl1eq.Text = "=";
            lbl1ans.Text = "?";

            num1 = rnum.Next(0, 10);
            num = rnum.Next(0, 10);

            if (num1 >= num)
            {
                lbl11.Text = Convert.ToString(num1);
                lbl12.Text = Convert.ToString(num);
            }
            else
            {
                lbl11.Text = Convert.ToString(num);
                lbl12.Text = Convert.ToString(num1);
            }


            ans = Convert.ToInt32(lbl11.Text) - Convert.ToInt32(lbl12.Text);

            choice = rnum.Next(1, 5);
            switch (choice)
            {
                case 1: lblChoice1.Text = Convert.ToString(ans);
                    lblChoice2.Text = Convert.ToString(ans + 1);
                    lblChoice3.Text = Convert.ToString(ans + 2);
                    lblChoice4.Text = Convert.ToString(ans + 3); break;
                case 2: lblChoice1.Text = Convert.ToString(ans - 1);
                    lblChoice2.Text = Convert.ToString(ans);
                    lblChoice3.Text = Convert.ToString(ans + 1);
                    lblChoice4.Text = Convert.ToString(ans + 2); break;
                case 3: lblChoice1.Text = Convert.ToString(ans - 2);
                    lblChoice2.Text = Convert.ToString(ans - 1);
                    lblChoice3.Text = Convert.ToString(ans);
                    lblChoice4.Text = Convert.ToString(ans + 1); break;
                case 4: lblChoice1.Text = Convert.ToString(ans - 3);
                    lblChoice2.Text = Convert.ToString(ans - 2);
                    lblChoice3.Text = Convert.ToString(ans - 1);
                    lblChoice4.Text = Convert.ToString(ans); break;
            }
        }

        public void TTMul1(int cardNum)
        {
            DisplayLayer1();
            lbl1op.Text = "*";
            lbl1eq.Text = "=";
            lbl1ans.Text = "?";

            num = rnum.Next(0, 10);
            toLabel = Convert.ToString(num);
            lbl11.Text = toLabel;
            num = rnum.Next(0, 10);
            toLabel = Convert.ToString(num);
            lbl12.Text = toLabel;

            ans = Convert.ToInt32(lbl11.Text) * Convert.ToInt32(lbl12.Text);

            choice = rnum.Next(1, 5);
            switch (choice)
            {
                case 1: lblChoice1.Text = Convert.ToString(ans);
                    lblChoice2.Text = Convert.ToString(ans + 1);
                    lblChoice3.Text = Convert.ToString(ans + 2);
                    lblChoice4.Text = Convert.ToString(ans + 3); break;
                case 2: lblChoice1.Text = Convert.ToString(ans - 1);
                    lblChoice2.Text = Convert.ToString(ans);
                    lblChoice3.Text = Convert.ToString(ans + 1);
                    lblChoice4.Text = Convert.ToString(ans + 2); break;
                case 3: lblChoice1.Text = Convert.ToString(ans - 2);
                    lblChoice2.Text = Convert.ToString(ans - 1);
                    lblChoice3.Text = Convert.ToString(ans);
                    lblChoice4.Text = Convert.ToString(ans + 1); break;
                case 4: lblChoice1.Text = Convert.ToString(ans - 3);
                    lblChoice2.Text = Convert.ToString(ans - 2);
                    lblChoice3.Text = Convert.ToString(ans - 1);
                    lblChoice4.Text = Convert.ToString(ans); break;
            }
        }

        public void TTDiv1(int cardNum)
        {
            DisplayLayer1();
            lbl1op.Text = "/";
            lbl1eq.Text = "=";
            lbl1ans.Text = "?";

            ans = rnum.Next(0, 10);
            num = rnum.Next(1, 10);
            toLabel = Convert.ToString(num);
            lbl12.Text = toLabel;

            num = ans * Convert.ToInt32(lbl12.Text);
            lbl11.Text = Convert.ToString(num);

            choice = rnum.Next(1, 5);
            switch (choice)
            {
                case 1: lblChoice1.Text = Convert.ToString(ans);
                    lblChoice2.Text = Convert.ToString(ans + 1);
                    lblChoice3.Text = Convert.ToString(ans + 2);
                    lblChoice4.Text = Convert.ToString(ans + 3); break;
                case 2: lblChoice1.Text = Convert.ToString(ans - 1);
                    lblChoice2.Text = Convert.ToString(ans);
                    lblChoice3.Text = Convert.ToString(ans + 1);
                    lblChoice4.Text = Convert.ToString(ans + 2); break;
                case 3: lblChoice1.Text = Convert.ToString(ans - 2);
                    lblChoice2.Text = Convert.ToString(ans - 1);
                    lblChoice3.Text = Convert.ToString(ans);
                    lblChoice4.Text = Convert.ToString(ans + 1); break;
                case 4: lblChoice1.Text = Convert.ToString(ans - 3);
                    lblChoice2.Text = Convert.ToString(ans - 2);
                    lblChoice3.Text = Convert.ToString(ans - 1);
                    lblChoice4.Text = Convert.ToString(ans); break;
            }
        }

        public void TTAddSub2(int cardNum)
        {
            DisplayLayer1();
            num = rnum.Next(0, 2);
            if (num == 0)
                lbl1op.Text = "+";
            else
                lbl1op.Text = "-";
            lbl1eq.Text = "=";
            lbl1ans.Text = "?";

            num = rnum.Next(10, 100);
            num1 = rnum.Next(10, 100);

            if (num1 >= num)
            {
                lbl11.Text = Convert.ToString(num1);
                lbl12.Text = Convert.ToString(num);
            }
            else
            {
                lbl11.Text = Convert.ToString(num);
                lbl12.Text = Convert.ToString(num1);
            }

            if (lbl1op.Text == "+")
                ans = Convert.ToInt32(lbl11.Text) + Convert.ToInt32(lbl12.Text);
            if (lbl1op.Text == "-")
                ans = Convert.ToInt32(lbl11.Text) - Convert.ToInt32(lbl12.Text);

            choice = rnum.Next(1, 5);
            switch (choice)
            {
                case 1: lblChoice1.Text = Convert.ToString(ans);
                    lblChoice2.Text = Convert.ToString(ans + 1);
                    lblChoice3.Text = Convert.ToString(ans + 2);
                    lblChoice4.Text = Convert.ToString(ans + 3); break;
                case 2: lblChoice1.Text = Convert.ToString(ans - 1);
                    lblChoice2.Text = Convert.ToString(ans);
                    lblChoice3.Text = Convert.ToString(ans + 1);
                    lblChoice4.Text = Convert.ToString(ans + 2); break;
                case 3: lblChoice1.Text = Convert.ToString(ans - 2);
                    lblChoice2.Text = Convert.ToString(ans - 1);
                    lblChoice3.Text = Convert.ToString(ans);
                    lblChoice4.Text = Convert.ToString(ans + 1); break;
                case 4: lblChoice1.Text = Convert.ToString(ans - 3);
                    lblChoice2.Text = Convert.ToString(ans - 2);
                    lblChoice3.Text = Convert.ToString(ans - 1);
                    lblChoice4.Text = Convert.ToString(ans); break;
            }
        }

        public void TTAddMul2(int cardNum)
        {
            DisplayLayer1();
            num = rnum.Next(0, 2);
            if (num == 0)
                lbl1op.Text = "+";
            else
                lbl1op.Text = "*";

            lbl1eq.Text = "=";
            lbl1ans.Text = "?";

            num = rnum.Next(10, 99);
            toLabel = Convert.ToString(num);
            lbl11.Text = toLabel;
            num = rnum.Next(0, 10);
            toLabel = Convert.ToString(num);
            lbl12.Text = toLabel;

            if (lbl1op.Text == "+")
                ans = Convert.ToInt32(lbl11.Text) + Convert.ToInt32(lbl12.Text);
            else
                ans = Convert.ToInt32(lbl11.Text) * Convert.ToInt32(lbl12.Text);

            choice = rnum.Next(1, 5);
            switch (choice)
            {
                case 1: lblChoice1.Text = Convert.ToString(ans);
                    lblChoice2.Text = Convert.ToString(ans + 1);
                    lblChoice3.Text = Convert.ToString(ans + 2);
                    lblChoice4.Text = Convert.ToString(ans + 3); break;
                case 2: lblChoice1.Text = Convert.ToString(ans - 1);
                    lblChoice2.Text = Convert.ToString(ans);
                    lblChoice3.Text = Convert.ToString(ans + 1);
                    lblChoice4.Text = Convert.ToString(ans + 2); break;
                case 3: lblChoice1.Text = Convert.ToString(ans - 2);
                    lblChoice2.Text = Convert.ToString(ans - 1);
                    lblChoice3.Text = Convert.ToString(ans);
                    lblChoice4.Text = Convert.ToString(ans + 1); break;
                case 4: lblChoice1.Text = Convert.ToString(ans - 3);
                    lblChoice2.Text = Convert.ToString(ans - 2);
                    lblChoice3.Text = Convert.ToString(ans - 1);
                    lblChoice4.Text = Convert.ToString(ans); break;
            }
        }

        public void TTAddDiv2(int cardNum)
        {
            DisplayLayer1();
            num = rnum.Next(0, 2);
            if (num == 0)
                lbl1op.Text = "+";
            else
                lbl1op.Text = "/";

            lbl1eq.Text = "=";
            lbl1ans.Text = "?";

            ans = rnum.Next(10, 99);
            num = rnum.Next(1, 15);
            if (ans <= num)
            {
                lbl12.Text = Convert.ToString(ans);
                ans = num;
            }
            else
                lbl12.Text = Convert.ToString(num);

            if (lbl1op.Text == "+")
                lbl11.Text = Convert.ToString(ans - Convert.ToInt32(lbl12.Text));
            else
                lbl11.Text = Convert.ToString(ans * Convert.ToInt32(lbl12.Text));

            choice = rnum.Next(1, 5);
            switch (choice)
            {
                case 1: lblChoice1.Text = Convert.ToString(ans);
                    lblChoice2.Text = Convert.ToString(ans + 1);
                    lblChoice3.Text = Convert.ToString(ans + 2);
                    lblChoice4.Text = Convert.ToString(ans + 3); break;
                case 2: lblChoice1.Text = Convert.ToString(ans - 1);
                    lblChoice2.Text = Convert.ToString(ans);
                    lblChoice3.Text = Convert.ToString(ans + 1);
                    lblChoice4.Text = Convert.ToString(ans + 2); break;
                case 3: lblChoice1.Text = Convert.ToString(ans - 2);
                    lblChoice2.Text = Convert.ToString(ans - 1);
                    lblChoice3.Text = Convert.ToString(ans);
                    lblChoice4.Text = Convert.ToString(ans + 1); break;
                case 4: lblChoice1.Text = Convert.ToString(ans - 3);
                    lblChoice2.Text = Convert.ToString(ans - 2);
                    lblChoice3.Text = Convert.ToString(ans - 1);
                    lblChoice4.Text = Convert.ToString(ans); break;
            }
        }

        public void TTSubMul2(int cardNum)
        {
            DisplayLayer1();
            num = rnum.Next(0, 2);
            if (num == 0)
                lbl1op.Text = "-";
            else
                lbl1op.Text = "*";
            lbl1eq.Text = "=";
            lbl1ans.Text = "?";

            num = rnum.Next(0, 75);
            num1 = rnum.Next(10, 100);

            if (num1 >= num)
            {
                lbl11.Text = Convert.ToString(num1);
                lbl12.Text = Convert.ToString(num);
            }
            else
            {
                lbl11.Text = Convert.ToString(num);
                lbl12.Text = Convert.ToString(num1);
            }

            if (lbl1op.Text == "*")
                ans = Convert.ToInt32(lbl11.Text) * Convert.ToInt32(lbl12.Text);
            if (lbl1op.Text == "-")
                ans = Convert.ToInt32(lbl11.Text) - Convert.ToInt32(lbl12.Text);

            choice = rnum.Next(1, 5);
            switch (choice)
            {
                case 1: lblChoice1.Text = Convert.ToString(ans);
                    lblChoice2.Text = Convert.ToString(ans + 1);
                    lblChoice3.Text = Convert.ToString(ans + 2);
                    lblChoice4.Text = Convert.ToString(ans + 3); break;
                case 2: lblChoice1.Text = Convert.ToString(ans - 1);
                    lblChoice2.Text = Convert.ToString(ans);
                    lblChoice3.Text = Convert.ToString(ans + 1);
                    lblChoice4.Text = Convert.ToString(ans + 2); break;
                case 3: lblChoice1.Text = Convert.ToString(ans - 2);
                    lblChoice2.Text = Convert.ToString(ans - 1);
                    lblChoice3.Text = Convert.ToString(ans);
                    lblChoice4.Text = Convert.ToString(ans + 1); break;
                case 4: lblChoice1.Text = Convert.ToString(ans - 3);
                    lblChoice2.Text = Convert.ToString(ans - 2);
                    lblChoice3.Text = Convert.ToString(ans - 1);
                    lblChoice4.Text = Convert.ToString(ans); break;
            }
        }

        public void TTAddAlg3(int cardNum)
        {
            DisplayLayer1();
            lbl1op.Text = "+";
            lbl1eq.Text = "=";
            num = rnum.Next(0, 3);
            switch (num)
            {
                case 0: lbl11.Text = "?"; break;
                case 1: lbl12.Text = "?"; break;
                case 2: lbl1ans.Text = "?"; break;
            }

            num = rnum.Next(0, 100);
            num1 = rnum.Next(0, 100);
            if (num1 >= num)
            {
                if (lbl11.Text == "?")
                {
                    lbl1ans.Text = Convert.ToString(num1);
                    lbl12.Text = Convert.ToString(num);
                    ans = num1 - num;
                }
                else if (lbl12.Text == "?")
                {
                    lbl1ans.Text = Convert.ToString(num1);
                    lbl11.Text = Convert.ToString(num);
                    ans = num1 - num;
                }
                else
                {
                    lbl11.Text = Convert.ToString(num1);
                    lbl12.Text = Convert.ToString(num);
                    ans = num1 + num;
                }
            }
            else
            {
                if (lbl11.Text == "?")
                {
                    lbl1ans.Text = Convert.ToString(num);
                    lbl12.Text = Convert.ToString(num1);
                    ans = num - num1;
                }
                else if (lbl12.Text == "?")
                {
                    lbl1ans.Text = Convert.ToString(num);
                    lbl11.Text = Convert.ToString(num1);
                    ans = num - num1;
                }
                else
                {
                    lbl11.Text = Convert.ToString(num1);
                    lbl12.Text = Convert.ToString(num);
                    ans = num1 + num;
                }
            }


            choice = rnum.Next(1, 5);
            switch (choice)
            {
                case 1: lblChoice1.Text = Convert.ToString(ans);
                    lblChoice2.Text = Convert.ToString(ans + 1);
                    lblChoice3.Text = Convert.ToString(ans + 2);
                    lblChoice4.Text = Convert.ToString(ans + 3); break;
                case 2: lblChoice1.Text = Convert.ToString(ans - 1);
                    lblChoice2.Text = Convert.ToString(ans);
                    lblChoice3.Text = Convert.ToString(ans + 1);
                    lblChoice4.Text = Convert.ToString(ans + 2); break;
                case 3: lblChoice1.Text = Convert.ToString(ans - 2);
                    lblChoice2.Text = Convert.ToString(ans - 1);
                    lblChoice3.Text = Convert.ToString(ans);
                    lblChoice4.Text = Convert.ToString(ans + 1); break;
                case 4: lblChoice1.Text = Convert.ToString(ans - 3);
                    lblChoice2.Text = Convert.ToString(ans - 2);
                    lblChoice3.Text = Convert.ToString(ans - 1);
                    lblChoice4.Text = Convert.ToString(ans); break;
            }
        }

        public void TTSubAlg3(int cardNum)
        {
            DisplayLayer1();
            lbl1op.Text = "-";
            lbl1eq.Text = "=";
            num = rnum.Next(0, 3);
            switch (num)
            {
                case 0: lbl11.Text = "?"; break;
                case 1: lbl12.Text = "?"; break;
                case 2: lbl1ans.Text = "?"; break;
            }

            num = rnum.Next(0, 100);
            num1 = rnum.Next(0, 100);
            if (lbl11.Text == "?")
            {
                lbl1ans.Text = Convert.ToString(num1);
                lbl12.Text = Convert.ToString(num);
                ans = num1 + num;
            }
            else if (lbl12.Text == "?")
            {
                if (num >= num1)
                {
                    lbl1ans.Text = Convert.ToString(num1);
                    lbl11.Text = Convert.ToString(num);
                }
                else
                {
                    lbl1ans.Text = Convert.ToString(num);
                    lbl11.Text = Convert.ToString(num1);
                }
                ans = num1 + num;
            }
            else
            {
                if (num1 >= num)
                {
                    lbl11.Text = Convert.ToString(num1);
                    lbl12.Text = Convert.ToString(num);
                    ans = num1 - num;
                }
                else
                {
                    lbl11.Text = Convert.ToString(num);
                    lbl12.Text = Convert.ToString(num1);
                    ans = num - num1;

                }
            }

            choice = rnum.Next(1, 5);
            switch (choice)
            {
                case 1: lblChoice1.Text = Convert.ToString(ans);
                    lblChoice2.Text = Convert.ToString(ans + 1);
                    lblChoice3.Text = Convert.ToString(ans + 2);
                    lblChoice4.Text = Convert.ToString(ans + 3); break;
                case 2: lblChoice1.Text = Convert.ToString(ans - 1);
                    lblChoice2.Text = Convert.ToString(ans);
                    lblChoice3.Text = Convert.ToString(ans + 1);
                    lblChoice4.Text = Convert.ToString(ans + 2); break;
                case 3: lblChoice1.Text = Convert.ToString(ans - 2);
                    lblChoice2.Text = Convert.ToString(ans - 1);
                    lblChoice3.Text = Convert.ToString(ans);
                    lblChoice4.Text = Convert.ToString(ans + 1); break;
                case 4: lblChoice1.Text = Convert.ToString(ans - 3);
                    lblChoice2.Text = Convert.ToString(ans - 2);
                    lblChoice3.Text = Convert.ToString(ans - 1);
                    lblChoice4.Text = Convert.ToString(ans); break;
            }
        }

        public void TTAddSubCombi(int cardNum)
        {
            num = rnum.Next(0, 2);
            if (num == 0)
                TTAddAlg3(cardNum);
            else
                TTSubAlg3(cardNum);
        }

        public void TTMulDiv3(int cardNum)
        {
            DisplayLayer1();
            num = rnum.Next(0, 2);
            if (num == 0)
                lbl1op.Text = "*";
            else
                lbl1op.Text = "/";

            lbl1eq.Text = "=";

            num = rnum.Next(0, 3);
            switch (num)
            {
                case 0: lbl11.Text = "?"; break;
                case 1: lbl12.Text = "?"; break;
                case 2: lbl1ans.Text = "?"; break;
            }

            num = rnum.Next(0, 50);
            num1 = rnum.Next(25, 100);

            if (num1 >= num)
            {
                if (lbl11.Text == "?")
                {
                    lbl1ans.Text = Convert.ToString(num1);
                    lbl12.Text = Convert.ToString(num);
                    if (lbl1op.Text == "*")
                        ans = num1 / num;
                    else
                        ans = num1 * num;
                }
                else if (lbl12.Text == "?")
                {
                    lbl1ans.Text = Convert.ToString(num1);
                    lbl11.Text = Convert.ToString(num);
                    if (lbl1op.Text == "*")
                        ans = num1 / num;
                    else
                        ans = num1 * num;
                }
                else
                {
                    if (lbl1op.Text == "*")
                    {
                        ans = num1 * num;
                        lbl11.Text = Convert.ToString(num1);
                        lbl12.Text = Convert.ToString(num);
                    }
                    else
                    {
                        ans = num1;
                        lbl11.Text = Convert.ToString(num * ans);
                        lbl12.Text = Convert.ToString(num);
                    }

                }
            }
            else
            {
                if (lbl11.Text == "?")
                {
                    lbl1ans.Text = Convert.ToString(num);
                    lbl12.Text = Convert.ToString(num1);
                    if (lbl1op.Text == "*")
                        ans = num / num1;
                    else
                        ans = num * num1;
                }
                else if (lbl12.Text == "?")
                {

                    if (lbl1op.Text == "*")
                    {
                        lbl1ans.Text = Convert.ToString(num);
                        lbl11.Text = Convert.ToString(num1);
                        ans = num / num1;
                    }
                    else
                    {
                        ans = num * num1;
                        lbl1ans.Text = Convert.ToString(ans);
                        lbl11.Text = Convert.ToString(num1);
                        ans = num;
                    }
                }
                else
                {
                    if (lbl1op.Text == "*")
                    {
                        ans = num1 * num;
                        lbl11.Text = Convert.ToString(num);
                        lbl12.Text = Convert.ToString(num1);
                    }
                    else
                    {
                        ans = num;
                        lbl11.Text = Convert.ToString(num1 * ans);
                        lbl12.Text = Convert.ToString(num);
                    }
                }
            }

            choice = rnum.Next(1, 5);
            switch (choice)
            {
                case 1: lblChoice1.Text = Convert.ToString(ans);
                    lblChoice2.Text = Convert.ToString(ans + 1);
                    lblChoice3.Text = Convert.ToString(ans + 2);
                    lblChoice4.Text = Convert.ToString(ans + 3); break;
                case 2: lblChoice1.Text = Convert.ToString(ans - 1);
                    lblChoice2.Text = Convert.ToString(ans);
                    lblChoice3.Text = Convert.ToString(ans + 1);
                    lblChoice4.Text = Convert.ToString(ans + 2); break;
                case 3: lblChoice1.Text = Convert.ToString(ans - 2);
                    lblChoice2.Text = Convert.ToString(ans - 1);
                    lblChoice3.Text = Convert.ToString(ans);
                    lblChoice4.Text = Convert.ToString(ans + 1); break;
                case 4: lblChoice1.Text = Convert.ToString(ans - 3);
                    lblChoice2.Text = Convert.ToString(ans - 2);
                    lblChoice3.Text = Convert.ToString(ans - 1);
                    lblChoice4.Text = Convert.ToString(ans); break;
            }
        }

        public void TTGreatLessAddMul(int cardNum)
        {
            DisplayLayer2();
            int ans1;

            num = rnum.Next(0, 2);
            if (num == 0)
            {
                lbl2op1.Text = "+";
                num = rnum.Next(0, 100);
                num1 = rnum.Next(0, 100);
                ans = num + num1;
                lbl21.Text = Convert.ToString(num);
                lbl22.Text = Convert.ToString(num1);
            }
            else
            {
                lbl2op1.Text = "*";
                num = rnum.Next(10, 51);
                num1 = rnum.Next(0, 10);
                ans = num * num1;
                lbl21.Text = Convert.ToString(num);
                lbl22.Text = Convert.ToString(num1);
            }

            num = rnum.Next(0, 2);
            if (num == 0)
            {
                lbl2op2.Text = "+";
                num = rnum.Next(0, 100);
                num1 = rnum.Next(0, 100);
                ans1 = num + num1;
                lbl23.Text = Convert.ToString(num);
                lbl24.Text = Convert.ToString(num1);
            }
            else
            {
                lbl2op1.Text = "*";
                num = rnum.Next(0, 10);
                num1 = rnum.Next(10, 51);
                ans1 = num * num1;
                lbl23.Text = Convert.ToString(num);
                lbl24.Text = Convert.ToString(num1);
            }

            lbl2eq.Text = "___";

            if (ans > ans1)
                ans2 = ">";
            else if (ans < ans1)
                ans2 = "<";
            else
                ans2 = "=";




        }

        public void TTGreatLessSubDiv(int cardNum)
        {
            DisplayLayer2();
            int ans1;

            num = rnum.Next(0, 2);
            if (num == 0)
            {
                lbl2op1.Text = "-";
                num = rnum.Next(0, 100);
                num1 = rnum.Next(0, 100);
                if (num >= num1)
                {
                    ans = num - num1;
                    lbl21.Text = Convert.ToString(num);
                    lbl22.Text = Convert.ToString(num1);
                }
                else
                {
                    ans = num1 - num;
                    lbl21.Text = Convert.ToString(num1);
                    lbl22.Text = Convert.ToString(num);
                }
            }
            else
            {
                lbl2op1.Text = "/";
                ans = rnum.Next(1, 51);
                num1 = rnum.Next(1, 10);
                num = ans * num1;
                lbl21.Text = Convert.ToString(num);
                lbl22.Text = Convert.ToString(num1);
            }

            num = rnum.Next(0, 2);
            if (num == 0)
            {
                lbl2op2.Text = "-";
                num = rnum.Next(0, 100);
                num1 = rnum.Next(0, 100);
                if (num >= num1)
                {
                    ans1 = num - num1;
                    lbl23.Text = Convert.ToString(num);
                    lbl24.Text = Convert.ToString(num1);
                }
                else
                {
                    ans1 = num1 - num;
                    lbl23.Text = Convert.ToString(num1);
                    lbl24.Text = Convert.ToString(num);
                }
            }
            else
            {
                lbl2op2.Text = "/";
                ans1 = rnum.Next(10, 51);
                num1 = rnum.Next(1, 11);
                num = ans1 * num1;
                lbl23.Text = Convert.ToString(num);
                lbl24.Text = Convert.ToString(num1);
            }

            lbl2eq.Text = "___";

            if (ans > ans1)
                ans2 = ">";
            else if (ans < ans1)
                ans2 = "<";
            else if (ans == ans1)
                ans2 = "=";
        }

        public void TTGreatLessAll(int cardNum)
        {
            num = rnum.Next(0, 2);
            if (num == 0)
                TTGreatLessAddMul(cardNum);
            else
                TTGreatLessSubDiv(cardNum);
        }

        public void GridPuzzle()
        {
            lblG1.Visible = true;
            lblG2.Visible = true;
            lblG3.Visible = true;
            lblG4.Visible = true;
            lblG5.Visible = true;
            lblG6.Visible = true;
            lblG7.Visible = true;
            lblG8.Visible = true;
            lblG9.Visible = true;

            lblg15a.Visible = true;
            lblg15b.Visible = true;
            lblg15c.Visible = true;
            lblg15d.Visible = true;
            lblg15e.Visible = true;
            lblg15f.Visible = true;
            lblg15g.Visible = true;
            lblg15h.Visible = true;

            lblgres.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cardNum = 1;
            num = rnum.Next(1, 3);
            EraseBoard();
            switch (num)
            {
                case 1: TTAdd1(1); break;
                case 2: TTSub1(1); break;
                case 3: TTMul1(1); break;
                case 4: TTDiv1(1); break;
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            cardNum = 5;
            num = rnum.Next(1, 5);
            EraseBoard();
            switch (num)
            {
                case 1: TTAdd1(5); break;
                case 2: TTSub1(5); break;
                case 3: TTMul1(5); break;
                case 4: TTDiv1(5); break;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            cardNum = 2;
            num = rnum.Next(1, 5);
            EraseBoard();
            switch (num)
            {
                case 1: TTAdd1(2); break;
                case 2: TTSub1(2); break;
                case 3: TTMul1(2); break;
                case 4: TTDiv1(2); break;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cardNum = 3;
            num = rnum.Next(1, 5);
            EraseBoard();
            switch (num)
            {
                case 1: TTAdd1(3); break;
                case 2: TTSub1(3); break;
                case 3: TTMul1(3); break;
                case 4: TTDiv1(3); break;
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            cardNum = 4;
            num = rnum.Next(1, 5);
            EraseBoard();
            switch (num)
            {
                case 1: TTAdd1(4); break;
                case 2: TTSub1(4); break;
                case 3: TTMul1(4); break;
                case 4: TTDiv1(4); break;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            cardNum = 6;
            opNum = rnum.Next(5, 9);
            EraseBoard();
            switch (opNum)
            {
                case 5: TTAddSub2(6); break;
                case 6: TTAddMul2(6); break;
                case 7: TTAddDiv2(6); break;
                case 8: TTSubMul2(6); break;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            cardNum = 7; EraseBoard();
            opNum = rnum.Next(5, 9);
            switch (opNum)
            {
                case 5: TTAddSub2(7); break;
                case 6: TTAddMul2(7); break;
                case 7: TTAddDiv2(7); break;
                case 8: TTSubMul2(7); break;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            cardNum = 8; EraseBoard();
            opNum = rnum.Next(5, 9);
            switch (opNum)
            {
                case 5: TTAddSub2(8); break;
                case 6: TTAddMul2(8); break;
                case 7: TTAddDiv2(8); break;
                case 8: TTSubMul2(8); break;
            }

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            cardNum = 9; EraseBoard();
            opNum = rnum.Next(5, 9);
            switch (opNum)
            {
                case 5: TTAddSub2(9); break;
                case 6: TTAddMul2(9); break;
                case 7: TTAddDiv2(9); break;
                case 8: TTSubMul2(9); break;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            cardNum = 10; EraseBoard();
            opNum = rnum.Next(9, 13);
            switch (opNum)
            {
                case 9: TTAddAlg3(10); break;
                case 10: TTSubAlg3(10); break;
                case 11: TTAddSubCombi(10); break;
                case 12: TTMulDiv3(10); break;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            cardNum = 11; EraseBoard();
            opNum = rnum.Next(9, 13);
            switch (opNum)
            {
                case 9: TTAddAlg3(11); break;
                case 10: TTSubAlg3(11); break;
                case 11: TTAddSubCombi(11); break;
                case 12: TTMulDiv3(11); break;
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            cardNum = 12; EraseBoard();
            opNum = rnum.Next(9, 13);
            switch (opNum)
            {
                case 9: TTAddAlg3(12); break;
                case 10: TTSubAlg3(12); break;
                case 11: TTAddSubCombi(12); break;
                case 12: TTMulDiv3(12); break;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            cardNum = 13; EraseBoard();
            opNum = rnum.Next(13, 16);
            switch (opNum)
            {
                case 13: TTGreatLessAddMul(13); break;
                case 14: TTGreatLessSubDiv(13); break;
                case 15: TTGreatLessAll(13); break;
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            cardNum = 14; EraseBoard();
            opNum = rnum.Next(13, 16);
            switch (opNum)
            {
                case 13: TTGreatLessAddMul(14); break;
                case 14: TTGreatLessSubDiv(14); break;
                case 15: TTGreatLessAll(14); break;
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            cardNum = 15; EraseBoard();
            GridPuzzle();
        }

        private void lblChoice1_Click(object sender, EventArgs e)
        {
            userChoice = 1;
            CheckChoice();
        }

        private void lblChoice2_Click(object sender, EventArgs e)
        {
            userChoice = 2;
            CheckChoice();
        }

        private void lblChoice3_Click(object sender, EventArgs e)
        {
            userChoice = 3;
            CheckChoice();
        }

        private void lblChoice4_Click(object sender, EventArgs e)
        {
            userChoice = 4;
            CheckChoice();
        }

        private void lbl2ch1_Click(object sender, EventArgs e)
        {
            usrChoice = ">";
            CheckChoice2();
        }

        private void lbl2ch2_Click(object sender, EventArgs e)
        {
            usrChoice = "=";
            CheckChoice2();
        }

        private void lbl2ch3_Click(object sender, EventArgs e)
        {
            usrChoice = "<";
            CheckChoice2();
        }

        int[] clicka = new int[9];

        public void CheckGrid()
        {
            if ((clicka[0] + clicka[1] + clicka[2] == 15) &&
                (clicka[0] + clicka[3] + clicka[6] == 15) &&
                (clicka[0] + clicka[4] + clicka[8] == 15) &&
                (clicka[1] + clicka[4] + clicka[7] == 15) &&
                (clicka[2] + clicka[5] + clicka[8] == 15) &&
                (clicka[2] + clicka[4] + clicka[6] == 15) &&
                (clicka[3] + clicka[4] + clicka[5] == 15) &&
                (clicka[6] + clicka[7] + clicka[8] == 15))
            {
                lblMsg.Visible = true;
                lblMsg.Text = "Congrats";

            };
        }

        private void lblG1_Click(object sender, EventArgs e)
        {
            clicka[0]++;
            if (clicka[0] == 10) clicka[0] = 0;
            else lblG1.Text = Convert.ToString(clicka[0]);
            CheckGrid();
        }

        private void lblG2_Click(object sender, EventArgs e)
        {
            clicka[1]++;
            if (clicka[1] == 10) clicka[1] = 0;
            else lblG2.Text = Convert.ToString(clicka[1]);
            CheckGrid();
        }

        private void lblG3_Click(object sender, EventArgs e)
        {
            clicka[2]++;
            if (clicka[2] == 10) clicka[2] = 0;
            else lblG3.Text = Convert.ToString(clicka[2]);
            CheckGrid();
        }

        private void lblG4_Click(object sender, EventArgs e)
        {
            clicka[3]++;
            if (clicka[3] == 10) clicka[3] = 0;
            else lblG4.Text = Convert.ToString(clicka[3]);
            CheckGrid();
        }

        private void lblG5_Click(object sender, EventArgs e)
        {
            clicka[4]++;
            if (clicka[4] == 10) clicka[4] = 0;
            else lblG5.Text = Convert.ToString(clicka[4]);
            CheckGrid();
        }

        private void lblG6_Click(object sender, EventArgs e)
        {
            clicka[5]++;
            if (clicka[5] == 10) clicka[5] = 0;
            else lblG6.Text = Convert.ToString(clicka[5]);
            CheckGrid();
        }

        private void lblG7_Click(object sender, EventArgs e)
        {
            clicka[6]++;
            if (clicka[6] == 10) clicka[6] = 0;
            else lblG7.Text = Convert.ToString(clicka[6]);
            CheckGrid();
        }

        private void lblG8_Click(object sender, EventArgs e)
        {
            clicka[7]++;
            if (clicka[7] == 10) clicka[7] = 0;
            else lblG8.Text = Convert.ToString(clicka[7]);
            CheckGrid();
        }

        private void lblG9_Click(object sender, EventArgs e)
        {
            clicka[8]++;
            if (clicka[8] == 10) clicka[8] = 0;
            else lblG9.Text = Convert.ToString(clicka[8]);
            CheckGrid();
        }

        private void lblgres_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
                clicka[i] = 0;
            lblG1.Text = "0";
            lblG2.Text = "0";
            lblG3.Text = "0";
            lblG4.Text = "0";
            lblG5.Text = "0";
            lblG6.Text = "0";
            lblG7.Text = "0";
            lblG8.Text = "0";
            lblG9.Text = "0";

        }


    }
}
