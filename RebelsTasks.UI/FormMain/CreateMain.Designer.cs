
namespace RebelsTasks.UI.FormMain
{
    partial class CreateMain
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
            this.btnAddSubTask = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnStartedOn = new System.Windows.Forms.Button();
            this.grdSubTask = new System.Windows.Forms.DataGridView();
            this.colSubTaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTaskDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMainStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompletedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.altGörevSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSubTaskDescription = new System.Windows.Forms.TextBox();
            this.txtSubTaskName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.subTaskName = new System.Windows.Forms.Label();
            this.txtMainTaskDescription = new System.Windows.Forms.TextBox();
            this.txtMainTaskName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numEmployeeExperience = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.grdSubTask)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEmployeeExperience)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddSubTask
            // 
            this.btnAddSubTask.Location = new System.Drawing.Point(825, 193);
            this.btnAddSubTask.Name = "btnAddSubTask";
            this.btnAddSubTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddSubTask.TabIndex = 142;
            this.btnAddSubTask.Text = "Ekle";
            this.btnAddSubTask.UseVisualStyleBackColor = true;
            this.btnAddSubTask.Click += new System.EventHandler(this.subTaskSave_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(304, 207);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 133;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(248, 169);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(200, 23);
            this.cmbCustomer.TabIndex = 117;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(96, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 15);
            this.label9.TabIndex = 114;
            this.label9.Text = "Gerekli Deneyim Süresi";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(94, 169);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 15);
            this.label22.TabIndex = 107;
            this.label22.Text = "Görev Atanan Kişi";
            // 
            // btnStartedOn
            // 
            this.btnStartedOn.Location = new System.Drawing.Point(761, 147);
            this.btnStartedOn.Name = "btnStartedOn";
            this.btnStartedOn.Size = new System.Drawing.Size(200, 27);
            this.btnStartedOn.TabIndex = 154;
            this.btnStartedOn.Text = "Görev Tarihini Başlat";
            this.btnStartedOn.UseVisualStyleBackColor = true;
            this.btnStartedOn.Click += new System.EventHandler(this.btnStartedOn_Click);
            // 
            // grdSubTask
            // 
            this.grdSubTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSubTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSubTaskName,
            this.colSubTaskDescription,
            this.colMainStatus,
            this.colStartedOn,
            this.colCompletedOn});
            this.grdSubTask.Location = new System.Drawing.Point(570, 244);
            this.grdSubTask.MultiSelect = false;
            this.grdSubTask.Name = "grdSubTask";
            this.grdSubTask.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.grdSubTask.RowTemplate.Height = 25;
            this.grdSubTask.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSubTask.Size = new System.Drawing.Size(582, 227);
            this.grdSubTask.TabIndex = 167;
            // 
            // colSubTaskName
            // 
            this.colSubTaskName.DataPropertyName = "Name";
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
            this.txtSubTaskDescription.Location = new System.Drawing.Point(761, 109);
            this.txtSubTaskDescription.Name = "txtSubTaskDescription";
            this.txtSubTaskDescription.Size = new System.Drawing.Size(200, 23);
            this.txtSubTaskDescription.TabIndex = 162;
            // 
            // txtSubTaskName
            // 
            this.txtSubTaskName.Location = new System.Drawing.Point(761, 68);
            this.txtSubTaskName.Name = "txtSubTaskName";
            this.txtSubTaskName.Size = new System.Drawing.Size(200, 23);
            this.txtSubTaskName.TabIndex = 159;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(630, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 15);
            this.label10.TabIndex = 156;
            this.label10.Text = "Alt Görev Açıklaması";
            // 
            // subTaskName
            // 
            this.subTaskName.AutoSize = true;
            this.subTaskName.Location = new System.Drawing.Point(630, 70);
            this.subTaskName.Name = "subTaskName";
            this.subTaskName.Size = new System.Drawing.Size(81, 15);
            this.subTaskName.TabIndex = 155;
            this.subTaskName.Text = "Alt Görev İsmi";
            // 
            // txtMainTaskDescription
            // 
            this.txtMainTaskDescription.Location = new System.Drawing.Point(248, 90);
            this.txtMainTaskDescription.Name = "txtMainTaskDescription";
            this.txtMainTaskDescription.Size = new System.Drawing.Size(200, 23);
            this.txtMainTaskDescription.TabIndex = 171;
            // 
            // txtMainTaskName
            // 
            this.txtMainTaskName.Location = new System.Drawing.Point(248, 54);
            this.txtMainTaskName.Name = "txtMainTaskName";
            this.txtMainTaskName.Size = new System.Drawing.Size(200, 23);
            this.txtMainTaskName.TabIndex = 170;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 169;
            this.label1.Text = "Görev Açıklaması";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 168;
            this.label2.Text = "Görev İsmi";
            // 
            // numEmployeeExperience
            // 
            this.numEmployeeExperience.Location = new System.Drawing.Point(248, 128);
            this.numEmployeeExperience.Name = "numEmployeeExperience";
            this.numEmployeeExperience.Size = new System.Drawing.Size(200, 23);
            this.numEmployeeExperience.TabIndex = 172;
            this.numEmployeeExperience.ValueChanged += new System.EventHandler(this.numEmployeeExperience_ValueChanged);
            // 
            // CreateMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 493);
            this.Controls.Add(this.numEmployeeExperience);
            this.Controls.Add(this.txtMainTaskDescription);
            this.Controls.Add(this.txtMainTaskName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grdSubTask);
            this.Controls.Add(this.txtSubTaskDescription);
            this.Controls.Add(this.txtSubTaskName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.subTaskName);
            this.Controls.Add(this.btnStartedOn);
            this.Controls.Add(this.btnAddSubTask);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label22);
            this.Name = "CreateMain";
            this.Text = "CreateMain";
            ((System.ComponentModel.ISupportInitialize)(this.grdSubTask)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numEmployeeExperience)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddSubTask;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnStartedOn;
        private System.Windows.Forms.DataGridView grdSubTask;
        private System.Windows.Forms.TextBox txtSubTaskDescription;
        private System.Windows.Forms.TextBox txtSubTaskName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label subTaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTaskDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMainStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompletedOn;
        private System.Windows.Forms.TextBox txtMainTaskDescription;
        private System.Windows.Forms.TextBox txtMainTaskName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NumericUpDown numEmployeeExperience;
        private System.Windows.Forms.ToolStripMenuItem altGörevSilToolStripMenuItem;
    }
}