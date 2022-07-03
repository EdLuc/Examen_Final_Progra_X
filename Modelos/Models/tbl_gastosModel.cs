using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Models
{
    public class tbl_gastosModel
    {
        public int id_gastos { get; set; }
        public string descripcion { get; set; }
        public float total { get; set; }
        public string estado { get; set; }
    }
}
