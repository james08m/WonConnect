namespace WonConnect
{
    partial class InfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.panel_author_image = new System.Windows.Forms.Panel();
            this.panel_information = new System.Windows.Forms.Panel();
            this.textbox_information = new System.Windows.Forms.TextBox();
            this.label_author_name = new System.Windows.Forms.Label();
            this.label_clan = new System.Windows.Forms.Label();
            this.panel_information.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_author_image
            // 
            this.panel_author_image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(120)))));
            this.panel_author_image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_author_image.BackgroundImage")));
            this.panel_author_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_author_image.Location = new System.Drawing.Point(11, 7);
            this.panel_author_image.Name = "panel_author_image";
            this.panel_author_image.Size = new System.Drawing.Size(38, 38);
            this.panel_author_image.TabIndex = 0;
            // 
            // panel_information
            // 
            this.panel_information.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(160)))), ((int)(((byte)(184)))));
            this.panel_information.Controls.Add(this.textbox_information);
            this.panel_information.Location = new System.Drawing.Point(59, 1);
            this.panel_information.Name = "panel_information";
            this.panel_information.Size = new System.Drawing.Size(348, 219);
            this.panel_information.TabIndex = 1;
            // 
            // textbox_information
            // 
            this.textbox_information.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(160)))), ((int)(((byte)(184)))));
            this.textbox_information.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_information.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_information.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textbox_information.Location = new System.Drawing.Point(6, 6);
            this.textbox_information.Multiline = true;
            this.textbox_information.Name = "textbox_information";
            this.textbox_information.ReadOnly = true;
            this.textbox_information.Size = new System.Drawing.Size(339, 213);
            this.textbox_information.TabIndex = 0;
            this.textbox_information.Text = resources.GetString("textbox_information.Text");
            // 
            // label_author_name
            // 
            this.label_author_name.AutoSize = true;
            this.label_author_name.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_author_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(120)))));
            this.label_author_name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_author_name.Location = new System.Drawing.Point(6, 45);
            this.label_author_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_author_name.Name = "label_author_name";
            this.label_author_name.Size = new System.Drawing.Size(48, 19);
            this.label_author_name.TabIndex = 9;
            this.label_author_name.Text = "Naixn";
            // 
            // label_clan
            // 
            this.label_clan.AutoSize = true;
            this.label_clan.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_clan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(120)))));
            this.label_clan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_clan.Location = new System.Drawing.Point(10, 61);
            this.label_clan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_clan.Name = "label_clan";
            this.label_clan.Size = new System.Drawing.Size(39, 16);
            this.label_clan.TabIndex = 10;
            this.label_clan.Text = "(SoW)";
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(189)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(405, 218);
            this.Controls.Add(this.label_clan);
            this.Controls.Add(this.label_author_name);
            this.Controls.Add(this.panel_information);
            this.Controls.Add(this.panel_author_image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Information";
            this.Load += new System.EventHandler(this.InfoForm_Load);
            this.panel_information.ResumeLayout(false);
            this.panel_information.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_author_image;
        private System.Windows.Forms.Panel panel_information;
        private System.Windows.Forms.Label label_author_name;
        private System.Windows.Forms.TextBox textbox_information;
        private System.Windows.Forms.Label label_clan;
    }
}