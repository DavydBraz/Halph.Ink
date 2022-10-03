using System.Collections;

namespace Halph.Ink;

public class Cliente:Pessoa
{
    private ArrayList _projeto = new ArrayList();

    public void AdicionarProjeto(Projeto projeto)
    {
        _projeto.Add(projeto);
    }
    public void RemoverProjeto(Projeto projeto)
    {
        _projeto.Remove(projeto);
    }


}
