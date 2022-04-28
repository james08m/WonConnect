namespace WonConnect
{
    partial class WonConnect
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WonConnect));
            this.panel_header = new System.Windows.Forms.Panel();
            this.label_last_connection_value = new System.Windows.Forms.Label();
            this.label_last_connection = new System.Windows.Forms.Label();
            this.label_timer = new System.Windows.Forms.Label();
            this.label_next_connection = new System.Windows.Forms.Label();
            this.button_info = new System.Windows.Forms.Panel();
            this.button_options = new System.Windows.Forms.Panel();
            this.button_add = new System.Windows.Forms.Panel();
            this.panel_body = new System.Windows.Forms.Panel();
            this.button_manual_connexion = new System.Windows.Forms.Button();
            this.timer_connexion = new System.Windows.Forms.Timer(this.components);
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(160)))), ((int)(((byte)(184)))));
            this.panel_header.Controls.Add(this.label_last_connection_value);
            this.panel_header.Controls.Add(this.label_last_connection);
            this.panel_header.Controls.Add(this.label_timer);
            this.panel_header.Controls.Add(this.label_next_connection);
            this.panel_header.Controls.Add(this.button_info);
            this.panel_header.Controls.Add(this.button_options);
            this.panel_header.Controls.Add(this.button_add);
            resources.ApplyResources(this.panel_header, "panel_header");
            this.panel_header.Name = "panel_header";
            // 
            // label_last_connection_value
            // 
            resources.ApplyResources(this.label_last_connection_value, "label_last_connection_value");
            this.label_last_connection_value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(120)))));
            this.label_last_connection_value.Name = "label_last_connection_value";
            // 
            // label_last_connection
            // 
            resources.ApplyResources(this.label_last_connection, "label_last_connection");
            this.label_last_connection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(120)))));
            this.label_last_connection.Name = "label_last_connection";
            // 
            // label_timer
            // 
            resources.ApplyResources(this.label_timer, "label_timer");
            this.label_timer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(120)))));
            this.label_timer.Name = "label_timer";
            // 
            // label_next_connection
            // 
            resources.ApplyResources(this.label_next_connection, "label_next_connection");
            this.label_next_connection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(120)))));
            this.label_next_connection.Name = "label_next_connection";
            // 
            // button_info
            // 
            this.button_info.BackgroundImage = global::WonConnect.Properties.Resources.info;
            resources.ApplyResources(this.button_info, "button_info");
            this.button_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_info.Name = "button_info";
            this.button_info.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_info_MouseClick);
            this.button_info.MouseLeave += new System.EventHandler(this.button_info_MouseLeave);
            this.button_info.MouseHover += new System.EventHandler(this.button_info_MouseHover);
            // 
            // button_options
            // 
            this.button_options.BackgroundImage = global::WonConnect.Properties.Resources.gear;
            resources.ApplyResources(this.button_options, "button_options");
            this.button_options.Name = "button_options";
            this.button_options.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_options_MouseClick);
            this.button_options.MouseLeave += new System.EventHandler(this.button_options_MouseLeave);
            this.button_options.MouseHover += new System.EventHandler(this.button_options_MouseHover);
            // 
            // button_add
            // 
            this.button_add.BackgroundImage = global::WonConnect.Properties.Resources.add;
            resources.ApplyResources(this.button_add, "button_add");
            this.button_add.Name = "button_add";
            this.button_add.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_add_MouseClick);
            this.button_add.MouseLeave += new System.EventHandler(this.button_add_MouseLeave);
            this.button_add.MouseHover += new System.EventHandler(this.button_add_MouseHover);
            // 
            // panel_body
            // 
            this.panel_body.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel_body, "panel_body");
            this.panel_body.Name = "panel_body";
            // 
            // button_manual_connexion
            // 
            this.button_manual_connexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(120)))));
            resources.ApplyResources(this.button_manual_connexion, "button_manual_connexion");
            this.button_manual_connexion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_manual_connexion.Name = "button_manual_connexion";
            this.button_manual_connexion.UseVisualStyleBackColor = false;
            this.button_manual_connexion.Click += new System.EventHandler(this.button_manual_connexion_Click);
            // 
            // timer_connexion
            // 
            this.timer_connexion.Tick += new System.EventHandler(this.timer_connexion_Tick);
            // 
            // WonConnect
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(189)))), ((int)(((byte)(207)))));
            this.Controls.Add(this.button_manual_connexion);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WonConnect";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WonConnect_FormClosing);
            this.Load += new System.EventHandler(this.WonConnect_Load);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Panel button_info;
        private System.Windows.Forms.Panel button_options;
        private System.Windows.Forms.Panel button_add;
        private System.Windows.Forms.Button button_manual_connexion;
        private System.Windows.Forms.Label label_next_connection;
        private System.Windows.Forms.Timer timer_connexion;
        private System.Windows.Forms.Label label_timer;
        private System.Windows.Forms.Label label_last_connection_value;
        private System.Windows.Forms.Label label_last_connection;
    }
}

