namespace sohi_russian
{
    partial class Form2
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
            this.load_button = new System.Windows.Forms.Button();
            this.Spin_button = new System.Windows.Forms.Button();
            this.Shoot_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Reset_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(510, 90);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(75, 23);
            this.load_button.TabIndex = 0;
            this.load_button.Text = "load";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // Spin_button
            // 
            this.Spin_button.Location = new System.Drawing.Point(510, 145);
            this.Spin_button.Name = "Spin_button";
            this.Spin_button.Size = new System.Drawing.Size(75, 23);
            this.Spin_button.TabIndex = 1;
            this.Spin_button.Text = "spin";
            this.Spin_button.UseVisualStyleBackColor = true;
            this.Spin_button.Click += new System.EventHandler(this.Spin_button_Click);
            // 
            // Shoot_button
            // 
            this.Shoot_button.Location = new System.Drawing.Point(510, 204);
            this.Shoot_button.Name = "Shoot_button";
            this.Shoot_button.Size = new System.Drawing.Size(75, 23);
            this.Shoot_button.TabIndex = 2;
            this.Shoot_button.Text = "shoot";
            this.Shoot_button.UseVisualStyleBackColor = true;
            this.Shoot_button.Click += new System.EventHandler(this.Shoot_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(29, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 194);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Chiller", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(219, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Let\'s Play";
            // 
            // Reset_button
            // 
            this.Reset_button.Location = new System.Drawing.Point(510, 260);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(75, 23);
            this.Reset_button.TabIndex = 5;
            this.Reset_button.Text = "Reset";
            this.Reset_button.UseVisualStyleBackColor = true;
            this.Reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Chiller", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(391, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sohi_russian.Properties.Resources.Stan_lees_lucky_man_1_05_the_last_chance_russian_roulette_3;
            this.ClientSize = new System.Drawing.Size(611, 339);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Reset_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Shoot_button);
            this.Controls.Add(this.Spin_button);
            this.Controls.Add(this.load_button);
            this.Name = "Form2";
            this.Text = "main";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.Button Spin_button;
        private System.Windows.Forms.Button Shoot_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.Label label2;
    }
}