using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spaceship_Marines
{
    public partial class GameForm : Form
    {
        Component _blueShip, _redShip;

        private bool _blueMovingLeft = false, _blueMovingRight = false;
        private bool _redMovingLeft = false, _redMovingRight = false;

        int _redID = 1, _blueID = 2;
        int pointsRed = 0, pointsBlue = 0;

        private Timer gameTimer;    // timer works like a pulse, or like core clock - every 16ms in this case the events in Tick function will trigger - main loop that is always present in the background to check
                                    // on game state

        private List<Timer> explosionTimers = new List<Timer>();

        private DateTime lastTimeBlueShot;
        private DateTime lastTimeRedShot;

        private List<Component> bullets = new List<Component>();            // need to have a list because we can have multiple bullets in one frame
        private List<Component> bulletsToRemove = new List<Component>();    // need second list beacause .NET won't let me doint regular iteration with list element and in that same list in the same time removing items

        public GameForm()
        {
            InitializeComponent();                          // initializes form
            InitializeAllGameCompnents();                   // initializes all game components

            this.KeyDown += GameForm_KeyDown;
            this.KeyUp += GameForm_KeyUp;

            this.DoubleBuffered = true;                     // this is the part I needed to import to prevent flickering 

            lastTimeBlueShot = DateTime.MinValue;
            lastTimeRedShot = DateTime.MinValue;

            gameTimer = new Timer();
            gameTimer.Interval = 16;                        // shorter interval more fluently game works
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();
        }

        public void InitializeAllGameCompnents()
        {
            InitializeBlueShip();
            InitializeRedShip();
        }

        public void InitializeBlueShip()
        {
            _blueShip = new Component(145, 200);
            _blueShip.Left = Width / 2 - _blueShip.Width / 2;   // distance between left edge of window to the left edge of element just like margins 
            _blueShip.Top = Height - _blueShip.Height - 10;     // distance between top of the window and the top of the element just like margins
            _blueShip.Image = Properties.Resources.blueship;
            Controls.Add(_blueShip);                            // ability to control element from this moment of initialization now on 
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            const int speed = 50;                               // how many pixels every 16ms ship passes

            if (_blueMovingLeft && _blueShip.Left > 0)
                _blueShip.Left -= speed;
            if (_blueMovingRight && _blueShip.Right < this.Width)
                _blueShip.Left += speed;

            if (_redMovingLeft && _redShip.Left > 0)
                _redShip.Left -= speed;
            if (_redMovingRight && _redShip.Right < this.Width)
                _redShip.Left += speed;



            // bullets moving
            const int bulletSpeed = 50;

            foreach (var bullet in bullets)
            {
                if (bullet.Tag.ToString() == "bluebullet")
                    bullet.Top -= bulletSpeed;                  // blue bullet going up -> top margin getting smaller
                else if (bullet.Tag.ToString() == "redbullet")
                    bullet.Top += bulletSpeed;                  // red bullet goind down -> top margin getting bigger

                // Uklanjanje metka ako izađe iz ekrana
                if (bullet.Top < 0 || bullet.Top > this.Height)
                {
                    bulletsToRemove.Add(bullet);    
                }
            }

            foreach (var bullet in bulletsToRemove)
            {
                Controls.Remove(bullet);
                bullets.Remove(bullet);
            }

            CheckForCollisions();
        }

        public void CheckForCollisions()
        {
            foreach (var bullet in bullets)
            {
                if (bullet.Bounds.IntersectsWith(_blueShip.Bounds) && bullet.Tag.ToString() == "redbullet")
                {
                    // blue ship gets hit by red bullet
                    ShowExplosion(_blueID, _blueShip);
                    redPoints.Text = (++pointsRed).ToString();

                    if(pointsRed == 10)
                    {
                        RedWinnerForm redWins = new RedWinnerForm();
                        redWins.Show();
                        this.Hide();
                    }

                    bulletsToRemove.Add(bullet);
                }
                else if (bullet.Bounds.IntersectsWith(_redShip.Bounds) && bullet.Tag.ToString() == "bluebullet")
                {
                    // red ship gets hit by blue bullet
                    ShowExplosion(_redID, _redShip);
                    bluePoints.Text = (++pointsBlue).ToString();

                    if(pointsBlue == 10)
                    {
                        BlueWinnerForm blueWins = new BlueWinnerForm();
                        blueWins.Show();
                        this.Hide();
                    }
                    bulletsToRemove.Add(bullet);
                }
            }

            foreach(var bullet in bulletsToRemove)
            {
                Controls.Remove(bullet);
                bullets.Remove(bullet);
            }
        }

        public void ShowExplosion(int hittedShipID, Component ship)
        { 
            Component explosion = InitializeExplosion(hittedShipID, ship);
            Controls.Add(explosion);
            explosion.BringToFront();
            explosion.BringToFront();
            explosion.Refresh();

            Timer explosionTimer = new Timer { Interval = 300 };
            explosionTimer.Tick += ExplosionTimer_Tick;                 // what events trigger on every timer interval
            explosionTimer.Tag = explosion;                             // sets essentially a reference to specific explosion object
            explosionTimer.Start();
            explosionTimers.Add(explosionTimer);
        }

        private void ExplosionTimer_Tick(object sender, EventArgs e)
        {
            Timer timer = sender as Timer; // to see if timer which calls its tick

            if(timer != null)
            {
                Component explosion = timer.Tag as Component;
                if(explosion != null)
                {
                    Controls.Remove(explosion);     // here we don't make lists for explosions because they are not moving like bullets, they are not dynamic
                                                    // explosions are just a temporary objects that last a fraction of a time 
                }

                timer.Stop();
                timer.Dispose();
                explosionTimers.Remove(timer);
            }
        }

        public Component InitializeExplosion(int hittedShipID, Component ship)
        {
            Component explosion = new Component(50, 50);
            explosion.Parent = ship;
            explosion.Image = Properties.Resources.damage;
            explosion.Left = ship.Left + ship.Width/2 - explosion.Width/2;

            if(hittedShipID == _blueID)
            {
                explosion.Top = ship.Top + ship.Height/2;
            }
            
            if(hittedShipID == _redID) 
            {
                explosion.Top = ship.Top + ship.Height/2;
            }

            explosion.BackColor = Color.Transparent;
            return explosion;
        }

        public void InitializeRedShip()
        {
            _redShip = new Component(135, 200);
            _redShip.Left = Width / 2 - _redShip.Width / 2;
            _redShip.Top = 50;
            _redShip.Image = Properties.Resources.redship;
            Controls.Add(_redShip);
        }

        public void FireBullet(Component shooter, int shooterId)
        {
            Component bullet = InitializeBullet(shooter, shooterId);
            Controls.Add(bullet);
            bullets.Add(bullet);    
        }

        public Component InitializeBullet(Component shooter, int shooterId) 
        {
            Component bullet = new Component(15, 52);
            bullet.Image = (shooterId == 2) ? Properties.Resources.bluebullet : Properties.Resources.redbullet;
            bullet.Left = shooter.Left + (shooter.Width / 2) - (bullet.Width / 2); // bullet centered by the ship center
            bullet.Top = (shooterId == 2) ? shooter.Top - bullet.Height : shooter.Bottom; // vertical position depending on who is the shooter
            bullet.Tag = (shooterId == 2) ? "bluebullet" : "redbullet"; // tag to seperate logically bullets to know which is which blue or red
            bullet.BackColor = Color.Transparent; // to blend with background

            return bullet; 
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    _blueMovingLeft = true;
                    break;
                case Keys.Right:
                    _blueMovingRight = true;
                    break;
                case Keys.A:
                    _redMovingLeft = true;
                    break;
                case Keys.D:
                    _redMovingRight = true;
                    break;
                case Keys.Space:
                    if((DateTime.Now - lastTimeRedShot).TotalSeconds >= 1)
                    {
                        FireBullet(_redShip, _redID);
                        lastTimeRedShot = DateTime.Now;
                    }
                    break;
                case Keys.Enter:
                    if((DateTime.Now - lastTimeBlueShot).TotalSeconds >= 1)
                    {
                        FireBullet(_blueShip, _blueID);
                        lastTimeBlueShot = DateTime.Now;
                    }
                    break;
                case Keys.Escape:
                    MainMenuForm mainMenuForm = new MainMenuForm();
                    mainMenuForm.Show();
                    this.Close();
                    break;

            }
        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    _blueMovingLeft = false;
                    break;
                case Keys.Right:
                    _blueMovingRight = false;
                    break;
                case Keys.A:
                    _redMovingLeft = false;
                    break;
                case Keys.D:
                    _redMovingRight = false;
                    break;
            }

        }
    }
}
