
using System;

namespace archivosdetextos
{
    partial class FrmPluma
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.LblColor = new System.Windows.Forms.Label();
            this.TxtColor = new System.Windows.Forms.TextBox();
            this.TxtTipo = new System.Windows.Forms.TextBox();
            this.LblTipo = new System.Windows.Forms.Label();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.lst = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAbrir.Location = new System.Drawing.Point(298, 156);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Size = new System.Drawing.Size(75, 23);
            this.BtnAbrir.TabIndex = 0;
            this.BtnAbrir.Text = "Abrir";
            this.BtnAbrir.UseVisualStyleBackColor = false;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnGuardar.Location = new System.Drawing.Point(384, 156);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 1;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // LblColor
            // 
            this.LblColor.AutoSize = true;
            this.LblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblColor.ForeColor = System.Drawing.Color.Yellow;
            this.LblColor.Location = new System.Drawing.Point(62, 52);
            this.LblColor.Name = "LblColor";
            this.LblColor.Size = new System.Drawing.Size(136, 24);
            this.LblColor.TabIndex = 2;
            this.LblColor.Text = "Ingrese Color";
            this.LblColor.Click += new System.EventHandler(this.LblColor_Click);
            // 
            // TxtColor
            // 
            this.TxtColor.Location = new System.Drawing.Point(208, 57);
            this.TxtColor.Name = "TxtColor";
            this.TxtColor.Size = new System.Drawing.Size(110, 20);
            this.TxtColor.TabIndex = 3;
            this.TxtColor.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // TxtTipo
            // 
            this.TxtTipo.Location = new System.Drawing.Point(208, 102);
            this.TxtTipo.Name = "TxtTipo";
            this.TxtTipo.Size = new System.Drawing.Size(110, 20);
            this.TxtTipo.TabIndex = 4;
            this.TxtTipo.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipo.ForeColor = System.Drawing.Color.Yellow;
            this.LblTipo.Location = new System.Drawing.Point(62, 97);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(128, 24);
            this.LblTipo.TabIndex = 5;
            this.LblTipo.Text = "Ingrese Tipo";
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnInsertar.Location = new System.Drawing.Point(208, 156);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(75, 23);
            this.BtnInsertar.TabIndex = 6;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = false;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // lst
            // 
            this.lst.FormattingEnabled = true;
            this.lst.Location = new System.Drawing.Point(384, 37);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(120, 95);
            this.lst.TabIndex = 7;
            this.lst.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // FrmPluma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.LblTipo);
            this.Controls.Add(this.TxtTipo);
            this.Controls.Add(this.TxtColor);
            this.Controls.Add(this.LblColor);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnAbrir);
            this.Name = "FrmPluma";
            this.Text = "Pluma";
            this.Load += new System.EventHandler(this.FrmPluma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button BtnAbrir;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label LblColor;
        private System.Windows.Forms.TextBox TxtColor;
        private System.Windows.Forms.TextBox TxtTipo;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.ListBox lst;
    }
}

