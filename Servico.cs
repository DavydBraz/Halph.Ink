namespace Halph.Ink;

public class Servico
{
    private string _nome;
    private int _id;
    private float _valor;

    public string Nome
    {
        get { return _nome;}
        set { _nome = value; }
    }

    public int Id
    {
        get { return _id;}
        set { _id = value; }
    }

    public float Valor
    {
        get { return _valor;}
        set { _valor = value; }
    }
}