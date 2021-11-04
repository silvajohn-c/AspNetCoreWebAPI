using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        public AlunoController() { }

        public List<Aluno> Alunos = new List<Aluno> {
            new Aluno(
                1,
                "Jhully",
                "Hermes",
                "27996584587"
            ),
            new Aluno(
                2,
                "Jenny",
                "Mejia",
                "27996584587"
            ),
            new Aluno(
                3,
                "John",
                "Silva",
                "27996584587"
            ),

        };

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(Alunos);
        }

        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null) return BadRequest("Aluno não encontrado");
            return Ok(aluno);
        }
        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {

            return Ok(aluno);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {

            return Ok(aluno);
        }
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {

            return Ok(aluno);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            return Ok();
        }
    }
}