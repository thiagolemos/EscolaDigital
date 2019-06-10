using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace ProjetoAspNetWebApi.Models
{
    public class Usuario : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<Usuario> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public Usuario()
        {
            //inicializando a lista de professores
            this.Professores = new HashSet<Professor>();
            this.Tipos = new List<string> { "Administrador", "Gestor", "Aluno", "Professor" };
        }

        public DateTime DataCriacao { get; set; }

        public string Nome { get; set; }

        public virtual ICollection<Aluno> Alunos { get; set; }
        public virtual ICollection<Professor> Professores { get; set; }


        public List<string> Tipos { get; set; }
    }
}
