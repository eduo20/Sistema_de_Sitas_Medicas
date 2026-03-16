namespace Sistema_de_Sitas_Medicas
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFecha = new System.Windows.Forms.TabPage();
            this.comboBoxHora = new System.Windows.Forms.ComboBox();
            this.buttonCita = new System.Windows.Forms.Button();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPaciente = new System.Windows.Forms.ComboBox();
            this.comboBoxDoctor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewCitas = new System.Windows.Forms.DataGridView();
            this.buttonReporte = new System.Windows.Forms.Button();
            this.buttonOrdenar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageFecha.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageFecha);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(980, 581);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageFecha
            // 
            this.tabPageFecha.Controls.Add(this.comboBoxHora);
            this.tabPageFecha.Controls.Add(this.buttonCita);
            this.tabPageFecha.Controls.Add(this.dateTimePickerFecha);
            this.tabPageFecha.Controls.Add(this.comboBoxPaciente);
            this.tabPageFecha.Controls.Add(this.comboBoxDoctor);
            this.tabPageFecha.Controls.Add(this.label5);
            this.tabPageFecha.Controls.Add(this.label4);
            this.tabPageFecha.Controls.Add(this.label3);
            this.tabPageFecha.Controls.Add(this.label2);
            this.tabPageFecha.Controls.Add(this.label1);
            this.tabPageFecha.Location = new System.Drawing.Point(4, 25);
            this.tabPageFecha.Name = "tabPageFecha";
            this.tabPageFecha.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFecha.Size = new System.Drawing.Size(972, 552);
            this.tabPageFecha.TabIndex = 0;
            this.tabPageFecha.Text = "Registro_citas";
            this.tabPageFecha.UseVisualStyleBackColor = true;
            // 
            // comboBoxHora
            // 
            this.comboBoxHora.FormattingEnabled = true;
            this.comboBoxHora.Location = new System.Drawing.Point(41, 325);
            this.comboBoxHora.Name = "comboBoxHora";
            this.comboBoxHora.Size = new System.Drawing.Size(368, 24);
            this.comboBoxHora.TabIndex = 10;
            // 
            // buttonCita
            // 
            this.buttonCita.Location = new System.Drawing.Point(330, 423);
            this.buttonCita.Name = "buttonCita";
            this.buttonCita.Size = new System.Drawing.Size(189, 72);
            this.buttonCita.TabIndex = 9;
            this.buttonCita.Text = "Ingresar";
            this.buttonCita.UseVisualStyleBackColor = true;
            this.buttonCita.Click += new System.EventHandler(this.buttonCita_Click);
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(41, 259);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(368, 22);
            this.dateTimePickerFecha.TabIndex = 7;
            // 
            // comboBoxPaciente
            // 
            this.comboBoxPaciente.FormattingEnabled = true;
            this.comboBoxPaciente.Location = new System.Drawing.Point(38, 195);
            this.comboBoxPaciente.Name = "comboBoxPaciente";
            this.comboBoxPaciente.Size = new System.Drawing.Size(371, 24);
            this.comboBoxPaciente.TabIndex = 6;
            // 
            // comboBoxDoctor
            // 
            this.comboBoxDoctor.FormattingEnabled = true;
            this.comboBoxDoctor.Location = new System.Drawing.Point(35, 122);
            this.comboBoxDoctor.Name = "comboBoxDoctor";
            this.comboBoxDoctor.Size = new System.Drawing.Size(374, 24);
            this.comboBoxDoctor.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ingrese la hora de cita:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingrese la fecha de cita:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seleccione el nombre del paciente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione el nombre del doctor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Citas ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonOrdenar);
            this.tabPage2.Controls.Add(this.buttonReporte);
            this.tabPage2.Controls.Add(this.dataGridViewCitas);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(972, 552);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Resultado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCitas
            // 
            this.dataGridViewCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCitas.Location = new System.Drawing.Point(152, 31);
            this.dataGridViewCitas.Name = "dataGridViewCitas";
            this.dataGridViewCitas.RowHeadersWidth = 51;
            this.dataGridViewCitas.RowTemplate.Height = 24;
            this.dataGridViewCitas.Size = new System.Drawing.Size(682, 319);
            this.dataGridViewCitas.TabIndex = 0;
            // 
            // buttonReporte
            // 
            this.buttonReporte.Location = new System.Drawing.Point(170, 398);
            this.buttonReporte.Name = "buttonReporte";
            this.buttonReporte.Size = new System.Drawing.Size(270, 95);
            this.buttonReporte.TabIndex = 1;
            this.buttonReporte.Text = "Generar reporte";
            this.buttonReporte.UseVisualStyleBackColor = true;
            this.buttonReporte.Click += new System.EventHandler(this.buttonReporte_Click);
            // 
            // buttonOrdenar
            // 
            this.buttonOrdenar.Location = new System.Drawing.Point(584, 398);
            this.buttonOrdenar.Name = "buttonOrdenar";
            this.buttonOrdenar.Size = new System.Drawing.Size(181, 93);
            this.buttonOrdenar.TabIndex = 2;
            this.buttonOrdenar.Text = "Ordenar por doctor";
            this.buttonOrdenar.UseVisualStyleBackColor = true;
            this.buttonOrdenar.Click += new System.EventHandler(this.buttonOrdenar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 596);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageFecha.ResumeLayout(false);
            this.tabPageFecha.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFecha;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.ComboBox comboBoxPaciente;
        private System.Windows.Forms.ComboBox comboBoxDoctor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCita;
        private System.Windows.Forms.ComboBox comboBoxHora;
        private System.Windows.Forms.Button buttonReporte;
        private System.Windows.Forms.DataGridView dataGridViewCitas;
        private System.Windows.Forms.Button buttonOrdenar;
    }
}

