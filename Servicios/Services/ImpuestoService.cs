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
    public class ImpuestoService : IImpuesto
    {
        public void DeleteImpuesto(int id)
        {
            throw new NotImplementedException();
        }

        public List<tbl_impuestosModel> EditImpuesto(IDbConnection connection, int id_impuesto)
        {
            throw new NotImplementedException();
        }

        public tbl_impuestosModel GetImpuesto()
        {
            throw new NotImplementedException();
        }

        public List<tbl_impuestosModel> GetImpuestos(IDbConnection connection)
        {
            throw new NotImplementedException();
        }

        public void SetImpuesto(tbl_impuestosModel impuesto)
        {
            throw new NotImplementedException();
        }
    }
}
