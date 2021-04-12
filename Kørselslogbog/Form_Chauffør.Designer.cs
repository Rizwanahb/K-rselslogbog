namespace Kørselslogbog
{
    partial class Form_Chauffør
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Chauffør));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_vise = new System.Windows.Forms.Button();
            this.button_Mainmenu = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.dateTime_opret = new System.Windows.Forms.DateTimePicker();
            this.button_rette = new System.Windows.Forms.Button();
            this.button_slet = new System.Windows.Forms.Button();
            this.but_Gem = new System.Windows.Forms.Button();
            this.txtEfternavn = new System.Windows.Forms.TextBox();
            this.txtFornavn = new System.Windows.Forms.TextBox();
            this.txtCHID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_vise);
            this.groupBox1.Controls.Add(this.button_Mainmenu);
            this.groupBox1.Controls.Add(this.button_clear);
            this.groupBox1.Controls.Add(this.dateTime_opret);
            this.groupBox1.Controls.Add(this.button_rette);
            this.groupBox1.Controls.Add(this.button_slet);
            this.groupBox1.Controls.Add(this.but_Gem);
            this.groupBox1.Controls.Add(this.txtEfternavn);
            this.groupBox1.Controls.Add(this.txtFornavn);
            this.groupBox1.Controls.Add(this.txtCHID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opret Chauffør";
            // 
            // button_vise
            // 
            this.button_vise.Location = new System.Drawing.Point(117, 324);
            this.button_vise.Name = "button_vise";
            this.button_vise.Size = new System.Drawing.Size(85, 31);
            this.button_vise.TabIndex = 13;
            this.button_vise.Text = "Vise";
            this.button_vise.UseVisualStyleBackColor = true;
            this.button_vise.Click += new System.EventHandler(this.button_vise_Click);
            // 
            // button_Mainmenu
            // 
            this.button_Mainmenu.Location = new System.Drawing.Point(219, 324);
            this.button_Mainmenu.Name = "button_Mainmenu";
            this.button_Mainmenu.Size = new System.Drawing.Size(85, 31);
            this.button_Mainmenu.TabIndex = 11;
            this.button_Mainmenu.Text = "Forrige";
            this.button_Mainmenu.UseVisualStyleBackColor = true;
            this.button_Mainmenu.Click += new System.EventHandler(this.button_Mainmenu_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(117, 268);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(85, 31);
            this.button_clear.TabIndex = 8;
            this.button_clear.Text = "Annuller";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // dateTime_opret
            // 
            this.dateTime_opret.Location = new System.Drawing.Point(117, 207);
            this.dateTime_opret.Name = "dateTime_opret";
            this.dateTime_opret.Size = new System.Drawing.Size(187, 25);
            this.dateTime_opret.TabIndex = 12;
            // 
            // button_rette
            // 
            this.button_rette.Location = new System.Drawing.Point(219, 268);
            this.button_rette.Name = "button_rette";
            this.button_rette.Size = new System.Drawing.Size(85, 31);
            this.button_rette.TabIndex = 10;
            this.button_rette.Text = "Redigere";
            this.button_rette.UseVisualStyleBackColor = true;
            this.button_rette.Click += new System.EventHandler(this.button_rette_Click);
            // 
            // button_slet
            // 
            this.button_slet.Location = new System.Drawing.Point(11, 324);
            this.button_slet.Name = "button_slet";
            this.button_slet.Size = new System.Drawing.Size(85, 31);
            this.button_slet.TabIndex = 9;
            this.button_slet.Text = "Slet";
            this.button_slet.UseVisualStyleBackColor = true;
            this.button_slet.Click += new System.EventHandler(this.button_slet_Click);
            // 
            // but_Gem
            // 
            this.but_Gem.Location = new System.Drawing.Point(11, 268);
            this.but_Gem.Name = "but_Gem";
            this.but_Gem.Size = new System.Drawing.Size(85, 31);
            this.but_Gem.TabIndex = 1;
            this.but_Gem.Text = "Gem";
            this.but_Gem.UseVisualStyleBackColor = true;
            this.but_Gem.Click += new System.EventHandler(this.but_Gem_Click);
            // 
            // txtEfternavn
            // 
            this.txtEfternavn.Location = new System.Drawing.Point(117, 154);
            this.txtEfternavn.Name = "txtEfternavn";
            this.txtEfternavn.Size = new System.Drawing.Size(187, 25);
            this.txtEfternavn.TabIndex = 6;
            // 
            // txtFornavn
            // 
            this.txtFornavn.Location = new System.Drawing.Point(117, 102);
            this.txtFornavn.Name = "txtFornavn";
            this.txtFornavn.Size = new System.Drawing.Size(187, 25);
            this.txtFornavn.TabIndex = 4;
            // 
            // txtCHID
            // 
            this.txtCHID.Location = new System.Drawing.Point(117, 52);
            this.txtCHID.Name = "txtCHID";
            this.txtCHID.Size = new System.Drawing.Size(187, 25);
            this.txtCHID.TabIndex = 1;
            this.txtCHID.TextChanged += new System.EventHandler(this.txtCHID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fornavn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Efternavn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opretdato";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chauffør ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(377, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(418, 262);
            this.dataGridView1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(622, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form_opret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_opret";
            this.Text = "Chauffør";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_rette;
        private System.Windows.Forms.Button button_slet;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button but_Gem;
        private System.Windows.Forms.TextBox txtEfternavn;
        private System.Windows.Forms.TextBox txtFornavn;
        private System.Windows.Forms.TextBox txtCHID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Mainmenu;
        private System.Windows.Forms.DateTimePicker dateTime_opret;
        private System.Windows.Forms.Button button_vise;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}