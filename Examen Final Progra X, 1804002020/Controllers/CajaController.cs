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
    public class CajaController : ControllerBase
    {
        private readonly ICaja service;
        private readonly IDbConnection connection;
        public CajaController(ICaja caja, IDbConnection _connection)
        {
            this.service = caja;
            this.connection = _connection;
        }
        // GET: api/<CajaController>
        [HttpGet]
        public List<tbl_cajaModel> Get()
        {
            return service.GetCajas(connection);
        }

        // PUT api/<CajaController>/5
        [HttpPut("{id}")]
        public List<tbl_cajaModel> Put(int id)
        {
            return service.EditCaja(connection, id);
        }

    }
}
