using Interfaces.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Modelos.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Examen_Final_Progra_X__1804002020.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GastosController : ControllerBase
    {
        private readonly IGastos service;
        private readonly IDbConnection connection;
        public GastosController(IGastos gasto, IDbConnection _connection)
        {
            this.service = gasto;
            this.connection = _connection;
        }

        // GET: api/<GastosController>
        [HttpGet]
        public List<tbl_gastosModel> Get()
        {
            return service.GetGastos(connection);
        }

        // PUT api/<GastosController>/5
        [HttpPut("{id}")]
        public List<tbl_gastosModel> Put(int id)
        {
            return service.EditGasto(connection, id);
        }
    }
}
