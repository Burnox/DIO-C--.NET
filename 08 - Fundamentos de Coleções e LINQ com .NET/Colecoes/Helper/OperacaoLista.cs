using System.Collections.Generic;

namespace Colecoes.Helper
{
  public class OperacaoLista
  {
    public void ImprimirListaString(List<string> lista)
    {
      for (int i = 0; i < lista.Count; i++)
      {
        System.Console.WriteLine($"Estado {i + 1}: {lista[i]}");
      }
    }
  }
}