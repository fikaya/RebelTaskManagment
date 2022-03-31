
namespace RebelsTasks.UI.FormMain
{
    partial class GridMain
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
            this.components = new System.ComponentModel.Container();
            this.grdMain = new System.Windows.Forms.DataGridView();
            this.colRequiredExperience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompletionRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompletedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignedToEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.görevListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altGörevListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdMain
            // 
            this.grdMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRequiredExperience,
            this.colCompletionRate,
            this.colName,
            this.colDescription,
            this.colProject,
            this.colStartedOn,
            this.colCompletedOn,
            this.colAssignedToEmployee});
            this.grdMain.Location = new System.Drawing.Point(-3, -4);
            this.grdMain.MultiSelect = false;
            this.grdMain.Name = "grdMain";
            this.grdMain.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.grdMain.RowTemplate.Height = 25;
            this.grdMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMain.Size = new System.Drawing.Size(1019, 470);
            this.grdMain.TabIndex = 3;
            this.grdMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMain_CellDoubleClick);
            this.grdMain.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdMain_CellMouseDown);
            // 
            // colRequiredExperience
            // 
            this.colRequiredExperience.DataPropertyName = "RequiredExperience";
            this.colRequiredExperience.HeaderText = "Gerekli Deneyim Süresi";
            this.colRequiredExperience.Name = "colRequiredExperience";
            this.colRequiredExperience.ReadOnly = true;
            // 
            // colCompletionRate
            // 
            this.colCompletionRate.DataPropertyName = "CompletionRate";
            this.colCompletionRate.HeaderText = "Tamamlanma Oranı";
            this.colCompletionRate.Name = "colCompletionRate";
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Görev İsmi";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "Description";
            this.colDescription.HeaderText = "Görev Açıklaması";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // colProject
            // 
            this.colProject.DataPropertyName = "Project";
            this.colProject.HeaderText = "Proje İsmi";
            this.colProject.Name = "colProject";
            // 
            // colStartedOn
            // 
            this.colStartedOn.DataPropertyName = "StartedOn";
            this.colStartedOn.HeaderText = "Başlama Tarihi";
            this.colStartedOn.Name = "colStartedOn";
            // 
            // colCompletedOn
            // 
            this.colCompletedOn.DataPropertyName = "CompletedOn";
            this.colCompletedOn.HeaderText = "Tamamlanma Tarihi";
            this.colCompletedOn.Name = "colCompletedOn";
            // 
            // colAssignedToEmployee
            // 
            this.colAssignedToEmployee.DataPropertyName = "AssignedToEmployee";
            this.colAssignedToEmployee.HeaderText = "Görev Atanan Kişi";
            this.colAssignedToEmployee.Name = "colAssignedToEmployee";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.görevListeleToolStripMenuItem,
            this.altGörevListeleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 48);
            // 
            // görevListeleToolStripMenuItem
            // 
            this.görevListeleToolStripMenuItem.Name = "görevListeleToolStripMenuItem";
            this.görevListeleToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.görevListeleToolStripMenuItem.Text = "Görev Sil";
            this.görevListeleToolStripMenuItem.Click += new System.EventHandler(this.görevListeleToolStripMenuItem_Click);
            // 
            // altGörevListeleToolStripMenuItem
            // 
            this.altGörevListeleToolStripMenuItem.Name = "altGörevListeleToolStripMenuItem";
            this.altGörevListeleToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.altGörevListeleToolStripMenuItem.Text = "Alt Görev Listele";
            this.altGörevListeleToolStripMenuItem.Click += new System.EventHandler(this.altGörevListeleToolStripMenuItem_Click);
            // 
            // GridMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 450);
            this.Controls.Add(this.grdMain);
            this.Name = "GridMain";
            this.Text = "GridMain";
            this.Load += new System.EventHandler(this.GridMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem görevListeleToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequiredExperience;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompletionRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompletedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignedToEmployee;
        private System.Windows.Forms.ToolStripMenuItem altGörevListeleToolStripMenuItem;
    }
}