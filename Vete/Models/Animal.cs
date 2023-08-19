using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vete
{
    public class Animal
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Raca { get; set; }
        public float Peso { get; set; }
        public float Altura { get; set; }
        public string? Responsavel { get; set; }
        public int Telefone_Responsavel { get; set; }

        public Animal()
        {

        }

        public Animal(
            int id
            , string? name
            , string? raca
            , float peso
            , float altura
            , string? responsavel
            , int telefone_responsavel
        )
        {
            Id = id;
            Name = name;
            Raca = raca;
            Peso = peso;
            Altura = altura;
            Responsavel = responsavel;
            Telefone_Responsavel = telefone_responsavel;
        }

        private void Salvar()
        {

        }

        private void Retornar()
        {
            
        }
    }
}