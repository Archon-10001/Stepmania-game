namespace Stepmania
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.P_pictureBox = new System.Windows.Forms.PictureBox();
            this.O_pictureBox = new System.Windows.Forms.PictureBox();
            this.W_PictureBox = new System.Windows.Forms.PictureBox();
            this.Q_Picturebox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.wall = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.P_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.W_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Q_Picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // P_pictureBox
            // 
            this.P_pictureBox.Image = global::Stepmania.Properties.Resources.Right_Roll_BottomCap_active;
            this.P_pictureBox.Location = new System.Drawing.Point(252, 325);
            this.P_pictureBox.Name = "P_pictureBox";
            this.P_pictureBox.Size = new System.Drawing.Size(64, 64);
            this.P_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.P_pictureBox.TabIndex = 3;
            this.P_pictureBox.TabStop = false;
            // 
            // O_pictureBox
            // 
            this.O_pictureBox.Image = global::Stepmania.Properties.Resources.Up_Roll_BottomCap_active;
            this.O_pictureBox.Location = new System.Drawing.Point(173, 325);
            this.O_pictureBox.Name = "O_pictureBox";
            this.O_pictureBox.Size = new System.Drawing.Size(64, 64);
            this.O_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.O_pictureBox.TabIndex = 2;
            this.O_pictureBox.TabStop = false;
            // 
            // W_PictureBox
            // 
            this.W_PictureBox.Image = global::Stepmania.Properties.Resources.Up_Roll_BottomCap_active;
            this.W_PictureBox.Location = new System.Drawing.Point(93, 325);
            this.W_PictureBox.Name = "W_PictureBox";
            this.W_PictureBox.Size = new System.Drawing.Size(64, 64);
            this.W_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.W_PictureBox.TabIndex = 1;
            this.W_PictureBox.TabStop = false;
            // 
            // Q_Picturebox
            // 
            this.Q_Picturebox.Image = global::Stepmania.Properties.Resources.Left_Roll_BottomCap_active;
            this.Q_Picturebox.Location = new System.Drawing.Point(12, 325);
            this.Q_Picturebox.Name = "Q_Picturebox";
            this.Q_Picturebox.Size = new System.Drawing.Size(64, 64);
            this.Q_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Q_Picturebox.TabIndex = 0;
            this.Q_Picturebox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stepmania.Properties.Resources.Left_Roll_BottomCap_active;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Stepmania.Properties.Resources.Up_Roll_BottomCap_active;
            this.pictureBox2.Location = new System.Drawing.Point(93, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Stepmania.Properties.Resources.Up_Roll_BottomCap_active;
            this.pictureBox3.Location = new System.Drawing.Point(173, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Stepmania.Properties.Resources.Right_Roll_BottomCap_active;
            this.pictureBox4.Location = new System.Drawing.Point(252, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // wall
            // 
            this.wall.Location = new System.Drawing.Point(12, 458);
            this.wall.Name = "wall";
            this.wall.Size = new System.Drawing.Size(301, 15);
            this.wall.TabIndex = 8;
            this.wall.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chartreuse;
            this.label1.Location = new System.Drawing.Point(322, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Points";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(322, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 272);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pause menu";
            this.groupBox1.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(55, 123);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Credits";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(55, 94);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "About";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(55, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Restart game";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Exit game";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(322, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 33);
            this.label2.TabIndex = 12;
            this.label2.Text = "Misses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label3.Location = new System.Drawing.Point(88, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Current Speed:1!";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 479);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(304, 23);
            this.progressBar1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(827, 548);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wall);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.P_pictureBox);
            this.Controls.Add(this.O_pictureBox);
            this.Controls.Add(this.W_PictureBox);
            this.Controls.Add(this.Q_Picturebox);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Stepmania";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.P_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.O_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.W_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Q_Picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Q_Picturebox;
        private System.Windows.Forms.PictureBox W_PictureBox;
        private System.Windows.Forms.PictureBox O_pictureBox;
        private System.Windows.Forms.PictureBox P_pictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox wall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

