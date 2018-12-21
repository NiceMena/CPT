namespace SimpleSideScrollingGameNiceM
{
    partial class frmScrollingGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScrollingGame));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.picCoin3 = new System.Windows.Forms.PictureBox();
            this.lblPoints = new System.Windows.Forms.Label();
            this.picDoor1 = new System.Windows.Forms.PictureBox();
            this.picCoin2 = new System.Windows.Forms.PictureBox();
            this.picDoor2 = new System.Windows.Forms.PictureBox();
            this.picCoin1 = new System.Windows.Forms.PictureBox();
            this.picPlatform1 = new System.Windows.Forms.PictureBox();
            this.picPlatform2 = new System.Windows.Forms.PictureBox();
            this.picCoin4 = new System.Windows.Forms.PictureBox();
            this.picKey1 = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.picPlatform3 = new System.Windows.Forms.PictureBox();
            this.picPlatform5 = new System.Windows.Forms.PictureBox();
            this.picPlatform4 = new System.Windows.Forms.PictureBox();
            this.picPlatform6 = new System.Windows.Forms.PictureBox();
            this.picPlatform8 = new System.Windows.Forms.PictureBox();
            this.picPlatform7 = new System.Windows.Forms.PictureBox();
            this.picCoin5 = new System.Windows.Forms.PictureBox();
            this.picCoin8 = new System.Windows.Forms.PictureBox();
            this.picCoin6 = new System.Windows.Forms.PictureBox();
            this.picCoin7 = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKey1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 20;
            this.Timer.Tag = "timer";
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // picCoin3
            // 
            this.picCoin3.BackColor = System.Drawing.Color.Transparent;
            this.picCoin3.BackgroundImage = global::SimpleSideScrollingGameNiceM.Properties.Resources.coin2;
            this.picCoin3.Location = new System.Drawing.Point(1172, 268);
            this.picCoin3.Name = "picCoin3";
            this.picCoin3.Size = new System.Drawing.Size(42, 39);
            this.picCoin3.TabIndex = 1;
            this.picCoin3.TabStop = false;
            this.picCoin3.Tag = "coin";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPoints.Location = new System.Drawing.Point(461, 2);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(113, 31);
            this.lblPoints.TabIndex = 4;
            this.lblPoints.Text = "Points: ";
            // 
            // picDoor1
            // 
            this.picDoor1.BackgroundImage = global::SimpleSideScrollingGameNiceM.Properties.Resources.door_closed3;
            this.picDoor1.Location = new System.Drawing.Point(144, 12);
            this.picDoor1.Name = "picDoor1";
            this.picDoor1.Size = new System.Drawing.Size(50, 85);
            this.picDoor1.TabIndex = 6;
            this.picDoor1.TabStop = false;
            this.picDoor1.Tag = "door";
            // 
            // picCoin2
            // 
            this.picCoin2.BackColor = System.Drawing.Color.Transparent;
            this.picCoin2.BackgroundImage = global::SimpleSideScrollingGameNiceM.Properties.Resources.coin2;
            this.picCoin2.Location = new System.Drawing.Point(467, 136);
            this.picCoin2.Name = "picCoin2";
            this.picCoin2.Size = new System.Drawing.Size(42, 41);
            this.picCoin2.TabIndex = 7;
            this.picCoin2.TabStop = false;
            this.picCoin2.Tag = "coin";
            // 
            // picDoor2
            // 
            this.picDoor2.BackgroundImage = global::SimpleSideScrollingGameNiceM.Properties.Resources.door_open1;
            this.picDoor2.Location = new System.Drawing.Point(999, 2);
            this.picDoor2.Name = "picDoor2";
            this.picDoor2.Size = new System.Drawing.Size(63, 104);
            this.picDoor2.TabIndex = 8;
            this.picDoor2.TabStop = false;
            this.picDoor2.Tag = "door";
            // 
            // picCoin1
            // 
            this.picCoin1.BackColor = System.Drawing.Color.Transparent;
            this.picCoin1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCoin1.BackgroundImage")));
            this.picCoin1.Location = new System.Drawing.Point(566, 162);
            this.picCoin1.Name = "picCoin1";
            this.picCoin1.Size = new System.Drawing.Size(33, 32);
            this.picCoin1.TabIndex = 9;
            this.picCoin1.TabStop = false;
            this.picCoin1.Tag = "coin";
            // 
            // picPlatform1
            // 
            this.picPlatform1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPlatform1.BackgroundImage")));
            this.picPlatform1.Location = new System.Drawing.Point(979, 100);
            this.picPlatform1.Name = "picPlatform1";
            this.picPlatform1.Size = new System.Drawing.Size(101, 25);
            this.picPlatform1.TabIndex = 10;
            this.picPlatform1.TabStop = false;
            this.picPlatform1.Tag = "platform";
            // 
            // picPlatform2
            // 
            this.picPlatform2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPlatform2.BackgroundImage")));
            this.picPlatform2.Location = new System.Drawing.Point(216, 250);
            this.picPlatform2.Name = "picPlatform2";
            this.picPlatform2.Size = new System.Drawing.Size(100, 31);
            this.picPlatform2.TabIndex = 11;
            this.picPlatform2.TabStop = false;
            this.picPlatform2.Tag = "platform";
            // 
            // picCoin4
            // 
            this.picCoin4.BackColor = System.Drawing.Color.Transparent;
            this.picCoin4.BackgroundImage = global::SimpleSideScrollingGameNiceM.Properties.Resources.coin2;
            this.picCoin4.Location = new System.Drawing.Point(244, 203);
            this.picCoin4.Name = "picCoin4";
            this.picCoin4.Size = new System.Drawing.Size(41, 41);
            this.picCoin4.TabIndex = 12;
            this.picCoin4.TabStop = false;
            this.picCoin4.Tag = "coin";
            // 
            // picKey1
            // 
            this.picKey1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picKey1.BackgroundImage")));
            this.picKey1.Location = new System.Drawing.Point(913, 151);
            this.picKey1.Name = "picKey1";
            this.picKey1.Size = new System.Drawing.Size(58, 31);
            this.picKey1.TabIndex = 13;
            this.picKey1.TabStop = false;
            this.picKey1.Tag = "key";
            // 
            // background
            // 
            this.background.BackgroundImage = global::SimpleSideScrollingGameNiceM.Properties.Resources.backgroundd;
            this.background.Location = new System.Drawing.Point(-8, 2);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1238, 465);
            this.background.TabIndex = 14;
            this.background.TabStop = false;
            this.background.Click += new System.EventHandler(this.background_Click);
            // 
            // picPlatform3
            // 
            this.picPlatform3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPlatform3.BackgroundImage")));
            this.picPlatform3.Location = new System.Drawing.Point(893, 188);
            this.picPlatform3.Name = "picPlatform3";
            this.picPlatform3.Size = new System.Drawing.Size(100, 41);
            this.picPlatform3.TabIndex = 15;
            this.picPlatform3.TabStop = false;
            this.picPlatform3.Tag = "platform";
            // 
            // picPlatform5
            // 
            this.picPlatform5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPlatform5.BackgroundImage")));
            this.picPlatform5.Location = new System.Drawing.Point(566, 250);
            this.picPlatform5.Name = "picPlatform5";
            this.picPlatform5.Size = new System.Drawing.Size(91, 31);
            this.picPlatform5.TabIndex = 16;
            this.picPlatform5.TabStop = false;
            this.picPlatform5.Tag = "platform";
            // 
            // picPlatform4
            // 
            this.picPlatform4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPlatform4.BackgroundImage")));
            this.picPlatform4.Location = new System.Drawing.Point(12, 273);
            this.picPlatform4.Name = "picPlatform4";
            this.picPlatform4.Size = new System.Drawing.Size(100, 34);
            this.picPlatform4.TabIndex = 17;
            this.picPlatform4.TabStop = false;
            this.picPlatform4.Tag = "platform";
            // 
            // picPlatform6
            // 
            this.picPlatform6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPlatform6.BackgroundImage")));
            this.picPlatform6.Location = new System.Drawing.Point(701, 89);
            this.picPlatform6.Name = "picPlatform6";
            this.picPlatform6.Size = new System.Drawing.Size(100, 36);
            this.picPlatform6.TabIndex = 18;
            this.picPlatform6.TabStop = false;
            this.picPlatform6.Tag = "platform";
            // 
            // picPlatform8
            // 
            this.picPlatform8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPlatform8.BackgroundImage")));
            this.picPlatform8.Location = new System.Drawing.Point(117, 93);
            this.picPlatform8.Name = "picPlatform8";
            this.picPlatform8.Size = new System.Drawing.Size(100, 32);
            this.picPlatform8.TabIndex = 19;
            this.picPlatform8.TabStop = false;
            this.picPlatform8.Tag = "platform";
            // 
            // picPlatform7
            // 
            this.picPlatform7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPlatform7.BackgroundImage")));
            this.picPlatform7.Location = new System.Drawing.Point(1066, 257);
            this.picPlatform7.Name = "picPlatform7";
            this.picPlatform7.Size = new System.Drawing.Size(100, 50);
            this.picPlatform7.TabIndex = 20;
            this.picPlatform7.TabStop = false;
            this.picPlatform7.Tag = "platform";
            // 
            // picCoin5
            // 
            this.picCoin5.BackColor = System.Drawing.Color.Transparent;
            this.picCoin5.BackgroundImage = global::SimpleSideScrollingGameNiceM.Properties.Resources.coin2;
            this.picCoin5.Location = new System.Drawing.Point(806, 250);
            this.picCoin5.Name = "picCoin5";
            this.picCoin5.Size = new System.Drawing.Size(41, 41);
            this.picCoin5.TabIndex = 21;
            this.picCoin5.TabStop = false;
            this.picCoin5.Tag = "coin";
            // 
            // picCoin8
            // 
            this.picCoin8.BackColor = System.Drawing.Color.Transparent;
            this.picCoin8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCoin8.BackgroundImage")));
            this.picCoin8.Location = new System.Drawing.Point(605, 141);
            this.picCoin8.Name = "picCoin8";
            this.picCoin8.Size = new System.Drawing.Size(33, 36);
            this.picCoin8.TabIndex = 22;
            this.picCoin8.TabStop = false;
            this.picCoin8.Tag = "coin";
            // 
            // picCoin6
            // 
            this.picCoin6.BackColor = System.Drawing.Color.Transparent;
            this.picCoin6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCoin6.BackgroundImage")));
            this.picCoin6.Location = new System.Drawing.Point(601, 196);
            this.picCoin6.Name = "picCoin6";
            this.picCoin6.Size = new System.Drawing.Size(37, 33);
            this.picCoin6.TabIndex = 23;
            this.picCoin6.TabStop = false;
            this.picCoin6.Tag = "coin";
            // 
            // picCoin7
            // 
            this.picCoin7.BackColor = System.Drawing.Color.Transparent;
            this.picCoin7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCoin7.BackgroundImage")));
            this.picCoin7.Location = new System.Drawing.Point(644, 163);
            this.picCoin7.Name = "picCoin7";
            this.picCoin7.Size = new System.Drawing.Size(35, 31);
            this.picCoin7.TabIndex = 24;
            this.picCoin7.TabStop = false;
            this.picCoin7.Tag = "coin";
            // 
            // picPlayer
            // 
            this.picPlayer.Image = global::SimpleSideScrollingGameNiceM.Properties.Resources.picPlayer;
            this.picPlayer.Location = new System.Drawing.Point(31, 55);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(48, 70);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 25;
            this.picPlayer.TabStop = false;
            this.picPlayer.Tag = "player";
            // 
            // frmScrollingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SimpleSideScrollingGameNiceM.Properties.Resources.backgroundd;
            this.ClientSize = new System.Drawing.Size(1226, 355);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picCoin7);
            this.Controls.Add(this.picCoin6);
            this.Controls.Add(this.picCoin8);
            this.Controls.Add(this.picCoin5);
            this.Controls.Add(this.picPlatform7);
            this.Controls.Add(this.picPlatform8);
            this.Controls.Add(this.picPlatform6);
            this.Controls.Add(this.picPlatform4);
            this.Controls.Add(this.picPlatform5);
            this.Controls.Add(this.picPlatform3);
            this.Controls.Add(this.picKey1);
            this.Controls.Add(this.picCoin4);
            this.Controls.Add(this.picPlatform2);
            this.Controls.Add(this.picPlatform1);
            this.Controls.Add(this.picCoin1);
            this.Controls.Add(this.picDoor2);
            this.Controls.Add(this.picCoin2);
            this.Controls.Add(this.picDoor1);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.picCoin3);
            this.Controls.Add(this.background);
            this.KeyPreview = true;
            this.Name = "frmScrollingGame";
            this.Tag = "background";
            this.Text = " Side Scrolling Game";
            this.Load += new System.EventHandler(this.frmSideScrollingGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.picCoin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKey1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatform7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox picCoin3;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.PictureBox picDoor1;
        private System.Windows.Forms.PictureBox picCoin2;
        private System.Windows.Forms.PictureBox picDoor2;
        private System.Windows.Forms.PictureBox picCoin1;
        private System.Windows.Forms.PictureBox picPlatform1;
        private System.Windows.Forms.PictureBox picPlatform2;
        private System.Windows.Forms.PictureBox picCoin4;
        private System.Windows.Forms.PictureBox picKey1;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox picPlatform3;
        private System.Windows.Forms.PictureBox picPlatform5;
        private System.Windows.Forms.PictureBox picPlatform4;
        private System.Windows.Forms.PictureBox picPlatform6;
        private System.Windows.Forms.PictureBox picPlatform8;
        private System.Windows.Forms.PictureBox picPlatform7;
        private System.Windows.Forms.PictureBox picCoin5;
        private System.Windows.Forms.PictureBox picCoin8;
        private System.Windows.Forms.PictureBox picCoin6;
        private System.Windows.Forms.PictureBox picCoin7;
        private System.Windows.Forms.PictureBox picPlayer;
    }
}

