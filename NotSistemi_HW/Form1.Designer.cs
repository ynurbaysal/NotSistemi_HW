namespace NotSistemi_HW
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
            this.btnNot = new System.Windows.Forms.Button();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNot
            // 
            this.btnNot.Location = new System.Drawing.Point(36, 52);
            this.btnNot.Name = "btnNot";
            this.btnNot.Size = new System.Drawing.Size(75, 23);
            this.btnNot.TabIndex = 0;
            this.btnNot.Text = "Notunuz";
            this.btnNot.UseVisualStyleBackColor = true;
            this.btnNot.Click += new System.EventHandler(this.BtnNot_Click);
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(25, 12);
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(100, 20);
            this.txtNot.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.btnNot);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNot;
        private System.Windows.Forms.TextBox txtNot;
    }
}

