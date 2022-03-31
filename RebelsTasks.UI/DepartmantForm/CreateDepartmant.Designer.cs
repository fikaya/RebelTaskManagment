
namespace RebelsTasks.UI.DepartmantForm
{
    partial class CreateDepartmant
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
            this.departmanTxt = new System.Windows.Forms.TextBox();
            this.departmandescriptiontxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // departmanTxt
            // 
            this.departmanTxt.Location = new System.Drawing.Point(334, 109);
            this.departmanTxt.Name = "departmanTxt";
            this.departmanTxt.Size = new System.Drawing.Size(100, 23);
            this.departmanTxt.TabIndex = 0;
            // 
            // departmandescriptiontxt
            // 
            this.departmandescriptiontxt.Location = new System.Drawing.Point(334, 145);
            this.departmandescriptiontxt.Name = "departmandescriptiontxt";
            this.departmandescriptiontxt.Size = new System.Drawing.Size(100, 23);
            this.departmandescriptiontxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Departman İsmi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Departman Açıklaması";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateDepartmant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.departmandescriptiontxt);
            this.Controls.Add(this.departmanTxt);
            this.Name = "CreateDepartmant";
            this.Text = "CreateDepartmant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox departmanTxt;
        private System.Windows.Forms.TextBox departmandescriptiontxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}