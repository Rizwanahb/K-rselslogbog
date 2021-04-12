namespace Kørselslogbog
{
    partial class Form_udtræk
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_udtræk = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.text_km = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Ch = new System.Windows.Forms.ComboBox();
            this.comboBox_bil = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chauffør ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bil ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(417, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Indtast chauffør id eller bil id for at udtrække kørselsoplysninger:";
            // 
            // button_udtræk
            // 
            this.button_udtræk.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_udtræk.Location = new System.Drawing.Point(600, 47);
            this.button_udtræk.Name = "button_udtræk";
            this.button_udtræk.Size = new System.Drawing.Size(160, 35);
            this.button_udtræk.TabIndex = 5;
            this.button_udtræk.Text = "Udtræk Entry_Log";
            this.button_udtræk.UseVisualStyleBackColor = true;
            this.button_udtræk.Click += new System.EventHandler(this.button_udtræk_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 263);
            this.dataGridView1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(600, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Forside";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_km
            // 
            this.text_km.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.text_km.Location = new System.Drawing.Point(194, 400);
            this.text_km.Name = "text_km";
            this.text_km.Size = new System.Drawing.Size(69, 20);
            this.text_km.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kørte Kilometer i alt";
            // 
            // comboBox_Ch
            // 
            this.comboBox_Ch.FormattingEnabled = true;
            this.comboBox_Ch.Location = new System.Drawing.Point(97, 53);
            this.comboBox_Ch.Name = "comboBox_Ch";
            this.comboBox_Ch.Size = new System.Drawing.Size(77, 21);
            this.comboBox_Ch.TabIndex = 10;
            this.comboBox_Ch.SelectedIndexChanged += new System.EventHandler(this.comboBox_Ch_SelectedIndexChanged);
            // 
            // comboBox_bil
            // 
            this.comboBox_bil.FormattingEnabled = true;
            this.comboBox_bil.Location = new System.Drawing.Point(322, 51);
            this.comboBox_bil.Name = "comboBox_bil";
            this.comboBox_bil.Size = new System.Drawing.Size(77, 21);
            this.comboBox_bil.TabIndex = 11;
            // 
            // Form_udtræk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_bil);
            this.Controls.Add(this.comboBox_Ch);
            this.Controls.Add(this.text_km);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_udtræk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_udtræk";
            this.Text = "Kørselslogbog_Udtræk";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_udtræk;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_km;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Ch;
        private System.Windows.Forms.ComboBox comboBox_bil;
    }
}