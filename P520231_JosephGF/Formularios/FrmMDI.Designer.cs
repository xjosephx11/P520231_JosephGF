﻿namespace P520231_JosephGF.Formularios
{
    partial class FrmMDI
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
            this.MnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MnuGestiones = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasPorFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasPorProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasPorProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reimpresionDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuPrincipal
            // 
            this.MnuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MnuPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuGestiones,
            this.MnuProcesos,
            this.MnuReportes,
            this.MnuSalir,
            this.MnuAcercaDe});
            this.MnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MnuPrincipal.Name = "MnuPrincipal";
            this.MnuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MnuPrincipal.Size = new System.Drawing.Size(800, 29);
            this.MnuPrincipal.TabIndex = 1;
            this.MnuPrincipal.Text = "menuStrip1";
            // 
            // MnuGestiones
            // 
            this.MnuGestiones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeUsuariosToolStripMenuItem,
            this.gestionDeProductosToolStripMenuItem,
            this.gestionDeProveedoresToolStripMenuItem,
            this.categoriasDeProductosToolStripMenuItem,
            this.rolesDeUsuarioToolStripMenuItem,
            this.tipoDeProveedorToolStripMenuItem,
            this.tipoDeCompraToolStripMenuItem});
            this.MnuGestiones.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MnuGestiones.Name = "MnuGestiones";
            this.MnuGestiones.Size = new System.Drawing.Size(90, 25);
            this.MnuGestiones.Text = "Gestiones";
            this.MnuGestiones.Click += new System.EventHandler(this.MnuGestiones_Click);
            // 
            // MnuProcesos
            // 
            this.MnuProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeComprasToolStripMenuItem});
            this.MnuProcesos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MnuProcesos.Name = "MnuProcesos";
            this.MnuProcesos.Size = new System.Drawing.Size(84, 25);
            this.MnuProcesos.Text = "Procesos";
            this.MnuProcesos.Click += new System.EventHandler(this.MnuProcesos_Click);
            // 
            // MnuReportes
            // 
            this.MnuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasPorFechasToolStripMenuItem,
            this.comprasPorProveedorToolStripMenuItem,
            this.comprasPorProductosToolStripMenuItem,
            this.listadoDeInventarioToolStripMenuItem,
            this.reimpresionDeCompraToolStripMenuItem});
            this.MnuReportes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MnuReportes.Name = "MnuReportes";
            this.MnuReportes.Size = new System.Drawing.Size(84, 25);
            this.MnuReportes.Text = "Reportes";
            this.MnuReportes.Click += new System.EventHandler(this.MnuReportes_Click);
            // 
            // MnuSalir
            // 
            this.MnuSalir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MnuSalir.Name = "MnuSalir";
            this.MnuSalir.Size = new System.Drawing.Size(53, 25);
            this.MnuSalir.Text = "Salir";
            // 
            // MnuAcercaDe
            // 
            this.MnuAcercaDe.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MnuAcercaDe.Name = "MnuAcercaDe";
            this.MnuAcercaDe.Size = new System.Drawing.Size(89, 25);
            this.MnuAcercaDe.Text = "Acerca de";
            // 
            // gestionDeUsuariosToolStripMenuItem
            // 
            this.gestionDeUsuariosToolStripMenuItem.Name = "gestionDeUsuariosToolStripMenuItem";
            this.gestionDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.gestionDeUsuariosToolStripMenuItem.Text = "Gestion de Usuarios";
            // 
            // gestionDeProductosToolStripMenuItem
            // 
            this.gestionDeProductosToolStripMenuItem.Name = "gestionDeProductosToolStripMenuItem";
            this.gestionDeProductosToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.gestionDeProductosToolStripMenuItem.Text = "Gestion de Productos";
            // 
            // gestionDeProveedoresToolStripMenuItem
            // 
            this.gestionDeProveedoresToolStripMenuItem.Name = "gestionDeProveedoresToolStripMenuItem";
            this.gestionDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.gestionDeProveedoresToolStripMenuItem.Text = "Gestion de Proveedores";
            // 
            // categoriasDeProductosToolStripMenuItem
            // 
            this.categoriasDeProductosToolStripMenuItem.Name = "categoriasDeProductosToolStripMenuItem";
            this.categoriasDeProductosToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.categoriasDeProductosToolStripMenuItem.Text = "Categorias de Productos";
            // 
            // rolesDeUsuarioToolStripMenuItem
            // 
            this.rolesDeUsuarioToolStripMenuItem.Name = "rolesDeUsuarioToolStripMenuItem";
            this.rolesDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.rolesDeUsuarioToolStripMenuItem.Text = "Roles de Usuario";
            // 
            // tipoDeProveedorToolStripMenuItem
            // 
            this.tipoDeProveedorToolStripMenuItem.Name = "tipoDeProveedorToolStripMenuItem";
            this.tipoDeProveedorToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.tipoDeProveedorToolStripMenuItem.Text = "Tipo de Proveedor";
            // 
            // tipoDeCompraToolStripMenuItem
            // 
            this.tipoDeCompraToolStripMenuItem.Name = "tipoDeCompraToolStripMenuItem";
            this.tipoDeCompraToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.tipoDeCompraToolStripMenuItem.Text = "Tipo de Compra";
            // 
            // registroDeComprasToolStripMenuItem
            // 
            this.registroDeComprasToolStripMenuItem.Name = "registroDeComprasToolStripMenuItem";
            this.registroDeComprasToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.registroDeComprasToolStripMenuItem.Text = "Registro de Compras";
            // 
            // comprasPorFechasToolStripMenuItem
            // 
            this.comprasPorFechasToolStripMenuItem.Name = "comprasPorFechasToolStripMenuItem";
            this.comprasPorFechasToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.comprasPorFechasToolStripMenuItem.Text = "Compras por Fechas";
            // 
            // comprasPorProveedorToolStripMenuItem
            // 
            this.comprasPorProveedorToolStripMenuItem.Name = "comprasPorProveedorToolStripMenuItem";
            this.comprasPorProveedorToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.comprasPorProveedorToolStripMenuItem.Text = "Compras por Proveedor";
            // 
            // comprasPorProductosToolStripMenuItem
            // 
            this.comprasPorProductosToolStripMenuItem.Name = "comprasPorProductosToolStripMenuItem";
            this.comprasPorProductosToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.comprasPorProductosToolStripMenuItem.Text = "Compras por Productos";
            // 
            // listadoDeInventarioToolStripMenuItem
            // 
            this.listadoDeInventarioToolStripMenuItem.Name = "listadoDeInventarioToolStripMenuItem";
            this.listadoDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.listadoDeInventarioToolStripMenuItem.Text = "Listado de Inventario";
            // 
            // reimpresionDeCompraToolStripMenuItem
            // 
            this.reimpresionDeCompraToolStripMenuItem.Name = "reimpresionDeCompraToolStripMenuItem";
            this.reimpresionDeCompraToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.reimpresionDeCompraToolStripMenuItem.Text = "Reimpresion de compra";
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MnuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MnuPrincipal;
            this.Name = "FrmMDI";
            this.Text = "Sistema de Compras  Progra P5_2023_1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMDI_FormClosed);
            this.Load += new System.EventHandler(this.FrmMDI_Load);
            this.MnuPrincipal.ResumeLayout(false);
            this.MnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MnuGestiones;
        private System.Windows.Forms.ToolStripMenuItem MnuProcesos;
        private System.Windows.Forms.ToolStripMenuItem MnuReportes;
        private System.Windows.Forms.ToolStripMenuItem MnuSalir;
        private System.Windows.Forms.ToolStripMenuItem MnuAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem gestionDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasPorFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasPorProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasPorProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reimpresionDeCompraToolStripMenuItem;
    }
}