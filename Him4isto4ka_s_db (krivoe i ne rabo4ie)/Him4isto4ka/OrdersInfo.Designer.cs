namespace Him4isto4ka
{
    partial class OrdersInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.OrderNum = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.ClientSurname = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Patronymic = new System.Windows.Forms.Label();
            this.ClientPatronymic = new System.Windows.Forms.TextBox();
            this.label000 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.TextBox();
            this.ClientPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pickup = new System.Windows.Forms.RadioButton();
            this.Delivery = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FlatBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.HouseBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.StreedBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "№ заказа";
            // 
            // OrderNum
            // 
            this.OrderNum.AutoSize = true;
            this.OrderNum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderNum.Location = new System.Drawing.Point(86, 9);
            this.OrderNum.Name = "OrderNum";
            this.OrderNum.Size = new System.Drawing.Size(17, 19);
            this.OrderNum.TabIndex = 1;
            this.OrderNum.Text = "0";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surname.Location = new System.Drawing.Point(12, 33);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(72, 19);
            this.Surname.TabIndex = 2;
            this.Surname.Text = "Фамилия";
            // 
            // ClientSurname
            // 
            this.ClientSurname.Enabled = false;
            this.ClientSurname.Location = new System.Drawing.Point(90, 32);
            this.ClientSurname.Name = "ClientSurname";
            this.ClientSurname.Size = new System.Drawing.Size(278, 20);
            this.ClientSurname.TabIndex = 3;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Patronymic
            // 
            this.Patronymic.AutoSize = true;
            this.Patronymic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Patronymic.Location = new System.Drawing.Point(12, 57);
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Size = new System.Drawing.Size(73, 19);
            this.Patronymic.TabIndex = 4;
            this.Patronymic.Text = "Отчество";
            // 
            // ClientPatronymic
            // 
            this.ClientPatronymic.Enabled = false;
            this.ClientPatronymic.Location = new System.Drawing.Point(90, 58);
            this.ClientPatronymic.Name = "ClientPatronymic";
            this.ClientPatronymic.Size = new System.Drawing.Size(278, 20);
            this.ClientPatronymic.TabIndex = 5;
            // 
            // label000
            // 
            this.label000.AutoSize = true;
            this.label000.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label000.Location = new System.Drawing.Point(408, 33);
            this.label000.Name = "label000";
            this.label000.Size = new System.Drawing.Size(37, 19);
            this.label000.TabIndex = 6;
            this.label000.Text = "Имя";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Phone.Location = new System.Drawing.Point(408, 57);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(65, 19);
            this.Phone.TabIndex = 7;
            this.Phone.Text = "Телефон";
            // 
            // ClientName
            // 
            this.ClientName.Enabled = false;
            this.ClientName.Location = new System.Drawing.Point(482, 32);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(278, 20);
            this.ClientName.TabIndex = 8;
            // 
            // ClientPhone
            // 
            this.ClientPhone.Enabled = false;
            this.ClientPhone.Location = new System.Drawing.Point(482, 58);
            this.ClientPhone.Name = "ClientPhone";
            this.ClientPhone.Size = new System.Drawing.Size(278, 20);
            this.ClientPhone.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(152, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Сотрудник";
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.User.Location = new System.Drawing.Point(240, 9);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(21, 19);
            this.User.TabIndex = 11;
            this.User.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(478, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Дата приёма";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category,
            this.Product,
            this.OrderType,
            this.Cost,
            this.amount,
            this.TotalCost,
            this.duration});
            this.dataGridView1.Location = new System.Drawing.Point(16, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 139);
            this.dataGridView1.TabIndex = 14;
            // 
            // Category
            // 
            this.Category.HeaderText = "Категория";
            this.Category.Name = "Category";
            // 
            // Product
            // 
            this.Product.HeaderText = "Изделие";
            this.Product.Name = "Product";
            // 
            // OrderType
            // 
            this.OrderType.HeaderText = "Вид услугу";
            this.OrderType.Name = "OrderType";
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Цена";
            this.Cost.Name = "Cost";
            // 
            // amount
            // 
            this.amount.HeaderText = "Количество";
            this.amount.Name = "amount";
            // 
            // TotalCost
            // 
            this.TotalCost.HeaderText = "Стоимость";
            this.TotalCost.Name = "TotalCost";
            // 
            // duration
            // 
            this.duration.HeaderText = "Длительность";
            this.duration.Name = "duration";
            // 
            // Pickup
            // 
            this.Pickup.AutoCheck = false;
            this.Pickup.AutoSize = true;
            this.Pickup.Enabled = false;
            this.Pickup.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pickup.Location = new System.Drawing.Point(214, 229);
            this.Pickup.Name = "Pickup";
            this.Pickup.Size = new System.Drawing.Size(104, 23);
            this.Pickup.TabIndex = 15;
            this.Pickup.TabStop = true;
            this.Pickup.Text = "Самовывоз";
            this.Pickup.UseVisualStyleBackColor = true;
            // 
            // Delivery
            // 
            this.Delivery.AutoCheck = false;
            this.Delivery.AutoSize = true;
            this.Delivery.Enabled = false;
            this.Delivery.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delivery.Location = new System.Drawing.Point(482, 229);
            this.Delivery.Name = "Delivery";
            this.Delivery.Size = new System.Drawing.Size(89, 23);
            this.Delivery.TabIndex = 16;
            this.Delivery.TabStop = true;
            this.Delivery.Text = "Доставка";
            this.Delivery.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FlatBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.HouseBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.StreedBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CityBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(16, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 46);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // FlatBox
            // 
            this.FlatBox.Enabled = false;
            this.FlatBox.Location = new System.Drawing.Point(638, 17);
            this.FlatBox.Name = "FlatBox";
            this.FlatBox.Size = new System.Drawing.Size(100, 20);
            this.FlatBox.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(558, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Квартира";
            // 
            // HouseBox
            // 
            this.HouseBox.Enabled = false;
            this.HouseBox.Location = new System.Drawing.Point(425, 15);
            this.HouseBox.Name = "HouseBox";
            this.HouseBox.Size = new System.Drawing.Size(100, 20);
            this.HouseBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(381, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Дом";
            // 
            // StreedBox
            // 
            this.StreedBox.Enabled = false;
            this.StreedBox.Location = new System.Drawing.Point(252, 15);
            this.StreedBox.Name = "StreedBox";
            this.StreedBox.Size = new System.Drawing.Size(100, 20);
            this.StreedBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(195, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Улица";
            // 
            // CityBox
            // 
            this.CityBox.Enabled = false;
            this.CityBox.Location = new System.Drawing.Point(61, 15);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(100, 20);
            this.CityBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Город";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(22, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Сумма";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Total.Location = new System.Drawing.Point(82, 314);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(17, 19);
            this.Total.TabIndex = 19;
            this.Total.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(478, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Дата выдачи";
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(572, 342);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(91, 28);
            this.Back.TabIndex = 22;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(669, 342);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(91, 28);
            this.Exit.TabIndex = 23;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(583, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(177, 20);
            this.dateTimePicker1.TabIndex = 52;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(583, 312);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(177, 20);
            this.dateTimePicker2.TabIndex = 53;
            // 
            // OrdersInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 374);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Delivery);
            this.Controls.Add(this.Pickup);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.User);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClientPhone);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label000);
            this.Controls.Add(this.ClientPatronymic);
            this.Controls.Add(this.Patronymic);
            this.Controls.Add(this.ClientSurname);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.OrderNum);
            this.Controls.Add(this.label1);
            this.Name = "OrdersInfo";
            this.Text = "Подробная информация о заказе";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OrderNum;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.TextBox ClientSurname;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClientPhone;
        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label label000;
        private System.Windows.Forms.TextBox ClientPatronymic;
        private System.Windows.Forms.Label Patronymic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox FlatBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox HouseBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox StreedBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton Delivery;
        private System.Windows.Forms.RadioButton Pickup;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}