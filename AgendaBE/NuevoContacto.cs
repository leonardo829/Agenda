﻿using System;
namespace AgendaBE
{
    public class NuevoContacto
    {
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Mail { get; set; }

        public void Agregar(string aNombre,
                            string aTelefono,
                            string aMail)

        {
            Nombre = aNombre;
            Telefono = Convert.ToInt32(aTelefono);
            Mail = aMail;



        }

        public string Listar()
        {
            string Res = "";
            Res = Nombre + " - " + Telefono + " - " + Mail;

            return Res;
        }
    }
}
