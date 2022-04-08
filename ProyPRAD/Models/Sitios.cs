using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace ProyPRAD.Models
{
    internal class Sitios
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100)]
        public string descripcion { get; set; }
        public double latitud { get; set; }
        public double longitud { get; set; }
        public byte[] foto { get; set; }

        [MaxLength(70)]
        public string pais { get; set; }
        public string comentarios { get; set; }

    }
}
