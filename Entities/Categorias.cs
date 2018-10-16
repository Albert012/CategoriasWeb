using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Categorias
    {
        [Key]
        public int CategoriId { get; set; }
        public string Descripcion { get; set; }
        public Decimal Presupuesto { get; set; }

        public Categorias()
        {

        }

        public Categorias(int categoriId, string descripcion, decimal presupuesto)
        {
            CategoriId = categoriId;
            Descripcion = descripcion;
            Presupuesto = presupuesto;
        }

        public override string ToString()
        {
            return Descripcion.ToString();
        }
    }
}
