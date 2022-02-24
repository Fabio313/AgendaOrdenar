using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaOrganizar
{
    internal class Agenda
    {
        //public Contato Anterior { get; set; }  
        //public Contato Registro { get; set; }
        //public Contato Proximo { get; set; }
        public Contato Cabeca { get; set; }
        public Contato Cauda { get; set; }

        public Agenda()
        {
            //Anterior = null;
            //Registro = null;
            //Proximo = null;
            Cabeca = null;
            Cauda = null;
        }

        //inserir
        //remover
        //editar
        //imprimir
        //buscar
        //ordenar
        //achaposicao
        //vazio

        public void Push(Contato novoContato)
        {

            if (Vazio())
            {
                Cabeca = novoContato;
                //Registro = novoContato;
                Cauda = novoContato;
            }
            else
            {
                Cauda.Proximo = novoContato;
                Cauda = novoContato;
                OrdenaAgenda();
            }

        }

        public void PrintAgenda()
        {
            Contato aux = Cabeca;
            do
            {
                Console.WriteLine(aux.ToString());
                aux = aux.Proximo;
            } while (aux != null);
        }

        public void OrdenaAgenda()
        {
            Contato antR = Cabeca;
            Contato antC = Cabeca;
            for (Contato referencia = Cabeca; referencia != null; referencia = referencia.Proximo)
            {
                for (Contato comparacao = referencia.Proximo; comparacao != null; comparacao = comparacao.Proximo)
                {
                    if (string.Compare(referencia.Nome, comparacao.Nome) > 0)
                    {
                        Contato sup = referencia;
                        Contato sup1 = referencia.Proximo;
                        if (referencia == Cabeca)
                        {
                            referencia.Proximo = comparacao.Proximo;
                            antC.Proximo = referencia;
                            Cabeca = comparacao;
                            Cauda = sup;
                            if (sup1 == comparacao)
                                comparacao.Proximo = referencia;
                            else
                                comparacao.Proximo = sup1;
                            referencia = comparacao;
                        }
                        else
                        {
                            referencia.Proximo = comparacao.Proximo;
                            antR.Proximo = comparacao;
                            antC.Proximo = referencia;
                            Cauda = sup;
                            if (sup1 == comparacao)
                                comparacao.Proximo = referencia;
                            else
                                comparacao.Proximo = sup1;
                            referencia = comparacao;
                        }
                    }
                    antC = comparacao;
                }
                antR = referencia;
            }
        }

        public bool Vazio()
        {
            if ((Cabeca == null) & (Cauda == null))
                return true;
            else
                return false;
        }
        //public override string ToString()
        //{
        //    return Cauda.ToString();
        //}
    }
}
