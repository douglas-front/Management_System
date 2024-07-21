using Management.database;
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
    public partial class Post : Form
    {
        public Post()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();

            string nameWorker = textBoxName.Text;
            string salary = textBoxSalary.Text;
            string profession = textBoxProfession.Text;
            string age = textBoxAge.Text;
            string phone = textBoxPhone.Text;


            try
            {
                controller.InsertWorker(nameWorker, salary,  profession, age, phone);

                MessageBox.Show("worker added");

            }catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
