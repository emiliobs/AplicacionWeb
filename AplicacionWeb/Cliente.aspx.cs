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

            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text))
                {

                    lblDatos.Text = "Debe ingresar un Nombre";
                    txtNombre.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtDireccion.Text))
                {

                    lblDatos.Text = "Debe ingresar una Direccíon";
                    txtDireccion.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtTelefono.Text))
                {
                    lblDatos.Text = "Debe ingresar un Número Teléfonico";
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
                lblDatos.Text = string.Empty;

                txtDireccion.Text = string.Empty;
                txtIdCliente.Text = string.Empty;
                txtNombre.Text = string.Empty;
                txtTelefono.Text = string.Empty;
            }
            catch (Exception ex)
            {

                lblError.Text = "ERROR: " + ex.Message;
            }
         
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {                                                                    

                if (cliente.Eliminar(int.Parse(txtIdCliente.Text)))
                {
                    lblEstado.Text = "El registro se Eliminó con Éxito.";

                    txtDireccion.Text = string.Empty;
                    txtIdCliente.Text = string.Empty;
                    txtNombre.Text = string.Empty;
                    txtTelefono.Text = string.Empty;
                }
                else
                {
                    lblEstado.Text = "El registro No se Eliminó.";
                }
            }
            catch (Exception ex)
            {

                lblError.Text = "ERROR: " + ex.Message;
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cliente.Existe(int.Parse(txtIdCliente.Text)))
                {
                    txtNombre.Text = cliente.Direccion;
                    txtDireccion.Text = cliente.Direccion;
                    txtTelefono.Text = cliente.Telefono;

                    

                    lblEstado.Text = "Registro Encontrado.";
                }
                else
                {
                    lblEstado.Text =  "No existes Registro.";
                }
            }
            catch (Exception ex)
            {

                lblError.Text = "ERROR: " + ex.Message;
            }
        }
    }
}