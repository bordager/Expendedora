namespace FmsForms
{
    partial class FrmExtraer
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
            this.lstopcionbebida = new System.Windows.Forms.ListBox();
            this.textdinero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExtraer = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstopcionbebida
            // 
            this.lstopcionbebida.FormattingEnabled = true;
            this.lstopcionbebida.Location = new System.Drawing.Point(25, 29);
            this.lstopcionbebida.Name = "lstopcionbebida";
            this.lstopcionbebida.Size = new System.Drawing.Size(192, 134);
            this.lstopcionbebida.TabIndex = 0;
            // 
            // textdinero
            // 
            this.textdinero.Location = new System.Drawing.Point(26, 194);
            this.textdinero.Name = "textdinero";
            this.textdinero.Size = new System.Drawing.Size(191, 20);
            this.textdinero.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese el dinero que dispone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccione su bebida";
            // 
            // btnExtraer
            // 
            this.btnExtraer.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtraer.Location = new System.Drawing.Point(145, 249);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.Size = new System.Drawing.Size(72, 23);
            this.btnExtraer.TabIndex = 4;
            this.btnExtraer.Text = "Extraer";
            this.btnExtraer.UseVisualStyleBackColor = true;
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(26, 249);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(72, 23);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmExtraer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 299);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnExtraer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textdinero);
            this.Controls.Add(this.lstopcionbebida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmExtraer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmExtraer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstopcionbebida;
        private System.Windows.Forms.TextBox textdinero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExtraer;
        private System.Windows.Forms.Button btnVolver;
    }
}