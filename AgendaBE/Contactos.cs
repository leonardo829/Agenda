namespace AgendaBE
{
    public class Contactos
    {
        public NuevoContacto[] contactos { get; set; } = new NuevoContacto[200];
        private int fila = 0;

        public void Agregar(NuevoContacto aContacto)
        {
            contactos[fila] = aContacto;

            fila++;

        }

        public string Listar()
        {
            string res = "";
            for (int i = 0; i < fila; i++)
            {
                res = res + contactos[i].Listar() + "\r\n";
            }
            return res;
        }
    }
}
