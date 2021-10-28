
namespace Compilador_clase
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewSimbolos = new System.Windows.Forms.DataGridView();
            this.ColLexemaSim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCategoriaSim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNumeroLineaSim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPosicionInicialSim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPosicionFinalSim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lTablaSimbolos = new System.Windows.Forms.Label();
            this.groupTablaSimbolos = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PestTablaSimbolos = new System.Windows.Forms.TabPage();
            this.PestTablaLiterales = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewLiterales = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PestTablaPalabras = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewPalRes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PestTablaDummies = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewDummies = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.PestCompilador = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtConsola = new System.Windows.Forms.TextBox();
            this.TxtArchivo = new System.Windows.Forms.TextBox();
            this.BtnCarga = new System.Windows.Forms.Button();
            this.RbtnArchivo = new System.Windows.Forms.RadioButton();
            this.RbtnConsola = new System.Windows.Forms.RadioButton();
            this.PestTablas = new System.Windows.Forms.TabPage();
            this.PestErrores = new System.Windows.Forms.TabPage();
            this.enableDebug = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSimbolos)).BeginInit();
            this.groupTablaSimbolos.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.PestTablaSimbolos.SuspendLayout();
            this.PestTablaLiterales.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLiterales)).BeginInit();
            this.PestTablaPalabras.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPalRes)).BeginInit();
            this.PestTablaDummies.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDummies)).BeginInit();
            this.TabControl.SuspendLayout();
            this.PestCompilador.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.PestTablas.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Procesar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewSimbolos
            // 
            this.dataGridViewSimbolos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSimbolos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColLexemaSim,
            this.ColCategoriaSim,
            this.ColNumeroLineaSim,
            this.ColPosicionInicialSim,
            this.ColPosicionFinalSim});
            this.dataGridViewSimbolos.Location = new System.Drawing.Point(6, 54);
            this.dataGridViewSimbolos.Name = "dataGridViewSimbolos";
            this.dataGridViewSimbolos.Size = new System.Drawing.Size(547, 172);
            this.dataGridViewSimbolos.TabIndex = 1;
            this.dataGridViewSimbolos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColLexemaSim
            // 
            this.ColLexemaSim.HeaderText = "Lexema";
            this.ColLexemaSim.Name = "ColLexemaSim";
            this.ColLexemaSim.ReadOnly = true;
            // 
            // ColCategoriaSim
            // 
            this.ColCategoriaSim.HeaderText = "Categoría";
            this.ColCategoriaSim.Name = "ColCategoriaSim";
            this.ColCategoriaSim.ReadOnly = true;
            // 
            // ColNumeroLineaSim
            // 
            this.ColNumeroLineaSim.HeaderText = "Número de Línea";
            this.ColNumeroLineaSim.Name = "ColNumeroLineaSim";
            this.ColNumeroLineaSim.ReadOnly = true;
            // 
            // ColPosicionInicialSim
            // 
            this.ColPosicionInicialSim.HeaderText = "Posición Inicial";
            this.ColPosicionInicialSim.Name = "ColPosicionInicialSim";
            this.ColPosicionInicialSim.ReadOnly = true;
            // 
            // ColPosicionFinalSim
            // 
            this.ColPosicionFinalSim.HeaderText = "Posición Final";
            this.ColPosicionFinalSim.Name = "ColPosicionFinalSim";
            this.ColPosicionFinalSim.ReadOnly = true;
            // 
            // lTablaSimbolos
            // 
            this.lTablaSimbolos.AutoSize = true;
            this.lTablaSimbolos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lTablaSimbolos.Location = new System.Drawing.Point(95, 27);
            this.lTablaSimbolos.Name = "lTablaSimbolos";
            this.lTablaSimbolos.Size = new System.Drawing.Size(167, 24);
            this.lTablaSimbolos.TabIndex = 2;
            this.lTablaSimbolos.Text = "Tabla de Símbolos";
            // 
            // groupTablaSimbolos
            // 
            this.groupTablaSimbolos.Controls.Add(this.lTablaSimbolos);
            this.groupTablaSimbolos.Controls.Add(this.dataGridViewSimbolos);
            this.groupTablaSimbolos.Location = new System.Drawing.Point(80, 6);
            this.groupTablaSimbolos.Name = "groupTablaSimbolos";
            this.groupTablaSimbolos.Size = new System.Drawing.Size(559, 321);
            this.groupTablaSimbolos.TabIndex = 3;
            this.groupTablaSimbolos.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PestTablaSimbolos);
            this.tabControl1.Controls.Add(this.PestTablaLiterales);
            this.tabControl1.Controls.Add(this.PestTablaPalabras);
            this.tabControl1.Controls.Add(this.PestTablaDummies);
            this.tabControl1.Location = new System.Drawing.Point(57, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 348);
            this.tabControl1.TabIndex = 4;
            // 
            // PestTablaSimbolos
            // 
            this.PestTablaSimbolos.Controls.Add(this.groupTablaSimbolos);
            this.PestTablaSimbolos.Location = new System.Drawing.Point(4, 22);
            this.PestTablaSimbolos.Name = "PestTablaSimbolos";
            this.PestTablaSimbolos.Padding = new System.Windows.Forms.Padding(3);
            this.PestTablaSimbolos.Size = new System.Drawing.Size(780, 322);
            this.PestTablaSimbolos.TabIndex = 0;
            this.PestTablaSimbolos.Text = "Tabla Símbolos";
            this.PestTablaSimbolos.UseVisualStyleBackColor = true;
            // 
            // PestTablaLiterales
            // 
            this.PestTablaLiterales.Controls.Add(this.groupBox1);
            this.PestTablaLiterales.Location = new System.Drawing.Point(4, 22);
            this.PestTablaLiterales.Name = "PestTablaLiterales";
            this.PestTablaLiterales.Padding = new System.Windows.Forms.Padding(3);
            this.PestTablaLiterales.Size = new System.Drawing.Size(780, 322);
            this.PestTablaLiterales.TabIndex = 1;
            this.PestTablaLiterales.Text = "Tabla Literales";
            this.PestTablaLiterales.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridViewLiterales);
            this.groupBox1.Location = new System.Drawing.Point(111, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 321);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(95, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tabla de Literales";
            // 
            // dataGridViewLiterales
            // 
            this.dataGridViewLiterales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLiterales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridViewLiterales.Location = new System.Drawing.Point(6, 54);
            this.dataGridViewLiterales.Name = "dataGridViewLiterales";
            this.dataGridViewLiterales.Size = new System.Drawing.Size(547, 172);
            this.dataGridViewLiterales.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Lexema";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Categoría";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Número de Línea";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Posición Inicial";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Posición Final";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // PestTablaPalabras
            // 
            this.PestTablaPalabras.Controls.Add(this.groupBox3);
            this.PestTablaPalabras.Location = new System.Drawing.Point(4, 22);
            this.PestTablaPalabras.Name = "PestTablaPalabras";
            this.PestTablaPalabras.Padding = new System.Windows.Forms.Padding(3);
            this.PestTablaPalabras.Size = new System.Drawing.Size(780, 322);
            this.PestTablaPalabras.TabIndex = 2;
            this.PestTablaPalabras.Text = "Tabla Palabras Reservadas";
            this.PestTablaPalabras.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dataGridViewPalRes);
            this.groupBox3.Location = new System.Drawing.Point(111, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(559, 321);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(95, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tabla de Palabras Reservadas";
            // 
            // dataGridViewPalRes
            // 
            this.dataGridViewPalRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPalRes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataGridViewPalRes.Location = new System.Drawing.Point(6, 54);
            this.dataGridViewPalRes.Name = "dataGridViewPalRes";
            this.dataGridViewPalRes.Size = new System.Drawing.Size(547, 172);
            this.dataGridViewPalRes.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Lexema";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Categoría";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Número de Línea";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Posición Inicial";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Posición Final";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // PestTablaDummies
            // 
            this.PestTablaDummies.Controls.Add(this.groupBox4);
            this.PestTablaDummies.Location = new System.Drawing.Point(4, 22);
            this.PestTablaDummies.Name = "PestTablaDummies";
            this.PestTablaDummies.Padding = new System.Windows.Forms.Padding(3);
            this.PestTablaDummies.Size = new System.Drawing.Size(780, 322);
            this.PestTablaDummies.TabIndex = 3;
            this.PestTablaDummies.Text = "Tabla Dummies";
            this.PestTablaDummies.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.dataGridViewDummies);
            this.groupBox4.Location = new System.Drawing.Point(111, 1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(559, 321);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(95, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tabla de Dummies";
            // 
            // dataGridViewDummies
            // 
            this.dataGridViewDummies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDummies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.dataGridViewDummies.Location = new System.Drawing.Point(6, 54);
            this.dataGridViewDummies.Name = "dataGridViewDummies";
            this.dataGridViewDummies.Size = new System.Drawing.Size(547, 172);
            this.dataGridViewDummies.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Lexema";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Categoría";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Número de Línea";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Posición Inicial";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Posición Final";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.PestCompilador);
            this.TabControl.Controls.Add(this.PestTablas);
            this.TabControl.Controls.Add(this.PestErrores);
            this.TabControl.Location = new System.Drawing.Point(12, 6);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(900, 417);
            this.TabControl.TabIndex = 5;
            // 
            // PestCompilador
            // 
            this.PestCompilador.Controls.Add(this.enableDebug);
            this.PestCompilador.Controls.Add(this.groupBox2);
            this.PestCompilador.Controls.Add(this.button1);
            this.PestCompilador.Location = new System.Drawing.Point(4, 22);
            this.PestCompilador.Name = "PestCompilador";
            this.PestCompilador.Padding = new System.Windows.Forms.Padding(3);
            this.PestCompilador.Size = new System.Drawing.Size(892, 391);
            this.PestCompilador.TabIndex = 0;
            this.PestCompilador.Text = "Compilador";
            this.PestCompilador.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtConsola);
            this.groupBox2.Controls.Add(this.TxtArchivo);
            this.groupBox2.Controls.Add(this.BtnCarga);
            this.groupBox2.Controls.Add(this.RbtnArchivo);
            this.groupBox2.Controls.Add(this.RbtnConsola);
            this.groupBox2.Location = new System.Drawing.Point(61, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(757, 228);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cargar destino";
            // 
            // txtConsola
            // 
            this.txtConsola.Location = new System.Drawing.Point(6, 72);
            this.txtConsola.Multiline = true;
            this.txtConsola.Name = "txtConsola";
            this.txtConsola.Size = new System.Drawing.Size(500, 98);
            this.txtConsola.TabIndex = 4;
            // 
            // TxtArchivo
            // 
            this.TxtArchivo.Location = new System.Drawing.Point(6, 46);
            this.TxtArchivo.Name = "TxtArchivo";
            this.TxtArchivo.Size = new System.Drawing.Size(500, 20);
            this.TxtArchivo.TabIndex = 2;
            // 
            // BtnCarga
            // 
            this.BtnCarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCarga.Location = new System.Drawing.Point(512, 43);
            this.BtnCarga.Name = "BtnCarga";
            this.BtnCarga.Size = new System.Drawing.Size(75, 23);
            this.BtnCarga.TabIndex = 3;
            this.BtnCarga.Text = "Cargar";
            this.BtnCarga.UseVisualStyleBackColor = true;
            this.BtnCarga.Click += new System.EventHandler(this.BtnCarga_Click);
            // 
            // RbtnArchivo
            // 
            this.RbtnArchivo.AutoSize = true;
            this.RbtnArchivo.Location = new System.Drawing.Point(33, 23);
            this.RbtnArchivo.Name = "RbtnArchivo";
            this.RbtnArchivo.Size = new System.Drawing.Size(61, 17);
            this.RbtnArchivo.TabIndex = 0;
            this.RbtnArchivo.TabStop = true;
            this.RbtnArchivo.Text = "Archivo";
            this.RbtnArchivo.UseVisualStyleBackColor = true;
            this.RbtnArchivo.CheckedChanged += new System.EventHandler(this.RbtnArchivo_CheckedChanged);
            // 
            // RbtnConsola
            // 
            this.RbtnConsola.AutoSize = true;
            this.RbtnConsola.Location = new System.Drawing.Point(149, 23);
            this.RbtnConsola.Name = "RbtnConsola";
            this.RbtnConsola.Size = new System.Drawing.Size(63, 17);
            this.RbtnConsola.TabIndex = 1;
            this.RbtnConsola.TabStop = true;
            this.RbtnConsola.Text = "Consola";
            this.RbtnConsola.UseVisualStyleBackColor = true;
            this.RbtnConsola.CheckedChanged += new System.EventHandler(this.RbtnConsola_CheckedChanged);
            // 
            // PestTablas
            // 
            this.PestTablas.Controls.Add(this.tabControl1);
            this.PestTablas.Location = new System.Drawing.Point(4, 22);
            this.PestTablas.Name = "PestTablas";
            this.PestTablas.Padding = new System.Windows.Forms.Padding(3);
            this.PestTablas.Size = new System.Drawing.Size(892, 391);
            this.PestTablas.TabIndex = 1;
            this.PestTablas.Text = "Tablas";
            this.PestTablas.UseVisualStyleBackColor = true;
            // 
            // PestErrores
            // 
            this.PestErrores.Location = new System.Drawing.Point(4, 22);
            this.PestErrores.Name = "PestErrores";
            this.PestErrores.Padding = new System.Windows.Forms.Padding(3);
            this.PestErrores.Size = new System.Drawing.Size(892, 391);
            this.PestErrores.TabIndex = 2;
            this.PestErrores.Text = "Errores";
            this.PestErrores.UseVisualStyleBackColor = true;
            // 
            // enableDebug
            // 
            this.enableDebug.AutoSize = true;
            this.enableDebug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enableDebug.Location = new System.Drawing.Point(389, 322);
            this.enableDebug.Name = "enableDebug";
            this.enableDebug.Size = new System.Drawing.Size(58, 17);
            this.enableDebug.TabIndex = 7;
            this.enableDebug.Text = "Debug";
            this.enableDebug.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 471);
            this.Controls.Add(this.TabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSimbolos)).EndInit();
            this.groupTablaSimbolos.ResumeLayout(false);
            this.groupTablaSimbolos.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.PestTablaSimbolos.ResumeLayout(false);
            this.PestTablaLiterales.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLiterales)).EndInit();
            this.PestTablaPalabras.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPalRes)).EndInit();
            this.PestTablaDummies.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDummies)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.PestCompilador.ResumeLayout(false);
            this.PestCompilador.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.PestTablas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewSimbolos;
        private System.Windows.Forms.Label lTablaSimbolos;
        private System.Windows.Forms.GroupBox groupTablaSimbolos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PestTablaSimbolos;
        private System.Windows.Forms.TabPage PestTablaLiterales;
        private System.Windows.Forms.TabPage PestTablaPalabras;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLexemaSim;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCategoriaSim;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumeroLineaSim;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPosicionInicialSim;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPosicionFinalSim;
        private System.Windows.Forms.TabPage PestTablaDummies;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage PestCompilador;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtConsola;
        private System.Windows.Forms.TextBox TxtArchivo;
        private System.Windows.Forms.Button BtnCarga;
        private System.Windows.Forms.RadioButton RbtnArchivo;
        private System.Windows.Forms.RadioButton RbtnConsola;
        private System.Windows.Forms.TabPage PestTablas;
        private System.Windows.Forms.TabPage PestErrores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewLiterales;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewPalRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewDummies;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.CheckBox enableDebug;
    }
}

