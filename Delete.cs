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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();

            if (int.TryParse(textBoxId.Text, out int id))
            {
                try
                {
                    bool isDeleted = controller.DeleteWorker(id);
                    if (isDeleted)
                    {
                        MessageBox.Show("Worker Deleted.");
                    }
                    else
                    {
                        MessageBox.Show("Id Not Found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error. Cant delete worker: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Write a number.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Get get = new Get();
            get.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Delete_Load(object sender, EventArgs e)
        {

        }
    }
    
}
