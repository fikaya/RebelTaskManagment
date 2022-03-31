
namespace RebelsTasks.UI.DepartmantForm
{
    partial class GridDepartment
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
            this.grdDepartment = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanlarıGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colDepartmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coDepartmantDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDepartment)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdDepartment
            // 
            this.grdDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDepartment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDepartmentId,
            this.colDepartmentName,
            this.coDepartmantDescription});
            this.grdDepartment.Location = new System.Drawing.Point(0, 1);
            this.grdDepartment.MultiSelect = false;
            this.grdDepartment.Name = "grdDepartment";
            this.grdDepartment.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.grdDepartment.RowTemplate.Height = 25;
            this.grdDepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDepartment.Size = new System.Drawing.Size(1088, 554);
            this.grdDepartment.TabIndex = 0;
            this.grdDepartment.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.grdDepartment.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteMenuItem,
            this.çalışanlarıGösterToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 48);
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.Size = new System.Drawing.Size(165, 22);
            this.deleteMenuItem.Text = "Sil";
            this.deleteMenuItem.Click += new System.EventHandler(this.deleteMenuItem_Click);
            // 
            // çalışanlarıGösterToolStripMenuItem
            // 
            this.çalışanlarıGösterToolStripMenuItem.Name = "çalışanlarıGösterToolStripMenuItem";
            this.çalışanlarıGösterToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.çalışanlarıGösterToolStripMenuItem.Text = "Çalışanları Göster";
            this.çalışanlarıGösterToolStripMenuItem.Click += new System.EventHandler(this.çalışanlarıGösterToolStripMenuItem_Click);
            // 
            // colDepartmentId
            // 
            this.colDepartmentId.DataPropertyName = "DepartmentId";
            this.colDepartmentId.HeaderText = "Departman Id";
            this.colDepartmentId.Name = "colDepartmentId";
            this.colDepartmentId.ReadOnly = true;
            // 
            // colDepartmentName
            // 
            this.colDepartmentName.DataPropertyName = "DepartmentName";
            this.colDepartmentName.HeaderText = "Departman Ad";
            this.colDepartmentName.Name = "colDepartmentName";
            this.colDepartmentName.ReadOnly = true;
            // 
            // coDepartmantDescription
            // 
            this.coDepartmantDescription.DataPropertyName = "DepartmentDescription";
            this.coDepartmantDescription.HeaderText = "Departman Açıklaması";
            this.coDepartmantDescription.Name = "coDepartmantDescription";
            this.coDepartmantDescription.ReadOnly = true;
            // 
            // GridDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 555);
            this.Controls.Add(this.grdDepartment);
            this.Name = "GridDepartment";
            this.Text = "GridDepartment";
            this.Load += new System.EventHandler(this.GridDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDepartment)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDepartment;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanlarıGösterToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn coDepartmantDescription;
    }
}