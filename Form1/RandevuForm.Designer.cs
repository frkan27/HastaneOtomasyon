namespace Form1
{
    partial class RandevuForm
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
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.lstHastalar = new System.Windows.Forms.ListBox();
            this.flpSaatler = new System.Windows.Forms.FlowLayoutPanel();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnRandevuKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbServis
            // 
            this.cmbServis.FormattingEnabled = true;
            this.cmbServis.Location = new System.Drawing.Point(175, 12);
            this.cmbServis.Name = "cmbServis";
            this.cmbServis.Size = new System.Drawing.Size(150, 21);
            this.cmbServis.TabIndex = 1;
            this.cmbServis.SelectedIndexChanged += new System.EventHandler(this.cmbServis_SelectedIndexChanged);
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(350, 12);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(121, 21);
            this.cmbDoktor.TabIndex = 2;
            this.cmbDoktor.SelectedIndexChanged += new System.EventHandler(this.cmbDoktor_SelectedIndexChanged);
            // 
            // lstHastalar
            // 
            this.lstHastalar.FormattingEnabled = true;
            this.lstHastalar.Location = new System.Drawing.Point(12, 55);
            this.lstHastalar.Name = "lstHastalar";
            this.lstHastalar.Size = new System.Drawing.Size(129, 238);
            this.lstHastalar.TabIndex = 3;
            this.lstHastalar.SelectedIndexChanged += new System.EventHandler(this.lstHastalar_SelectedIndexChanged);
            this.lstHastalar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstHastalar_KeyDown);
            // 
            // flpSaatler
            // 
            this.flpSaatler.Location = new System.Drawing.Point(195, 55);
            this.flpSaatler.Name = "flpSaatler";
            this.flpSaatler.Size = new System.Drawing.Size(353, 245);
            this.flpSaatler.TabIndex = 4;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(12, 13);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(129, 20);
            this.txtAra.TabIndex = 5;
            // 
            // btnRandevuKaydet
            // 
            this.btnRandevuKaydet.Location = new System.Drawing.Point(599, 104);
            this.btnRandevuKaydet.Name = "btnRandevuKaydet";
            this.btnRandevuKaydet.Size = new System.Drawing.Size(90, 56);
            this.btnRandevuKaydet.TabIndex = 6;
            this.btnRandevuKaydet.Text = "Randevu";
            this.btnRandevuKaydet.UseVisualStyleBackColor = true;
            this.btnRandevuKaydet.Click += new System.EventHandler(this.btnRandevuKaydet_Click);
            // 
            // RandevuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRandevuKaydet);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.flpSaatler);
            this.Controls.Add(this.lstHastalar);
            this.Controls.Add(this.cmbDoktor);
            this.Controls.Add(this.cmbServis);
            this.Name = "RandevuForm";
            this.Text = "RandevuForm";
            this.Load += new System.EventHandler(this.RandevuForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RandevuForm_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbServis;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.ListBox lstHastalar;
        private System.Windows.Forms.FlowLayoutPanel flpSaatler;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnRandevuKaydet;
    }
}