using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using contasLuz.Domain.Entities;
using contasLuz.Repositories.Interfaces;

namespace contasLuz.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaRepository : ControllerBase
    {
        private IContaRepository repository;
        private IImovelRepository imovelRepository;

        public ContaRepository(IContaRepository repository, IImovelRepository imovelRepository)
        {
            this.repository = repository;
            this.imovelRepository = imovelRepository;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<ContaLuz>> Get()
        {
            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = repository.GetAll()
            });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<ContaLuz> Get(int id)
        {
            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = repository.GetByID(id)
            });
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ContaLuz entity)
        {
            var imovel = imovelRepository.GetByID(entity.idimovel);

            if (imovel != null)
                entity.imovel = imovel;

            repository.Create(entity);

            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = entity
            });
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ContaLuz entity)
        {
            var imovel = imovelRepository.GetByID(entity.idimovel);

            if (imovel != null)
                entity.imovel = imovel;

            repository.Update(entity);

            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = entity
            });
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            repository.Delete(id);

            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = new { }
            });
        }
    }
}
