
namespace RebelsTasks.UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.departmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmanEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmanListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projeListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmanToolStripMenuItem,
            this.çalışanToolStripMenuItem,
            this.projeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // departmanToolStripMenuItem
            // 
            this.departmanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmanEkleToolStripMenuItem,
            this.departmanListeleToolStripMenuItem});
            this.departmanToolStripMenuItem.Name = "departmanToolStripMenuItem";
            this.departmanToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.departmanToolStripMenuItem.Text = "Departman";
            // 
            // departmanEkleToolStripMenuItem
            // 
            this.departmanEkleToolStripMenuItem.Name = "departmanEkleToolStripMenuItem";
            this.departmanEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.departmanEkleToolStripMenuItem.Text = "Departman Ekle";
            this.departmanEkleToolStripMenuItem.Click += new System.EventHandler(this.departmanEkleToolStripMenuItem_Click);
            // 
            // departmanListeleToolStripMenuItem
            // 
            this.departmanListeleToolStripMenuItem.Name = "departmanListeleToolStripMenuItem";
            this.departmanListeleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.departmanListeleToolStripMenuItem.Text = "Departman Listele";
            this.departmanListeleToolStripMenuItem.Click += new System.EventHandler(this.departmanListeleToolStripMenuItem_Click);
            // 
            // çalışanToolStripMenuItem
            // 
            this.çalışanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çalışanEkleToolStripMenuItem,
            this.çalışanListeleToolStripMenuItem});
            this.çalışanToolStripMenuItem.Name = "çalışanToolStripMenuItem";
            this.çalışanToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.çalışanToolStripMenuItem.Text = "Çalışan";
            // 
            // çalışanEkleToolStripMenuItem
            // 
            this.çalışanEkleToolStripMenuItem.Name = "çalışanEkleToolStripMenuItem";
            this.çalışanEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çalışanEkleToolStripMenuItem.Text = "Çalışan Ekle";
            this.çalışanEkleToolStripMenuItem.Click += new System.EventHandler(this.çalışanEkleToolStripMenuItem_Click);
            // 
            // çalışanListeleToolStripMenuItem
            // 
            this.çalışanListeleToolStripMenuItem.Name = "çalışanListeleToolStripMenuItem";
            this.çalışanListeleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çalışanListeleToolStripMenuItem.Text = "Çalışan Listele";
            this.çalışanListeleToolStripMenuItem.Click += new System.EventHandler(this.çalışanListeleToolStripMenuItem_Click);
            // 
            // projeToolStripMenuItem
            // 
            this.projeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projeEkleToolStripMenuItem,
            this.projeListeleToolStripMenuItem});
            this.projeToolStripMenuItem.Name = "projeToolStripMenuItem";
            this.projeToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.projeToolStripMenuItem.Text = "Proje";
            // 
            // projeEkleToolStripMenuItem
            // 
            this.projeEkleToolStripMenuItem.Name = "projeEkleToolStripMenuItem";
            this.projeEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.projeEkleToolStripMenuItem.Text = "Proje Ekle";
            this.projeEkleToolStripMenuItem.Click += new System.EventHandler(this.projeEkleToolStripMenuItem_Click);
            // 
            // projeListeleToolStripMenuItem
            // 
            this.projeListeleToolStripMenuItem.Name = "projeListeleToolStripMenuItem";
            this.projeListeleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.projeListeleToolStripMenuItem.Text = "Proje Listele";
            this.projeListeleToolStripMenuItem.Click += new System.EventHandler(this.projeListeleToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem departmanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmanEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmanListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projeListeleToolStripMenuItem;
    }
}

