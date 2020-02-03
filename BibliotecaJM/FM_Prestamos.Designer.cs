namespace BibliotecaJM
{
    partial class FM_Prestamos
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.librosDataGridView = new System.Windows.Forms.DataGridView();
            this.Prestar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.tbBuscarAutor = new System.Windows.Forms.TextBox();
            this.tbBuscarTitulo = new System.Windows.Forms.TextBox();
            this.tbBuscarIDLibro = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lectoresDataGridView = new System.Windows.Forms.DataGridView();
            this.btnBuscarNombre = new System.Windows.Forms.Button();
            this.tbIdentificador = new System.Windows.Forms.TextBox();
            this.btnBuscarID = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.librosPrestadosDataGridView = new System.Windows.Forms.DataGridView();
            this.dS_Lectores = new BibliotecaJM.DS_Lectores();
            this.dSLectoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lectoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lectoresTableAdapter = new BibliotecaJM.DS_LectoresTableAdapters.lectoresTableAdapter();
            this.idlecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrelecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domiciliolecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provincialecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emaillecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanacimientolecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechapenalizacionlecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dS_LibrosPrestados = new BibliotecaJM.DS_LibrosPrestados();
            this.dSLibrosPrestadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosPrestadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosPrestadosTableAdapter = new BibliotecaJM.DS_LibrosPrestadosTableAdapters.LibrosPrestadosTableAdapter();
            this.idlibDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulolibDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaprestapreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechadevolpreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dS_Libros = new BibliotecaJM.DS_Libros();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosTableAdapter = new BibliotecaJM.DS_LibrosTableAdapters.librosTableAdapter();
            this.idlecDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrelecDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domiciliolecDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provincialecDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emaillecDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanacimientolecDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechapenalizacionlecDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lectoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSLectoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_LibrosPrestados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSLibrosPrestadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.librosDataGridView);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.tbBuscarAutor);
            this.groupBox2.Controls.Add(this.tbBuscarTitulo);
            this.groupBox2.Controls.Add(this.tbBuscarIDLibro);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(524, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 645);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Libro";
            // 
            // librosDataGridView
            // 
            this.librosDataGridView.AllowUserToAddRows = false;
            this.librosDataGridView.AllowUserToDeleteRows = false;
            this.librosDataGridView.AutoGenerateColumns = false;
            this.librosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.librosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Prestar,
            this.idlecDataGridViewTextBoxColumn1,
            this.nombrelecDataGridViewTextBoxColumn1,
            this.domiciliolecDataGridViewTextBoxColumn1,
            this.provincialecDataGridViewTextBoxColumn1,
            this.emaillecDataGridViewTextBoxColumn1,
            this.fechanacimientolecDataGridViewTextBoxColumn1,
            this.fechapenalizacionlecDataGridViewTextBoxColumn1});
            this.librosDataGridView.DataSource = this.lectoresBindingSource1;
            this.librosDataGridView.Location = new System.Drawing.Point(6, 135);
            this.librosDataGridView.Name = "librosDataGridView";
            this.librosDataGridView.ReadOnly = true;
            this.librosDataGridView.RowHeadersVisible = false;
            this.librosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.librosDataGridView.Size = new System.Drawing.Size(449, 432);
            this.librosDataGridView.TabIndex = 7;
            // 
            // Prestar
            // 
            this.Prestar.HeaderText = "Prestar";
            this.Prestar.Name = "Prestar";
            this.Prestar.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(440, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "PRESTAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbBuscarAutor
            // 
            this.tbBuscarAutor.Location = new System.Drawing.Point(83, 91);
            this.tbBuscarAutor.Name = "tbBuscarAutor";
            this.tbBuscarAutor.Size = new System.Drawing.Size(280, 20);
            this.tbBuscarAutor.TabIndex = 1;
            // 
            // tbBuscarTitulo
            // 
            this.tbBuscarTitulo.Location = new System.Drawing.Point(83, 63);
            this.tbBuscarTitulo.Name = "tbBuscarTitulo";
            this.tbBuscarTitulo.Size = new System.Drawing.Size(280, 20);
            this.tbBuscarTitulo.TabIndex = 1;
            // 
            // tbBuscarIDLibro
            // 
            this.tbBuscarIDLibro.Location = new System.Drawing.Point(83, 33);
            this.tbBuscarIDLibro.Name = "tbBuscarIDLibro";
            this.tbBuscarIDLibro.Size = new System.Drawing.Size(280, 20);
            this.tbBuscarIDLibro.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(380, 89);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(380, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lectoresDataGridView);
            this.groupBox1.Controls.Add(this.btnBuscarNombre);
            this.groupBox1.Controls.Add(this.tbIdentificador);
            this.groupBox1.Controls.Add(this.btnBuscarID);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Location = new System.Drawing.Point(25, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 405);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda Lector";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Identificador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // lectoresDataGridView
            // 
            this.lectoresDataGridView.AllowUserToAddRows = false;
            this.lectoresDataGridView.AllowUserToDeleteRows = false;
            this.lectoresDataGridView.AllowUserToResizeRows = false;
            this.lectoresDataGridView.AutoGenerateColumns = false;
            this.lectoresDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lectoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lectoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlecDataGridViewTextBoxColumn,
            this.nombrelecDataGridViewTextBoxColumn,
            this.domiciliolecDataGridViewTextBoxColumn,
            this.provincialecDataGridViewTextBoxColumn,
            this.emaillecDataGridViewTextBoxColumn,
            this.fechanacimientolecDataGridViewTextBoxColumn,
            this.fechapenalizacionlecDataGridViewTextBoxColumn});
            this.lectoresDataGridView.DataSource = this.lectoresBindingSource;
            this.lectoresDataGridView.Location = new System.Drawing.Point(6, 103);
            this.lectoresDataGridView.MultiSelect = false;
            this.lectoresDataGridView.Name = "lectoresDataGridView";
            this.lectoresDataGridView.ReadOnly = true;
            this.lectoresDataGridView.RowHeadersVisible = false;
            this.lectoresDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lectoresDataGridView.Size = new System.Drawing.Size(460, 283);
            this.lectoresDataGridView.TabIndex = 1;
            // 
            // btnBuscarNombre
            // 
            this.btnBuscarNombre.Location = new System.Drawing.Point(367, 61);
            this.btnBuscarNombre.Name = "btnBuscarNombre";
            this.btnBuscarNombre.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarNombre.TabIndex = 4;
            this.btnBuscarNombre.Text = "Buscar";
            this.btnBuscarNombre.UseVisualStyleBackColor = true;
            // 
            // tbIdentificador
            // 
            this.tbIdentificador.Location = new System.Drawing.Point(89, 33);
            this.tbIdentificador.Name = "tbIdentificador";
            this.tbIdentificador.Size = new System.Drawing.Size(271, 20);
            this.tbIdentificador.TabIndex = 3;
            // 
            // btnBuscarID
            // 
            this.btnBuscarID.Location = new System.Drawing.Point(367, 28);
            this.btnBuscarID.Name = "btnBuscarID";
            this.btnBuscarID.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarID.TabIndex = 4;
            this.btnBuscarID.Text = "Buscar";
            this.btnBuscarID.UseVisualStyleBackColor = true;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(89, 63);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(271, 20);
            this.tbNombre.TabIndex = 3;
            // 
            // librosPrestadosDataGridView
            // 
            this.librosPrestadosDataGridView.AllowUserToAddRows = false;
            this.librosPrestadosDataGridView.AllowUserToDeleteRows = false;
            this.librosPrestadosDataGridView.AllowUserToResizeRows = false;
            this.librosPrestadosDataGridView.AutoGenerateColumns = false;
            this.librosPrestadosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.librosPrestadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosPrestadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlibDataGridViewTextBoxColumn,
            this.titulolibDataGridViewTextBoxColumn,
            this.fechaprestapreDataGridViewTextBoxColumn,
            this.fechadevolpreDataGridViewTextBoxColumn});
            this.librosPrestadosDataGridView.DataSource = this.librosPrestadosBindingSource;
            this.librosPrestadosDataGridView.Location = new System.Drawing.Point(31, 435);
            this.librosPrestadosDataGridView.MultiSelect = false;
            this.librosPrestadosDataGridView.Name = "librosPrestadosDataGridView";
            this.librosPrestadosDataGridView.ReadOnly = true;
            this.librosPrestadosDataGridView.RowHeadersVisible = false;
            this.librosPrestadosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.librosPrestadosDataGridView.Size = new System.Drawing.Size(460, 220);
            this.librosPrestadosDataGridView.TabIndex = 10;
            // 
            // dS_Lectores
            // 
            this.dS_Lectores.DataSetName = "DS_Lectores";
            this.dS_Lectores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSLectoresBindingSource
            // 
            this.dSLectoresBindingSource.DataSource = this.dS_Lectores;
            this.dSLectoresBindingSource.Position = 0;
            // 
            // lectoresBindingSource
            // 
            this.lectoresBindingSource.DataMember = "lectores";
            this.lectoresBindingSource.DataSource = this.dSLectoresBindingSource;
            // 
            // lectoresTableAdapter
            // 
            this.lectoresTableAdapter.ClearBeforeFill = true;
            // 
            // idlecDataGridViewTextBoxColumn
            // 
            this.idlecDataGridViewTextBoxColumn.DataPropertyName = "id_lec";
            this.idlecDataGridViewTextBoxColumn.HeaderText = "id_lec";
            this.idlecDataGridViewTextBoxColumn.Name = "idlecDataGridViewTextBoxColumn";
            this.idlecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombrelecDataGridViewTextBoxColumn
            // 
            this.nombrelecDataGridViewTextBoxColumn.DataPropertyName = "nombre_lec";
            this.nombrelecDataGridViewTextBoxColumn.HeaderText = "nombre_lec";
            this.nombrelecDataGridViewTextBoxColumn.Name = "nombrelecDataGridViewTextBoxColumn";
            this.nombrelecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // domiciliolecDataGridViewTextBoxColumn
            // 
            this.domiciliolecDataGridViewTextBoxColumn.DataPropertyName = "domicilio_lec";
            this.domiciliolecDataGridViewTextBoxColumn.HeaderText = "domicilio_lec";
            this.domiciliolecDataGridViewTextBoxColumn.Name = "domiciliolecDataGridViewTextBoxColumn";
            this.domiciliolecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // provincialecDataGridViewTextBoxColumn
            // 
            this.provincialecDataGridViewTextBoxColumn.DataPropertyName = "provincia_lec";
            this.provincialecDataGridViewTextBoxColumn.HeaderText = "provincia_lec";
            this.provincialecDataGridViewTextBoxColumn.Name = "provincialecDataGridViewTextBoxColumn";
            this.provincialecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emaillecDataGridViewTextBoxColumn
            // 
            this.emaillecDataGridViewTextBoxColumn.DataPropertyName = "email_lec";
            this.emaillecDataGridViewTextBoxColumn.HeaderText = "email_lec";
            this.emaillecDataGridViewTextBoxColumn.Name = "emaillecDataGridViewTextBoxColumn";
            this.emaillecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechanacimientolecDataGridViewTextBoxColumn
            // 
            this.fechanacimientolecDataGridViewTextBoxColumn.DataPropertyName = "fecha_nacimiento_lec";
            this.fechanacimientolecDataGridViewTextBoxColumn.HeaderText = "fecha_nacimiento_lec";
            this.fechanacimientolecDataGridViewTextBoxColumn.Name = "fechanacimientolecDataGridViewTextBoxColumn";
            this.fechanacimientolecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechapenalizacionlecDataGridViewTextBoxColumn
            // 
            this.fechapenalizacionlecDataGridViewTextBoxColumn.DataPropertyName = "fecha_penalizacion_lec";
            this.fechapenalizacionlecDataGridViewTextBoxColumn.HeaderText = "fecha_penalizacion_lec";
            this.fechapenalizacionlecDataGridViewTextBoxColumn.Name = "fechapenalizacionlecDataGridViewTextBoxColumn";
            this.fechapenalizacionlecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dS_LibrosPrestados
            // 
            this.dS_LibrosPrestados.DataSetName = "DS_LibrosPrestados";
            this.dS_LibrosPrestados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSLibrosPrestadosBindingSource
            // 
            this.dSLibrosPrestadosBindingSource.DataSource = this.dS_LibrosPrestados;
            this.dSLibrosPrestadosBindingSource.Position = 0;
            // 
            // librosPrestadosBindingSource
            // 
            this.librosPrestadosBindingSource.DataMember = "LibrosPrestados";
            this.librosPrestadosBindingSource.DataSource = this.dSLibrosPrestadosBindingSource;
            // 
            // librosPrestadosTableAdapter
            // 
            this.librosPrestadosTableAdapter.ClearBeforeFill = true;
            // 
            // idlibDataGridViewTextBoxColumn
            // 
            this.idlibDataGridViewTextBoxColumn.DataPropertyName = "id_lib";
            this.idlibDataGridViewTextBoxColumn.HeaderText = "id_lib";
            this.idlibDataGridViewTextBoxColumn.Name = "idlibDataGridViewTextBoxColumn";
            this.idlibDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titulolibDataGridViewTextBoxColumn
            // 
            this.titulolibDataGridViewTextBoxColumn.DataPropertyName = "titulo_lib";
            this.titulolibDataGridViewTextBoxColumn.HeaderText = "titulo_lib";
            this.titulolibDataGridViewTextBoxColumn.Name = "titulolibDataGridViewTextBoxColumn";
            this.titulolibDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaprestapreDataGridViewTextBoxColumn
            // 
            this.fechaprestapreDataGridViewTextBoxColumn.DataPropertyName = "fecha_presta_pre";
            this.fechaprestapreDataGridViewTextBoxColumn.HeaderText = "fecha_presta_pre";
            this.fechaprestapreDataGridViewTextBoxColumn.Name = "fechaprestapreDataGridViewTextBoxColumn";
            this.fechaprestapreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechadevolpreDataGridViewTextBoxColumn
            // 
            this.fechadevolpreDataGridViewTextBoxColumn.DataPropertyName = "fecha_devol_pre";
            this.fechadevolpreDataGridViewTextBoxColumn.HeaderText = "fecha_devol_pre";
            this.fechadevolpreDataGridViewTextBoxColumn.Name = "fechadevolpreDataGridViewTextBoxColumn";
            this.fechadevolpreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dS_Libros
            // 
            this.dS_Libros.DataSetName = "DS_Libros";
            this.dS_Libros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "libros";
            this.librosBindingSource.DataSource = this.dS_Libros;
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // idlecDataGridViewTextBoxColumn1
            // 
            this.idlecDataGridViewTextBoxColumn1.DataPropertyName = "id_lec";
            this.idlecDataGridViewTextBoxColumn1.HeaderText = "id_lec";
            this.idlecDataGridViewTextBoxColumn1.Name = "idlecDataGridViewTextBoxColumn1";
            this.idlecDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nombrelecDataGridViewTextBoxColumn1
            // 
            this.nombrelecDataGridViewTextBoxColumn1.DataPropertyName = "nombre_lec";
            this.nombrelecDataGridViewTextBoxColumn1.HeaderText = "nombre_lec";
            this.nombrelecDataGridViewTextBoxColumn1.Name = "nombrelecDataGridViewTextBoxColumn1";
            this.nombrelecDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // domiciliolecDataGridViewTextBoxColumn1
            // 
            this.domiciliolecDataGridViewTextBoxColumn1.DataPropertyName = "domicilio_lec";
            this.domiciliolecDataGridViewTextBoxColumn1.HeaderText = "domicilio_lec";
            this.domiciliolecDataGridViewTextBoxColumn1.Name = "domiciliolecDataGridViewTextBoxColumn1";
            this.domiciliolecDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // provincialecDataGridViewTextBoxColumn1
            // 
            this.provincialecDataGridViewTextBoxColumn1.DataPropertyName = "provincia_lec";
            this.provincialecDataGridViewTextBoxColumn1.HeaderText = "provincia_lec";
            this.provincialecDataGridViewTextBoxColumn1.Name = "provincialecDataGridViewTextBoxColumn1";
            this.provincialecDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // emaillecDataGridViewTextBoxColumn1
            // 
            this.emaillecDataGridViewTextBoxColumn1.DataPropertyName = "email_lec";
            this.emaillecDataGridViewTextBoxColumn1.HeaderText = "email_lec";
            this.emaillecDataGridViewTextBoxColumn1.Name = "emaillecDataGridViewTextBoxColumn1";
            this.emaillecDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fechanacimientolecDataGridViewTextBoxColumn1
            // 
            this.fechanacimientolecDataGridViewTextBoxColumn1.DataPropertyName = "fecha_nacimiento_lec";
            this.fechanacimientolecDataGridViewTextBoxColumn1.HeaderText = "fecha_nacimiento_lec";
            this.fechanacimientolecDataGridViewTextBoxColumn1.Name = "fechanacimientolecDataGridViewTextBoxColumn1";
            this.fechanacimientolecDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fechapenalizacionlecDataGridViewTextBoxColumn1
            // 
            this.fechapenalizacionlecDataGridViewTextBoxColumn1.DataPropertyName = "fecha_penalizacion_lec";
            this.fechapenalizacionlecDataGridViewTextBoxColumn1.HeaderText = "fecha_penalizacion_lec";
            this.fechapenalizacionlecDataGridViewTextBoxColumn1.Name = "fechapenalizacionlecDataGridViewTextBoxColumn1";
            this.fechapenalizacionlecDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lectoresBindingSource1
            // 
            this.lectoresBindingSource1.DataMember = "lectores";
            this.lectoresBindingSource1.DataSource = this.dSLectoresBindingSource;
            // 
            // FM_Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1010, 700);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.librosPrestadosDataGridView);
            this.Name = "FM_Prestamos";
            this.Load += new System.EventHandler(this.FM_Prestamos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSLectoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_LibrosPrestados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSLibrosPrestadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView librosDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Prestar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbBuscarAutor;
        private System.Windows.Forms.TextBox tbBuscarTitulo;
        private System.Windows.Forms.TextBox tbBuscarIDLibro;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView lectoresDataGridView;
        private System.Windows.Forms.Button btnBuscarNombre;
        private System.Windows.Forms.TextBox tbIdentificador;
        private System.Windows.Forms.Button btnBuscarID;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.DataGridView librosPrestadosDataGridView;
        private System.Windows.Forms.BindingSource dSLectoresBindingSource;
        private DS_Lectores dS_Lectores;
        private System.Windows.Forms.BindingSource lectoresBindingSource;
        private DS_LectoresTableAdapters.lectoresTableAdapter lectoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrelecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domiciliolecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provincialecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emaillecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanacimientolecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechapenalizacionlecDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dSLibrosPrestadosBindingSource;
        private DS_LibrosPrestados dS_LibrosPrestados;
        private System.Windows.Forms.BindingSource librosPrestadosBindingSource;
        private DS_LibrosPrestadosTableAdapters.LibrosPrestadosTableAdapter librosPrestadosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlibDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulolibDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaprestapreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechadevolpreDataGridViewTextBoxColumn;
        private DS_Libros dS_Libros;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private DS_LibrosTableAdapters.librosTableAdapter librosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlecDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrelecDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn domiciliolecDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn provincialecDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emaillecDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanacimientolecDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechapenalizacionlecDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource lectoresBindingSource1;
    }
}
