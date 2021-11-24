using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface iAnimal
    {
        void Nome(string nome);
        void Especie(string especie);
        void Raca(string raca);
    }

    class Animal : iAnimal
    {
        public string Nome { get; set; }
        public string Especie { get; set; }
        public string Raca { get; set; }

        void iAnimal.Nome(string nome)
        {
            this.Nome = nome;
        }
        void iAnimal.Especie(string especie)
        {
            this.Especie = especie;
        }
        void iAnimal.Raca(string raca)
        {
            this.Raca = raca;
        }
    }
}
