namespace Spaceship_Marines
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.redPoints = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bluePoints = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 16;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(1092, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESC: exit MAIN MENU";
            // 
            // redPoints
            // 
            this.redPoints.AutoSize = true;
            this.redPoints.BackColor = System.Drawing.Color.Black;
            this.redPoints.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redPoints.ForeColor = System.Drawing.Color.Red;
            this.redPoints.Location = new System.Drawing.Point(12, 9);
            this.redPoints.Name = "redPoints";
            this.redPoints.Size = new System.Drawing.Size(31, 36);
            this.redPoints.TabIndex = 1;
            this.redPoints.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(40, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = ":";
            // 
            // bluePoints
            // 
            this.bluePoints.AutoSize = true;
            this.bluePoints.BackColor = System.Drawing.Color.Black;
            this.bluePoints.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bluePoints.ForeColor = System.Drawing.Color.Blue;
            this.bluePoints.Location = new System.Drawing.Point(58, 9);
            this.bluePoints.Name = "bluePoints";
            this.bluePoints.Size = new System.Drawing.Size(31, 36);
            this.bluePoints.TabIndex = 3;
            this.bluePoints.Text = "0";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Spaceship_Marines.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1264, 921);
            this.Controls.Add(this.bluePoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.redPoints);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spaceship Marines";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label redPoints;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label bluePoints;
    }
}