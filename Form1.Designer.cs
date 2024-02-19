
namespace RacingGame
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonStart = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.award = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.npc2 = new System.Windows.Forms.PictureBox();
            this.npc1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.RoadTrack2 = new System.Windows.Forms.PictureBox();
            this.RoadTrack1 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.award)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadTrack1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(193, 501);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(106, 41);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.restartGame);
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtScore.Location = new System.Drawing.Point(12, 465);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(473, 23);
            this.txtScore.TabIndex = 1;
            this.txtScore.Text = "Score: 0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.award);
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.npc2);
            this.panel1.Controls.Add(this.npc1);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.RoadTrack2);
            this.panel1.Controls.Add(this.RoadTrack1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 441);
            this.panel1.TabIndex = 2;
            // 
            // award
            // 
            this.award.Image = global::RacingGame.Properties.Resources.bronze;
            this.award.Location = new System.Drawing.Point(123, 193);
            this.award.Name = "award";
            this.award.Size = new System.Drawing.Size(250, 100);
            this.award.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.award.TabIndex = 6;
            this.award.TabStop = false;
            // 
            // explosion
            // 
            this.explosion.Image = global::RacingGame.Properties.Resources.explosion;
            this.explosion.Location = new System.Drawing.Point(123, 317);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(64, 64);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.explosion.TabIndex = 5;
            this.explosion.TabStop = false;
            // 
            // npc2
            // 
            this.npc2.Image = global::RacingGame.Properties.Resources.carGrey;
            this.npc2.Location = new System.Drawing.Point(323, 44);
            this.npc2.Name = "npc2";
            this.npc2.Size = new System.Drawing.Size(50, 100);
            this.npc2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.npc2.TabIndex = 4;
            this.npc2.TabStop = false;
            this.npc2.Tag = "CarRight";
            // 
            // npc1
            // 
            this.npc1.Image = global::RacingGame.Properties.Resources.carGreen;
            this.npc1.Location = new System.Drawing.Point(67, 43);
            this.npc1.Name = "npc1";
            this.npc1.Size = new System.Drawing.Size(50, 101);
            this.npc1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.npc1.TabIndex = 3;
            this.npc1.TabStop = false;
            this.npc1.Tag = "CarLeft";
            // 
            // player
            // 
            this.player.Image = global::RacingGame.Properties.Resources.carYellow;
            this.player.Location = new System.Drawing.Point(237, 317);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 99);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // RoadTrack2
            // 
            this.RoadTrack2.Image = global::RacingGame.Properties.Resources.roadTrack;
            this.RoadTrack2.Location = new System.Drawing.Point(0, 0);
            this.RoadTrack2.Name = "RoadTrack2";
            this.RoadTrack2.Size = new System.Drawing.Size(482, 441);
            this.RoadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RoadTrack2.TabIndex = 1;
            this.RoadTrack2.TabStop = false;
            // 
            // RoadTrack1
            // 
            this.RoadTrack1.Image = global::RacingGame.Properties.Resources.roadTrack;
            this.RoadTrack1.Location = new System.Drawing.Point(0, -441);
            this.RoadTrack1.Name = "RoadTrack1";
            this.RoadTrack1.Size = new System.Drawing.Size(482, 441);
            this.RoadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RoadTrack1.TabIndex = 0;
            this.RoadTrack1.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 558);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.award)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadTrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadTrack1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox award;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.PictureBox npc2;
        private System.Windows.Forms.PictureBox npc1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox RoadTrack2;
        private System.Windows.Forms.PictureBox RoadTrack1;
        private System.Windows.Forms.Timer gameTimer;
    }
}

