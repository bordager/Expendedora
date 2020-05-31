namespace FmsForms
{
    partial class Frmstock
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
            this.liststock = new System.Windows.Forms.ListBox();
            this.btnvolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // liststock
            // 
            this.liststock.FormattingEnabled = true;
            this.liststock.Location = new System.Drawing.Point(23, 25);
            this.liststock.Name = "liststock";
            this.liststock.Size = new System.Drawing.Size(197, 212);
            this.liststock.TabIndex = 0;
            // 
            // btnvolver
            // 
            this.btnvolver.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.Location = new System.Drawing.Point(82, 260);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(78, 22);
            this.btnvolver.TabIndex = 1;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // Frmstock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 299);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.liststock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmstock";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frmstock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox liststock;
        private System.Windows.Forms.Button btnvolver;
    }
}