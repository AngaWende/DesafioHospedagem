using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioHospedagem.models
{
    public class Pessoa
    {
        
        public Pessoa(string nome, string sobrenome){
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;
        private string _sobrenome;

        public string Nome { 
            get => _nome.ToUpper();
            set{ _nome = value; 
        } }
        public string Sobrenome { 
            get => _sobrenome.ToUpper();
            set{ _sobrenome = value; 
        } }

    }
}