namespace Form1
{
    partial class DoktorEkleme
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
            this.cmbServis = new System.Windows.Forms.ComboBox();
            this.lstDoktorlar = new System.Windows.Forms.ListBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.chlstHemsire = new System.Windows.Forms.CheckedListBox();
            this.btnHemsireGünc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbServis
            // 
            this.cmbServis.FormattingEnabled = true;
            this.cmbServis.Location = new System.Drawing.Point(24, 72);
            this.cmbServis.Name = "cmbServis";
            this.cmbServis.Size = new System.Drawing.Size(121, 21);
            this.cmbServis.TabIndex = 0;
            this.cmbServis.SelectedIndexChanged += new System.EventHandler(this.cmbServis_SelectedIndexChanged);
            // 
            // lstDoktorlar
            // 
            this.lstDoktorlar.FormattingEnabled = true;
            this.lstDoktorlar.Location = new System.Drawing.Point(207, 72);
            this.lstDoktorlar.Name = "lstDoktorlar";
            this.lstDoktorlar.Size = new System.Drawing.Size(157, 225);
            this.lstDoktorlar.TabIndex = 1;
            this.lstDoktorlar.SelectedIndexChanged += new System.EventHandler(this.lstDoktorlar_SelectedIndexChanged);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(207, 29);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(157, 20);
            this.txtAra.TabIndex = 2;
            this.txtAra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAra_KeyUp);
            // 
            // chlstHemsire
            // 
            this.chlstHemsire.FormattingEnabled = true;
            this.chlstHemsire.Location = new System.Drawing.Point(394, 29);
            this.chlstHemsire.Name = "chlstHemsire";
            this.chlstHemsire.Size = new System.Drawing.Size(151, 259);
            this.chlstHemsire.TabIndex = 3;
            // 
            // btnHemsireGünc
            // 
            this.btnHemsireGünc.Location = new System.Drawing.Point(98, 200);
            this.btnHemsireGünc.Name = "btnHemsireGünc";
            this.btnHemsireGünc.Size = new System.Drawing.Size(75, 42);
            this.btnHemsireGünc.TabIndex = 4;
            this.btnHemsireGünc.Text = "Hemşire güncele";
            this.btnHemsireGünc.UseVisualStyleBackColor = true;
            this.btnHemsireGünc.Click += new System.EventHandler(this.btnHemsireGünc_Click);
            // 
            // DoktorEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHemsireGünc);
            this.Controls.Add(this.chlstHemsire);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lstDoktorlar);
            this.Controls.Add(this.cmbServis);
            this.Name = "DoktorEkleme";
            this.Text = "DoktorEkleme";
            this.Load += new System.EventHandler(this.DoktorEkleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbServis;
        private System.Windows.Forms.ListBox lstDoktorlar;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.CheckedListBox chlstHemsire;
        private System.Windows.Forms.Button btnHemsireGünc;
    }
}