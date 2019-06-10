using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoAspNetWebApi.Models
{
    public class Turma
    {
        public int Id { get; set; }

        public string ProfessorId { get; set; }
        public string Nome { get; set; }     
        public decimal MediaMinima { get; set; }
        public decimal TaxaFrequencia { get; set; }
        public string Turno { get; set; }

        // Cria propriedade de relacionamento com a tabela Usuario

        public ICollection<Aluno> Aluno { get; set; }
        public ICollection<Disciplina> Disciplinas { get; set; }


        public Professor Professor { get; set; }
    }
}