namespace Him4isto4ka
{
    partial class MainMenu
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
            this.TotalOrders = new System.Windows.Forms.Button();
            this.NewOrder = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.UserLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TotalOrders
            // 
            this.TotalOrders.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalOrders.Location = new System.Drawing.Point(12, 50);
            this.TotalOrders.Name = "TotalOrders";
            this.TotalOrders.Size = new System.Drawing.Size(152, 57);
            this.TotalOrders.TabIndex = 0;
            this.TotalOrders.Text = "Оформленные заказы";
            this.TotalOrders.UseVisualStyleBackColor = true;
            this.TotalOrders.Click += new System.EventHandler(this.TotalOrders_Click);
            // 
            // NewOrder
            // 
            this.NewOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewOrder.Location = new System.Drawing.Point(191, 50);
            this.NewOrder.Name = "NewOrder";
            this.NewOrder.Size = new System.Drawing.Size(152, 57);
            this.NewOrder.TabIndex = 1;
            this.NewOrder.Text = "Новый заказ";
            this.NewOrder.UseVisualStyleBackColor = true;
            this.NewOrder.Click += new System.EventHandler(this.NewOrder_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(133, 125);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(94, 25);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // UserLable
            // 
            this.UserLable.AutoSize = true;
            this.UserLable.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLable.Location = new System.Drawing.Point(138, 28);
            this.UserLable.Name = "UserLable";
            this.UserLable.Size = new System.Drawing.Size(76, 19);
            this.UserLable.TabIndex = 3;
            this.UserLable.Text = "(username)";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 161);
            this.Controls.Add(this.UserLable);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.NewOrder);
            this.Controls.Add(this.TotalOrders);
            this.Name = "MainMenu";
            this.Text = "Главная";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TotalOrders;
        private System.Windows.Forms.Button NewOrder;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label UserLable;
    }
}