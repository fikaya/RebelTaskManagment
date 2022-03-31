
namespace RebelsTasks.UI.ProjectForm
{
    partial class GridProject
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
            this.grdProject = new System.Windows.Forms.DataGridView();
            this.colProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjectDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstimatedDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjectDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWorkedDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemainingDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompletedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClosedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görevEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görevListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdProject)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdProject
            // 
            this.grdProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProjectName,
            this.colProjectDescription,
            this.colEstimatedDuration,
            this.colStartDate,
            this.colProjectDueDate,
            this.colStartedOn,
            this.colWorkedDays,
            this.colRemainingDays,
            this.colCompletedOn,
            this.colClosedOn,
            this.colStatus});
            this.grdProject.Location = new System.Drawing.Point(12, 41);
            this.grdProject.MultiSelect = false;
            this.grdProject.Name = "grdProject";
            this.grdProject.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.grdProject.RowTemplate.Height = 25;
            this.grdProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProject.Size = new System.Drawing.Size(1142, 562);
            this.grdProject.TabIndex = 2;
            this.grdProject.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEmployee_CellDoubleClick);
            this.grdProject.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdEmployee_CellMouseDown);
            // 
            // colProjectName
            // 
            this.colProjectName.DataPropertyName = "Name";
            this.colProjectName.HeaderText = "Proje İsmi";
            this.colProjectName.Name = "colProjectName";
            this.colProjectName.ReadOnly = true;
            // 
            // colProjectDescription
            // 
            this.colProjectDescription.DataPropertyName = "Description";
            this.colProjectDescription.HeaderText = "Proje Açıklaması";
            this.colProjectDescription.Name = "colProjectDescription";
            // 
            // colEstimatedDuration
            // 
            this.colEstimatedDuration.DataPropertyName = "EstimatedDurationInDays";
            this.colEstimatedDuration.HeaderText = "Tahmini Bitirliş Gün Sayısı";
            this.colEstimatedDuration.Name = "colEstimatedDuration";
            this.colEstimatedDuration.ReadOnly = true;
            // 
            // colStartDate
            // 
            this.colStartDate.DataPropertyName = "StartDate";
            this.colStartDate.HeaderText = "Tahmini Başlangıç Tarihi";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.ReadOnly = true;
            // 
            // colProjectDueDate
            // 
            this.colProjectDueDate.DataPropertyName = "DueDate";
            this.colProjectDueDate.HeaderText = "Tarhmini Bitş Tarihi";
            this.colProjectDueDate.Name = "colProjectDueDate";
            // 
            // colStartedOn
            // 
            this.colStartedOn.DataPropertyName = "StartedOn";
            this.colStartedOn.HeaderText = "Başlama Tarihi";
            this.colStartedOn.Name = "colStartedOn";
            // 
            // colWorkedDays
            // 
            this.colWorkedDays.DataPropertyName = "WorkedDays";
            this.colWorkedDays.HeaderText = "Çalışılan Gün Sayısı";
            this.colWorkedDays.Name = "colWorkedDays";
            // 
            // colRemainingDays
            // 
            this.colRemainingDays.DataPropertyName = "RemainingDays";
            this.colRemainingDays.HeaderText = "Kalan Gün Sayısı";
            this.colRemainingDays.Name = "colRemainingDays";
            this.colRemainingDays.ReadOnly = true;
            // 
            // colCompletedOn
            // 
            this.colCompletedOn.DataPropertyName = "CompletedOn";
            this.colCompletedOn.HeaderText = "Tamamlanma Tarihi";
            this.colCompletedOn.Name = "colCompletedOn";
            // 
            // colClosedOn
            // 
            this.colClosedOn.DataPropertyName = "ClosedOn";
            this.colClosedOn.HeaderText = "Kapatılma Tarihi";
            this.colClosedOn.Name = "colClosedOn";
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Proje Durumu";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteMenuItem,
            this.görevEkleToolStripMenuItem,
            this.görevListeleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 70);
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.Size = new System.Drawing.Size(141, 22);
            this.deleteMenuItem.Text = "Proje Sil";
            this.deleteMenuItem.Click += new System.EventHandler(this.deleteMenuItem_Click);
            // 
            // görevEkleToolStripMenuItem
            // 
            this.görevEkleToolStripMenuItem.Name = "görevEkleToolStripMenuItem";
            this.görevEkleToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.görevEkleToolStripMenuItem.Text = "Görev Ekle";
            this.görevEkleToolStripMenuItem.Click += new System.EventHandler(this.görevEkleToolStripMenuItem_Click);
            // 
            // görevListeleToolStripMenuItem
            // 
            this.görevListeleToolStripMenuItem.Name = "görevListeleToolStripMenuItem";
            this.görevListeleToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.görevListeleToolStripMenuItem.Text = "Görev Listele";
            this.görevListeleToolStripMenuItem.Click += new System.EventHandler(this.görevListeleToolStripMenuItem_Click);
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(12, 12);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(175, 19);
            this.chkStatus.TabIndex = 3;
            this.chkStatus.Text = "Devam Eden Projeleri Göster";
            this.chkStatus.UseVisualStyleBackColor = true;
            this.chkStatus.CheckedChanged += new System.EventHandler(this.chkStatus_CheckedChanged);
            // 
            // GridProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 703);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.grdProject);
            this.Name = "GridProject";
            this.Text = "GridProject";
            this.Load += new System.EventHandler(this.GridProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProject)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstimatedDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWorkedDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemainingDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompletedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClosedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görevEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görevListeleToolStripMenuItem;
    }
}