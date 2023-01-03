namespace basketbolFinal
{
    partial class basket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(basket));
            this.pnlstart = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnzor = new System.Windows.Forms.RadioButton();
            this.rbtnorta = new System.Windows.Forms.RadioButton();
            this.rbtnkolay = new System.Windows.Forms.RadioButton();
            this.btnstart = new System.Windows.Forms.Button();
            this.lblsure = new System.Windows.Forms.Label();
            this.top = new System.Windows.Forms.PictureBox();
            this.pnlsonuc = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnrestart = new System.Windows.Forms.Button();
            this.lblpuan = new System.Windows.Forms.Label();
            this.lblisabetlitik = new System.Windows.Forms.Label();
            this.lbltoplamtik = new System.Windows.Forms.Label();
            this.timersure = new System.Windows.Forms.Timer(this.components);
            this.timerLoc = new System.Windows.Forms.Timer(this.components);
            this.pnlstart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).BeginInit();
            this.pnlsonuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlstart
            // 
            this.pnlstart.BackColor = System.Drawing.Color.Teal;
            this.pnlstart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlstart.Controls.Add(this.label5);
            this.pnlstart.Controls.Add(this.label4);
            this.pnlstart.Controls.Add(this.label3);
            this.pnlstart.Controls.Add(this.label2);
            this.pnlstart.Controls.Add(this.pictureBox1);
            this.pnlstart.Controls.Add(this.label1);
            this.pnlstart.Controls.Add(this.rbtnzor);
            this.pnlstart.Controls.Add(this.rbtnorta);
            this.pnlstart.Controls.Add(this.rbtnkolay);
            this.pnlstart.Controls.Add(this.btnstart);
            this.pnlstart.Location = new System.Drawing.Point(-8, 3);
            this.pnlstart.Name = "pnlstart";
            this.pnlstart.Size = new System.Drawing.Size(53, 573);
            this.pnlstart.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(6, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "-Oyun süresine dikkat ediniz!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(6, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 46);
            this.label4.TabIndex = 15;
            this.label4.Text = "-Her başarılı tıklayış 5 puandır.\r\n\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(6, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(826, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "-Farklı yerlerde ortaya çıkan basketbol topuna mause ile tıklamanız gerekmektedir" +
    ".\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-4, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Oyun Kuralları :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(798, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(153, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 47);
            this.label1.TabIndex = 8;
            this.label1.Text = "Basketbol Topunu Yakala";
            // 
            // rbtnzor
            // 
            this.rbtnzor.AutoSize = true;
            this.rbtnzor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnzor.Location = new System.Drawing.Point(467, 228);
            this.rbtnzor.Name = "rbtnzor";
            this.rbtnzor.Size = new System.Drawing.Size(57, 24);
            this.rbtnzor.TabIndex = 7;
            this.rbtnzor.Text = "Zor";
            this.rbtnzor.UseVisualStyleBackColor = true;
            // 
            // rbtnorta
            // 
            this.rbtnorta.AutoSize = true;
            this.rbtnorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnorta.Location = new System.Drawing.Point(374, 228);
            this.rbtnorta.Name = "rbtnorta";
            this.rbtnorta.Size = new System.Drawing.Size(67, 24);
            this.rbtnorta.TabIndex = 7;
            this.rbtnorta.Text = "Orta";
            this.rbtnorta.UseVisualStyleBackColor = true;
            // 
            // rbtnkolay
            // 
            this.rbtnkolay.AutoSize = true;
            this.rbtnkolay.Checked = true;
            this.rbtnkolay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnkolay.Location = new System.Drawing.Point(273, 228);
            this.rbtnkolay.Name = "rbtnkolay";
            this.rbtnkolay.Size = new System.Drawing.Size(76, 24);
            this.rbtnkolay.TabIndex = 7;
            this.rbtnkolay.TabStop = true;
            this.rbtnkolay.Text = "Kolay";
            this.rbtnkolay.UseVisualStyleBackColor = true;
            // 
            // btnstart
            // 
            this.btnstart.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnstart.Location = new System.Drawing.Point(583, 518);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(223, 43);
            this.btnstart.TabIndex = 1;
            this.btnstart.Text = "Oyuna Başla";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // lblsure
            // 
            this.lblsure.AutoSize = true;
            this.lblsure.BackColor = System.Drawing.Color.Transparent;
            this.lblsure.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsure.ForeColor = System.Drawing.Color.Red;
            this.lblsure.Location = new System.Drawing.Point(332, 517);
            this.lblsure.Name = "lblsure";
            this.lblsure.Size = new System.Drawing.Size(101, 34);
            this.lblsure.TabIndex = 2;
            this.lblsure.Text = "Süre :";
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.Transparent;
            this.top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.top.Image = ((System.Drawing.Image)(resources.GetObject("top.Image")));
            this.top.Location = new System.Drawing.Point(397, 174);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(71, 41);
            this.top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.top.TabIndex = 3;
            this.top.TabStop = false;
            this.top.Click += new System.EventHandler(this.top_Click);
            // 
            // pnlsonuc
            // 
            this.pnlsonuc.BackColor = System.Drawing.Color.Teal;
            this.pnlsonuc.Controls.Add(this.pictureBox2);
            this.pnlsonuc.Controls.Add(this.btnrestart);
            this.pnlsonuc.Controls.Add(this.lblpuan);
            this.pnlsonuc.Controls.Add(this.lblisabetlitik);
            this.pnlsonuc.Controls.Add(this.lbltoplamtik);
            this.pnlsonuc.Location = new System.Drawing.Point(831, 3);
            this.pnlsonuc.Name = "pnlsonuc";
            this.pnlsonuc.Size = new System.Drawing.Size(25, 573);
            this.pnlsonuc.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(84, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnrestart
            // 
            this.btnrestart.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrestart.Location = new System.Drawing.Point(346, 310);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(247, 43);
            this.btnrestart.TabIndex = 1;
            this.btnrestart.Text = "Yeniden Başlat";
            this.btnrestart.UseVisualStyleBackColor = true;
            this.btnrestart.Click += new System.EventHandler(this.btnrestart_Click);
            // 
            // lblpuan
            // 
            this.lblpuan.AutoSize = true;
            this.lblpuan.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpuan.Location = new System.Drawing.Point(176, 247);
            this.lblpuan.Name = "lblpuan";
            this.lblpuan.Size = new System.Drawing.Size(60, 19);
            this.lblpuan.TabIndex = 2;
            this.lblpuan.Text = "Puan :";
            // 
            // lblisabetlitik
            // 
            this.lblisabetlitik.AutoSize = true;
            this.lblisabetlitik.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblisabetlitik.Location = new System.Drawing.Point(176, 193);
            this.lblisabetlitik.Name = "lblisabetlitik";
            this.lblisabetlitik.Size = new System.Drawing.Size(145, 19);
            this.lblisabetlitik.TabIndex = 2;
            this.lblisabetlitik.Text = "İsabetli Tıklama :";
            // 
            // lbltoplamtik
            // 
            this.lbltoplamtik.AutoSize = true;
            this.lbltoplamtik.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltoplamtik.Location = new System.Drawing.Point(174, 138);
            this.lbltoplamtik.Name = "lbltoplamtik";
            this.lbltoplamtik.Size = new System.Drawing.Size(147, 19);
            this.lbltoplamtik.TabIndex = 2;
            this.lbltoplamtik.Text = "Toplam Tıklama :";
            // 
            // timersure
            // 
            this.timersure.Tick += new System.EventHandler(this.timersure_Tick);
            // 
            // timerLoc
            // 
            this.timerLoc.Tick += new System.EventHandler(this.timerLoc_Tick);
            // 
            // basket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(868, 576);
            this.ControlBox = false;
            this.Controls.Add(this.pnlsonuc);
            this.Controls.Add(this.pnlstart);
            this.Controls.Add(this.lblsure);
            this.Controls.Add(this.top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "basket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "basket";
            this.Load += new System.EventHandler(this.basket_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.basket_MouseClick);
            this.pnlstart.ResumeLayout(false);
            this.pnlstart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).EndInit();
            this.pnlsonuc.ResumeLayout(false);
            this.pnlsonuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlstart;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Panel pnlsonuc;
        private System.Windows.Forms.Button btnrestart;
        private System.Windows.Forms.Label lblpuan;
        private System.Windows.Forms.Label lblisabetlitik;
        private System.Windows.Forms.Label lbltoplamtik;
        private System.Windows.Forms.Label lblsure;
        private System.Windows.Forms.PictureBox top;
        private System.Windows.Forms.Timer timersure;
        private System.Windows.Forms.Timer timerLoc;
        private System.Windows.Forms.RadioButton rbtnkolay;
        private System.Windows.Forms.RadioButton rbtnzor;
        private System.Windows.Forms.RadioButton rbtnorta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}