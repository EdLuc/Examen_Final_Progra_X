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
    public class CajaService : ICaja
    {
        public void DeleteCaja(int id)
        {
            throw new NotImplementedException();
        }

        public List<tbl_cajaModel> EditCaja(IDbConnection connection, int id_caja)
        {
            throw new NotImplementedException();
        }

        public tbl_cajaModel GetCaja()
        {
            throw new NotImplementedException();
        }

        public List<tbl_cajaModel> GetCajas(IDbConnection connection)
        {
            throw new NotImplementedException();
        }

        public void SetCaja(tbl_cajaModel caja)
        {
            throw new NotImplementedException();
        }
    }
}
