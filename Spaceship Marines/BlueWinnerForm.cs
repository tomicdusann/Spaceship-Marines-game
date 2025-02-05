using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spaceship_Marines
{
    public partial class BlueWinnerForm : Form
    {
        public BlueWinnerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenuForm mainForm = new MainMenuForm();
            mainForm.Show();
            this.Hide();    
        }
    }
}
