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
    public partial class AddForm : Form
    {
        public string[] Usernames;
        public string[] Passwords;
        char Separator;

        public AddForm(string[] users, string[] passwords, char separator)
        {
            InitializeComponent();
            this.Separator = separator;
            for(int i = 0; i < users.Length; i++)  
            {
                list_accounts.Items.Add(users[i] + this.Separator.ToString() + passwords[i]);
            }                    
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if(this.input_username.Text != "" && this.input_password.Text != "")
            {
                this.list_accounts.Items.Add(this.input_username.Text + this.Separator.ToString() + this.input_password.Text);
                this.input_username.Text = "";
                this.input_password.Text = "";
            }         
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            this.list_accounts.Items.Remove(list_accounts.SelectedItem);
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            Usernames = new string[list_accounts.Items.Count];
            Passwords = new string[list_accounts.Items.Count];

            for(int i = 0; i < list_accounts.Items.Count; i++)
            {
                string[] info = list_accounts.Items[i].ToString().Split(this.Separator);
                Usernames[i] = info[0];
                Passwords[i] = info[1];
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
