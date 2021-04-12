namespace Kørselslogbog
{
    partial class Opret
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opret));
            this.b_KMINPUT = new System.Windows.Forms.Button();
            this.b_Chauffør = new System.Windows.Forms.Button();
            this.b_UDTRÆK = new System.Windows.Forms.Button();
            this.b_Bil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Quit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // b_KMINPUT
            // 
            this.b_KMINPUT.BackColor = System.Drawing.Color.PeachPuff;
            this.b_KMINPUT.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_KMINPUT.Location = new System.Drawing.Point(557, 114);
            this.b_KMINPUT.Name = "b_KMINPUT";
            this.b_KMINPUT.Size = new System.Drawing.Size(171, 43);
            this.b_KMINPUT.TabIndex = 0;
            this.b_KMINPUT.Text = "KM_input";
            this.b_KMINPUT.UseVisualStyleBackColor = false;
            this.b_KMINPUT.Click += new System.EventHandler(this.b_KMINPUT_Click);
            // 
            // b_Chauffør
            // 
            this.b_Chauffør.BackColor = System.Drawing.Color.PeachPuff;
            this.b_Chauffør.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Chauffør.Location = new System.Drawing.Point(557, 186);
            this.b_Chauffør.Name = "b_Chauffør";
            this.b_Chauffør.Size = new System.Drawing.Size(171, 43);
            this.b_Chauffør.TabIndex = 1;
            this.b_Chauffør.Text = "Chauffør";
            this.b_Chauffør.UseVisualStyleBackColor = false;
            this.b_Chauffør.Click += new System.EventHandler(this.button2_Click);
            // 
            // b_UDTRÆK
            // 
            this.b_UDTRÆK.BackColor = System.Drawing.Color.PeachPuff;
            this.b_UDTRÆK.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_UDTRÆK.Location = new System.Drawing.Point(557, 333);
            this.b_UDTRÆK.Name = "b_UDTRÆK";
            this.b_UDTRÆK.Size = new System.Drawing.Size(171, 43);
            this.b_UDTRÆK.TabIndex = 2;
            this.b_UDTRÆK.Text = "Udtræk";
            this.b_UDTRÆK.UseVisualStyleBackColor = false;
            this.b_UDTRÆK.Click += new System.EventHandler(this.b_UDTRÆK_Click);
            // 
            // b_Bil
            // 
            this.b_Bil.BackColor = System.Drawing.Color.PeachPuff;
            this.b_Bil.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Bil.Location = new System.Drawing.Point(557, 261);
            this.b_Bil.Name = "b_Bil";
            this.b_Bil.Size = new System.Drawing.Size(171, 43);
            this.b_Bil.TabIndex = 3;
            this.b_Bil.Text = "Bil";
            this.b_Bil.UseVisualStyleBackColor = false;
            this.b_Bil.Click += new System.EventHandler(this.b_RETTE_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 474);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(434, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "TECK Kørselslogbog";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.PeachPuff;
            this.Quit.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.Location = new System.Drawing.Point(557, 398);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(171, 43);
            this.Quit.TabIndex = 6;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Opret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_Bil);
            this.Controls.Add(this.b_UDTRÆK);
            this.Controls.Add(this.b_Chauffør);
            this.Controls.Add(this.b_KMINPUT);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Opret";
            this.Text = "Hovedmenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_KMINPUT;
        private System.Windows.Forms.Button b_Chauffør;
        private System.Windows.Forms.Button b_UDTRÆK;
        private System.Windows.Forms.Button b_Bil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Quit;
    }
}

