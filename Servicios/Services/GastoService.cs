using Interfaces.Interfaces;
using Modelos.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Services
{
    public class GastoService : IGastos
    {
        public void DeleteGasto(int id)
        {
            throw new NotImplementedException();
        }

        public List<tbl_gastosModel> EditGasto(IDbConnection connection, int id_gasto)
        {
            throw new NotImplementedException();
        }

        public tbl_gastosModel GetGasto()
        {
            throw new NotImplementedException();
        }

        public List<tbl_gastosModel> GetGastos(IDbConnection connection)
        {
            throw new NotImplementedException();
        }

        public void SetGasto(tbl_gastosModel gasto)
        {
            throw new NotImplementedException();
        }
    }
}
