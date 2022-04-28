namespace WonConnect
{
    partial class OptionForm
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
            this.button_save = new System.Windows.Forms.Button();
            this.button_account_clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input_cycle = new System.Windows.Forms.TextBox();
            this.input_separator = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(120)))));
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_save.Location = new System.Drawing.Point(10, 102);
            this.button_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(207, 28);
            this.button_save.TabIndex = 4;
            this.button_save.Text = "Sauvegarder";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_account_clear
            // 
            this.button_account_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(120)))));
            this.button_account_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_account_clear.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_account_clear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_account_clear.Location = new System.Drawing.Point(10, 68);
            this.button_account_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_account_clear.Name = "button_account_clear";
            this.button_account_clear.Size = new System.Drawing.Size(207, 28);
            this.button_account_clear.TabIndex = 3;
            this.button_account_clear.Text = "Effacer les utilisateurs";
            this.button_account_clear.UseVisualStyleBackColor = false;
            this.button_account_clear.Click += new System.EventHandler(this.button_account_clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cycle de connexion (min)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(9, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Caractère de séparation";
            // 
            // input_cycle
            // 
            this.input_cycle.Location = new System.Drawing.Point(194, 11);
            this.input_cycle.Margin = new System.Windows.Forms.Padding(2);
            this.input_cycle.Name = "input_cycle";
            this.input_cycle.Size = new System.Drawing.Size(24, 20);
            this.input_cycle.TabIndex = 1;
            this.input_cycle.TextChanged += new System.EventHandler(this.input_cycle_TextChanged);
            // 
            // input_separator
            // 
            this.input_separator.Location = new System.Drawing.Point(194, 37);
            this.input_separator.Margin = new System.Windows.Forms.Padding(2);
            this.input_separator.Name = "input_separator";
            this.input_separator.Size = new System.Drawing.Size(24, 20);
            this.input_separator.TabIndex = 2;
            this.input_separator.TextChanged += new System.EventHandler(this.input_separator_TextChanged);
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(189)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(229, 139);
            this.Controls.Add(this.input_separator);
            this.Controls.Add(this.input_cycle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_account_clear);
            this.Controls.Add(this.button_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_account_clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_cycle;
        private System.Windows.Forms.TextBox input_separator;
    }
}