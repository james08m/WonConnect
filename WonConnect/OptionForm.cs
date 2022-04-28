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
    public partial class OptionForm : Form
    {
        public int Cycle = new int();
        public char Separator = new char();
        public bool Reset_Account = false;

        public OptionForm(int cycle, char separator)
        {
            InitializeComponent();
            Cycle = cycle;
            Separator = separator;
        }

        private void OptionForm_Load(object sender, EventArgs e)
        {
            input_cycle.Text = this.Cycle.ToString();
            input_separator.Text = this.Separator.ToString();
        }

        private void input_cycle_TextChanged(object sender, EventArgs e)
        {
            int i = 0;       
            bool isNumeric = int.TryParse(input_cycle.Text, out i);
            if (isNumeric)
                this.Cycle = i;
            else
                input_cycle.Text = Cycle.ToString();
        }

        private void input_separator_TextChanged(object sender, EventArgs e)
        {
            if (input_separator.Text.Length > 1)
                input_separator.Text = this.Separator.ToString();
            else if(input_separator.Text.Length == 1)
                this.Separator = input_separator.Text[0];
        }

        private void button_account_clear_Click(object sender, EventArgs e)
        {
            this.Reset_Account = true;
            MessageBox.Show("Sauvegardez pour confirmer la suppression des comptes.", "Information");
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (input_separator.Text.Length == 0)
            {
                MessageBox.Show("Le champ caractère de séparation ne peut être vide!", "Attention");
            }
            else
            {
                if (this.Reset_Account)
                {
                    if(MessageBox.Show("Les informations reliées aux utilisateurs seront éffacées. Voulez-vous vraiment les effacer?", "Attention", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        this.Reset_Account = false;
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
