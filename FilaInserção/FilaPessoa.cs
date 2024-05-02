using FilaInserção;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FilaInserção
{
    internal class FilaPessoa
    {
        Pessoa? head;
        Pessoa? tail;
        public FilaPessoa()
        {
            this.head = null;
            this.tail = null;
        }
        public void Push(Pessoa aux)
        {
            if (IsEmpty())
                this.head = this.tail = aux;
            else
            {
                this.tail.setNext(aux);
                this.tail = aux;
            }
        }
        public void Pop()
        {
            if (!IsEmpty())
            {
                if(tail == head) //verifico se só tenho um elemneto na fila 
                {
                    head = tail = null;
                }

                else
                {
                    this.head = head.getNext();
                }
                
            }
        }
        //antes de percorrer a fila, preciso criar um auxiliar
        public void RunOver()
        {
            if(!IsEmpty())
            {
                Pessoa aux = head; //criei o auxiliar usando head
                do
                {
                    Console.WriteLine(">>" + aux.ToString());
                    aux = aux.getNext();
                } while (aux != null); //até auxiliar ser nullo

            }
        }
        bool IsEmpty()
        {
            return head == null && tail == null;
        }
    }
}

