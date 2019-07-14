namespace FrbaCrucero.Menu
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarRolToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarFuncionalidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarFuncionalidadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoEstadisticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puertosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recorridosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarRecorridosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarRecorridoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crucerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCrucerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCruceroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprarPasajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservarPasajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarPasajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarViajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoEstadísticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolesToolStripMenuItem,
            this.puertosToolStripMenuItem,
            this.recorridosToolStripMenuItem,
            this.crucerosToolStripMenuItem,
            this.pasajesToolStripMenuItem,
            this.viajesToolStripMenuItem,
            this.estadisticaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(720, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarRolToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.listadoEstadisticoToolStripMenuItem});
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.rolesToolStripMenuItem.Text = "Administración";
            // 
            // agregarRolToolStripMenuItem
            // 
            this.agregarRolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoRolesToolStripMenuItem,
            this.agregarRolToolStripMenuItem1});
            this.agregarRolToolStripMenuItem.Name = "agregarRolToolStripMenuItem";
            this.agregarRolToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.agregarRolToolStripMenuItem.Text = "Roles";
            // 
            // listadoRolesToolStripMenuItem
            // 
            this.listadoRolesToolStripMenuItem.Name = "listadoRolesToolStripMenuItem";
            this.listadoRolesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.listadoRolesToolStripMenuItem.Text = "Listado Roles";
            this.listadoRolesToolStripMenuItem.Click += new System.EventHandler(this.listarRoles);
            // 
            // agregarRolToolStripMenuItem1
            // 
            this.agregarRolToolStripMenuItem1.Name = "agregarRolToolStripMenuItem1";
            this.agregarRolToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.agregarRolToolStripMenuItem1.Text = "Agregar Rol";
            this.agregarRolToolStripMenuItem1.Click += new System.EventHandler(this.btnAgregarRol);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarFuncionalidadToolStripMenuItem,
            this.agregarFuncionalidadToolStripMenuItem1});
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.listarToolStripMenuItem.Text = "Funcionalidades";
            // 
            // listarFuncionalidadToolStripMenuItem
            // 
            this.listarFuncionalidadToolStripMenuItem.Name = "listarFuncionalidadToolStripMenuItem";
            this.listarFuncionalidadToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.listarFuncionalidadToolStripMenuItem.Text = "Listar Funcionalidad";
            // 
            // agregarFuncionalidadToolStripMenuItem1
            // 
            this.agregarFuncionalidadToolStripMenuItem1.Name = "agregarFuncionalidadToolStripMenuItem1";
            this.agregarFuncionalidadToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.agregarFuncionalidadToolStripMenuItem1.Text = "Agregar Funcionalidad";
            // 
            // listadoEstadisticoToolStripMenuItem
            // 
            this.listadoEstadisticoToolStripMenuItem.Name = "listadoEstadisticoToolStripMenuItem";
            this.listadoEstadisticoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.listadoEstadisticoToolStripMenuItem.Text = "Listado Estadística";
            // 
            // puertosToolStripMenuItem
            // 
            this.puertosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem});
            this.puertosToolStripMenuItem.Name = "puertosToolStripMenuItem";
            this.puertosToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.puertosToolStripMenuItem.Text = "Puertos";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.agregarToolStripMenuItem.Text = "Agregar Puerto";
            // 
            // recorridosToolStripMenuItem
            // 
            this.recorridosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarRecorridosToolStripMenuItem,
            this.agregarRecorridoToolStripMenuItem});
            this.recorridosToolStripMenuItem.Name = "recorridosToolStripMenuItem";
            this.recorridosToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.recorridosToolStripMenuItem.Text = "Recorridos";
            // 
            // listarRecorridosToolStripMenuItem
            // 
            this.listarRecorridosToolStripMenuItem.Name = "listarRecorridosToolStripMenuItem";
            this.listarRecorridosToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.listarRecorridosToolStripMenuItem.Text = "Listar Recorridos";
            // 
            // agregarRecorridoToolStripMenuItem
            // 
            this.agregarRecorridoToolStripMenuItem.Name = "agregarRecorridoToolStripMenuItem";
            this.agregarRecorridoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.agregarRecorridoToolStripMenuItem.Text = "Agregar Recorrido";
            // 
            // crucerosToolStripMenuItem
            // 
            this.crucerosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarCrucerosToolStripMenuItem,
            this.agregarCruceroToolStripMenuItem});
            this.crucerosToolStripMenuItem.Name = "crucerosToolStripMenuItem";
            this.crucerosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.crucerosToolStripMenuItem.Text = "Cruceros";
            // 
            // listarCrucerosToolStripMenuItem
            // 
            this.listarCrucerosToolStripMenuItem.Name = "listarCrucerosToolStripMenuItem";
            this.listarCrucerosToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.listarCrucerosToolStripMenuItem.Text = "Listar Cruceros";
            // 
            // agregarCruceroToolStripMenuItem
            // 
            this.agregarCruceroToolStripMenuItem.Name = "agregarCruceroToolStripMenuItem";
            this.agregarCruceroToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.agregarCruceroToolStripMenuItem.Text = "Agregar Crucero";
            // 
            // pasajesToolStripMenuItem
            // 
            this.pasajesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprarPasajeToolStripMenuItem,
            this.reservarPasajeToolStripMenuItem,
            this.cancelarPasajeToolStripMenuItem});
            this.pasajesToolStripMenuItem.Name = "pasajesToolStripMenuItem";
            this.pasajesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pasajesToolStripMenuItem.Text = "Pasajes";
            // 
            // comprarPasajeToolStripMenuItem
            // 
            this.comprarPasajeToolStripMenuItem.Name = "comprarPasajeToolStripMenuItem";
            this.comprarPasajeToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.comprarPasajeToolStripMenuItem.Text = "Comprar Pasaje";
            // 
            // reservarPasajeToolStripMenuItem
            // 
            this.reservarPasajeToolStripMenuItem.Name = "reservarPasajeToolStripMenuItem";
            this.reservarPasajeToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.reservarPasajeToolStripMenuItem.Text = "Reservar Pasaje";
            // 
            // cancelarPasajeToolStripMenuItem
            // 
            this.cancelarPasajeToolStripMenuItem.Name = "cancelarPasajeToolStripMenuItem";
            this.cancelarPasajeToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.cancelarPasajeToolStripMenuItem.Text = "Cancelar Pasaje";
            // 
            // viajesToolStripMenuItem
            // 
            this.viajesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoToolStripMenuItem,
            this.agregarViajeToolStripMenuItem});
            this.viajesToolStripMenuItem.Name = "viajesToolStripMenuItem";
            this.viajesToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.viajesToolStripMenuItem.Text = "Viajes";
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.listadoToolStripMenuItem.Text = "Listado Viajes";
            this.listadoToolStripMenuItem.Click += new System.EventHandler(this.listadoToolStripMenuItem_Click);
            // 
            // agregarViajeToolStripMenuItem
            // 
            this.agregarViajeToolStripMenuItem.Name = "agregarViajeToolStripMenuItem";
            this.agregarViajeToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.agregarViajeToolStripMenuItem.Text = "Agregar Viaje";
            this.agregarViajeToolStripMenuItem.Click += new System.EventHandler(this.agregarViajeToolStripMenuItem_Click);
            // 
            // estadisticaToolStripMenuItem
            // 
            this.estadisticaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoEstadísticoToolStripMenuItem});
            this.estadisticaToolStripMenuItem.Name = "estadisticaToolStripMenuItem";
            this.estadisticaToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.estadisticaToolStripMenuItem.Text = "Estadística";
            this.estadisticaToolStripMenuItem.Click += new System.EventHandler(this.estadisticaToolStripMenuItem_Click);
            // 
            // listadoEstadísticoToolStripMenuItem
            // 
            this.listadoEstadísticoToolStripMenuItem.Name = "listadoEstadísticoToolStripMenuItem";
            this.listadoEstadísticoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.listadoEstadísticoToolStripMenuItem.Text = "Listado Estadístico";
            this.listadoEstadísticoToolStripMenuItem.Click += new System.EventHandler(this.listadoEstadísticoToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puertosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorridosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarRecorridosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarRecorridoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crucerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarCrucerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCruceroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasajesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprarPasajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservarPasajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarPasajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarRolToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listarFuncionalidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarFuncionalidadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listadoEstadisticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viajesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarViajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoEstadísticoToolStripMenuItem;
    }
}