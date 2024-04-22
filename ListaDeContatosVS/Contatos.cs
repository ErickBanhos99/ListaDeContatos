using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatosVS
{
    internal class Contatos
    {
        private string nome;
        private string sobrenome;
        private string telefone;
    

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }
            set
            {
                sobrenome = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                if (value.Length == 11)
                {
                    telefone = value;
                }
                else
                {
                    //País-Cidade-Telefone. ex: +55=11-99999-9999
                    telefone = "00-00000-0000";
                }
            }
        }
        //O método que tem o mesmo nome da Classe
        //e não retorna nada, é chamado CONSTRUTOR
        //DA CLASSE.

        public Contatos()
        {
            Nome = "José";
            Sobrenome = "Da Silva";
            Telefone = "11-99999-9999";
        }

        public Contatos(string nome, string sobrenome, string telefone)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }

        // Sobrescreve o método ToString()
        // "Polimorfismo".
        public override string ToString()
        {
            string saida = string.Empty;
            saida += String.Format("{0}, {1}", Nome, Sobrenome);
            saida += String.Format("({0}) {1}-{2}", Telefone.Substring(0, 2), Telefone.Substring(2, 5), Telefone.Substring(7, 4));
            return saida;
        }
    }
}

