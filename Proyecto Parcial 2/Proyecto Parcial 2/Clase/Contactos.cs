using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite; //AGREGAMOS LIBRERIA

namespace Proyecto_Parcial_2.Clase
{
    class Contactos
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string RE { get; set; }
        public String Pag { get; set; }

        public override string ToString()
        {
            return $"{Nombre} - {Correo} - {Telefono}- {RE} - {Pag} ";
        }
       

    }
}
