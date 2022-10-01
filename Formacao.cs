namespace Halph.Ink;

public class Formacao
{
    private string _tipo;
    private string _area;
    private string _especializacao;
    private string _andamento;

    public string Tipo
    {
        get { return _tipo; }
        set { _tipo = value; }
    }

    public string Area
    {
        get { return _area; }
        set { _area = value; }
    }

    public string Especializacao
    {
        get { return _especializacao; }
        set { _especializacao = value; }
    }

    public string Andamento
    {
        get { return _andamento; }
        set { _andamento = value; }
    }
}