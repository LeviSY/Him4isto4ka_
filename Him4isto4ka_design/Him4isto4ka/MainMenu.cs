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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TotalOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlacedOrder PO = new PlacedOrder();
            PO.Show();
        }

        private void NewOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_Order NO = new New_Order();
            NO.Show();
        }
    }
}
