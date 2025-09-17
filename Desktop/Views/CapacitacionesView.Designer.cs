namespace Desktop.Views
{
    partial class CapacitacionesView
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
            components = new System.ComponentModel.Container();
            GridPeliculas = new DataGridView();
            BtnAgregar = new FontAwesome.Sharp.IconButton();
            BtnEliminar = new FontAwesome.Sharp.IconButton();
            BtnModificar = new FontAwesome.Sharp.IconButton();
            BtnSalir = new FontAwesome.Sharp.IconButton();
            tabAgregarEliminar = new TabControl();
            tabPageLista = new TabPage();
            BtnRestaurar = new FontAwesome.Sharp.IconButton();
            checkVerEliminados = new CheckBox();
            BtnBuscar = new FontAwesome.Sharp.IconButton();
            TxtBuscar = new TextBox();
            LbBuscar = new Label();
            FilmPicture = new PictureBox();
            tabPageAgregar = new TabPage();
            checkInscripcionAbierta = new CheckBox();
            label2 = new Label();
            dateTimeFechaHora = new DateTimePicker();
            TxtExponente = new TextBox();
            label3 = new Label();
            DuracionMinutos = new Label();
            NumericCupo = new NumericUpDown();
            TxtDetalle = new TextBox();
            TxtPortada = new Label();
            TxtNombre = new TextBox();
            TxtTitulo = new Label();
            BtnCancelar = new FontAwesome.Sharp.IconButton();
            BtnGuardar = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            label1 = new Label();
            LabelStatusMessage = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            TimerStatusBar = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)GridPeliculas).BeginInit();
            tabAgregarEliminar.SuspendLayout();
            tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FilmPicture).BeginInit();
            tabPageAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericCupo).BeginInit();
            panel1.SuspendLayout();
            LabelStatusMessage.SuspendLayout();
            SuspendLayout();
            // 
            // GridPeliculas
            // 
            GridPeliculas.AllowUserToAddRows = false;
            GridPeliculas.AllowUserToDeleteRows = false;
            GridPeliculas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridPeliculas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridPeliculas.Location = new Point(6, 66);
            GridPeliculas.MultiSelect = false;
            GridPeliculas.Name = "GridPeliculas";
            GridPeliculas.ReadOnly = true;
            GridPeliculas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridPeliculas.Size = new Size(710, 251);
            GridPeliculas.TabIndex = 0;
            GridPeliculas.SelectionChanged += GridPeliculas_SelectionChanged;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Anchor = AnchorStyles.Bottom;
            BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            BtnAgregar.IconColor = Color.Black;
            BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAgregar.IconSize = 40;
            BtnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgregar.Location = new Point(1136, 81);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(93, 43);
            BtnAgregar.TabIndex = 3;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.TextAlign = ContentAlignment.MiddleRight;
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Anchor = AnchorStyles.Bottom;
            BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            BtnEliminar.IconColor = Color.Black;
            BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEliminar.IconSize = 40;
            BtnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEliminar.Location = new Point(1136, 184);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(99, 54);
            BtnEliminar.TabIndex = 5;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.TextAlign = ContentAlignment.MiddleRight;
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.Anchor = AnchorStyles.Bottom;
            BtnModificar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            BtnModificar.IconColor = Color.Black;
            BtnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnModificar.IconSize = 40;
            BtnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnModificar.Location = new Point(1136, 130);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(97, 48);
            BtnModificar.TabIndex = 4;
            BtnModificar.Text = "Modificar";
            BtnModificar.TextAlign = ContentAlignment.MiddleRight;
            BtnModificar.UseVisualStyleBackColor = true;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            BtnSalir.IconColor = Color.Black;
            BtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnSalir.IconSize = 40;
            BtnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSalir.Location = new Point(1154, 323);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(81, 43);
            BtnSalir.TabIndex = 7;
            BtnSalir.Text = "Salir";
            BtnSalir.TextAlign = ContentAlignment.MiddleRight;
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // tabAgregarEliminar
            // 
            tabAgregarEliminar.Controls.Add(tabPageLista);
            tabAgregarEliminar.Controls.Add(tabPageAgregar);
            tabAgregarEliminar.Location = new Point(3, 62);
            tabAgregarEliminar.Name = "tabAgregarEliminar";
            tabAgregarEliminar.SelectedIndex = 0;
            tabAgregarEliminar.Size = new Size(1249, 400);
            tabAgregarEliminar.TabIndex = 6;
            // 
            // tabPageLista
            // 
            tabPageLista.Controls.Add(BtnRestaurar);
            tabPageLista.Controls.Add(checkVerEliminados);
            tabPageLista.Controls.Add(BtnBuscar);
            tabPageLista.Controls.Add(TxtBuscar);
            tabPageLista.Controls.Add(LbBuscar);
            tabPageLista.Controls.Add(FilmPicture);
            tabPageLista.Controls.Add(BtnEliminar);
            tabPageLista.Controls.Add(BtnModificar);
            tabPageLista.Controls.Add(BtnSalir);
            tabPageLista.Controls.Add(GridPeliculas);
            tabPageLista.Controls.Add(BtnAgregar);
            tabPageLista.Location = new Point(4, 24);
            tabPageLista.Name = "tabPageLista";
            tabPageLista.Padding = new Padding(3);
            tabPageLista.Size = new Size(1241, 372);
            tabPageLista.TabIndex = 0;
            tabPageLista.Text = "Lista";
            tabPageLista.UseVisualStyleBackColor = true;
            // 
            // BtnRestaurar
            // 
            BtnRestaurar.Anchor = AnchorStyles.Bottom;
            BtnRestaurar.IconChar = FontAwesome.Sharp.IconChar.Reply;
            BtnRestaurar.IconColor = Color.Black;
            BtnRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnRestaurar.IconSize = 40;
            BtnRestaurar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnRestaurar.Location = new Point(1136, 244);
            BtnRestaurar.Name = "BtnRestaurar";
            BtnRestaurar.Size = new Size(99, 54);
            BtnRestaurar.TabIndex = 6;
            BtnRestaurar.Text = "Restaurar";
            BtnRestaurar.TextAlign = ContentAlignment.MiddleRight;
            BtnRestaurar.UseVisualStyleBackColor = true;
            BtnRestaurar.Visible = false;
            BtnRestaurar.Click += BtnRestaurar_Click;
            // 
            // checkVerEliminados
            // 
            checkVerEliminados.AutoSize = true;
            checkVerEliminados.Location = new Point(752, 33);
            checkVerEliminados.Name = "checkVerEliminados";
            checkVerEliminados.Size = new Size(103, 19);
            checkVerEliminados.TabIndex = 1;
            checkVerEliminados.Text = "Ver eliminados";
            checkVerEliminados.UseVisualStyleBackColor = true;
            checkVerEliminados.CheckedChanged += checkVerEliminados_CheckedChanged;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Bottom;
            BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnBuscar.IconColor = Color.Black;
            BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscar.IconSize = 40;
            BtnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBuscar.Location = new Point(1136, 15);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(93, 50);
            BtnBuscar.TabIndex = 2;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.TextAlign = ContentAlignment.MiddleRight;
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += iconButton1_Click;
            // 
            // TxtBuscar
            // 
            TxtBuscar.Location = new Point(57, 30);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(659, 23);
            TxtBuscar.TabIndex = 0;
            TxtBuscar.TextChanged += TxtBuscar_TextChanged;
            // 
            // LbBuscar
            // 
            LbBuscar.Location = new Point(6, 33);
            LbBuscar.Name = "LbBuscar";
            LbBuscar.Size = new Size(45, 23);
            LbBuscar.TabIndex = 8;
            LbBuscar.Text = "Buscar:";
            // 
            // FilmPicture
            // 
            FilmPicture.Location = new Point(719, 66);
            FilmPicture.Name = "FilmPicture";
            FilmPicture.Size = new Size(271, 251);
            FilmPicture.SizeMode = PictureBoxSizeMode.Zoom;
            FilmPicture.TabIndex = 7;
            FilmPicture.TabStop = false;
            // 
            // tabPageAgregar
            // 
            tabPageAgregar.Controls.Add(checkInscripcionAbierta);
            tabPageAgregar.Controls.Add(label2);
            tabPageAgregar.Controls.Add(dateTimeFechaHora);
            tabPageAgregar.Controls.Add(TxtExponente);
            tabPageAgregar.Controls.Add(label3);
            tabPageAgregar.Controls.Add(DuracionMinutos);
            tabPageAgregar.Controls.Add(NumericCupo);
            tabPageAgregar.Controls.Add(TxtDetalle);
            tabPageAgregar.Controls.Add(TxtPortada);
            tabPageAgregar.Controls.Add(TxtNombre);
            tabPageAgregar.Controls.Add(TxtTitulo);
            tabPageAgregar.Controls.Add(BtnCancelar);
            tabPageAgregar.Controls.Add(BtnGuardar);
            tabPageAgregar.Location = new Point(4, 24);
            tabPageAgregar.Name = "tabPageAgregar";
            tabPageAgregar.Padding = new Padding(3);
            tabPageAgregar.Size = new Size(1241, 372);
            tabPageAgregar.TabIndex = 1;
            tabPageAgregar.Text = "Agregar/Editar";
            tabPageAgregar.UseVisualStyleBackColor = true;
            // 
            // checkInscripcionAbierta
            // 
            checkInscripcionAbierta.AutoSize = true;
            checkInscripcionAbierta.Location = new Point(303, 246);
            checkInscripcionAbierta.Name = "checkInscripcionAbierta";
            checkInscripcionAbierta.Size = new Size(125, 19);
            checkInscripcionAbierta.TabIndex = 5;
            checkInscripcionAbierta.Text = "Inscripcion Abierta";
            checkInscripcionAbierta.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 149);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 22;
            label2.Text = "Fecha y Hora";
            // 
            // dateTimeFechaHora
            // 
            dateTimeFechaHora.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimeFechaHora.Format = DateTimePickerFormat.Custom;
            dateTimeFechaHora.Location = new Point(303, 149);
            dateTimeFechaHora.Name = "dateTimeFechaHora";
            dateTimeFechaHora.Size = new Size(200, 23);
            dateTimeFechaHora.TabIndex = 3;
            // 
            // TxtExponente
            // 
            TxtExponente.Location = new Point(298, 111);
            TxtExponente.Name = "TxtExponente";
            TxtExponente.Size = new Size(397, 23);
            TxtExponente.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 111);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 19;
            label3.Text = "Orador/a";
            // 
            // DuracionMinutos
            // 
            DuracionMinutos.AutoSize = true;
            DuracionMinutos.Location = new Point(251, 196);
            DuracionMinutos.Name = "DuracionMinutos";
            DuracionMinutos.Size = new Size(36, 15);
            DuracionMinutos.TabIndex = 14;
            DuracionMinutos.Text = "Cupo";
            // 
            // NumericCupo
            // 
            NumericCupo.Location = new Point(303, 196);
            NumericCupo.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            NumericCupo.Name = "NumericCupo";
            NumericCupo.Size = new Size(77, 23);
            NumericCupo.TabIndex = 4;
            NumericCupo.TextAlign = HorizontalAlignment.Right;
            // 
            // TxtDetalle
            // 
            TxtDetalle.Location = new Point(298, 67);
            TxtDetalle.Name = "TxtDetalle";
            TxtDetalle.Size = new Size(397, 23);
            TxtDetalle.TabIndex = 1;
            // 
            // TxtPortada
            // 
            TxtPortada.AutoSize = true;
            TxtPortada.Location = new Point(221, 70);
            TxtPortada.Name = "TxtPortada";
            TxtPortada.Size = new Size(43, 15);
            TxtPortada.TabIndex = 11;
            TxtPortada.Text = "Detalle";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(298, 29);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(397, 23);
            TxtNombre.TabIndex = 0;
            // 
            // TxtTitulo
            // 
            TxtTitulo.AutoSize = true;
            TxtTitulo.Location = new Point(221, 29);
            TxtTitulo.Name = "TxtTitulo";
            TxtTitulo.Size = new Size(51, 15);
            TxtTitulo.TabIndex = 4;
            TxtTitulo.Text = "Nombre";
            // 
            // BtnCancelar
            // 
            BtnCancelar.Anchor = AnchorStyles.Bottom;
            BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            BtnCancelar.IconColor = Color.Black;
            BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelar.IconSize = 40;
            BtnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancelar.Location = new Point(591, 303);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(101, 43);
            BtnCancelar.TabIndex = 7;
            BtnCancelar.Text = "cancelar";
            BtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += iconButton3_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Anchor = AnchorStyles.Bottom;
            BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            BtnGuardar.IconColor = Color.Black;
            BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnGuardar.IconSize = 38;
            BtnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGuardar.Location = new Point(465, 303);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(104, 43);
            BtnGuardar.TabIndex = 6;
            BtnGuardar.Text = "Guardar ";
            BtnGuardar.TextAlign = ContentAlignment.MiddleRight;
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += iconButton2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1254, 58);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 0);
            label1.Name = "label1";
            label1.Size = new Size(301, 51);
            label1.TabIndex = 0;
            label1.Text = "Capacitaciones";
            // 
            // LabelStatusMessage
            // 
            LabelStatusMessage.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            LabelStatusMessage.Location = new Point(0, 467);
            LabelStatusMessage.Name = "LabelStatusMessage";
            LabelStatusMessage.Size = new Size(1252, 22);
            LabelStatusMessage.TabIndex = 8;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 17);
            // 
            // TimerStatusBar
            // 
            TimerStatusBar.Interval = 3000;
            TimerStatusBar.Tick += TimerStatusBar_Tick;
            // 
            // CapacitacionesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 489);
            Controls.Add(LabelStatusMessage);
            Controls.Add(panel1);
            Controls.Add(tabAgregarEliminar);
            Name = "CapacitacionesView";
            Text = "CapacitacionesView";
            ((System.ComponentModel.ISupportInitialize)GridPeliculas).EndInit();
            tabAgregarEliminar.ResumeLayout(false);
            tabPageLista.ResumeLayout(false);
            tabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FilmPicture).EndInit();
            tabPageAgregar.ResumeLayout(false);
            tabPageAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericCupo).EndInit();
            panel1.ResumeLayout(false);
            LabelStatusMessage.ResumeLayout(false);
            LabelStatusMessage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GridPeliculas;
        private FontAwesome.Sharp.IconButton BtnAgregar;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnModificar;
        private FontAwesome.Sharp.IconButton BtnSalir;
        private TabControl tabAgregarEliminar;
        private TabPage tabPageLista;
        private TabPage tabPageAgregar;
        private Panel panel1;
        private Label label1;
        private Label LbBuscar;
        private TextBox TxtBuscar;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private TextBox TxtNombre;
        private Label TxtTitulo;
        private TextBox TxtDetalle;
        private Label TxtPortada;
        private Label DuracionMinutos;
        private NumericUpDown NumericCupo;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private StatusStrip LabelStatusMessage;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer TimerStatusBar;
        private CheckBox checkVerEliminados;
        private FontAwesome.Sharp.IconButton BtnRestaurar;
        private PictureBox FilmPicture;
        private DateTimePicker dateTimeFechaHora;
        private TextBox TxtExponente;
        private Label label3;
        private Label label2;
        private CheckBox checkInscripcionAbierta;
    }
}