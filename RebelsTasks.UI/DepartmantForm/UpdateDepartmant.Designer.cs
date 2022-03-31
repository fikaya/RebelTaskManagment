
namespace RebelsTasks.UI.DepartmantForm
{
    partial class UpdateDepartmant
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.departmandescriptiontxt = new System.Windows.Forms.TextBox();
            this.departmanTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(415, 199);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Departman Açıklaması";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Departman İsmi";
            // 
            // departmandescriptiontxt
            // 
            this.departmandescriptiontxt.Location = new System.Drawing.Point(402, 155);
            this.departmandescriptiontxt.Name = "departmandescriptiontxt";
            this.departmandescriptiontxt.Size = new System.Drawing.Size(100, 23);
            this.departmandescriptiontxt.TabIndex = 6;
            // 
            // departmanTxt
            // 
            this.departmanTxt.Location = new System.Drawing.Point(402, 119);
            this.departmanTxt.Name = "departmanTxt";
            this.departmanTxt.Size = new System.Drawing.Size(100, 23);
            this.departmanTxt.TabIndex = 5;
            // 
            // UpdateDepartmant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.departmandescriptiontxt);
            this.Controls.Add(this.departmanTxt);
            this.Name = "UpdateDepartmant";
            this.Text = "UpdateDepartmant";
            this.Load += new System.EventHandler(this.UpdateDepartmant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox departmandescriptiontxt;
        private System.Windows.Forms.TextBox departmanTxt;
    }
}