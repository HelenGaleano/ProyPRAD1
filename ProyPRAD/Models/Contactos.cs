using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace ProyPRAD.Models
{
    internal class Contactos
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Nombres { get; set; }

        [MaxLength(100)]
        public string Apellidos { get; set; }

        [MaxLength(15)]
        public string Telefono { get; set; }

        public DateTime Fechanac { get; set; }
        public string Parentesco { get; set; }
        public byte[] Foto { get; set; }

        [MaxLength(100)]
        public string Pais { get; set; }
    }
}
