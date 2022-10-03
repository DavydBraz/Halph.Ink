using Halph.Ink;
using System.Collections;
public class Projeto
{
    private int _id;
    private string _name;
    private Servico[] _servico;
    private string _status;
    private Cliente[] _cliente;
    private Designer[] _designer;
    private float _total;
    private DateTime _dataCriacao;
    private DateTime _prazo;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string Status {
        get { return _status; }
        set { _status = value; }
    }
    public float Total {
        get { return _total; }
        set { _total = value; }
    }

}
