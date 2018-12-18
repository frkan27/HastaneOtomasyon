namespace Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kişiİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hemşireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.içeAKtarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dışaAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kişiİşlemleriToolStripMenuItem,
            this.randevuToolStripMenuItem,
            this.veriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kişiİşlemleriToolStripMenuItem
            // 
            this.kişiİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doktorToolStripMenuItem,
            this.hemşireToolStripMenuItem,
            this.hastaToolStripMenuItem,
            this.personleToolStripMenuItem});
            this.kişiİşlemleriToolStripMenuItem.Name = "kişiİşlemleriToolStripMenuItem";
            this.kişiİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.kişiİşlemleriToolStripMenuItem.Text = "Kişi İşlemleri";
            // 
            // doktorToolStripMenuItem
            // 
            this.doktorToolStripMenuItem.Name = "doktorToolStripMenuItem";
            this.doktorToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.doktorToolStripMenuItem.Text = "Doktor";
            this.doktorToolStripMenuItem.Click += new System.EventHandler(this.doktorToolStripMenuItem_Click);
            // 
            // hemşireToolStripMenuItem
            // 
            this.hemşireToolStripMenuItem.Name = "hemşireToolStripMenuItem";
            this.hemşireToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.hemşireToolStripMenuItem.Text = "Hemşire";
            // 
            // hastaToolStripMenuItem
            // 
            this.hastaToolStripMenuItem.Name = "hastaToolStripMenuItem";
            this.hastaToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.hastaToolStripMenuItem.Text = "Hasta";
            // 
            // personleToolStripMenuItem
            // 
            this.personleToolStripMenuItem.Name = "personleToolStripMenuItem";
            this.personleToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.personleToolStripMenuItem.Text = "Personle";
            // 
            // randevuToolStripMenuItem
            // 
            this.randevuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randevuAlToolStripMenuItem,
            this.raporlarToolStripMenuItem});
            this.randevuToolStripMenuItem.Name = "randevuToolStripMenuItem";
            this.randevuToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.randevuToolStripMenuItem.Text = "Randevu";
            // 
            // randevuAlToolStripMenuItem
            // 
            this.randevuAlToolStripMenuItem.Name = "randevuAlToolStripMenuItem";
            this.randevuAlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.randevuAlToolStripMenuItem.Text = "Randevu Al";
            this.randevuAlToolStripMenuItem.Click += new System.EventHandler(this.randevuAlToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            this.raporlarToolStripMenuItem.Click += new System.EventHandler(this.raporlarToolStripMenuItem_Click);
            // 
            // veriToolStripMenuItem
            // 
            this.veriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.içeAKtarToolStripMenuItem,
            this.dışaAktarToolStripMenuItem});
            this.veriToolStripMenuItem.Name = "veriToolStripMenuItem";
            this.veriToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.veriToolStripMenuItem.Text = "Veri";
            // 
            // içeAKtarToolStripMenuItem
            // 
            this.içeAKtarToolStripMenuItem.Name = "içeAKtarToolStripMenuItem";
            this.içeAKtarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.içeAKtarToolStripMenuItem.Text = "İçe AKtar";
            this.içeAKtarToolStripMenuItem.Click += new System.EventHandler(this.içeAKtarToolStripMenuItem_Click);
            // 
            // dışaAktarToolStripMenuItem
            // 
            this.dışaAktarToolStripMenuItem.Name = "dışaAktarToolStripMenuItem";
            this.dışaAktarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.dışaAktarToolStripMenuItem.Text = "Dışa Aktar";
            this.dışaAktarToolStripMenuItem.Click += new System.EventHandler(this.dışaAktarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kişiİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hemşireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem içeAKtarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dışaAktarToolStripMenuItem;
    }
}

