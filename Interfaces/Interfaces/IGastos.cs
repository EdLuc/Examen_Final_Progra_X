using Modelos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces
{
    public interface IGastos
    {
        tbl_gastosModel GetGasto();
        List<tbl_gastosModel> GetGastos(System.Data.IDbConnection connection);
        void SetGasto(tbl_gastosModel gasto);
        void DeleteGasto(int id);
        List<tbl_gastosModel> EditGasto(System.Data.IDbConnection connection, int id_gasto);
    }
}
