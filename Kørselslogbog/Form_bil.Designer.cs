namespace Kørselslogbog
{
    partial class Form_bil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_bil));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_vise = new System.Windows.Forms.Button();
            this.button_Mainmenu = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.dateTime_registration = new System.Windows.Forms.DateTimePicker();
            this.button_slet = new System.Windows.Forms.Button();
            this.but_Gem = new System.Windows.Forms.Button();
            this.txtbilfabrikat = new System.Windows.Forms.TextBox();
            this.txtNummerplade = new System.Windows.Forms.TextBox();
            this.txtbilid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textmodel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioinacktiv = new System.Windows.Forms.RadioButton();
            this.radioaktiv = new System.Windows.Forms.RadioButton();
            this.txtkørtekm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(722, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button_vise
            // 
            this.button_vise.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_vise.Location = new System.Drawing.Point(361, 62);
            this.button_vise.Name = "button_vise";
            this.button_vise.Size = new System.Drawing.Size(85, 31);
            this.button_vise.TabIndex = 13;
            this.button_vise.Text = "Søg";
            this.button_vise.UseVisualStyleBackColor = true;
            this.button_vise.Click += new System.EventHandler(this.button_vise_Click);
            // 
            // button_Mainmenu
            // 
            this.button_Mainmenu.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Mainmenu.Location = new System.Drawing.Point(775, 410);
            this.button_Mainmenu.Name = "button_Mainmenu";
            this.button_Mainmenu.Size = new System.Drawing.Size(85, 31);
            this.button_Mainmenu.TabIndex = 11;
            this.button_Mainmenu.Text = "Forrige";
            this.button_Mainmenu.UseVisualStyleBackColor = true;
            this.button_Mainmenu.Click += new System.EventHandler(this.button_Mainmenu_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(235, 357);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(85, 31);
            this.button_clear.TabIndex = 8;
            this.button_clear.Text = "Annuller";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // dateTime_registration
            // 
            this.dateTime_registration.Location = new System.Drawing.Point(133, 207);
            this.dateTime_registration.Name = "dateTime_registration";
            this.dateTime_registration.Size = new System.Drawing.Size(187, 25);
            this.dateTime_registration.TabIndex = 12;
            // 
            // button_slet
            // 
            this.button_slet.Location = new System.Drawing.Point(121, 357);
            this.button_slet.Name = "button_slet";
            this.button_slet.Size = new System.Drawing.Size(85, 31);
            this.button_slet.TabIndex = 9;
            this.button_slet.Text = "Slet";
            this.button_slet.UseVisualStyleBackColor = true;
            this.button_slet.Click += new System.EventHandler(this.button_slet_Click);
            // 
            // but_Gem
            // 
            this.but_Gem.Location = new System.Drawing.Point(240, 296);
            this.but_Gem.Name = "but_Gem";
            this.but_Gem.Size = new System.Drawing.Size(85, 31);
            this.but_Gem.TabIndex = 1;
            this.but_Gem.Text = "Gem";
            this.but_Gem.UseVisualStyleBackColor = true;
            this.but_Gem.Click += new System.EventHandler(this.but_Gem_Click);
            // 
            // txtbilfabrikat
            // 
            this.txtbilfabrikat.Location = new System.Drawing.Point(133, 120);
            this.txtbilfabrikat.Name = "txtbilfabrikat";
            this.txtbilfabrikat.Size = new System.Drawing.Size(187, 25);
            this.txtbilfabrikat.TabIndex = 6;
            // 
            // txtNummerplade
            // 
            this.txtNummerplade.Location = new System.Drawing.Point(133, 71);
            this.txtNummerplade.Name = "txtNummerplade";
            this.txtNummerplade.Size = new System.Drawing.Size(187, 25);
            this.txtNummerplade.TabIndex = 4;
            // 
            // txtbilid
            // 
            this.txtbilid.Location = new System.Drawing.Point(133, 24);
            this.txtbilid.Name = "txtbilid";
            this.txtbilid.Size = new System.Drawing.Size(187, 25);
            this.txtbilid.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nummerplade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bilfabrikat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registration dato";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bil ID";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(370, 146);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(490, 250);
            this.dataGridView.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textmodel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.radioinacktiv);
            this.groupBox1.Controls.Add(this.radioaktiv);
            this.groupBox1.Controls.Add(this.txtkørtekm);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button_clear);
            this.groupBox1.Controls.Add(this.dateTime_registration);
            this.groupBox1.Controls.Add(this.button_slet);
            this.groupBox1.Controls.Add(this.but_Gem);
            this.groupBox1.Controls.Add(this.txtbilfabrikat);
            this.groupBox1.Controls.Add(this.txtNummerplade);
            this.groupBox1.Controls.Add(this.txtbilid);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 394);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opret Bil";
            // 
            // textmodel
            // 
            this.textmodel.Location = new System.Drawing.Point(133, 164);
            this.textmodel.Name = "textmodel";
            this.textmodel.Size = new System.Drawing.Size(187, 25);
            this.textmodel.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Model";
            // 
            // radioinacktiv
            // 
            this.radioinacktiv.AutoSize = true;
            this.radioinacktiv.Location = new System.Drawing.Point(126, 300);
            this.radioinacktiv.Name = "radioinacktiv";
            this.radioinacktiv.Size = new System.Drawing.Size(74, 22);
            this.radioinacktiv.TabIndex = 17;
            this.radioinacktiv.TabStop = true;
            this.radioinacktiv.Text = "Inactive";
            this.radioinacktiv.UseVisualStyleBackColor = true;
            // 
            // radioaktiv
            // 
            this.radioaktiv.AutoSize = true;
            this.radioaktiv.Location = new System.Drawing.Point(18, 300);
            this.radioaktiv.Name = "radioaktiv";
            this.radioaktiv.Size = new System.Drawing.Size(64, 22);
            this.radioaktiv.TabIndex = 16;
            this.radioaktiv.TabStop = true;
            this.radioaktiv.Text = "Active";
            this.radioaktiv.UseVisualStyleBackColor = true;
            // 
            // txtkørtekm
            // 
            this.txtkørtekm.Location = new System.Drawing.Point(133, 252);
            this.txtkørtekm.Name = "txtkørtekm";
            this.txtkørtekm.Size = new System.Drawing.Size(187, 25);
            this.txtkørtekm.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kørte kilometer";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(27, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 31);
            this.button1.TabIndex = 20;
            this.button1.Text = "Vise";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_bil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Mainmenu);
            this.Controls.Add(this.button_vise);
            this.Name = "Form_bil";
            this.Text = "Form_bil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_vise;
        private System.Windows.Forms.Button button_Mainmenu;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.DateTimePicker dateTime_registration;
        private System.Windows.Forms.Button button_slet;
        private System.Windows.Forms.Button but_Gem;
        private System.Windows.Forms.TextBox txtbilfabrikat;
        private System.Windows.Forms.TextBox txtNummerplade;
        private System.Windows.Forms.TextBox txtbilid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioinacktiv;
        private System.Windows.Forms.RadioButton radioaktiv;
        private System.Windows.Forms.TextBox txtkørtekm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textmodel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}