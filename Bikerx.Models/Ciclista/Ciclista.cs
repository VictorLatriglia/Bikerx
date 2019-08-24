using System;
using System.Collections.Generic;
using System.Text;

namespace Bikerx.Models.Ciclista
{
    /// <summary>
    /// Clase para ciclistas
    /// </summary>
    public class Ciclista : EntityBase<int>
    {
        //Propiedades
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public long NumeroContacto { get; set; }
        public string Email { get; set; }
        public int Puntos { get; set; }
        //

        //ForeignKeys
        public int AmigoId { get; set; }
        public Ciclista Amigo { get; set; }
        //

        //Entidades Dependientes
        public List<Ciclista> Amigos { get; set; }
        //
    }
}
