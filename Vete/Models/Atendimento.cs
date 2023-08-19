using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vete
{
    public class Atendimento
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string? Animal { get; set; }
        public string? Veterinario { get; set; }
        public string? Observacao { get; set; }

        public Atendimento()
        {

        }

        public Atendimento(
            int id
            , DateTime date
            , string? animal
            , string? veterinario
            , string? observacao
        )
        {
            Id = id;
            Date = date;
            Animal = animal;
            Veterinario = veterinario;
            Observacao = observacao;
        }

        private void Salvar()
        {

        }

        private void Retornar()
        {
            
        }
    }
}