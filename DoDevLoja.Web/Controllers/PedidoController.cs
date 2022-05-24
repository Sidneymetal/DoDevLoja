using Microsoft.AspNetCore.Mvc;

namespace DoDevLoja.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class PedidoController : ControllerBase
{
    public static Cliente Cliente { get; set; } = new Cliente("33445845489-66", "Rua Megalomaníaca, 311", "Morramad Pataxó", "morramadpataxó@gmail.com", "123456");
    public static Pedido Pedido { get; set; } = new Pedido("NickName", "Confirmado", DateTime.Now);
    public static List<Produto> ProdutoVenda { get; set; } = new List<Produto>()
    {
      new Mouse(1, "MouseRuim", "MarcaUm", "Mouse abaixo da média", 30, 5, false, 800),
      new Mouse(2, "MouseMedio", "MarcaDois", "Mouse na média", 100, 7, false, 2400),
      new Mouse(3, "MouseBom", "MarcaDois", "Mouse acima da média", 200, 2, true, 12000),
      new Keyboard(4, "TecladoRuim", "MarcaUm", "Teclado abaixo da média", 100, 3, false, false),
      new Keyboard(5, "TecladoBom", "MarcaTres", "Teclado acima da média", 500, 1, true, true),
      new Headset(6, "HeadsetMedio", "MarcaDois", "Headset na média", 250, 2, false, true),
      new Headset(7, "HeadsetBom", "MarcaTres", "Headset acima da média", 400, 1, true, true)
    };

    [HttpGet("Itens para vendas.")]
    public IActionResult ProdutoVenda()
    {
        return Ok(ProdutoVenda);
    }

    [HttpGet("Pedido Atualizado.")]
    public IActionResult PedidoAtual()
    {
        return Ok(PedidoAtual);
    }

    [HttpGet("Finalizar Pedido.")]
    public IActionResult FinalizarPedido()
    {
        Pedido.FinalizarPedido();
        return Ok(Pedido);
    }    
}
