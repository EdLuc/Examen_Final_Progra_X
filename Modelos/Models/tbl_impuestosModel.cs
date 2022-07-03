using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Models
{
    public class tbl_impuestosModel
    {
        public int id_impuesto { get; set; }
        public float iva { get; set; }
        public float isr { get; set; }
        public float total { get; set; }
        public string estado { get; set; }
    }
}
