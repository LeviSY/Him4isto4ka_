using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            String loginUser = loginfield.Text;
            String passUser = passfield.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `userLogin` = @uL AND `userPassword` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                db.openConnection();
                MySqlCommand name = new MySqlCommand("SELECT `userName`, `userSurname`, `userPatronymic` FROM `users` WHERE `userLogin` = @uLo AND `userPassword` = @uPa", db.getConnection());

                name.Parameters.Add("@uLo", MySqlDbType.VarChar).Value = loginUser;
                name.Parameters.Add("@uPa", MySqlDbType.VarChar).Value = passUser;

                MySqlDataReader reader = name.ExecuteReader();

                List<string[]> Name = new List<string[]>();
                while (reader.Read())
                {
                    Name.Add(new string[3]);

                    Name[Name.Count - 1][0] = reader[0].ToString();
                    Name[Name.Count - 1][1] = reader[1].ToString();
                    Name[Name.Count - 1][2] = reader[2].ToString();
                }
                reader.Close();
                db.closeConnection();

                this.Hide();
                MainMenu mainform = new MainMenu();
                mainform.Show();
                mainform.UserName(Name);

            }
            else
                MessageBox.Show("Неверный логин или пароль");
        }
    }
}
