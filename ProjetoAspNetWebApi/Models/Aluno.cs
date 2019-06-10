using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoAspNetWebApi.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        // Chave estrangeira do Usuário
        public string UsuarioId { get; set; }
        public string NomeMae { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }

        // Cria propriedade de relacionamento com a tabela Usuario
        public virtual Usuario Usuario { get; set; }


        public IEnumerable<Disciplina> Disciplinas { get; set; }

        public IEnumerable<Turma> Turma { get; set; }

        public IEnumerable<Professor> Professor { get; set; }


    }

}
