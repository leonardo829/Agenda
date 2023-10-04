using AgendaBE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            Contacto.Agregar(txtNombre.Text = " ",
                          txtTelefono.Text = " ",
                          txtMail.Text = " ");

            contactos.Agregar(Contacto);

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
            lblContactos.Visible=false;
            btnNuevoContacto.Visible=false;
            btnContactos.Visible=true;
            lblAgenda.Visible=true;
        }
    }
}
