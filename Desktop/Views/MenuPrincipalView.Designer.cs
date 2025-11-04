namespace Desktop.Views
{
    partial class MenuPrincipalView
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
            menuStrip1 = new MenuStrip();
            SubMenuPrincipal = new ToolStripMenuItem();
            SubMenuUsuarios = new ToolStripMenuItem();
            SubMenuCapacitaciones = new ToolStripMenuItem();
            SubMenuTipoInscripciones = new ToolStripMenuItem();
            inscripcionesToolStripMenuItem = new ToolStripMenuItem();
            SubMenuSalir = new ToolStripMenuItem();
            SubMenuSalirDelSistema = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { SubMenuPrincipal, SubMenuSalir });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // SubMenuPrincipal
            // 
            SubMenuPrincipal.DropDownItems.AddRange(new ToolStripItem[] { SubMenuUsuarios, SubMenuCapacitaciones, SubMenuTipoInscripciones, inscripcionesToolStripMenuItem });
            SubMenuPrincipal.Name = "SubMenuPrincipal";
            SubMenuPrincipal.Size = new Size(65, 20);
            SubMenuPrincipal.Text = "Principal";
            // 
            // SubMenuUsuarios
            // 
            SubMenuUsuarios.Name = "SubMenuUsuarios";
            SubMenuUsuarios.Size = new Size(185, 22);
            SubMenuUsuarios.Text = "Usuarios";
            SubMenuUsuarios.Click += SubMenuUsuarios_Click;
            // 
            // SubMenuCapacitaciones
            // 
            SubMenuCapacitaciones.Name = "SubMenuCapacitaciones";
            SubMenuCapacitaciones.Size = new Size(185, 22);
            SubMenuCapacitaciones.Text = "Capacitaciones";
            SubMenuCapacitaciones.Click += SubMenuCapacitaciones_Click;
            // 
            // SubMenuTipoInscripciones
            // 
            SubMenuTipoInscripciones.Name = "SubMenuTipoInscripciones";
            SubMenuTipoInscripciones.Size = new Size(185, 22);
            SubMenuTipoInscripciones.Text = "Tipo de Inscripciones";
            SubMenuTipoInscripciones.Click += SubMenuTipoInscripciones_Click;
            // 
            // inscripcionesToolStripMenuItem
            // 
            inscripcionesToolStripMenuItem.Name = "inscripcionesToolStripMenuItem";
            inscripcionesToolStripMenuItem.Size = new Size(185, 22);
            inscripcionesToolStripMenuItem.Text = "Inscripciones";
            inscripcionesToolStripMenuItem.Click += inscripcionesToolStripMenuItem_Click;
            // 
            // SubMenuSalir
            // 
            SubMenuSalir.DropDownItems.AddRange(new ToolStripItem[] { SubMenuSalirDelSistema });
            SubMenuSalir.Name = "SubMenuSalir";
            SubMenuSalir.Size = new Size(41, 20);
            SubMenuSalir.Text = "Salir";
            // 
            // SubMenuSalirDelSistema
            // 
            SubMenuSalirDelSistema.Name = "SubMenuSalirDelSistema";
            SubMenuSalirDelSistema.Size = new Size(156, 22);
            SubMenuSalirDelSistema.Text = "Salir de Sistema";
            SubMenuSalirDelSistema.Click += SubMenuSalirDelSistema_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // MenuPrincipalView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MenuPrincipalView";
            Text = "MenuPrincipalView";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem SubMenuPrincipal;
        private ToolStripMenuItem SubMenuSalir;
        private ToolStripMenuItem SubMenuSalirDelSistema;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem SubMenuUsuarios;
        private ToolStripMenuItem SubMenuCapacitaciones;
        private ToolStripMenuItem SubMenuTipoInscripciones;
        private ToolStripMenuItem inscripcionesToolStripMenuItem;
    }
}