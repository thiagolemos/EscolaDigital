using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoAspNetWebApi.Models
{
    public class Professor
    {
        public int Id { get; set; }

        // Chave estrangeira do Usuário
        public string UsuarioId { get; set; }
        public string Especialidade { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }

        // Cria propriedade de relacionamento com a tabela Usuario
        public virtual Usuario Usuario { get; set; }

        public ICollection<Aluno> Aluno { get; set; }

        public ICollection<Disciplina> Disciplina { get; set; }

        public ICollection<Turma> Turmas { get; set; }

        public Turma Turma { get; set; }






    }
}
