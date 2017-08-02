using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Infra.Data.Contexto
{
    public class ProjetoContexto : DbContext
    {
        public ProjetoContexto() 
            : base("ProjetoDDD") // Nome da string de conexão ou String de conexão
        {

        }

        //public DbSet<Entidade> Entidades { get; set; }
    }
}
