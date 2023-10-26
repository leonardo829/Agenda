using AgendaBE;
using System;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Agenda : Form
    {

        private Contactos contactos = new Contactos();
        public Agenda()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoContacto Contacto = new NuevoContacto();



            decimal verificacion;



            if (txtTelefono.Text == "")
            {

                errorProvider1.SetError(txtTelefono, "error ingrese un valor");
                txtTelefono.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtTelefono, "");
                if (!Decimal.TryParse(txtTelefono.Text, out verificacion))
                {
                    errorProvider1.SetError(txtTelefono, "ingrese numeros");
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtTelefono, "");
                    Contacto.Agregar(txtNombre.Text,
                    txtTelefono.Text,
                    txtMail.Text);
                    contactos.Agregar(Contacto);

                }
            }



            MostrarContactos();
        }

        private void MostrarContactos()
        {
            lblContactos.Text = contactos.Listar();
        }

        private void btnContactos_Click(object sender, EventArgs e)
        {
            MostrarContactos();
            lblContactos.Visible = true;
            btnNuevoContacto.Visible = true;
            btnContactos.Visible = false;
            lblAgenda.Visible = false;
        }

        private void btnNuevoContacto_Click(object sender, EventArgs e)
        {
            lblContactos.Visible = false;
            btnNuevoContacto.Visible = false;
            btnContactos.Visible = true;
            lblAgenda.Visible = true;
        }
    }
}
