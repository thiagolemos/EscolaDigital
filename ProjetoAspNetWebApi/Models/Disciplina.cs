using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoAspNetWebApi.Models
{
    public class Disciplina
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }

        public IEnumerable<Aluno> Aluno { get; set; }
        public IEnumerable<Turma> Turmas { get; set; }

        public IEnumerable<Professor> Professors { get; set; }


    }
}
