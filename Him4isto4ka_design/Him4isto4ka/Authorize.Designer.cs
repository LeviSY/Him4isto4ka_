namespace Him4isto4ka
{
    partial class Authorize
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.AuthorizeButton = new System.Windows.Forms.Button();
            this.passfield = new System.Windows.Forms.TextBox();
            this.loginfield = new System.Windows.Forms.TextBox();
            this.LoginLable = new System.Windows.Forms.Label();
            this.PassLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(16, 59);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(110, 38);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AuthorizeButton
            // 
            this.AuthorizeButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorizeButton.Location = new System.Drawing.Point(182, 59);
            this.AuthorizeButton.Name = "AuthorizeButton";
            this.AuthorizeButton.Size = new System.Drawing.Size(126, 38);
            this.AuthorizeButton.TabIndex = 1;
            this.AuthorizeButton.Text = "Авторизация";
            this.AuthorizeButton.UseVisualStyleBackColor = true;
            this.AuthorizeButton.Click += new System.EventHandler(this.AuthorizeButton_Click);
            // 
            // passfield
            // 
            this.passfield.Location = new System.Drawing.Point(79, 33);
            this.passfield.Name = "passfield";
            this.passfield.Size = new System.Drawing.Size(229, 20);
            this.passfield.TabIndex = 2;
            this.passfield.UseSystemPasswordChar = true;
            // 
            // loginfield
            // 
            this.loginfield.Location = new System.Drawing.Point(79, 10);
            this.loginfield.Name = "loginfield";
            this.loginfield.Size = new System.Drawing.Size(229, 20);
            this.loginfield.TabIndex = 3;
            // 
            // LoginLable
            // 
            this.LoginLable.AutoSize = true;
            this.LoginLable.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLable.Location = new System.Drawing.Point(12, 9);
            this.LoginLable.Name = "LoginLable";
            this.LoginLable.Size = new System.Drawing.Size(52, 19);
            this.LoginLable.TabIndex = 4;
            this.LoginLable.Text = "Логин";
            // 
            // PassLable
            // 
            this.PassLable.AutoSize = true;
            this.PassLable.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassLable.Location = new System.Drawing.Point(12, 32);
            this.PassLable.Name = "PassLable";
            this.PassLable.Size = new System.Drawing.Size(58, 19);
            this.PassLable.TabIndex = 5;
            this.PassLable.Text = "Пароль";
            // 
            // Authorize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 98);
            this.Controls.Add(this.PassLable);
            this.Controls.Add(this.LoginLable);
            this.Controls.Add(this.loginfield);
            this.Controls.Add(this.passfield);
            this.Controls.Add(this.AuthorizeButton);
            this.Controls.Add(this.ExitButton);
            this.Name = "Authorize";
            this.Text = "Авторизация сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AuthorizeButton;
        public System.Windows.Forms.TextBox passfield;
        public System.Windows.Forms.TextBox loginfield;
        private System.Windows.Forms.Label LoginLable;
        private System.Windows.Forms.Label PassLable;
    }
}