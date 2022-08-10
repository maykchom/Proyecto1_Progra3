using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class categorias
    {
        /// <summary>
        /// La clase categorias representa a la entidad categorias de la base de datos
        /// Los atributos de la clase representan a los campos de la entidad categorias
        /// </summary>
        public int CategoriaID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public Byte[] Picture { get; set; }
    }
}
