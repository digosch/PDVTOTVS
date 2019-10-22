using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PDVT.Models;
using TPDV.Models;

namespace TPDV.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]

    public class TransacaosController : Controller
    {
        private readonly TPDVContext _context;

        public TransacaosController(TPDVContext context)
        {
            _context = context;
        }

        // GET: api/Transacao/1
        [HttpGet("{id}")]
        public Transacao Get(
            [FromServices]TransacaoDAO transacaoDAO,
            int id)
        {
            return transacaoDAO.Obter(id);
        }



        // POST: api/Transacaos
        [HttpPost]
        public  ActionResult PostTransacao([FromBody]Transacao transacao)
        {
            Transacao T = new Transacao();

            int t1 = 0;
            int t2 = 0;

            t1 = T.ValorPagar;
            t2 = T.ValorPago;



            T.calculatroco(t1,t2);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Resultado.Add(transacao);
            _context.SaveChanges();

            return CreatedAtAction("GetTransacao", transacao);
        }

        private bool TransacaoExists(int id)
        {
            return _context.Resultado.Any(e => e.Id == id);
        }
    }
}