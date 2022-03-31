
namespace RebelsTasks.UI.FormMain
{
    partial class UpdateMain
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
            this.txtMainTaskDescription = new System.Windows.Forms.TextBox();
            this.txtMainTaskName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.grdSubTask = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.altGörevSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSubTaskDescription = new System.Windows.Forms.TextBox();
            this.txtSubTaskName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.subTaskName = new System.Windows.Forms.Label();
            this.btnStartedOn = new System.Windows.Forms.Button();
            this.btnAddSubTask = new System.Windows.Forms.Button();
            this.numEmployeeExperience = new System.Windows.Forms.NumericUpDown();
            this.colSubTaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTaskDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMainStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompletedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartedsOn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colCompletedsOn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdSubTask)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEmployeeExperience)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMainTaskDescription
            // 
            this.txtMainTaskDescription.Location = new System.Drawing.Point(203, 68);
            this.txtMainTaskDescription.Name = "txtMainTaskDescription";
            this.txtMainTaskDescription.Size = new System.Drawing.Size(200, 23);
            this.txtMainTaskDescription.TabIndex = 187;
            // 
            // txtMainTaskName
            // 
            this.txtMainTaskName.Location = new System.Drawing.Point(203, 32);
            this.txtMainTaskName.Name = "txtMainTaskName";
            this.txtMainTaskName.Size = new System.Drawing.Size(200, 23);
            this.txtMainTaskName.TabIndex = 186;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 185;
            this.label1.Text = "Görev Açıklaması";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 184;
            this.label2.Text = "Görev İsmi";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(259, 185);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 176;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(203, 147);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(200, 23);
            this.cmbCustomer.TabIndex = 174;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 15);
            this.label9.TabIndex = 173;
            this.label9.Text = "Gerekli Deneyim Süresi";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(51, 134);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 15);
            this.label22.TabIndex = 172;
            this.label22.Text = "Görev Atanan Kişi";
            // 
            // grdSubTask
            // 
            this.grdSubTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSubTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSubTaskName,
            this.colSubTaskDescription,
            this.colMainStatus,
            this.colStartedOn,
            this.colCompletedOn,
            this.colStartedsOn,
            this.colCompletedsOn});
            this.grdSubTask.Location = new System.Drawing.Point(119, 240);
            this.grdSubTask.MultiSelect = false;
            this.grdSubTask.Name = "grdSubTask";
            this.grdSubTask.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.grdSubTask.RowTemplate.Height = 25;
            this.grdSubTask.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSubTask.Size = new System.Drawing.Size(797, 227);
            this.grdSubTask.TabIndex = 194;
            this.grdSubTask.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSubTask_CellContentClick);
            this.grdSubTask.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdSubTask_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altGörevSilToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 26);
            // 
            // altGörevSilToolStripMenuItem
            // 
            this.altGörevSilToolStripMenuItem.Name = "altGörevSilToolStripMenuItem";
            this.altGörevSilToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.altGörevSilToolStripMenuItem.Text = "Alt Görev Sil";
            this.altGörevSilToolStripMenuItem.Click += new System.EventHandler(this.altGörevSilToolStripMenuItem_Click);
            // 
            // txtSubTaskDescription
            // 
            this.txtSubTaskDescription.Location = new System.Drawing.Point(642, 84);
            this.txtSubTaskDescription.Name = "txtSubTaskDescription";
            this.txtSubTaskDescription.Size = new System.Drawing.Size(200, 23);
            this.txtSubTaskDescription.TabIndex = 193;
            // 
            // txtSubTaskName
            // 
            this.txtSubTaskName.Location = new System.Drawing.Point(642, 43);
            this.txtSubTaskName.Name = "txtSubTaskName";
            this.txtSubTaskName.Size = new System.Drawing.Size(200, 23);
            this.txtSubTaskName.TabIndex = 192;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(511, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 15);
            this.label10.TabIndex = 191;
            this.label10.Text = "Alt Görev Açıklaması";
            // 
            // subTaskName
            // 
            this.subTaskName.AutoSize = true;
            this.subTaskName.Location = new System.Drawing.Point(511, 45);
            this.subTaskName.Name = "subTaskName";
            this.subTaskName.Size = new System.Drawing.Size(81, 15);
            this.subTaskName.TabIndex = 190;
            this.subTaskName.Text = "Alt Görev İsmi";
            // 
            // btnStartedOn
            // 
            this.btnStartedOn.Location = new System.Drawing.Point(642, 113);
            this.btnStartedOn.Name = "btnStartedOn";
            this.btnStartedOn.Size = new System.Drawing.Size(200, 27);
            this.btnStartedOn.TabIndex = 189;
            this.btnStartedOn.Text = "Görev Tarihini Başlat";
            this.btnStartedOn.UseVisualStyleBackColor = true;
            this.btnStartedOn.Click += new System.EventHandler(this.btnStartedOn_Click_1);
            // 
            // btnAddSubTask
            // 
            this.btnAddSubTask.Location = new System.Drawing.Point(706, 168);
            this.btnAddSubTask.Name = "btnAddSubTask";
            this.btnAddSubTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddSubTask.TabIndex = 188;
            this.btnAddSubTask.Text = "Ekle";
            this.btnAddSubTask.UseVisualStyleBackColor = true;
            this.btnAddSubTask.Click += new System.EventHandler(this.btnAddSubTask_Click);
            // 
            // numEmployeeExperience
            // 
            this.numEmployeeExperience.Location = new System.Drawing.Point(203, 106);
            this.numEmployeeExperience.Name = "numEmployeeExperience";
            this.numEmployeeExperience.Size = new System.Drawing.Size(200, 23);
            this.numEmployeeExperience.TabIndex = 195;
            this.numEmployeeExperience.ValueChanged += new System.EventHandler(this.numEmployeeExperience_ValueChanged_1);
            // 
            // colSubTaskName
            // 
            this.colSubTaskName.DataPropertyName = "Name";
            this.colSubTaskName.Frozen = true;
            this.colSubTaskName.HeaderText = "Alt Görev İsmi";
            this.colSubTaskName.Name = "colSubTaskName";
            this.colSubTaskName.ReadOnly = true;
            // 
            // colSubTaskDescription
            // 
            this.colSubTaskDescription.DataPropertyName = "Description";
            this.colSubTaskDescription.HeaderText = "Alt Görev Açıklaması";
            this.colSubTaskDescription.Name = "colSubTaskDescription";
            // 
            // colMainStatus
            // 
            this.colMainStatus.DataPropertyName = "Status";
            this.colMainStatus.HeaderText = "Alt Görev Durumu";
            this.colMainStatus.Name = "colMainStatus";
            this.colMainStatus.ReadOnly = true;
            // 
            // colStartedOn
            // 
            this.colStartedOn.DataPropertyName = "StartedOn";
            this.colStartedOn.HeaderText = "Alt Görev Başlama Tarihi";
            this.colStartedOn.Name = "colStartedOn";
            this.colStartedOn.ReadOnly = true;
            // 
            // colCompletedOn
            // 
            this.colCompletedOn.DataPropertyName = "CompletedOn";
            this.colCompletedOn.HeaderText = "Alt Görev Bitiş Tarihi";
            this.colCompletedOn.Name = "colCompletedOn";
            this.colCompletedOn.ReadOnly = true;
            // 
            // colStartedsOn
            // 
            this.colStartedsOn.HeaderText = "Başlangıç Tarihi";
            this.colStartedsOn.Name = "colStartedsOn";
            this.colStartedsOn.ReadOnly = true;
            this.colStartedsOn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colStartedsOn.Text = "Ekle";
            this.colStartedsOn.UseColumnTextForButtonValue = true;
            // 
            // colCompletedsOn
            // 
            this.colCompletedsOn.HeaderText = "Tamamlanma Tarihi";
            this.colCompletedsOn.Name = "colCompletedsOn";
            this.colCompletedsOn.ReadOnly = true;
            this.colCompletedsOn.Text = "Ekle";
            this.colCompletedsOn.UseColumnTextForButtonValue = true;
            // 
            // UpdateMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 514);
            this.Controls.Add(this.numEmployeeExperience);
            this.Controls.Add(this.grdSubTask);
            this.Controls.Add(this.txtSubTaskDescription);
            this.Controls.Add(this.txtSubTaskName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.subTaskName);
            this.Controls.Add(this.btnStartedOn);
            this.Controls.Add(this.btnAddSubTask);
            this.Controls.Add(this.txtMainTaskDescription);
            this.Controls.Add(this.txtMainTaskName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label22);
            this.Name = "UpdateMain";
            this.Text = "UpdateMain";
            this.Load += new System.EventHandler(this.UpdateMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSubTask)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numEmployeeExperience)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMainTaskDescription;
        private System.Windows.Forms.TextBox txtMainTaskName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridView grdSubTask;
        private System.Windows.Forms.TextBox txtSubTaskDescription;
        private System.Windows.Forms.TextBox txtSubTaskName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label subTaskName;
        private System.Windows.Forms.Button btnStartedOn;
        private System.Windows.Forms.Button btnAddSubTask;
        private System.Windows.Forms.NumericUpDown numEmployeeExperience;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem altGörevSilToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTaskDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMainStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompletedOn;
        private System.Windows.Forms.DataGridViewButtonColumn colStartedsOn;
        private System.Windows.Forms.DataGridViewButtonColumn colCompletedsOn;
    }
}