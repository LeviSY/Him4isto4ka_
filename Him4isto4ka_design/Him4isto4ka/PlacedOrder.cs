using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Him4isto4ka
{
    public partial class PlacedOrder : Form
    {
        public PlacedOrder()
        {
            InitializeComponent();
            dataGridView1.RowCount = 4;
            dataGridView1.ColumnCount = 4;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu main = new MainMenu();
            main.Show();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.ColumnIndex == 1)
            {
                this.Hide();
                OrdersInfo OI = new OrdersInfo();
                OI.Show();
            }
                
        }
    }
}
