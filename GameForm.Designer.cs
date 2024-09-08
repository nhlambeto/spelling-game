namespace INF164HWAss1
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
            this.lblTime = new System.Windows.Forms.Label();
            this.lblScorePlayer = new System.Windows.Forms.Label();
            this.lblFruitName = new System.Windows.Forms.Label();
            this.pbFruit = new System.Windows.Forms.PictureBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblScoreEnemy = new System.Windows.Forms.Label();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbFruit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.PeachPuff;
            this.lblTime.Font = new System.Drawing.Font("Lemon", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(334, 105);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 19);
            this.lblTime.TabIndex = 0;
            // 
            // lblScorePlayer
            // 
            this.lblScorePlayer.AutoSize = true;
            this.lblScorePlayer.BackColor = System.Drawing.Color.PeachPuff;
            this.lblScorePlayer.Font = new System.Drawing.Font("Lemon", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScorePlayer.ForeColor = System.Drawing.Color.Black;
            this.lblScorePlayer.Location = new System.Drawing.Point(529, 91);
            this.lblScorePlayer.Name = "lblScorePlayer";
            this.lblScorePlayer.Size = new System.Drawing.Size(0, 22);
            this.lblScorePlayer.TabIndex = 1;
            // 
            // lblFruitName
            // 
            this.lblFruitName.AutoSize = true;
            this.lblFruitName.Location = new System.Drawing.Point(304, 288);
            this.lblFruitName.Name = "lblFruitName";
            this.lblFruitName.Size = new System.Drawing.Size(0, 16);
            this.lblFruitName.TabIndex = 2;
            // 
            // pbFruit
            // 
            this.pbFruit.Location = new System.Drawing.Point(300, 151);
            this.pbFruit.Name = "pbFruit";
            this.pbFruit.Size = new System.Drawing.Size(158, 125);
            this.pbFruit.TabIndex = 3;
            this.pbFruit.TabStop = false;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(300, 317);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(138, 22);
            this.txtAnswer.TabIndex = 4;
            // 
            // lblScoreEnemy
            // 
            this.lblScoreEnemy.AutoSize = true;
            this.lblScoreEnemy.BackColor = System.Drawing.Color.PeachPuff;
            this.lblScoreEnemy.Font = new System.Drawing.Font("Lemon", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreEnemy.ForeColor = System.Drawing.Color.Black;
            this.lblScoreEnemy.Location = new System.Drawing.Point(123, 151);
            this.lblScoreEnemy.Name = "lblScoreEnemy";
            this.lblScoreEnemy.Size = new System.Drawing.Size(0, 19);
            this.lblScoreEnemy.TabIndex = 5;
            // 
            // btnAnswer
            // 
            this.btnAnswer.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAnswer.Font = new System.Drawing.Font("Lemon", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer.Location = new System.Drawing.Point(300, 357);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(128, 41);
            this.btnAnswer.TabIndex = 6;
            this.btnAnswer.Text = "ANSWER";
            this.btnAnswer.UseVisualStyleBackColor = false;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click_1);
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::INF164HWAss1.Properties.Resources.HealthFull;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.lblScoreEnemy);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.pbFruit);
            this.Controls.Add(this.lblFruitName);
            this.Controls.Add(this.lblScorePlayer);
            this.Controls.Add(this.lblTime);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFruit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblScorePlayer;
        private System.Windows.Forms.Label lblFruitName;
        private System.Windows.Forms.PictureBox pbFruit;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblScoreEnemy;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Timer gameTimer;
    }
}