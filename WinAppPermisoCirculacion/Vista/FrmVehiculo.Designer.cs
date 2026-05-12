namespace WinAppPermisoCirculacion.Vista
{
    partial class FrmVehiculo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtPatenteBus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtRutEd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAnioEd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtColorEd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtModeloEd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMarcaEd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPatenteEd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataVehiculos = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVehiculos)).BeginInit();
            this.SuspendLayout();
            //
            // tabControl1
            //
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(36, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(882, 480);
            this.tabControl1.TabIndex = 0;
            //
            // tabPage1
            //
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(874, 454);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar Vehiculo";
            this.tabPage1.UseVisualStyleBackColor = true;
            //
            // groupBox1
            //
            this.groupBox1.Controls.Add(this.btnIngresar);
            this.groupBox1.Controls.Add(this.txtRut);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAnio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtColor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPatente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(98, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 310);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Vehiculo";
            //
            // btnIngresar
            //
            this.btnIngresar.Location = new System.Drawing.Point(287, 44);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(103, 23);
            this.btnIngresar.TabIndex = 12;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            //
            // txtRut
            //
            this.txtRut.Location = new System.Drawing.Point(125, 256);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(100, 20);
            this.txtRut.TabIndex = 11;
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rut Contribuy.:";
            //
            // txtAnio
            //
            this.txtAnio.Location = new System.Drawing.Point(125, 221);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(100, 20);
            this.txtAnio.TabIndex = 9;
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ano:";
            //
            // txtColor
            //
            this.txtColor.Location = new System.Drawing.Point(125, 186);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(140, 20);
            this.txtColor.TabIndex = 7;
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Color:";
            //
            // txtModelo
            //
            this.txtModelo.Location = new System.Drawing.Point(125, 151);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(140, 20);
            this.txtModelo.TabIndex = 5;
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modelo:";
            //
            // txtMarca
            //
            this.txtMarca.Location = new System.Drawing.Point(125, 116);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(140, 20);
            this.txtMarca.TabIndex = 3;
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca:";
            //
            // txtPatente
            //
            this.txtPatente.Location = new System.Drawing.Point(125, 46);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(100, 20);
            this.txtPatente.TabIndex = 1;
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patente:";
            //
            // tabPage2
            //
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(874, 454);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar Vehiculo";
            this.tabPage2.UseVisualStyleBackColor = true;
            //
            // groupBox3
            //
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.txtPatenteBus);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(98, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(504, 80);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Busqueda de Datos por Patente";
            //
            // btnBuscar
            //
            this.btnBuscar.Location = new System.Drawing.Point(287, 35);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            //
            // txtPatenteBus
            //
            this.txtPatenteBus.Location = new System.Drawing.Point(125, 37);
            this.txtPatenteBus.Name = "txtPatenteBus";
            this.txtPatenteBus.Size = new System.Drawing.Size(100, 20);
            this.txtPatenteBus.TabIndex = 10;
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Patente:";
            //
            // groupBox2
            //
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.txtRutEd);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtAnioEd);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtColorEd);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtModeloEd);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtMarcaEd);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtPatenteEd);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(98, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 310);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editor de Datos del Vehiculo";
            //
            // btnEliminar
            //
            this.btnEliminar.Location = new System.Drawing.Point(287, 78);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            //
            // btnModificar
            //
            this.btnModificar.Location = new System.Drawing.Point(287, 44);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(103, 23);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            //
            // txtRutEd
            //
            this.txtRutEd.Location = new System.Drawing.Point(125, 256);
            this.txtRutEd.Name = "txtRutEd";
            this.txtRutEd.Size = new System.Drawing.Size(100, 20);
            this.txtRutEd.TabIndex = 13;
            //
            // label13
            //
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 259);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Rut Contribuy.:";
            //
            // txtAnioEd
            //
            this.txtAnioEd.Location = new System.Drawing.Point(125, 221);
            this.txtAnioEd.Name = "txtAnioEd";
            this.txtAnioEd.Size = new System.Drawing.Size(100, 20);
            this.txtAnioEd.TabIndex = 11;
            //
            // label12
            //
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Ano:";
            //
            // txtColorEd
            //
            this.txtColorEd.Location = new System.Drawing.Point(125, 186);
            this.txtColorEd.Name = "txtColorEd";
            this.txtColorEd.Size = new System.Drawing.Size(140, 20);
            this.txtColorEd.TabIndex = 9;
            //
            // label11
            //
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Color:";
            //
            // txtModeloEd
            //
            this.txtModeloEd.Location = new System.Drawing.Point(125, 151);
            this.txtModeloEd.Name = "txtModeloEd";
            this.txtModeloEd.Size = new System.Drawing.Size(140, 20);
            this.txtModeloEd.TabIndex = 5;
            //
            // label10
            //
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Modelo:";
            //
            // txtMarcaEd
            //
            this.txtMarcaEd.Location = new System.Drawing.Point(125, 116);
            this.txtMarcaEd.Name = "txtMarcaEd";
            this.txtMarcaEd.Size = new System.Drawing.Size(140, 20);
            this.txtMarcaEd.TabIndex = 3;
            //
            // label9
            //
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Marca:";
            //
            // txtPatenteEd
            //
            this.txtPatenteEd.Location = new System.Drawing.Point(125, 46);
            this.txtPatenteEd.Name = "txtPatenteEd";
            this.txtPatenteEd.ReadOnly = true;
            this.txtPatenteEd.Size = new System.Drawing.Size(100, 20);
            this.txtPatenteEd.TabIndex = 1;
            //
            // label8
            //
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Patente:";
            //
            // tabPage3
            //
            this.tabPage3.Controls.Add(this.dataVehiculos);
            this.tabPage3.Controls.Add(this.btnListar);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(874, 454);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Listar Vehiculos";
            this.tabPage3.UseVisualStyleBackColor = true;
            //
            // dataVehiculos
            //
            this.dataVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVehiculos.Location = new System.Drawing.Point(113, 93);
            this.dataVehiculos.Name = "dataVehiculos";
            this.dataVehiculos.Size = new System.Drawing.Size(650, 280);
            this.dataVehiculos.TabIndex = 1;
            //
            // btnListar
            //
            this.btnListar.Location = new System.Drawing.Point(308, 30);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(125, 41);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            //
            // FrmVehiculo
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 560);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmVehiculo";
            this.Text = "FrmVehiculo";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataVehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtPatenteBus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtRutEd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAnioEd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtColorEd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtModeloEd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMarcaEd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPatenteEd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataVehiculos;
        private System.Windows.Forms.Button btnListar;
    }
}
