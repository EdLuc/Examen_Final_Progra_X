using Modelos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces
{
    public interface IImpuesto
    {
        tbl_impuestosModel GetImpuesto();
        List<tbl_impuestosModel> GetImpuestos(System.Data.IDbConnection connection);
        void SetImpuesto(tbl_impuestosModel impuesto);
        void DeleteImpuesto(int id);
        List<tbl_impuestosModel> EditImpuesto(System.Data.IDbConnection connection, int id_impuesto);
    }
}
