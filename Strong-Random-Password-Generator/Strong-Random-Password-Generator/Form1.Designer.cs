namespace Strong_Random_Password_Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.tytul = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.infodlugosc = new System.Windows.Forms.Label();
            this.duzelit = new System.Windows.Forms.CheckBox();
            this.malelitery = new System.Windows.Forms.CheckBox();
            this.cyfry = new System.Windows.Forms.CheckBox();
            this.znakispecjal = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(203, 118);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 142);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "PLAY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tytul
            // 
            this.tytul.AutoSize = true;
            this.tytul.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tytul.Location = new System.Drawing.Point(155, 7);
            this.tytul.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tytul.Name = "tytul";
            this.tytul.Size = new System.Drawing.Size(244, 32);
            this.tytul.TabIndex = 2;
            this.tytul.Text = "Password Generator";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 204);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(495, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // infodlugosc
            // 
            this.infodlugosc.AutoSize = true;
            this.infodlugosc.Location = new System.Drawing.Point(9, 120);
            this.infodlugosc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infodlugosc.Name = "infodlugosc";
            this.infodlugosc.Size = new System.Drawing.Size(118, 13);
            this.infodlugosc.TabIndex = 4;
            this.infodlugosc.Text = "Length password (8-50)";
            // 
            // duzelit
            // 
            this.duzelit.AutoSize = true;
            this.duzelit.Location = new System.Drawing.Point(169, 54);
            this.duzelit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.duzelit.Name = "duzelit";
            this.duzelit.Size = new System.Drawing.Size(49, 17);
            this.duzelit.TabIndex = 5;
            this.duzelit.Text = "A...Z";
            this.duzelit.UseVisualStyleBackColor = true;
            // 
            // malelitery
            // 
            this.malelitery.AutoSize = true;
            this.malelitery.Location = new System.Drawing.Point(318, 54);
            this.malelitery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.malelitery.Name = "malelitery";
            this.malelitery.Size = new System.Drawing.Size(46, 17);
            this.malelitery.TabIndex = 6;
            this.malelitery.Text = "a...z";
            this.malelitery.UseVisualStyleBackColor = true;
            // 
            // cyfry
            // 
            this.cyfry.AutoSize = true;
            this.cyfry.Location = new System.Drawing.Point(169, 83);
            this.cyfry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cyfry.Name = "cyfry";
            this.cyfry.Size = new System.Drawing.Size(47, 17);
            this.cyfry.TabIndex = 7;
            this.cyfry.Text = "0...9";
            this.cyfry.UseVisualStyleBackColor = true;
            // 
            // znakispecjal
            // 
            this.znakispecjal.AutoSize = true;
            this.znakispecjal.Location = new System.Drawing.Point(318, 83);
            this.znakispecjal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.znakispecjal.Name = "znakispecjal";
            this.znakispecjal.Size = new System.Drawing.Size(56, 17);
            this.znakispecjal.TabIndex = 8;
            this.znakispecjal.Text = "!@#...";
            this.znakispecjal.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(434, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 67);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(434, 102);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 67);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 257);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.znakispecjal);
            this.Controls.Add(this.cyfry);
            this.Controls.Add(this.malelitery);
            this.Controls.Add(this.duzelit);
            this.Controls.Add(this.infodlugosc);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tytul);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Strong Random Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label tytul;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label infodlugosc;
        private System.Windows.Forms.CheckBox duzelit;
        private System.Windows.Forms.CheckBox malelitery;
        private System.Windows.Forms.CheckBox cyfry;
        private System.Windows.Forms.CheckBox znakispecjal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

