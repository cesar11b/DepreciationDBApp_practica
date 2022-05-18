
namespace DepreciationDBApp.Forms
{
    partial class FrmDec
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
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnActivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Location = new System.Drawing.Point(12, 93);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(201, 61);
            this.btnEmpleado.TabIndex = 5;
            this.btnEmpleado.Text = "Empleado";
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnActivo
            // 
            this.btnActivo.Location = new System.Drawing.Point(12, 12);
            this.btnActivo.Name = "btnActivo";
            this.btnActivo.Size = new System.Drawing.Size(201, 61);
            this.btnActivo.TabIndex = 4;
            this.btnActivo.Text = "Activo";
            this.btnActivo.UseVisualStyleBackColor = true;
            this.btnActivo.Click += new System.EventHandler(this.btnActivo_Click);
            // 
            // FrmDec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 234);
            this.Controls.Add(this.btnEmpleado);
            this.Controls.Add(this.btnActivo);
            this.Name = "FrmDec";
            this.Text = "FrmDec";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button btnActivo;
    }
}