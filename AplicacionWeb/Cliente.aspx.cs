using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//
using AplicacionWeb.CapaDatos;

namespace AplicacionWeb
{
    public partial class Cliente : System.Web.UI.Page
    {
        DCliente cliente = new DCliente();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {

                lblEstado.Text = "Debe ingresar un Nombre";
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtDireccion.Text))
            {

                lblEstado.Text = "Debe ingresar una Direccion";
                txtDireccion.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                lblEstado.Text = "Debe ingresar un Número Teléfonoco";
                txtTelefono.Focus();
                return;
            }
            //cliente.IdCliente =Convert.ToInt32(txtIdCliente.Text.Trim());
            cliente.Nombre = txtNombre.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Telefono = txtTelefono.Text;
            
            cliente.Agregar();

            lblError.Text = DConexion.Error;
            lblEstado.Text = "Registro Agregado con Éxito.....";

            txtDireccion.Text = string.Empty;
            txtIdCliente.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }
    }
}