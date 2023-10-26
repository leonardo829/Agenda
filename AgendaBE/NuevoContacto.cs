namespace AgendaBE
{
    public class NuevoContacto
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }

        public void Agregar(string aNombre,
                            string aTelefono,  //esta bien asi??. si pongo int me da un error.
                            string aMail)

        {
            Nombre = aNombre;
            Telefono = aTelefono; // despues de probar todos los int es el unico que me deja "agregar" el telefono correctamente
            Mail = aMail;

            //sin el if el programa si anda :)
            /*
            if (aTelefono.IsNullOrEmpty(txtTelefono.Text))
            {
                ("inserte numero de telefono");  //mostrar????
            }

        }

        public string Listar()
        {
            string Res = "";
            Res = Nombre + " - " + Telefono + " - " + Mail;

            return Res;
        }
    }
}
