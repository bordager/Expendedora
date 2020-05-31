namespace FmsForms
{
    partial class FrmEncender
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
            this.btnencender = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnencender
            // 
            this.btnencender.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnencender.Location = new System.Drawing.Point(63, 80);
            this.btnencender.Name = "btnencender";
            this.btnencender.Size = new System.Drawing.Size(115, 115);
            this.btnencender.TabIndex = 0;
            this.btnencender.Text = "Encender";
            this.btnencender.UseVisualStyleBackColor = true;
            this.btnencender.Click += new System.EventHandler(this.btnencender_Click);
            // 
            // FrmEncender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(243, 299);
            this.Controls.Add(this.btnencender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEncender";
            this.Text = "Expendedora";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnencender;
    }
}