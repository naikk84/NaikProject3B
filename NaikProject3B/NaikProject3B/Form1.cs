using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaikProject3B
{
    public partial class String : Form
    {
        public String()
        {
            InitializeComponent();
        }

        private void butvalidate1_Click(object sender, EventArgs e)
        {
            string a = string1.Text;
            for (int i = 0; i <= a.Length; i++)
            {
                a = a.Replace("$", "");
                a = a.Replace("@", "");
                a = a.Replace("#", "");
                a = a.Replace("%", "");
                a = a.Replace("&", "");
                a = a.Replace("^", "");
                a = a.Replace("*", "");
            }
                outptstring1.Text = a;
            

        }

        private void butvalidate3_Click(object sender, EventArgs e)
        {
            string b = String3.Text;
            if(b.StartsWith(" ") || b.StartsWith("$") || b.StartsWith("@") || b.StartsWith("%") || b.StartsWith("#"))
            {
                MessageBox.Show("The string3 can't start with a space or $ or @ or % or #");
                String3.Clear();
                String3.Focus();
            }
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butvalidate2_Click(object sender, EventArgs e)
        {
            string c = string2.Text;
            if (c.EndsWith(" ") || c.EndsWith("$") || c.EndsWith("@") || c.EndsWith("%") || c.EndsWith("#"))
            {
                MessageBox.Show("The string2 can't End with a space or $ or @ or % or #");
                string2.Clear();
                string2.Focus();

            }
        }

        private void butValidateall_Click(object sender, EventArgs e)
        {
            string a = string1.Text;
            for (int i = 0; i <= a.Length; i++)
            {
                a = a.Replace("$", "");
                a = a.Replace("@", "");
                a = a.Replace("#", "");
                a = a.Replace("%", "");
                a = a.Replace("&", "");
                a = a.Replace("^", "");
                a = a.Replace("*", "");
            }
            outptstring1.Text = a;
            string b = String3.Text;
            if (b.StartsWith(" ") || b.StartsWith("$") || b.StartsWith("@") || b.StartsWith("%") || b.StartsWith("#"))
            {
                MessageBox.Show("The string3 can't start with a space or $ or @ or % or #");
                String3.Clear();
                String3.Focus();
            }
            string c = string2.Text;
            if (c.EndsWith(" ") || c.EndsWith("$") || c.EndsWith("@") || c.EndsWith("%") || c.EndsWith("#"))
            {
                MessageBox.Show("The string2 can't End with a space or $ or @ or % or #");
                string2.Clear();
                string2.Focus();

            }

            try
            {
                int x = int.Parse(String4.Text, System.Globalization.NumberStyles.None);
                String4.Text = x.ToString();
            }

            catch (Exception)
            {
                MessageBox.Show("Enter only numbers");
                String4.Clear();

            }
        }

        private void butValidate4_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(String4.Text, System.Globalization.NumberStyles.None);
                String4.Text = x.ToString();
            }
             
           catch(Exception)
                {
                MessageBox.Show("Enter only numbers");
                String4.Clear();

            }
        }
    }
}