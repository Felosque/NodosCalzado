﻿namespace CalzadoProyecto
{
    partial class VentanaPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calzadoDeInicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calzadoDelFinalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calzadoEnPosiciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calzadoPorNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarCalzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarListaDeCalzadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(145, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "INGENIERIA DE SISTEMAS";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.calzadoToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(608, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // calzadoToolStripMenuItem
            // 
            this.calzadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.mostrarListaDeCalzadoToolStripMenuItem});
            this.calzadoToolStripMenuItem.Name = "calzadoToolStripMenuItem";
            this.calzadoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.calzadoToolStripMenuItem.Text = "Calzado";
            // 
            // insertarToolStripMenuItem
            // 
            this.insertarToolStripMenuItem.Name = "insertarToolStripMenuItem";
            this.insertarToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.insertarToolStripMenuItem.Text = "Insertar Calzado";
            this.insertarToolStripMenuItem.Click += new System.EventHandler(this.insertarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calzadoDeInicioToolStripMenuItem,
            this.calzadoDelFinalToolStripMenuItem,
            this.calzadoEnPosiciónToolStripMenuItem1});
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // calzadoDeInicioToolStripMenuItem
            // 
            this.calzadoDeInicioToolStripMenuItem.Name = "calzadoDeInicioToolStripMenuItem";
            this.calzadoDeInicioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calzadoDeInicioToolStripMenuItem.Text = "Calzado de inicio";
            // 
            // calzadoDelFinalToolStripMenuItem
            // 
            this.calzadoDelFinalToolStripMenuItem.Name = "calzadoDelFinalToolStripMenuItem";
            this.calzadoDelFinalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calzadoDelFinalToolStripMenuItem.Text = "Calzado del final";
            // 
            // calzadoEnPosiciónToolStripMenuItem1
            // 
            this.calzadoEnPosiciónToolStripMenuItem1.Name = "calzadoEnPosiciónToolStripMenuItem1";
            this.calzadoEnPosiciónToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.calzadoEnPosiciónToolStripMenuItem1.Text = "Calzado en posición";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calzadoPorNombreToolStripMenuItem,
            this.actualizarCalzadoToolStripMenuItem});
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // calzadoPorNombreToolStripMenuItem
            // 
            this.calzadoPorNombreToolStripMenuItem.Name = "calzadoPorNombreToolStripMenuItem";
            this.calzadoPorNombreToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.calzadoPorNombreToolStripMenuItem.Text = "Calzado por nombre";
            // 
            // actualizarCalzadoToolStripMenuItem
            // 
            this.actualizarCalzadoToolStripMenuItem.Name = "actualizarCalzadoToolStripMenuItem";
            this.actualizarCalzadoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.actualizarCalzadoToolStripMenuItem.Text = "Actualizar calzado";
            // 
            // mostrarListaDeCalzadoToolStripMenuItem
            // 
            this.mostrarListaDeCalzadoToolStripMenuItem.Name = "mostrarListaDeCalzadoToolStripMenuItem";
            this.mostrarListaDeCalzadoToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.mostrarListaDeCalzadoToolStripMenuItem.Text = "Mostrar lista de calzado";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditosToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // creditosToolStripMenuItem
            // 
            this.creditosToolStripMenuItem.Name = "creditosToolStripMenuItem";
            this.creditosToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.creditosToolStripMenuItem.Text = "Creditos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(137, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "LISTA DE CALZADO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalzadoProyecto.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(201, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 83);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 405);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentanaPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calzadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditosToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem insertarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calzadoDeInicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calzadoDelFinalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calzadoEnPosiciónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calzadoPorNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarCalzadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarListaDeCalzadoToolStripMenuItem;
    }
}

