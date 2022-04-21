using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class StackInt
    {
        //Definition of NO
        private class NO
        {
            public int dado { get; set; }
            public NO prox { get; set; }
        }

        //Definition of return from methods POP and TOP
        public class Retorno
        {
            public int item { get; set; }
            public Boolean ok { get; set; }
        }

        //Definition of pointer top of stack
        private static NO topo;

        public void INIT()
        {
            topo = null;
        }

        public bool IsEmpty()
        {
            return topo == null;
        }

        public void PUSH(int item)
        {
            NO novo = new NO();
            novo.dado = item;
            novo.prox = topo;
            topo = novo;
        }

        public Retorno POP()
        {
            Retorno saida = new Retorno();
            if (!IsEmpty())
            {
                saida.item = topo.dado;
                topo = topo.prox;
                saida.ok = true;
            }
            else
            {
                saida.ok = false;
            }

            return saida;
        }

        public Retorno TOP()
        {
            Retorno saida = new Retorno();
            if (!IsEmpty()) 
            {
                saida.item = topo.dado;
                saida.ok = true;
            }
            else
            {
                saida.ok = false;
            }

            return saida;
        }

    }
}
