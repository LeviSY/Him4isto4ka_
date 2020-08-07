using MySql.Data.MySqlClient;
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
    public partial class New_Order : Form
    {
        string cc;
        public int ii;
        public New_Order()
        {
            InitializeComponent();
            LoadData();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu MM = new MainMenu();
            MM.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClientName.Clear();
            ClientSurname.Clear();
            ClientPatronymic.Clear();
            ClientPhone.Clear();
            HouseBox.Clear();
            StreetBox.Clear();
            CityBox.Clear();
            FlatBox.Clear();
            CategoryBox.Text = "";
            ProductBox.Text = "";
            ServiceType.Text = "";
            numericUpDown1.Value = 1;
            CostBox.Clear();
            PreCost.Clear();
            dataGridView1.Rows.Clear();
            dateTimePicker2.Value = dateTimePicker1.Value;
        }


        private void Add_Click(object sender, EventArgs e)
        {
            int a = int.Parse(CostBox.Text) * int.Parse(numericUpDown1.Text);
            int b = int.Parse(DurationTime.Text) * int.Parse(numericUpDown1.Text);

            List<string[]> data = new List<string[]>();

            data.Add(new string[7]);

            data[data.Count - 1][0] = CategoryBox.Text;
            data[data.Count - 1][1] = ProductBox.Text;
            data[data.Count - 1][2] = ServiceType.Text;
            data[data.Count - 1][3] = CostBox.Text;
            data[data.Count - 1][4] = numericUpDown1.Text;
            data[data.Count - 1][5] = Convert.ToString(a);
            data[data.Count - 1][6] = Convert.ToString(b);

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
            }
            PreCost.Text = sum.ToString();

            int dgv = (dataGridView1.Rows.Count)-2;
            int day = 0;
            day = Convert.ToInt32(dataGridView1.Rows[dgv].Cells[6].Value);
            dateTimePicker2.Value = dateTimePicker2.Value.AddDays(day);
        }

        public void LoadData()
        {
            DB db = new DB();

            db.openConnection();

            MySqlCommand category = new MySqlCommand("SELECT cost.category FROM cost", db.getConnection());

            MySqlDataReader reader = category.ExecuteReader();

            List<string[]> Cat = new List<string[]>();

            while (reader.Read())
            {
                Cat.Add(new string[1]);

                Cat[Cat.Count - 1][0] = reader[0].ToString();
            }
            foreach (string[] a in Cat)
                CategoryBox.Items.AddRange(a);

            reader.Close();


            MySqlCommand service = new MySqlCommand("SELECT cost.service FROM cost", db.getConnection());

            reader = service.ExecuteReader();

            List<string[]> Serv = new List<string[]>();

            while (reader.Read())
            {
                Serv.Add(new string[1]);

                Serv[Serv.Count - 1][0] = reader[0].ToString();
            }
            foreach (string[] a in Serv)
                ServiceType.Items.AddRange(a);

            reader.Close();


            MySqlCommand ServiceCost = new MySqlCommand("SELECT cost.cost FROM cost", db.getConnection());

            reader = ServiceCost.ExecuteReader();

            List<string[]> cost = new List<string[]>();

            while (reader.Read())
            {
                cost.Add(new string[1]);

                cost[cost.Count - 1][0] = reader[0].ToString();
            }

            reader.Close();

            MySqlCommand id = new MySqlCommand("SELECT clientdata.id FROM clientdata", db.getConnection());

            reader = id.ExecuteReader();

            
                List<string[]> ID = new List<string[]>();

                while (reader.Read())
                {
                    ID.Add(new string[1]);

                    ID[ID.Count - 1][0] = reader[0].ToString();
                }
            
            if (ID.Count != 0 )
            {
                OrderID.Text = ((ID[0].Length) + 1).ToString();
            }
            reader.Close();

            db.closeConnection();


        }

        public void CategoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DB db = new DB();

            db.openConnection();

            MySqlDataReader reader;

            MySqlCommand tuxedo = new MySqlCommand("SELECT category.tuxedo FROM category", db.getConnection());

            reader = tuxedo.ExecuteReader();

            List<string[]> tux = new List<string[]>();
            while (reader.Read())
            {
                tux.Add(new string[1]);
                tux[tux.Count - 1][0] = reader[0].ToString();
            }

            reader.Close();


            MySqlCommand overcoat = new MySqlCommand("SELECT category.overcoat FROM category", db.getConnection());

             reader = overcoat.ExecuteReader();

            List<string[]> oc = new List<string[]>();
            while (reader.Read())
            {
                oc.Add(new string[1]);
                oc[oc.Count - 1][0] = reader[0].ToString();
            }

            reader.Close();


            MySqlCommand fur_coat = new MySqlCommand("SELECT category.fur_coat FROM category", db.getConnection());

             reader = fur_coat.ExecuteReader();

            List<string[]> fc = new List<string[]>();
            while (reader.Read())
            {
                fc.Add(new string[1]);
                fc[fc.Count - 1][0] = reader[0].ToString();
            }


            reader.Close();


            MySqlCommand sport = new MySqlCommand("SELECT category.sport FROM category", db.getConnection());

             reader = sport.ExecuteReader();

            List<string[]> st = new List<string[]>();
            while (reader.Read())
            {
                st.Add(new string[1]);
                st[st.Count - 1][0] = reader[0].ToString();
            }
            
            reader.Close();

            string[] ar = new string[4];
            int a = CategoryBox.SelectedIndex;
            string b = a.ToString();
            switch (b)
            {
                case "0":
                    {
                        ProductBox.Text = "";
                        ProductBox.Items.Clear();
                        for (int i = 0; i < 4; i++)
                        {
                            ar[i] = tux[i][0].ToString();
                        }
                        ProductBox.Items.AddRange(ar);
                        break;
                    }
                case "1":
                    {
                        ProductBox.Text = "";
                        ProductBox.Items.Clear();
                        for (int i = 0; i < 4; i++)
                        {
                            ar[i] = oc[i][0].ToString();
                        }
                        ProductBox.Items.AddRange(ar);
                        break;
                    }
                case "2":
                    {
                        ProductBox.Text = "";
                        ProductBox.Items.Clear();
                        for (int i = 0; i < 4; i++)
                        {
                            ar[i] = fc[i][0].ToString();
                        }
                        ProductBox.Items.AddRange(ar);
                        break;
                    }
                case "3":
                    {
                        ProductBox.Text = "";
                        ProductBox.Items.Clear();
                        for (int i = 0; i < 4; i++)
                        {
                            ar[i] = st[i][0].ToString();
                        }
                        ProductBox.Items.AddRange(ar);
                        break;
                    }
            }


            MySqlCommand categoryCost = new MySqlCommand("SELECT cost.catCost FROM cost", db.getConnection());

            reader = categoryCost.ExecuteReader();

            List<string[]> catCost = new List<string[]>();

            while (reader.Read())
            {
                catCost.Add(new string[1]);

                catCost[catCost.Count - 1][0] = reader[0].ToString();
            }

            reader.Close();

            db.closeConnection();

            cc = catCost[a][0].ToString();

            CostBox.Text = cc;

        }

        public void ServiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DB db = new DB();

            db.openConnection();

            MySqlCommand ServiceCost = new MySqlCommand("SELECT cost.cost FROM cost", db.getConnection());

            MySqlDataReader reader = ServiceCost.ExecuteReader();

            List<string[]> cost = new List<string[]>();

            while (reader.Read())
            {
                cost.Add(new string[1]);

                cost[cost.Count - 1][0] = reader[0].ToString();
            }

            reader.Close();

            db.closeConnection();


            int a = ServiceType.SelectedIndex;

            int sc = int.Parse(cost[a][0].ToString());

            int b = int.Parse(cc);

            CostBox.Text = (sc + b).ToString();
        }

        private void Pickup_CheckedChanged(object sender, EventArgs e)
        {
            if (Pickup.Checked)
            {
                EndCost.Text = PreCost.Text;
            }
        }

        private void Delivery_CheckedChanged(object sender, EventArgs e)
        {
            if (Delivery.Checked)
            {
                EndCost.Text = (int.Parse(PreCost.Text) + 500).ToString();
            }
        }

        public void AddOrder_Click(object sender, EventArgs e)
        {
            if (ClientSurname.Text == null)
            {
                MessageBox.Show("Фамилия не указана");
                return;
            }
            if (ClientName.Text == null)
            {
                MessageBox.Show("имя не указано");
                return;
            }
            if (ClientPatronymic.Text == null)
            {
                MessageBox.Show("Отчество не указано");
                return;
            }
            if (ClientPhone.Text == null)
            {
                MessageBox.Show("Телефон не указан");
                return;
            }

            for (int i = 0; i<((dataGridView1.Rows.Count)-1); i++)
            {
                for(int j = 0; j<dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value == null)
                    {
                        MessageBox.Show("Данные в таблице отсутствуют");
                        return;
                    }
                }
            }

            if (Delivery.Checked == false && Pickup.Checked == false)
            {
                MessageBox.Show("Тип доставки не указан");
                return;
            }
            
            int del = 0;
            if (Delivery.Checked)
            {
                del = 1;
                if(CityBox == null)
                {
                    MessageBox.Show("Город не указан");
                    return;
                }
                if (StreetBox == null)
                {
                    MessageBox.Show("Улица не указана");
                    return;
                }
                if (HouseBox == null)
                {
                    MessageBox.Show("Дом не указан");
                    return;
                }
                if (FlatBox == null)
                {
                    MessageBox.Show("Квартира не указана");
                    return;
                }

            }

            DB db = new DB();

            Authorize aut = new Authorize();
            String loginUser = aut.loginfield.Text;
            String passUser = aut.passfield.Text;

            db.openConnection();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand name = new MySqlCommand("SELECT `id` FROM `users` WHERE `userLogin` = @uL AND `userPassword` = @uP", db.getConnection());

            name.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            name.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = name;
            adapter.Fill(table);

            int id = int.Parse(table.ToString());


            MySqlCommand ClientData = new MySqlCommand("INSERT INTO `clientdata`(`UserID`,`Surname`, `Name`, `Patronymic`, `Phone`, `City`, `Street`, `House`, `Flat`) VALUES (@userid, @surname, @name, @patronymic, @phone, @city, @street, @house, @flat)", db.getConnection());

            ClientData.Parameters.Add("@userid", MySqlDbType.Int32).Value = id;
            ClientData.Parameters.Add("@surname", MySqlDbType.VarChar).Value = ClientSurname.Text;
            ClientData.Parameters.Add("@name", MySqlDbType.VarChar).Value = ClientName.Text;
            ClientData.Parameters.Add("@patronymic", MySqlDbType.VarChar).Value = ClientPatronymic.Text;
            ClientData.Parameters.Add("@phone", MySqlDbType.VarChar).Value = ClientPhone.Text;
            ClientData.Parameters.Add("@city", MySqlDbType.VarChar).Value = CityBox.Text;
            ClientData.Parameters.Add("@street", MySqlDbType.VarChar).Value = StreetBox.Text;
            ClientData.Parameters.Add("@house", MySqlDbType.VarChar).Value = HouseBox.Text;
            ClientData.Parameters.Add("@flat", MySqlDbType.VarChar).Value = FlatBox.Text;
            db.openConnection();
            if (ClientData.ExecuteNonQuery() == 1)
                MessageBox.Show("Данные клиента успешно сохранены");
            else
                MessageBox.Show("Ошибка сохранения");
            db.closeConnection();

            for (int i = 0; i < (dataGridView1.Rows.Count)-1; i++)
            {
                MySqlCommand OrderTable = new MySqlCommand("INSERT INTO `ordertable`(`ClientID` ,`CategoryBox`, `Product`, `Service`, `Cost`, `Amount`, `Worth`, `Duretion`, `OrderDate`, `OrderEndDate`, `TotalCost`, `Delivery`) VALUES (@clientid, @category, @product, @service, @cost, @amount, @worth, @duration, @orderdate, @orderenddate, @totalcost, @delivery)", db.getConnection());

                OrderTable.Parameters.Add("@clientid", MySqlDbType.Int32).Value = OrderID.Text;
                OrderTable.Parameters.Add("@category", MySqlDbType.VarChar).Value = dataGridView1.Rows[i].Cells[0].Value;
                OrderTable.Parameters.Add("@product", MySqlDbType.VarChar).Value = dataGridView1.Rows[i].Cells[1].Value;
                OrderTable.Parameters.Add("@service", MySqlDbType.VarChar).Value = dataGridView1.Rows[i].Cells[2].Value;
                OrderTable.Parameters.Add("@cost", MySqlDbType.Int32).Value = dataGridView1.Rows[i].Cells[3].Value;
                OrderTable.Parameters.Add("@amount", MySqlDbType.Int32).Value = dataGridView1.Rows[i].Cells[4].Value;
                OrderTable.Parameters.Add("@worth", MySqlDbType.Int32).Value = dataGridView1.Rows[i].Cells[5].Value;
                OrderTable.Parameters.Add("@duration", MySqlDbType.Int32).Value = dataGridView1.Rows[i].Cells[6].Value;
                OrderTable.Parameters.Add("@orderdate", MySqlDbType.DateTime).Value = dateTimePicker1.Value;
                OrderTable.Parameters.Add("@orderenddate", MySqlDbType.DateTime).Value = dateTimePicker2.Value;
                OrderTable.Parameters.Add("@totalcost", MySqlDbType.Int32).Value = EndCost.Text;
                OrderTable.Parameters.Add("@delivery", MySqlDbType.Int16).Value = del;

                db.openConnection();
                if (OrderTable.ExecuteNonQuery()==1)
                    MessageBox.Show("Данные заказа успешно сохранены");
                else
                    MessageBox.Show("Ошибка сохранения");
                db.closeConnection();
                
            }
            this.Hide();
            MainMenu MM = new MainMenu();
            MM.Show();
        }
    }
}
