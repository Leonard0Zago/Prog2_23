using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vete
{
    public class Veterinario
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int Telefone { get; set; }
        public int CRM { get; set; }

        public Veterinario()
            {

            }

        public Veterinario(
            int id
            , string? name
            , string? email
            , int telefone
            , int cRM
        )
        {
            Id = id;
            Name = name;
            Email = email;
            Telefone = telefone;
            CRM = cRM;
        }

        private void Salvar()
        {

        }

        private void Retornar()
        {

        }

    }
}