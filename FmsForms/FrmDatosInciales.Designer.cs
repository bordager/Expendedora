namespace FmsForms
{
    partial class FrmDatosInciales
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtprov = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdin = new System.Windows.Forms.TextBox();
            this.btnaceptar1 = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿A que empresa pertenece esta maquina?";
            // 
            // txtprov
            // 
            this.txtprov.Location = new System.Drawing.Point(12, 25);
            this.txtprov.Name = "txtprov";
            this.txtprov.Size = new System.Drawing.Size(219, 20);
            this.txtprov.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "¿Que capacidad tiene esta expendedora?";
            // 
            // txtcap
            // 
            this.txtcap.Location = new System.Drawing.Point(12, 95);
            this.txtcap.Name = "txtcap";
            this.txtcap.Size = new System.Drawing.Size(219, 20);
            this.txtcap.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "¿Cuanto dinero incial va a ponerle a esta \r\nexpendedora?";
            // 
            // txtdin
            // 
            this.txtdin.Location = new System.Drawing.Point(15, 168);
            this.txtdin.Name = "txtdin";
            this.txtdin.Size = new System.Drawing.Size(216, 20);
            this.txtdin.TabIndex = 5;
            // 
            // btnaceptar1
            // 
            this.btnaceptar1.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar1.Location = new System.Drawing.Point(146, 244);
            this.btnaceptar1.Name = "btnaceptar1";
            this.btnaceptar1.Size = new System.Drawing.Size(72, 23);
            this.btnaceptar1.TabIndex = 6;
            this.btnaceptar1.Text = "Aceptar";
            this.btnaceptar1.UseVisualStyleBackColor = true;
            this.btnaceptar1.Click += new System.EventHandler(this.btnaceptar1_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(24, 244);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(72, 23);
            this.btnlimpiar.TabIndex = 7;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // FrmDatosInciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 299);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnaceptar1);
            this.Controls.Add(this.txtdin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtprov);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDatosInciales";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtprov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdin;
        private System.Windows.Forms.Button btnaceptar1;
        private System.Windows.Forms.Button btnlimpiar;
    }
}