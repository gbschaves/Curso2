//namespace Cadastro;

namespace Cadastro
{
  public class Produto
  {
    public string? Descricao { get; set; }

    public void ImprimirDescricao()
    {
      //Console.WriteLine(Descricao);

      var produto = new Cadastro.Produto();
      produto.Descricao = "Teclado";

      produto.ImprimirDescricao();
    }
  }
}