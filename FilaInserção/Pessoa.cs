using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaInserção
{
    internal class Pessoa
    {
        string nome;
        Pessoa? proximo;

        public Pessoa(string n)
        {
            this.nome = n;
            this.proximo = null;
        }
        public  void setNext (Pessoa aux)
        {
            this.proximo = aux;
        }
        public Pessoa getNext()
        {
            return proximo;
        }

        public Pessoa(string nome, Pessoa? proximo) : this(nome)
        {
            this.proximo = proximo;
        }

        public override string ToString()
        {
            return this.nome;
        }
    }
}
