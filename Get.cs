using Management.database;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Management
{
    public partial class Get : Form
    {
        private DataGridView dataGridView;

        public Get()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dataGridView = new DataGridView
            {
                BackColor = Color.White,
                Size = new Size(600, 400),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToOrderColumns = false
            };

            int x = (this.ClientSize.Width - dataGridView.Width) / 2;
            int y = (this.ClientSize.Height - dataGridView.Height) / 2;

            dataGridView.Location = new Point(x, y);

            this.Controls.Add(dataGridView);
        }

        private void Get_Load(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            var res = controller.Get();

            if (res != null && res.Any())
            {
                dataGridView.DataSource = res;
            }
            else
            {
                MessageBox.Show("No Workers Found! Add Workers to view!");
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
