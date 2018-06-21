using System;
using System.Collections.Generic;
using System.Text;

namespace Violet
{
    public class Pessoa : IPessoa
    {
        public Pessoa()
        {
            ID = GerarID();
        }

        public Pessoa(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
            ID = GerarID();
        }

        public Pessoa(string nome, string telefone, string email, string endereco, string cEP)
        {

            Nome = nome;
            Telefone = telefone;
            Email = email;
            Endereco = endereco;
            CEP = cEP;
            ID = GerarID();
        }

        public Pessoa(Guid iD, string nome, string telefone, string email, string endereco, string cEP)
        {
            ID = iD;
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Endereco = endereco;
            CEP = cEP;
        }
        private Guid GerarID()
        {
            Random gerador = new Random();
            byte[] ID = new byte[16];
            gerador.NextBytes(ID);
            return new Guid(ID);
        }

        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string CEP { get; set; }
        public Guid ID { get; private set; }

    }
}
