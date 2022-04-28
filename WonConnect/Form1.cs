using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WonConnect
{
    public partial class WonConnect : Form
    {
        // Attributs
        Connector connector = new Connector();
        List<Account> accounts = new List<Account>();
        char separator = new char();
        int cycle = new int();

        // Timer attributs 
        int minute_elapsed = 0;
        int minutes = 0;
        int secondes = 0;

        ///
        // WonConnect constructor
        ///
        public WonConnect()
        {
            InitializeComponent();        
        }

        ///
        // WonConnect form load event
        ///
        private void WonConnect_Load(object sender, EventArgs e)
        {
            // Controls manual setup on load
            this.panel_body.AutoScroll = true;

            // Load information from settings
            this.LoadOptionsFromSetting();
            this.LoadAccountsFromSettings();

            // Set timer and countdown
            this.minutes = this.cycle;
            this.UpdateTimerLabel();
            this.timer_connexion.Interval = 1000;
            this.timer_connexion.Start();

            // Display Accounts Panel
            this.DisplayAccountsPanels();

        }

        /// 
        // Timer tick event
        ///
        private void timer_connexion_Tick(object sender, EventArgs e)
        {
            if(this.TimeCountdown())
            {
                this.ConnexionCycle();
            }
        }

        ///
        // WonConnect form closing event
        ///
        private void WonConnect_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.SaveOptionsToSettings();
            this.SaveAccountsToSettings();
        }

        ///
        // Display methods
        ///
        private void DisplayAccountsPanels()
        {
            this.panel_body.Controls.Clear();

            for (int i = 0; i < accounts.Count; ++i)
            {
                if (i % 2 == 0) // if even
                    this.AddAccountPanel(accounts[i], Color.FromArgb(167, 189, 207));
                else
                    this.AddAccountPanel(accounts[i], Color.FromArgb(65, 105, 145));
            }
        }

        private void AddAccountPanel(Account account, Color color)
        {

            float font_size = 9.5f;
            string font_name = "Microsoft YaHei";
            // Main panel
            Panel main_panel = new Panel();
            main_panel.Height = 30;
            main_panel.Dock = DockStyle.Top;
            main_panel.Margin = new Padding(5);
            main_panel.BackColor = color;

            // Spacer panel
            Panel spacer_panel = new Panel();
            spacer_panel.Height = 5;
            spacer_panel.Dock = DockStyle.Top;
            spacer_panel.Margin = new Padding(5);
            spacer_panel.Padding = new Padding(5);
            spacer_panel.BackColor = Color.White;

            // Labels
            Label label_user = new Label();
            Label label_user_value = new Label();
            Label label_status = new Label();
            Label label_status_value = new Label();

            label_user.AutoSize = true;
            label_user.Location = new Point(label_user.Location.X+5, label_user.Location.Y + 6);
            label_user.Font = new Font(font_name, font_size, FontStyle.Bold);
            label_user.ForeColor = Color.White;
            label_user.Text = "Utilisateur:";

            label_user_value.AutoSize = true;
            label_user_value.Location = new Point(label_user.Location.X + 80, label_user.Location.Y);
            label_user_value.Font = new Font(font_name, font_size);
            label_user_value.ForeColor = Color.White;
            label_user_value.Text = account.Username;

            label_status.AutoSize = true;
            label_status.Location = new Point(label_user.Location.X + 180, label_user.Location.Y);
            label_status.Font = new Font(font_name, font_size, FontStyle.Bold);
            label_status.ForeColor = Color.White;
            label_status.Text = "Status:";

            label_status_value.AutoSize = true;
            label_status_value.Location = new Point(label_user.Location.X + 230, label_user.Location.Y);
            label_status_value.Font = new Font(font_name, font_size);
            label_status_value.ForeColor = Color.White;

            if (account.status.Contains("échoué") || account.status.Contains("Erreur"))
            {
                label_status_value.ForeColor = Color.Red;
            }
            else if(account.status.Contains("réussi"))
            {
                label_status_value.ForeColor = Color.Green;
            }
            
            label_status_value.Text = account.status;

            // Add controls
            main_panel.Controls.Add(label_user);
            main_panel.Controls.Add(label_user_value);
            main_panel.Controls.Add(label_status);
            main_panel.Controls.Add(label_status_value);
            this.panel_body.Controls.Add(main_panel);
            this.panel_body.Controls.Add(spacer_panel);
        }

        ///
        // Save accounts container to settings file
        ///
        private void SaveAccountsToSettings()
        {
            ResetAccountSettings();
            foreach (Account a in this.accounts)
            {
                Properties.Settings.Default.Accounts +=  a.Username + this.separator.ToString();
                Properties.Settings.Default.Passwords += a.Password + this.separator.ToString();
            }
            Properties.Settings.Default.Save();
        }
        ///
        // Parse accounts info saved to settings file into account container
        ///
        private void LoadAccountsFromSettings()
        {
            if (Properties.Settings.Default.Accounts != "" & Properties.Settings.Default.Passwords != "")
            {
                string[] usernames = Properties.Settings.Default.Accounts.Split(this.separator);
                string[] passwords = Properties.Settings.Default.Passwords.Split(this.separator);

                for (int i = 0; i < usernames.Length - 1; i++)
                {
                    this.accounts.Add(new Account(usernames[i], passwords[i]));
                }
            }
        }

        ///
        // Reset accounts information settings file
        ///
        private void ResetAccountSettings()
        {
            Properties.Settings.Default.Accounts = "";
            Properties.Settings.Default.Passwords = "";
            Properties.Settings.Default.Save();
        }

        private void LoadOptionsFromSetting()
        {
            if (Properties.Settings.Default.Cycle != null & Properties.Settings.Default.Separator != null)
            {
                this.cycle = Properties.Settings.Default.Cycle;
                this.separator = Properties.Settings.Default.Separator;
            }
            else
            {
                this.cycle = 24;
                this.separator = ',';

            }
        }

        private void SaveOptionsToSettings()
        {
            Properties.Settings.Default.Cycle = this.cycle;
            Properties.Settings.Default.Separator = this.separator;
            Properties.Settings.Default.Save();
        }


        ///
        // Buttons mouse over events
        ///
        private void button_add_MouseHover(object sender, EventArgs e)
        {
            this.button_add.BorderStyle = BorderStyle.FixedSingle;
            this.button_add.BorderStyle = BorderStyle.FixedSingle;
        }

        private void button_options_MouseHover(object sender, EventArgs e)
        {
            this.button_options.BorderStyle = BorderStyle.FixedSingle;
        }

        private void button_info_MouseHover(object sender, EventArgs e)
        {
            this.button_info.BorderStyle = BorderStyle.FixedSingle;
        }

        ///
        // Buttons mouse leave events
        ///
        private void button_add_MouseLeave(object sender, EventArgs e)
        {
            this.button_add.BorderStyle = BorderStyle.None;
        }

        private void button_options_MouseLeave(object sender, EventArgs e)
        {
            this.button_options.BorderStyle = BorderStyle.None;
        }

        private void button_info_MouseLeave(object sender, EventArgs e)
        {
            this.button_info.BorderStyle = BorderStyle.None;
        }

        /// 
        // Buttons click events
        ///
        private void button_add_MouseClick(object sender, MouseEventArgs e)
        {
            // Store account info into 2 array of strings
            string[] users = new string[accounts.Count];
            string[] passwords = new string[accounts.Count];

            for (int i=0;i<accounts.Count;i++)
            {
                users[i] = accounts[i].Username;
                passwords[i] = accounts[i].Password;
            }

            // Lunch Add form and retrive information after closure
            AddForm addForm = new AddForm(users, passwords, this.separator);
            if(addForm.ShowDialog() == DialogResult.OK)
            {
                accounts.Clear();
                for (int i=0;i< addForm.Usernames.Length;i++)
                {                
                    accounts.Add(new Account(addForm.Usernames[i], addForm.Passwords[i]));
                }
                this.DisplayAccountsPanels();
            }
        }

        private void button_options_MouseClick(object sender, MouseEventArgs e)
        {
            OptionForm optionForm = new OptionForm(this.cycle, this.separator);
            if(optionForm.ShowDialog() == DialogResult.OK)
            {
                if(this.cycle != optionForm.Cycle)
                {
                    this.cycle = optionForm.Cycle;
                    this.minutes = this.cycle;
                    this.secondes = 0;
                }
                this.separator = optionForm.Separator;

                if (optionForm.Reset_Account)
                    this.accounts.Clear();

                this.DisplayAccountsPanels();
            }
        }

        private void button_info_MouseClick(object sender, MouseEventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            infoForm.ShowDialog();
        }

        private void button_manual_connexion_Click(object sender, EventArgs e)
        {
            this.ConnexionCycle();
        }     

        ///
        // Timer utilities methods
        ///
        private void UpdateTimerLabel()
        {
            string sec_string = "";
            if (this.secondes < 10)
                sec_string = "0" + this.secondes;
            else
                sec_string = this.secondes.ToString();

            this.label_timer.Text = this.minutes + ":" + sec_string;
        }

        private bool TimeCountdown()
        {
            if(this.minutes == 0 && this.secondes == 0)
            {
                this.minutes = this.cycle;
                this.secondes = 0;
                this.UpdateTimerLabel();
                return true;
            }
            else if (this.secondes == 0)
            {
                this.minutes--;
                this.secondes = 59;
            }
            else
            {
                this.secondes--;
            }
            this.UpdateTimerLabel();
            return false;
        }

        ///
        // Connexion cycle
        ///
        private void ConnexionCycle()
        {
            foreach(Account a in accounts)
            {
                int response = connector.connect(a.Username, a.Password);
                // Connect and update account status
                if (response == 1)
                {
                    a.status = "Connexion réussi";
                }
                else if (response == 0)
                {
                    a.status = "Connexion échoué";
                }
                else if(response == -1)
                {
                    MessageBox.Show("Un problème de connexion est survenu! Il s'agit peut être de votre connexion internet ou du serveur www.wonaruto.com. Vérifiez votre connexion et l'accessibilité de www.wonaruto.com.", "Attention");

                    foreach(Account a2 in accounts)
                    {
                        a2.status = "Erreur connexion";
                    }
                    break;
                }             
            }
            this.label_last_connection_value.Text = DateTime.Now.ToString(@"MM\/dd h\:mm tt");
            this.DisplayAccountsPanels();
        }
    }
}
