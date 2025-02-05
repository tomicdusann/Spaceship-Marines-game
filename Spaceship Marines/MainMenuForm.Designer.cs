namespace Spaceship_Marines
{
    partial class MainMenuForm
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
            this.play_button = new System.Windows.Forms.Button();
            this.controls_button = new System.Windows.Forms.Button();
            this.quit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // play_button
            // 
            this.play_button.AutoSize = true;
            this.play_button.BackColor = System.Drawing.Color.Yellow;
            this.play_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play_button.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_button.Location = new System.Drawing.Point(546, 406);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(189, 56);
            this.play_button.TabIndex = 0;
            this.play_button.Text = "PLAY";
            this.play_button.UseVisualStyleBackColor = false;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // controls_button
            // 
            this.controls_button.AutoSize = true;
            this.controls_button.BackColor = System.Drawing.Color.Yellow;
            this.controls_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.controls_button.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controls_button.Location = new System.Drawing.Point(546, 509);
            this.controls_button.Name = "controls_button";
            this.controls_button.Size = new System.Drawing.Size(189, 56);
            this.controls_button.TabIndex = 1;
            this.controls_button.Text = "CONTROLS / RULES";
            this.controls_button.UseVisualStyleBackColor = false;
            this.controls_button.Click += new System.EventHandler(this.controls_button_Click);
            // 
            // quit_button
            // 
            this.quit_button.AutoSize = true;
            this.quit_button.BackColor = System.Drawing.Color.Yellow;
            this.quit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quit_button.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit_button.Location = new System.Drawing.Point(546, 612);
            this.quit_button.Name = "quit_button";
            this.quit_button.Size = new System.Drawing.Size(189, 56);
            this.quit_button.TabIndex = 2;
            this.quit_button.Text = "QUIT GAME";
            this.quit_button.UseVisualStyleBackColor = false;
            this.quit_button.Click += new System.EventHandler(this.quit_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label1.Location = new System.Drawing.Point(238, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(824, 117);
            this.label1.TabIndex = 3;
            this.label1.Text = "SPACESHIP MARINES";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Spaceship_Marines.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1264, 921);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quit_button);
            this.Controls.Add(this.controls_button);
            this.Controls.Add(this.play_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spaceship Marines";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.Button controls_button;
        private System.Windows.Forms.Button quit_button;
        private System.Windows.Forms.Label label1;
    }
}

