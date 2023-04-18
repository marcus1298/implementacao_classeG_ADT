public class Lista<TAD> where TAD : IComparable<TAD>
{
    private NoLista<TAD> INICIO;
    private NoLista<TAD> FIM;

    public Lista()
    {
        INICIO = null;
        FIM = null;
    }

    public NoLista<TAD> getInicio()
    {
        return INICIO;
    }

    public void setInicio(NoLista<TAD> novoInicio)
    {
        INICIO = novoInicio;
    }

    public NoLista<TAD> getFim()
    {
        return FIM;
    }

    public void setFim(NoLista<TAD> novoFim)
    {
        FIM = novoFim;
    }

    public bool estaVazia()
    {
        return INICIO == null;
    }

    public void insere(TAD n)
    {
        NoLista<TAD> novoNo = new NoLista<TAD>(n);

        if (estaVazia())
        {
            INICIO = novoNo;
            FIM = novoNo;
        }
        else if (n.CompareTo(INICIO.getInfo()) < 0)
        {
            novoNo.setNext(INICIO);
            INICIO.setPrevio(novoNo);
            INICIO = novoNo;
        }
        else if (n.CompareTo(FIM.getInfo()) > 0)
        {
            novoNo.setPrevio(FIM);
            FIM.setNext(novoNo);
            FIM = novoNo;
        }
        else
        {
            NoLista<TAD> aux = INICIO.getNext();
            while (aux.getInfo().CompareTo(n) < 0)
            {
                aux = aux.getNext();
            }
            aux.getPrevio().setNext(novoNo);
            novoNo.setPrevio(aux.getPrevio());
            novoNo.setNext(aux);
            aux.setPrevio(novoNo);
        }
    }

    public void remove(TAD n)
    {
        NoLista<TAD> aux = INICIO;
        while (aux != null && !aux.getInfo().Equals(n))
        {
            aux = aux.getNext();
        }
        if (aux != null)
        {
            if (INICIO == FIM)
            {
                INICIO = null;
                FIM = null;
            }
            else if (aux == INICIO)
            {
                INICIO = aux.getNext();
                INICIO.setPrevio(null);
            }
            else if (aux == FIM)
            {
                FIM = aux.getPrevio();
                FIM.setNext(null);
            }
            else
            {
                aux.getPrevio().setNext(aux.getNext());
                aux.getNext().setPrevio(aux.getPrevio());
            }
        }
    }

    public void imprime()
    {
        NoLista<TAD> aux = INICIO;
        while (aux != null)
        {
            Console.Write(aux.getInfo() + " ");
            aux = aux.getNext();
        }
        Console.WriteLine();
    }
}