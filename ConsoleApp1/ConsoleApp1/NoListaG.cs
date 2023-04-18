public class NoLista<TAD>
{
    private NoLista<TAD> previo;
    private TAD info;
    private NoLista<TAD> next;

    public NoLista()
    {
        previo = null;
        info = default(TAD);
        next = null;
    }

    public NoLista(TAD valor)
    {
        previo = null;
        info = valor;
        next = null;
    }

    public NoLista<TAD> getPrevio()
    {
        return previo;
    }

public void setPrevio(NoLista<TAD> novoPrevio)
    {
        previo = novoPrevio;
    }

    public TAD getInfo()
    {
        return info;
    }

    public void setInfo(TAD novaInfo)
    {
        info = novaInfo;
    }

    public NoLista<TAD> getNext()
    {
        return next;
    }

    public void setNext(NoLista<TAD> novoNext)
    {
        next = novoNext;
    }
}