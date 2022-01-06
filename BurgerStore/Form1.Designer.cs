
namespace BurgerStore
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
            this.sipraişYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menüEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekstraEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sipraişYönetimiToolStripMenuItem,
            this.ürünYönetimiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sipraişYönetimiToolStripMenuItem
            // 
            this.sipraişYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişEkranıToolStripMenuItem,
            this.siparişBilgileriToolStripMenuItem});
            this.sipraişYönetimiToolStripMenuItem.Name = "sipraişYönetimiToolStripMenuItem";
            this.sipraişYönetimiToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.sipraişYönetimiToolStripMenuItem.Text = "Sipraiş Yönetimi";
            // 
            // siparişEkranıToolStripMenuItem
            // 
            this.siparişEkranıToolStripMenuItem.Name = "siparişEkranıToolStripMenuItem";
            this.siparişEkranıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparişEkranıToolStripMenuItem.Text = "Sipariş Oluştur";
            this.siparişEkranıToolStripMenuItem.Click += new System.EventHandler(this.siparişEkranıToolStripMenuItem_Click);
            // 
            // siparişBilgileriToolStripMenuItem
            // 
            this.siparişBilgileriToolStripMenuItem.Name = "siparişBilgileriToolStripMenuItem";
            this.siparişBilgileriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparişBilgileriToolStripMenuItem.Text = "Sipariş Bilgileri";
            this.siparişBilgileriToolStripMenuItem.Click += new System.EventHandler(this.siparişBilgileriToolStripMenuItem_Click);
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            this.ürünYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüEkleToolStripMenuItem,
            this.ekstraEkleToolStripMenuItem});
            this.ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            this.ürünYönetimiToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // menüEkleToolStripMenuItem
            // 
            this.menüEkleToolStripMenuItem.Name = "menüEkleToolStripMenuItem";
            this.menüEkleToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.menüEkleToolStripMenuItem.Text = "Menü Ekle";
            this.menüEkleToolStripMenuItem.Click += new System.EventHandler(this.menüEkleToolStripMenuItem_Click);
            // 
            // ekstraEkleToolStripMenuItem
            // 
            this.ekstraEkleToolStripMenuItem.Name = "ekstraEkleToolStripMenuItem";
            this.ekstraEkleToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ekstraEkleToolStripMenuItem.Text = "Ekstra Ekle";
            this.ekstraEkleToolStripMenuItem.Click += new System.EventHandler(this.ekstraEkleToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem sipraişYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menüEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekstraEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişEkranıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişBilgileriToolStripMenuItem;
    }
}

