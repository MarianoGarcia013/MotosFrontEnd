using MotosBackEnd.Datos;
using MotosBackEnd.Dominio;
using MotosBackEnd.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotosFrontEnd
{
    public partial class FromMotos : Form
    {

        Helper HP;
        iDataApi DA;
        List<Moto> lmotos;
        bool nuevo;
        Moto moto = new Moto();
        
        
        public FromMotos()
        {
            InitializeComponent();
            HP = new Helper();
            lmotos = new List<Moto>();
            DA = new DataApi();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarComboDB(cboMarca, "Marcas");
            CargarLista();
            Habilitar(false);
            btnNuevo.Focus();
        } 

        public void CargarComboDB(ComboBox combo, string nombreTabla)
        {
            DataTable tabla = HP.ConsultarDB("SELECT * FROM " + nombreTabla + " ORDER BY 2");
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void CargarLista()
        {
            lmotos.Clear();
            lstMotos.Items.Clear();

            DataTable tabla = HP.ConsultarDB("SELECT * FROM MOTOS");
            foreach (DataRow dr in tabla.Rows)
            {
                Moto m = new Moto();
                m.codigo = Convert.ToInt32(dr[0].ToString());
                m.modelo = dr[1].ToString();
                m.marca = Convert.ToInt32(dr[2].ToString());
                m.precio = Convert.ToDouble(dr[3].ToString());
                m.fecha = Convert.ToDateTime(dr[4].ToString());

                lmotos.Add(m);
                lstMotos.Items.Add(m);
            }
        }

        private void Limpiar()
        {
            txtCodigo.Text = String.Empty;
            txtModelo.Text = String.Empty;
            cboMarca.SelectedIndex = 0;
            txtPrecio.Text = string.Empty;
            dtpFecha.Value = DateTime.Now;
        }
        private void Habilitar(bool x)
        {
            txtCodigo.Enabled = x;
            txtModelo.Enabled = x;
            cboMarca.Enabled = x;
            txtPrecio.Enabled = x;
            dtpFecha.Enabled = x;            
            btnEditar.Enabled = !x;
            btnNuevo.Enabled = !x;
            btnGuardar.Enabled = x;
            btnCancelar.Enabled = x;
        }

        private bool Validar()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                valido = false;
                MessageBox.Show("Debe ingresar un codigo!", "CONROL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(string.IsNullOrEmpty(txtModelo.Text))
            {
                valido = false;
                MessageBox.Show("Debe ingresar un modelo!", "CONTROL", MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Exclamation);
            if(string.IsNullOrEmpty(txtPrecio.Text)) 
            {
                valido = false;
            }
                MessageBox.Show("Debe ingresar el precio!", "CONTROL", MessageBoxButtons.OKCancel,
                              MessageBoxIcon.Information);
            }
            else
            { 
            try
            {
                double.Parse(txtPrecio.Text);
            }
                catch(Exception)
                {
                    valido=false;
                    MessageBox.Show("El precio debe ser en numeros", "CONTROL", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Exclamation);
                }               
                
            }
            return valido;  
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            lstMotos.Enabled = false;
            txtCodigo.Focus();
            Habilitar(true);
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Moto m = new Moto();
            if (nuevo)
            {
                if(Validar())
                { 
                moto.codigo = Convert.ToInt32(txtCodigo.Text);
                moto.modelo = txtModelo.Text;
                moto.marca = (int)cboMarca.SelectedValue;
                moto.precio = Convert.ToDouble(txtPrecio.Text);
                moto.fecha = Convert.ToDateTime(dtpFecha.Value);
                }

                if (DA.InsertarDB(moto))
                    MessageBox.Show("La carga fue realizada con exito", "Control", MessageBoxButtons.OK);
                CargarLista();                

            }
            else
            {
                moto.codigo = Convert.ToInt32(txtCodigo.Text);
                moto.modelo = txtModelo.Text;
                moto.marca = (int)cboMarca.SelectedValue;
                moto.precio = Convert.ToDouble(txtPrecio.Text);
                //moto.fecha = Convert.ToDateTime(dtpFecha.Text);
                if (DA.ModificarDB(moto))  
                  MessageBox.Show("Se modifico con exito!", "CONTROL", MessageBoxButtons.OK);
                CargarLista();
               
            }           

        }

        private void CargarCampo(int Posicion)
        {
            if (lstMotos.SelectedIndex != -1)
            {
                txtCodigo.Text = lmotos[Posicion].codigo.ToString();
                txtModelo.Text = lmotos[Posicion].modelo.ToString();
                cboMarca.SelectedValue = lmotos[Posicion].marca;
                txtPrecio.Text = lmotos[Posicion].precio.ToString();
                dtpFecha.Text = lmotos[Posicion].fecha.ToString();
            }
        }

        private void lstMotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCampo(lstMotos.SelectedIndex);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            nuevo = false;
            lstMotos.Enabled = true;
            Habilitar(true);
        }
       
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            nuevo = true;
            Habilitar(false);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que quiere salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes) 
            { this.Close(); }
                
                             
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FromConsulta consulta = new FromConsulta();
            consulta.Show();          
        }
    }
}
