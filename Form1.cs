using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBoxPassword.PasswordChar = '*';
        }


        private void button1_Click(object sender, EventArgs e)
        {
            GetLogin login = new GetLogin();

            bool result = login.getLogin(textBoxName,textBoxPassword);

            if (result)
            {
               Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("User not found");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }


    }


    public class GetLogin
    {
        public bool getLogin(TextBox name, TextBox password)
        {
            if(name.Text == "douglas" && password.Text == "1234")
            {
                return true;    
            }
              return false; 
        }
    }
}
