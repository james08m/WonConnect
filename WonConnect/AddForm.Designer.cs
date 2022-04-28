namespace WonConnect
{
    partial class AddForm
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
            this.input_username = new System.Windows.Forms.TextBox();
            this.input_password = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.list_accounts = new System.Windows.Forms.ListBox();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_username
            // 
            this.input_username.Dock = System.Windows.Forms.DockStyle.Left;
            this.input_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_username.Location = new System.Drawing.Point(9, 8);
            this.input_username.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.input_username.Name = "input_username";
            this.input_username.Size = new System.Drawing.Size(132, 20);
            this.input_username.TabIndex = 0;
            this.input_username.Text = "Utilisateur";
            this.input_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // input_password
            // 
            this.input_password.Dock = System.Windows.Forms.DockStyle.Right;
            this.input_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_password.Location = new System.Drawing.Point(148, 8);
            this.input_password.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.input_password.Name = "input_password";
            this.input_password.Size = new System.Drawing.Size(132, 20);
            this.input_password.TabIndex = 1;
            this.input_password.Text = "Mot de passe";
            this.input_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(120)))));
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_add.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(9, 35);
            this.button_add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(271, 23);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "Ajouter";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // list_accounts
            // 
            this.list_accounts.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_accounts.FormattingEnabled = true;
            this.list_accounts.ItemHeight = 19;
            this.list_accounts.Location = new System.Drawing.Point(9, 64);
            this.list_accounts.Name = "list_accounts";
            this.list_accounts.Size = new System.Drawing.Size(271, 137);
            this.list_accounts.TabIndex = 3;
            // 
            // button_remove
            // 
            this.button_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(120)))));
            this.button_remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_remove.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_remove.Location = new System.Drawing.Point(9, 217);
            this.button_remove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(132, 23);
            this.button_remove.TabIndex = 4;
            this.button_remove.Text = "Enlever";
            this.button_remove.UseVisualStyleBackColor = false;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_OK
            // 
            this.button_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(120)))));
            this.button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_OK.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OK.Location = new System.Drawing.Point(148, 217);
            this.button_OK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(132, 23);
            this.button_OK.TabIndex = 5;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(189)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(289, 246);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.list_accounts);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.input_password);
            this.Controls.Add(this.input_username);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_username;
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ListBox list_accounts;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_OK;
    }
}