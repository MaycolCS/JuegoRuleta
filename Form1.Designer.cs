namespace pruebaMasivian
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_GenerarIdRuleta = new System.Windows.Forms.Button();
            this.label_idRuleta = new System.Windows.Forms.Label();
            this.groupBox_CrearRuleta = new System.Windows.Forms.GroupBox();
            this.button_ConsultarEstadoRuleta = new System.Windows.Forms.Button();
            this.label_EstadoRuletaConsultada = new System.Windows.Forms.Label();
            this.label_EstadoRuleta = new System.Windows.Forms.Label();
            this.comboBox_ListaRuletas = new System.Windows.Forms.ComboBox();
            this.idRuleta = new System.Windows.Forms.Label();
            this.groupBox_VerificarRuleta = new System.Windows.Forms.GroupBox();
            this.comboBox_IngresoIdRuleta = new System.Windows.Forms.ComboBox();
            this.comboBox_IngresoColorApuesta = new System.Windows.Forms.ComboBox();
            this.comboBox_IngresoNumeroApuesta = new System.Windows.Forms.ComboBox();
            this.label_NumeroApuesta = new System.Windows.Forms.Label();
            this.label_ColorApuesta = new System.Windows.Forms.Label();
            this.label_ValorApuesta = new System.Windows.Forms.Label();
            this.textBox_IngresoValorApuesta = new System.Windows.Forms.TextBox();
            this.label_DatosApuesta = new System.Windows.Forms.Label();
            this.label_IngresoIdUsuario = new System.Windows.Forms.Label();
            this.textBox_IngresoIdCliente = new System.Windows.Forms.TextBox();
            this.button_RealizarApuesta = new System.Windows.Forms.Button();
            this.label_IngresoIdRuleta = new System.Windows.Forms.Label();
            this.groupBox_CerrarRuleta = new System.Windows.Forms.GroupBox();
            this.comboBox_IdRuletaCerrada = new System.Windows.Forms.ComboBox();
            this.textBox_ResultadoApuestas = new System.Windows.Forms.TextBox();
            this.label_Resultados = new System.Windows.Forms.Label();
            this.label_IdRuletadaCerrada = new System.Windows.Forms.Label();
            this.button_CerrarRuleta = new System.Windows.Forms.Button();
            this.button_CrearUsuario = new System.Windows.Forms.Button();
            this.button_Clean = new System.Windows.Forms.Button();
            this.button_CloseApp = new System.Windows.Forms.Button();
            this.groupBox_CrearRuleta.SuspendLayout();
            this.groupBox_VerificarRuleta.SuspendLayout();
            this.groupBox_CerrarRuleta.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_GenerarIdRuleta
            // 
            this.button_GenerarIdRuleta.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_GenerarIdRuleta.Location = new System.Drawing.Point(122, 46);
            this.button_GenerarIdRuleta.Name = "button_GenerarIdRuleta";
            this.button_GenerarIdRuleta.Size = new System.Drawing.Size(101, 23);
            this.button_GenerarIdRuleta.TabIndex = 0;
            this.button_GenerarIdRuleta.Text = "Crear ruleta";
            this.button_GenerarIdRuleta.UseVisualStyleBackColor = true;
            this.button_GenerarIdRuleta.Click += new System.EventHandler(this.button_GenerarIdRuleta_Click);
            // 
            // label_idRuleta
            // 
            this.label_idRuleta.AutoSize = true;
            this.label_idRuleta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_idRuleta.Location = new System.Drawing.Point(6, 19);
            this.label_idRuleta.Name = "label_idRuleta";
            this.label_idRuleta.Size = new System.Drawing.Size(97, 18);
            this.label_idRuleta.TabIndex = 1;
            this.label_idRuleta.Text = "ID Ruleta:";
            // 
            // groupBox_CrearRuleta
            // 
            this.groupBox_CrearRuleta.Controls.Add(this.button_ConsultarEstadoRuleta);
            this.groupBox_CrearRuleta.Controls.Add(this.label_EstadoRuletaConsultada);
            this.groupBox_CrearRuleta.Controls.Add(this.label_EstadoRuleta);
            this.groupBox_CrearRuleta.Controls.Add(this.comboBox_ListaRuletas);
            this.groupBox_CrearRuleta.Controls.Add(this.idRuleta);
            this.groupBox_CrearRuleta.Controls.Add(this.label_idRuleta);
            this.groupBox_CrearRuleta.Controls.Add(this.button_GenerarIdRuleta);
            this.groupBox_CrearRuleta.Location = new System.Drawing.Point(27, 28);
            this.groupBox_CrearRuleta.Name = "groupBox_CrearRuleta";
            this.groupBox_CrearRuleta.Size = new System.Drawing.Size(353, 148);
            this.groupBox_CrearRuleta.TabIndex = 2;
            this.groupBox_CrearRuleta.TabStop = false;
            this.groupBox_CrearRuleta.Text = "Creación y consulta de ruleta";
            // 
            // button_ConsultarEstadoRuleta
            // 
            this.button_ConsultarEstadoRuleta.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ConsultarEstadoRuleta.Location = new System.Drawing.Point(109, 116);
            this.button_ConsultarEstadoRuleta.Name = "button_ConsultarEstadoRuleta";
            this.button_ConsultarEstadoRuleta.Size = new System.Drawing.Size(142, 23);
            this.button_ConsultarEstadoRuleta.TabIndex = 0;
            this.button_ConsultarEstadoRuleta.Text = "Consultar ruleta";
            this.button_ConsultarEstadoRuleta.UseVisualStyleBackColor = true;
            this.button_ConsultarEstadoRuleta.Click += new System.EventHandler(this.button_ConsultarEstadoRuleta_Click);
            // 
            // label_EstadoRuletaConsultada
            // 
            this.label_EstadoRuletaConsultada.AutoSize = true;
            this.label_EstadoRuletaConsultada.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_EstadoRuletaConsultada.Location = new System.Drawing.Point(243, 88);
            this.label_EstadoRuletaConsultada.Name = "label_EstadoRuletaConsultada";
            this.label_EstadoRuletaConsultada.Size = new System.Drawing.Size(0, 16);
            this.label_EstadoRuletaConsultada.TabIndex = 1;
            // 
            // label_EstadoRuleta
            // 
            this.label_EstadoRuleta.AutoSize = true;
            this.label_EstadoRuleta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_EstadoRuleta.Location = new System.Drawing.Point(163, 85);
            this.label_EstadoRuleta.Name = "label_EstadoRuleta";
            this.label_EstadoRuleta.Size = new System.Drawing.Size(74, 18);
            this.label_EstadoRuleta.TabIndex = 1;
            this.label_EstadoRuleta.Text = "Estado:";
            // 
            // comboBox_ListaRuletas
            // 
            this.comboBox_ListaRuletas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_ListaRuletas.FormattingEnabled = true;
            this.comboBox_ListaRuletas.Location = new System.Drawing.Point(6, 80);
            this.comboBox_ListaRuletas.Name = "comboBox_ListaRuletas";
            this.comboBox_ListaRuletas.Size = new System.Drawing.Size(151, 24);
            this.comboBox_ListaRuletas.TabIndex = 4;
            // 
            // idRuleta
            // 
            this.idRuleta.AutoSize = true;
            this.idRuleta.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idRuleta.Location = new System.Drawing.Point(109, 19);
            this.idRuleta.Name = "idRuleta";
            this.idRuleta.Size = new System.Drawing.Size(0, 16);
            this.idRuleta.TabIndex = 1;
            // 
            // groupBox_VerificarRuleta
            // 
            this.groupBox_VerificarRuleta.Controls.Add(this.comboBox_IngresoIdRuleta);
            this.groupBox_VerificarRuleta.Controls.Add(this.comboBox_IngresoColorApuesta);
            this.groupBox_VerificarRuleta.Controls.Add(this.comboBox_IngresoNumeroApuesta);
            this.groupBox_VerificarRuleta.Controls.Add(this.label_NumeroApuesta);
            this.groupBox_VerificarRuleta.Controls.Add(this.label_ColorApuesta);
            this.groupBox_VerificarRuleta.Controls.Add(this.label_ValorApuesta);
            this.groupBox_VerificarRuleta.Controls.Add(this.textBox_IngresoValorApuesta);
            this.groupBox_VerificarRuleta.Controls.Add(this.label_DatosApuesta);
            this.groupBox_VerificarRuleta.Controls.Add(this.label_IngresoIdUsuario);
            this.groupBox_VerificarRuleta.Controls.Add(this.textBox_IngresoIdCliente);
            this.groupBox_VerificarRuleta.Controls.Add(this.button_RealizarApuesta);
            this.groupBox_VerificarRuleta.Controls.Add(this.label_IngresoIdRuleta);
            this.groupBox_VerificarRuleta.Location = new System.Drawing.Point(27, 182);
            this.groupBox_VerificarRuleta.Name = "groupBox_VerificarRuleta";
            this.groupBox_VerificarRuleta.Size = new System.Drawing.Size(353, 291);
            this.groupBox_VerificarRuleta.TabIndex = 3;
            this.groupBox_VerificarRuleta.TabStop = false;
            this.groupBox_VerificarRuleta.Text = "Generar apuesta";
            // 
            // comboBox_IngresoIdRuleta
            // 
            this.comboBox_IngresoIdRuleta.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_IngresoIdRuleta.FormattingEnabled = true;
            this.comboBox_IngresoIdRuleta.Location = new System.Drawing.Point(122, 19);
            this.comboBox_IngresoIdRuleta.Name = "comboBox_IngresoIdRuleta";
            this.comboBox_IngresoIdRuleta.Size = new System.Drawing.Size(211, 24);
            this.comboBox_IngresoIdRuleta.TabIndex = 5;
            // 
            // comboBox_IngresoColorApuesta
            // 
            this.comboBox_IngresoColorApuesta.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_IngresoColorApuesta.FormattingEnabled = true;
            this.comboBox_IngresoColorApuesta.Items.AddRange(new object[] {
            "Negro",
            "Rojo"});
            this.comboBox_IngresoColorApuesta.Location = new System.Drawing.Point(248, 148);
            this.comboBox_IngresoColorApuesta.Name = "comboBox_IngresoColorApuesta";
            this.comboBox_IngresoColorApuesta.Size = new System.Drawing.Size(85, 24);
            this.comboBox_IngresoColorApuesta.TabIndex = 5;
            // 
            // comboBox_IngresoNumeroApuesta
            // 
            this.comboBox_IngresoNumeroApuesta.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_IngresoNumeroApuesta.FormattingEnabled = true;
            this.comboBox_IngresoNumeroApuesta.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36"});
            this.comboBox_IngresoNumeroApuesta.Location = new System.Drawing.Point(96, 149);
            this.comboBox_IngresoNumeroApuesta.Name = "comboBox_IngresoNumeroApuesta";
            this.comboBox_IngresoNumeroApuesta.Size = new System.Drawing.Size(79, 24);
            this.comboBox_IngresoNumeroApuesta.TabIndex = 4;
            // 
            // label_NumeroApuesta
            // 
            this.label_NumeroApuesta.AutoSize = true;
            this.label_NumeroApuesta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_NumeroApuesta.Location = new System.Drawing.Point(6, 149);
            this.label_NumeroApuesta.Name = "label_NumeroApuesta";
            this.label_NumeroApuesta.Size = new System.Drawing.Size(84, 18);
            this.label_NumeroApuesta.TabIndex = 1;
            this.label_NumeroApuesta.Text = "Número:";
            // 
            // label_ColorApuesta
            // 
            this.label_ColorApuesta.AutoSize = true;
            this.label_ColorApuesta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ColorApuesta.Location = new System.Drawing.Point(181, 149);
            this.label_ColorApuesta.Name = "label_ColorApuesta";
            this.label_ColorApuesta.Size = new System.Drawing.Size(60, 18);
            this.label_ColorApuesta.TabIndex = 1;
            this.label_ColorApuesta.Text = "Color:";
            // 
            // label_ValorApuesta
            // 
            this.label_ValorApuesta.AutoSize = true;
            this.label_ValorApuesta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ValorApuesta.Location = new System.Drawing.Point(6, 203);
            this.label_ValorApuesta.Name = "label_ValorApuesta";
            this.label_ValorApuesta.Size = new System.Drawing.Size(136, 18);
            this.label_ValorApuesta.TabIndex = 1;
            this.label_ValorApuesta.Text = "Valor apuesta:";
            // 
            // textBox_IngresoValorApuesta
            // 
            this.textBox_IngresoValorApuesta.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_IngresoValorApuesta.Location = new System.Drawing.Point(148, 202);
            this.textBox_IngresoValorApuesta.Name = "textBox_IngresoValorApuesta";
            this.textBox_IngresoValorApuesta.Size = new System.Drawing.Size(185, 23);
            this.textBox_IngresoValorApuesta.TabIndex = 2;
            // 
            // label_DatosApuesta
            // 
            this.label_DatosApuesta.AutoSize = true;
            this.label_DatosApuesta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_DatosApuesta.Location = new System.Drawing.Point(107, 105);
            this.label_DatosApuesta.Name = "label_DatosApuesta";
            this.label_DatosApuesta.Size = new System.Drawing.Size(135, 18);
            this.label_DatosApuesta.TabIndex = 1;
            this.label_DatosApuesta.Text = "Datos apuesta";
            // 
            // label_IngresoIdUsuario
            // 
            this.label_IngresoIdUsuario.AutoSize = true;
            this.label_IngresoIdUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_IngresoIdUsuario.Location = new System.Drawing.Point(6, 62);
            this.label_IngresoIdUsuario.Name = "label_IngresoIdUsuario";
            this.label_IngresoIdUsuario.Size = new System.Drawing.Size(105, 18);
            this.label_IngresoIdUsuario.TabIndex = 1;
            this.label_IngresoIdUsuario.Text = "ID usuario:";
            // 
            // textBox_IngresoIdCliente
            // 
            this.textBox_IngresoIdCliente.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_IngresoIdCliente.Location = new System.Drawing.Point(122, 61);
            this.textBox_IngresoIdCliente.Name = "textBox_IngresoIdCliente";
            this.textBox_IngresoIdCliente.Size = new System.Drawing.Size(211, 23);
            this.textBox_IngresoIdCliente.TabIndex = 2;
            // 
            // button_RealizarApuesta
            // 
            this.button_RealizarApuesta.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_RealizarApuesta.Location = new System.Drawing.Point(96, 250);
            this.button_RealizarApuesta.Name = "button_RealizarApuesta";
            this.button_RealizarApuesta.Size = new System.Drawing.Size(145, 23);
            this.button_RealizarApuesta.TabIndex = 3;
            this.button_RealizarApuesta.Text = "Realizar apuesta";
            this.button_RealizarApuesta.UseVisualStyleBackColor = true;
            this.button_RealizarApuesta.Click += new System.EventHandler(this.button_RealizarApuesta_Click);
            // 
            // label_IngresoIdRuleta
            // 
            this.label_IngresoIdRuleta.AutoSize = true;
            this.label_IngresoIdRuleta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_IngresoIdRuleta.Location = new System.Drawing.Point(6, 19);
            this.label_IngresoIdRuleta.Name = "label_IngresoIdRuleta";
            this.label_IngresoIdRuleta.Size = new System.Drawing.Size(92, 18);
            this.label_IngresoIdRuleta.TabIndex = 1;
            this.label_IngresoIdRuleta.Text = "ID ruleta:";
            // 
            // groupBox_CerrarRuleta
            // 
            this.groupBox_CerrarRuleta.Controls.Add(this.comboBox_IdRuletaCerrada);
            this.groupBox_CerrarRuleta.Controls.Add(this.textBox_ResultadoApuestas);
            this.groupBox_CerrarRuleta.Controls.Add(this.label_Resultados);
            this.groupBox_CerrarRuleta.Controls.Add(this.label_IdRuletadaCerrada);
            this.groupBox_CerrarRuleta.Controls.Add(this.button_CerrarRuleta);
            this.groupBox_CerrarRuleta.Location = new System.Drawing.Point(413, 28);
            this.groupBox_CerrarRuleta.Name = "groupBox_CerrarRuleta";
            this.groupBox_CerrarRuleta.Size = new System.Drawing.Size(355, 624);
            this.groupBox_CerrarRuleta.TabIndex = 4;
            this.groupBox_CerrarRuleta.TabStop = false;
            this.groupBox_CerrarRuleta.Text = "Cerrar mesa de apuestas";
            // 
            // comboBox_IdRuletaCerrada
            // 
            this.comboBox_IdRuletaCerrada.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_IdRuletaCerrada.FormattingEnabled = true;
            this.comboBox_IdRuletaCerrada.Location = new System.Drawing.Point(105, 22);
            this.comboBox_IdRuletaCerrada.Name = "comboBox_IdRuletaCerrada";
            this.comboBox_IdRuletaCerrada.Size = new System.Drawing.Size(211, 24);
            this.comboBox_IdRuletaCerrada.TabIndex = 6;
            // 
            // textBox_ResultadoApuestas
            // 
            this.textBox_ResultadoApuestas.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_ResultadoApuestas.Location = new System.Drawing.Point(7, 116);
            this.textBox_ResultadoApuestas.Multiline = true;
            this.textBox_ResultadoApuestas.Name = "textBox_ResultadoApuestas";
            this.textBox_ResultadoApuestas.Size = new System.Drawing.Size(342, 502);
            this.textBox_ResultadoApuestas.TabIndex = 4;
            // 
            // label_Resultados
            // 
            this.label_Resultados.AutoSize = true;
            this.label_Resultados.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Resultados.Location = new System.Drawing.Point(7, 93);
            this.label_Resultados.Name = "label_Resultados";
            this.label_Resultados.Size = new System.Drawing.Size(111, 18);
            this.label_Resultados.TabIndex = 1;
            this.label_Resultados.Text = "Resultados:";
            // 
            // label_IdRuletadaCerrada
            // 
            this.label_IdRuletadaCerrada.AutoSize = true;
            this.label_IdRuletadaCerrada.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_IdRuletadaCerrada.Location = new System.Drawing.Point(6, 22);
            this.label_IdRuletadaCerrada.Name = "label_IdRuletadaCerrada";
            this.label_IdRuletadaCerrada.Size = new System.Drawing.Size(92, 18);
            this.label_IdRuletadaCerrada.TabIndex = 1;
            this.label_IdRuletadaCerrada.Text = "ID ruleta:";
            // 
            // button_CerrarRuleta
            // 
            this.button_CerrarRuleta.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_CerrarRuleta.Location = new System.Drawing.Point(98, 57);
            this.button_CerrarRuleta.Name = "button_CerrarRuleta";
            this.button_CerrarRuleta.Size = new System.Drawing.Size(137, 23);
            this.button_CerrarRuleta.TabIndex = 0;
            this.button_CerrarRuleta.Text = "Cerrar apuestas";
            this.button_CerrarRuleta.UseVisualStyleBackColor = true;
            this.button_CerrarRuleta.Click += new System.EventHandler(this.button_CerrarRuleta_Click);
            // 
            // button_CrearUsuario
            // 
            this.button_CrearUsuario.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_CrearUsuario.Location = new System.Drawing.Point(145, 497);
            this.button_CrearUsuario.Name = "button_CrearUsuario";
            this.button_CrearUsuario.Size = new System.Drawing.Size(105, 23);
            this.button_CrearUsuario.TabIndex = 5;
            this.button_CrearUsuario.Text = "Crear usuario";
            this.button_CrearUsuario.UseVisualStyleBackColor = true;
            this.button_CrearUsuario.Click += new System.EventHandler(this.button_CrearUsuario_Click);
            // 
            // button_Clean
            // 
            this.button_Clean.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Clean.Location = new System.Drawing.Point(134, 547);
            this.button_Clean.Name = "button_Clean";
            this.button_Clean.Size = new System.Drawing.Size(128, 23);
            this.button_Clean.TabIndex = 6;
            this.button_Clean.Text = "Limpiar campos";
            this.button_Clean.UseVisualStyleBackColor = true;
            this.button_Clean.Click += new System.EventHandler(this.button_Clean_Click);
            // 
            // button_CloseApp
            // 
            this.button_CloseApp.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_CloseApp.Location = new System.Drawing.Point(159, 596);
            this.button_CloseApp.Name = "button_CloseApp";
            this.button_CloseApp.Size = new System.Drawing.Size(75, 23);
            this.button_CloseApp.TabIndex = 7;
            this.button_CloseApp.Text = "Salir";
            this.button_CloseApp.UseVisualStyleBackColor = true;
            this.button_CloseApp.Click += new System.EventHandler(this.button_CloseApp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 664);
            this.Controls.Add(this.button_CloseApp);
            this.Controls.Add(this.button_Clean);
            this.Controls.Add(this.button_CrearUsuario);
            this.Controls.Add(this.groupBox_CerrarRuleta);
            this.Controls.Add(this.groupBox_VerificarRuleta);
            this.Controls.Add(this.groupBox_CrearRuleta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_CrearRuleta.ResumeLayout(false);
            this.groupBox_CrearRuleta.PerformLayout();
            this.groupBox_VerificarRuleta.ResumeLayout(false);
            this.groupBox_VerificarRuleta.PerformLayout();
            this.groupBox_CerrarRuleta.ResumeLayout(false);
            this.groupBox_CerrarRuleta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_GenerarIdRuleta;
        private System.Windows.Forms.Label label_idRuleta;
        private System.Windows.Forms.GroupBox groupBox_CrearRuleta;
        private System.Windows.Forms.Label label_EstadoRuleta;
        private System.Windows.Forms.ComboBox comboBox_ListaRuletas;
        private System.Windows.Forms.Label idRuleta;
        private System.Windows.Forms.GroupBox groupBox_VerificarRuleta;
        private System.Windows.Forms.ComboBox comboBox_IngresoColorApuesta;
        private System.Windows.Forms.ComboBox comboBox_IngresoNumeroApuesta;
        private System.Windows.Forms.Label label_NumeroApuesta;
        private System.Windows.Forms.Label label_ColorApuesta;
        private System.Windows.Forms.Label label_ValorApuesta;
        private System.Windows.Forms.TextBox textBox_IngresoValorApuesta;
        private System.Windows.Forms.Label label_DatosApuesta;
        private System.Windows.Forms.Label label_IngresoIdUsuario;
        private System.Windows.Forms.TextBox textBox_IngresoIdCliente;
        private System.Windows.Forms.Button button_RealizarApuesta;
        private System.Windows.Forms.Label label_IngresoIdRuleta;
        private System.Windows.Forms.GroupBox groupBox_CerrarRuleta;
        private System.Windows.Forms.TextBox textBox_ResultadoApuestas;
        private System.Windows.Forms.Label label_Resultados;
        private System.Windows.Forms.Label label_IdRuletadaCerrada;
        private System.Windows.Forms.Button button_CerrarRuleta;
        private System.Windows.Forms.Button button_ConsultarEstadoRuleta;
        private System.Windows.Forms.Label label_EstadoRuletaConsultada;
        private System.Windows.Forms.Button button_CrearUsuario;
        private System.Windows.Forms.Button button_Clean;
        private System.Windows.Forms.Button button_CloseApp;
        private System.Windows.Forms.ComboBox comboBox_IngresoIdRuleta;
        private System.Windows.Forms.ComboBox comboBox_IdRuletaCerrada;
    }
}

