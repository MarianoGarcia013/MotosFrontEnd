using MotosBackEnd.Datos;
using MotosBackEnd.Dominio;
using MotosBackEnd.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotosFrontEnd
{
    public partial class FromConsulta : Form
    {
        iDataApi DA;
        Helper HP;

        public FromConsulta()
        {
            InitializeComponent();
            DA = new DataApi();            
            HP= new Helper();
        }

        private void FromConsulta_Load(object sender, EventArgs e)
        {
            txtModelo.Focus();
            ContarMotos();
        }   
        
        private void ContarMotos()
        {
            lblCantidad.Text = "Cantidad de Motos: " + Convert.ToString(lstBusqueda.Items.Count); 
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lstBusqueda.Items.Clear();
            List<Moto> lst = DA.ConsultarDBconParam(txtModelo.Text);

            foreach (Moto m in lst)
            {
                lstBusqueda.Items.Add(m);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Desea abandonar la busqueda?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                                 MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes) 
                this.Close();                    
        }

        private void BorrarModelo(int posicion)
        {

        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            Moto moto = new Moto(); // No borra la moto, solo escribe el mensaje toda la hora 
            int codigo = moto.codigo;
            if ((lstBusqueda.SelectedIndex != -1) && (codigo == moto.codigo))
             DA.DeleteMotos(codigo);
               MessageBox.Show("La Moto fue eliminada con exito", "CONTROL");         
        }
    }
}

