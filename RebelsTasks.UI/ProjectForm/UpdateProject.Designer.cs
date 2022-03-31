
namespace RebelsTasks.UI.ProjectForm
{
    partial class UpdateProject
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
            this.btnClosedOn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numEstimatedDuration = new System.Windows.Forms.NumericUpDown();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProjectDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.btnCompletedOn = new System.Windows.Forms.Button();
            this.btnStartedOn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numEstimatedDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClosedOn
            // 
            this.btnClosedOn.Location = new System.Drawing.Point(457, 107);
            this.btnClosedOn.Name = "btnClosedOn";
            this.btnClosedOn.Size = new System.Drawing.Size(220, 27);
            this.btnClosedOn.TabIndex = 55;
            this.btnClosedOn.Text = "Projeyi Kapat";
            this.btnClosedOn.UseVisualStyleBackColor = true;
            this.btnClosedOn.Click += new System.EventHandler(this.btnClosedOn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 15);
            this.label3.TabIndex = 54;
            this.label3.Text = "Tahmini Bitirliş Gün Sayısı";
            // 
            // numEstimatedDuration
            // 
            this.numEstimatedDuration.Location = new System.Drawing.Point(217, 134);
            this.numEstimatedDuration.Name = "numEstimatedDuration";
            this.numEstimatedDuration.Size = new System.Drawing.Size(200, 23);
            this.numEstimatedDuration.TabIndex = 53;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(217, 176);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 23);
            this.dtpStartDate.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 15);
            this.label5.TabIndex = 51;
            this.label5.Text = "Tahmini Başlangıç Tarihi";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(266, 229);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 50;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 49;
            this.label2.Text = "Proje Açıklaması";
            // 
            // txtProjectDescription
            // 
            this.txtProjectDescription.Location = new System.Drawing.Point(217, 87);
            this.txtProjectDescription.Name = "txtProjectDescription";
            this.txtProjectDescription.Size = new System.Drawing.Size(200, 23);
            this.txtProjectDescription.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 47;
            this.label1.Text = "Proje İsmi";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(217, 43);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(200, 23);
            this.txtProjectName.TabIndex = 46;
            // 
            // btnCompletedOn
            // 
            this.btnCompletedOn.Location = new System.Drawing.Point(457, 151);
            this.btnCompletedOn.Name = "btnCompletedOn";
            this.btnCompletedOn.Size = new System.Drawing.Size(220, 27);
            this.btnCompletedOn.TabIndex = 56;
            this.btnCompletedOn.Text = "Projeyi Tamamla";
            this.btnCompletedOn.UseVisualStyleBackColor = true;
            this.btnCompletedOn.Click += new System.EventHandler(this.btnCompletedOn_Click);
            // 
            // btnStartedOn
            // 
            this.btnStartedOn.Location = new System.Drawing.Point(457, 60);
            this.btnStartedOn.Name = "btnStartedOn";
            this.btnStartedOn.Size = new System.Drawing.Size(220, 27);
            this.btnStartedOn.TabIndex = 57;
            this.btnStartedOn.Text = "Proje Tarihini Başlat";
            this.btnStartedOn.UseVisualStyleBackColor = true;
            this.btnStartedOn.Click += new System.EventHandler(this.btnStartedOn_Click);
            // 
            // UpdateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStartedOn);
            this.Controls.Add(this.btnCompletedOn);
            this.Controls.Add(this.btnClosedOn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numEstimatedDuration);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProjectDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProjectName);
            this.Name = "UpdateProject";
            this.Text = "UpdateProject";
            this.Load += new System.EventHandler(this.UpdateProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numEstimatedDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClosedOn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numEstimatedDuration;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProjectDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Button btnCompletedOn;
        private System.Windows.Forms.Button btnStartedOn;
    }
}