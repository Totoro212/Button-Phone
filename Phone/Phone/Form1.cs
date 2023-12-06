using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int id = 0, index = 0;
        bool Activ = true, Call = false;
        string SS = "";

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            id++;
            if (id < 11) Activ = false;
        }
        //кнопки 
        private void button7_Click(object sender, EventArgs e)
        {
            SMS(button7.Text);
            if (index < button7.Text.Length - 1) index++; else index = 0;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            SMS(button8.Text);
            if (index < button8.Text.Length - 1) index++; else index = 0;

        }
        private void button6_Click(object sender, EventArgs e)
        {
            SMS(button6.Text);
            if (index < button6.Text.Length - 1) index++; else index = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SMS(button9.Text);
            if (index < button9.Text.Length - 1) index++; else index = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {

            SMS(button10.Text);
            if (index < button10.Text.Length - 1) index++; else index = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {

            SMS(button11.Text);
            if (index < button11.Text.Length - 1) index++; else index = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SMS(button12.Text);
            if (index < button12.Text.Length - 1) index++; else index = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SMS(button13.Text);
            if (index < button13.Text.Length - 1) index++; else index = 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SMS(button14.Text);
            if (index < button14.Text.Length - 1) index++; else index = 0;
        }





        //
        void SMS(string S)
        {
            timer1.Enabled = true;
            if (Call && '0' <= S[0] && S[0] <= '9')
                if (richTextBox1.Text != "") Num(S[0]);
                else if (S[0] != '0') Num(S[0]);
            if (!Call)
            {
                if (SS != S)
                {
                    Activ = true; SS = S; index = 0;
                }
                if (id >= 10) index = 0;
                if (id >= 10 | richTextBox1.Text == "" | Activ)
                {
                    if (textBox1.Visible = true)
                    {
                        textBox1.Text += S[index]; Activ = false;
                    }

                    else
                    { richTextBox1.Text += S[index]; Activ = false; }

                }
                else 
                    if (id < 10)
                {
                    if (textBox1.Visible = true)
                    {
                        textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1) + S[index];
                    }
                    else
                    {
                        richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1) + S[index];
                    }
                }
                id = 0;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
                if (listBox1.Visible == false)
                {
                    listBox1.Visible = true;
                    button19.Visible = true;
                }
                else
                {
                    button19.Visible = false;
                    listBox1.Visible = false;
                }

            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (button8.Text[1] == 'a')
            {
                button8.Text = button8.Text.ToUpper();
                button6.Text = button6.Text.ToUpper();
                button9.Text = button9.Text.ToUpper();
                button10.Text = button10.Text.ToUpper();
                button11.Text = button11.Text.ToUpper();
                button12.Text = button12.Text.ToUpper();
                button13.Text = button13.Text.ToUpper();
                button14.Text = button14.Text.ToUpper();
            }
            else
            {
                button8.Text = button8.Text.ToLower();
                button6.Text = button6.Text.ToLower();
                button9.Text = button9.Text.ToLower();
                button10.Text = button10.Text.ToLower();
                button11.Text = button11.Text.ToLower();
                button12.Text = button12.Text.ToLower();
                button13.Text = button13.Text.ToLower();
                button14.Text = button14.Text.ToLower();
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            SMS("0"); id = 11;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Visible == true)
            {
                if (listBox1.SelectedIndex != 0)
                {
                    richTextBox1.Clear();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Call)
            {
                Call = false;
                label1.Text = "SMS";
            }
            else
            {
                Call = true;
                label1.Text = "CALL";

            }
            richTextBox1.Clear();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            string name;

            if (listBox1.Visible == true)
            {
                if (int.TryParse(richTextBox1.Text, out number))
                    name = richTextBox1.Text;
                if (number != 0)
                {
                    listBox1.Items.Add(number);
                }
                richTextBox1.Clear();
                textBox1.Clear();
                textBox1.Visible = false;

            }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string, ulong> Contact = new Dictionary<string, ulong>();
            Contact.Add("oleg", 901111111);
            Contact.Add("dayan", 902222222);
            Contact.Add("danya", 903333333);
            Contact.Add("vilya", 904444444);
            Contact.Add("borya", 905555555);
            Contact.Add("amir", 906666666);

            foreach (var contact in Contact)
            {
                if (contact.Key.ToString() == listBox1.Items[listBox1.SelectedIndex].ToString())
                {
                    richTextBox1.Text = contact.Value.ToString();
                    textBox1.Visible = true;
                }
            }
            
        }

        void Num(char ch)
        {
            richTextBox1.Text += ch;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
