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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Post post = new Post();
            post.ShowDialog();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Get get = new Get();
            get.ShowDialog();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.ShowDialog();
        }

        
    }
}
