namespace MotosFrontEnd
{
    partial class FromConsulta
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.Modelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lstBusqueda = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(387, 712);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(112, 34);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Modelo
            // 
            this.Modelo.AutoSize = true;
            this.Modelo.Location = new System.Drawing.Point(39, 113);
            this.Modelo.Name = "Modelo";
            this.Modelo.Size = new System.Drawing.Size(74, 25);
            this.Modelo.TabIndex = 1;
            this.Modelo.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(39, 151);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(435, 31);
            this.txtModelo.TabIndex = 4;
            // 
            // lstBusqueda
            // 
            this.lstBusqueda.FormattingEnabled = true;
            this.lstBusqueda.ItemHeight = 25;
            this.lstBusqueda.Location = new System.Drawing.Point(39, 268);
            this.lstBusqueda.Name = "lstBusqueda";
            this.lstBusqueda.Size = new System.Drawing.Size(435, 379);
            this.lstBusqueda.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Historic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(29, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "MotosMine S.A";
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(346, 210);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(115, 36);
            this.btBorrar.TabIndex = 9;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(39, 210);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 34);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(39, 664);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(169, 25);
            this.lblCantidad.TabIndex = 11;
            this.lblCantidad.Text = "Cantidad de Motos:";
            // 
            // FromConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 758);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstBusqueda);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.Modelo);
            this.Controls.Add(this.btnVolver);
            this.Name = "FromConsulta";
            this.Text = "FromConsulta";
            this.Load += new System.EventHandler(this.FromConsulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnVolver;
        private Label Modelo;
        private TextBox txtModelo;
        private ListBox lstBusqueda;
        private Label label4;
        private Button btBorrar;
        private Button btnBuscar;
        private Label lblCantidad;
    }
}