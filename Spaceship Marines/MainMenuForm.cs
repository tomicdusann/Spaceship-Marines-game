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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            gameForm.Show();
            this.Hide();
        }

        private void controls_button_Click(object sender, EventArgs e)
        {
            ControlsForm controlsForm = new ControlsForm();
            controlsForm.Show();
            this.Hide();
        }

        private void quit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
