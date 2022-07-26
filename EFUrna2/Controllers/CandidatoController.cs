using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EFUrna2.Dominio;
using EFUrna2.Repositorio;

namespace EFUrna2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatoController : ControllerBase
    {
        private readonly CandidatoContext _context;

        public CandidatoController(CandidatoContext context)
        {
            _context = context;
        }

        // GET: api/Candidato
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Candidato>>> GetCandidatos()
        {
            return await _context.Candidatos.ToListAsync();
        }

        // GET: api/Candidato/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Candidato>> GetCandidato(int id)
        {
            var candidato = await _context.Candidatos.FindAsync(id);

            if (candidato == null)
            {
                return NotFound();
            }

            return candidato;
        }

        //AddCandidato: api/Candidato
        [HttpPost]
        public ActionResult Post(Candidato model)
        {
            try
            {
                _context.Candidatos.Add(model);
                _context.SaveChanges();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }
        }

        // Votar: api/Candidato/Votar/5
        [HttpPost("Votar/{id}")]
        public async Task<ActionResult<Candidato>> VotarCandidato(int id)
        {
            var candidato = await _context.Candidatos.FindAsync(id);
            if (candidato == null)
            {
                return NotFound();
            }

            _context.Candidatos.Update(candidato);
            candidato.Votos++;
            _context.SaveChanges();


            return candidato;
        }

        // PUT: api/Candidato/5    
        [HttpPut("{id}")]
        public ActionResult Put(int id, Candidato model)
        {
            try
            {
                if (_context.Candidatos
                    .AsNoTracking()
                    .FirstOrDefault(h => h.Id == id) != null)
                {
                    _context.Update(model);
                    _context.SaveChanges();

                    return Ok();
                }
                return Ok("Não Encontrado!");

            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }
        }
        // DELETE: api/Candidato/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Candidato>> DeleteCandidato(int id)
        {
            var candidato = await _context.Candidatos.FindAsync(id);
            if (candidato == null)
            {
                return NotFound();
            }

            _context.Candidatos.Remove(candidato);
            await _context.SaveChangesAsync();

            return candidato;
        }
    }
}
