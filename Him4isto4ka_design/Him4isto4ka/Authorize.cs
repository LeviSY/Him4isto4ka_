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
    public partial class Authorize : Form
    {
        public Authorize()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        public void AuthorizeButton_Click(object sender, EventArgs e)
        {
                this.Hide();
                MainMenu mainform = new MainMenu();
                mainform.Show();
        }
    }
}
