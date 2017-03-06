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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.tytul = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.infodlugosc = new System.Windows.Forms.Label();
            this.duzelit = new System.Windows.Forms.CheckBox();
            this.malelitery = new System.Windows.Forms.CheckBox();
            this.cyfry = new System.Windows.Forms.CheckBox();
            this.znakispecjal = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(225, 142);
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
            this.numericUpDown1.Size = new System.Drawing.Size(160, 22);
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
            this.button1.Location = new System.Drawing.Point(225, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "GENERUJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tytul
            // 
            this.tytul.AutoSize = true;
            this.tytul.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tytul.Location = new System.Drawing.Point(207, 9);
            this.tytul.Name = "tytul";
            this.tytul.Size = new System.Drawing.Size(198, 32);
            this.tytul.TabIndex = 2;
            this.tytul.Text = "Generator hasła";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 254);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(565, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // infodlugosc
            // 
            this.infodlugosc.AutoSize = true;
            this.infodlugosc.Location = new System.Drawing.Point(12, 148);
            this.infodlugosc.Name = "infodlugosc";
            this.infodlugosc.Size = new System.Drawing.Size(136, 16);
            this.infodlugosc.TabIndex = 4;
            this.infodlugosc.Text = "Długość hasła (8-50)";
            // 
            // duzelit
            // 
            this.duzelit.AutoSize = true;
            this.duzelit.Location = new System.Drawing.Point(225, 67);
            this.duzelit.Name = "duzelit";
            this.duzelit.Size = new System.Drawing.Size(53, 20);
            this.duzelit.TabIndex = 5;
            this.duzelit.Text = "A...Z";
            this.duzelit.UseVisualStyleBackColor = true;
            // 
            // malelitery
            // 
            this.malelitery.AutoSize = true;
            this.malelitery.Location = new System.Drawing.Point(335, 67);
            this.malelitery.Name = "malelitery";
            this.malelitery.Size = new System.Drawing.Size(50, 20);
            this.malelitery.TabIndex = 6;
            this.malelitery.Text = "a...z";
            this.malelitery.UseVisualStyleBackColor = true;
            // 
            // cyfry
            // 
            this.cyfry.AutoSize = true;
            this.cyfry.Location = new System.Drawing.Point(225, 102);
            this.cyfry.Name = "cyfry";
            this.cyfry.Size = new System.Drawing.Size(50, 20);
            this.cyfry.TabIndex = 7;
            this.cyfry.Text = "0...9";
            this.cyfry.UseVisualStyleBackColor = true;
            // 
            // znakispecjal
            // 
            this.znakispecjal.AutoSize = true;
            this.znakispecjal.Location = new System.Drawing.Point(335, 102);
            this.znakispecjal.Name = "znakispecjal";
            this.znakispecjal.Size = new System.Drawing.Size(60, 20);
            this.znakispecjal.TabIndex = 8;
            this.znakispecjal.Text = "!@#...";
            this.znakispecjal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 316);
            this.Controls.Add(this.znakispecjal);
            this.Controls.Add(this.cyfry);
            this.Controls.Add(this.malelitery);
            this.Controls.Add(this.duzelit);
            this.Controls.Add(this.infodlugosc);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tytul);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Strong Random Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
    }
}

