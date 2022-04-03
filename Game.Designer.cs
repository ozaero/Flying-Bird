namespace Flying_Bird
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.cloud1 = new System.Windows.Forms.PictureBox();
            this.cloud2 = new System.Windows.Forms.PictureBox();
            this.cloud3 = new System.Windows.Forms.PictureBox();
            this.cloud4 = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.Wall1 = new System.Windows.Forms.PictureBox();
            this.Wall2 = new System.Windows.Forms.PictureBox();
            this.Wall3 = new System.Windows.Forms.PictureBox();
            this.Wall4 = new System.Windows.Forms.PictureBox();
            this.Wall5 = new System.Windows.Forms.PictureBox();
            this.Wall6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cloud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall6)).BeginInit();
            this.SuspendLayout();
            // 
            // cloud1
            // 
            this.cloud1.Image = ((System.Drawing.Image)(resources.GetObject("cloud1.Image")));
            this.cloud1.Location = new System.Drawing.Point(225, 30);
            this.cloud1.Name = "cloud1";
            this.cloud1.Size = new System.Drawing.Size(100, 50);
            this.cloud1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud1.TabIndex = 0;
            this.cloud1.TabStop = false;
            // 
            // cloud2
            // 
            this.cloud2.Image = ((System.Drawing.Image)(resources.GetObject("cloud2.Image")));
            this.cloud2.Location = new System.Drawing.Point(672, 131);
            this.cloud2.Name = "cloud2";
            this.cloud2.Size = new System.Drawing.Size(100, 50);
            this.cloud2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud2.TabIndex = 1;
            this.cloud2.TabStop = false;
            // 
            // cloud3
            // 
            this.cloud3.Location = new System.Drawing.Point(1072, 429);
            this.cloud3.Name = "cloud3";
            this.cloud3.Size = new System.Drawing.Size(100, 50);
            this.cloud3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud3.TabIndex = 2;
            this.cloud3.TabStop = false;
            // 
            // cloud4
            // 
            this.cloud4.Image = ((System.Drawing.Image)(resources.GetObject("cloud4.Image")));
            this.cloud4.Location = new System.Drawing.Point(746, 209);
            this.cloud4.Name = "cloud4";
            this.cloud4.Size = new System.Drawing.Size(100, 50);
            this.cloud4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud4.TabIndex = 3;
            this.cloud4.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(106, 106);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(60, 60);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bird.TabIndex = 4;
            this.bird.TabStop = false;
            // 
            // Wall1
            // 
            this.Wall1.BackColor = System.Drawing.Color.Black;
            this.Wall1.Location = new System.Drawing.Point(841, 143);
            this.Wall1.Name = "Wall1";
            this.Wall1.Size = new System.Drawing.Size(50, 500);
            this.Wall1.TabIndex = 5;
            this.Wall1.TabStop = false;
            // 
            // Wall2
            // 
            this.Wall2.BackColor = System.Drawing.Color.Black;
            this.Wall2.Location = new System.Drawing.Point(841, 199);
            this.Wall2.Name = "Wall2";
            this.Wall2.Size = new System.Drawing.Size(50, 500);
            this.Wall2.TabIndex = 6;
            this.Wall2.TabStop = false;
            // 
            // Wall3
            // 
            this.Wall3.BackColor = System.Drawing.Color.Black;
            this.Wall3.Location = new System.Drawing.Point(841, 199);
            this.Wall3.Name = "Wall3";
            this.Wall3.Size = new System.Drawing.Size(50, 500);
            this.Wall3.TabIndex = 8;
            this.Wall3.TabStop = false;
            // 
            // Wall4
            // 
            this.Wall4.BackColor = System.Drawing.Color.Black;
            this.Wall4.Image = ((System.Drawing.Image)(resources.GetObject("Wall4.Image")));
            this.Wall4.Location = new System.Drawing.Point(841, 143);
            this.Wall4.Name = "Wall4";
            this.Wall4.Size = new System.Drawing.Size(50, 500);
            this.Wall4.TabIndex = 7;
            this.Wall4.TabStop = false;
            // 
            // Wall5
            // 
            this.Wall5.BackColor = System.Drawing.Color.Black;
            this.Wall5.Location = new System.Drawing.Point(841, 265);
            this.Wall5.Name = "Wall5";
            this.Wall5.Size = new System.Drawing.Size(50, 500);
            this.Wall5.TabIndex = 12;
            this.Wall5.TabStop = false;
            // 
            // Wall6
            // 
            this.Wall6.BackColor = System.Drawing.Color.Black;
            this.Wall6.Location = new System.Drawing.Point(841, 209);
            this.Wall6.Name = "Wall6";
            this.Wall6.Size = new System.Drawing.Size(50, 500);
            this.Wall6.TabIndex = 11;
            this.Wall6.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1045, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Wall5);
            this.Controls.Add(this.Wall6);
            this.Controls.Add(this.Wall3);
            this.Controls.Add(this.Wall4);
            this.Controls.Add(this.Wall2);
            this.Controls.Add(this.Wall1);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.cloud4);
            this.Controls.Add(this.cloud3);
            this.Controls.Add(this.cloud2);
            this.Controls.Add(this.cloud1);
            this.Location = new System.Drawing.Point(50, 50);
            this.MaximizeBox = false;
            this.Name = "Game";
            this.Text = "Flying Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.cloud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox cloud1;
        private System.Windows.Forms.PictureBox cloud2;
        private System.Windows.Forms.PictureBox cloud3;
        private System.Windows.Forms.PictureBox cloud4;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox Wall1;
        private System.Windows.Forms.PictureBox Wall2;
        private System.Windows.Forms.PictureBox Wall3;
        private System.Windows.Forms.PictureBox Wall4;
        private System.Windows.Forms.PictureBox Wall5;
        private System.Windows.Forms.PictureBox Wall6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}