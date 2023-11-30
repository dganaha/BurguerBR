using BurguerBR.Models;
using BurguerBR.Repositories.Interfaces;
using BurguerBR.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BurguerBR.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraController(ILancheRepository lancheRepository, CarrinhoCompra carrinhoCompra)
        {
            _lancheRepository = lancheRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        public IActionResult Index()
        {
            var itens = _carrinhoCompra.GetCarrinhoCompraItens();
            _carrinhoCompra.CarrinhoCompraItems = itens;

            var carrinhoCompraVM = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
            };
            
            return View(carrinhoCompraVM);
        }

        [Authorize]
        public IActionResult AdicionarItemNoCarrinhoCompra(int lancheId) //Recebo o id do lanche que gostaria de adicionar
        {
            var lancheSelecionado = _lancheRepository.Lanches.FirstOrDefault(p => p.LancheId == lancheId); //localizo o lanche no banco usando LINQ
            if (lancheSelecionado != null)                                      //verifico se é null
            {
                _carrinhoCompra.AdicionarAoCarrinho(lancheSelecionado);         //adiciono no carrinho
            }
            return RedirectToAction("Index");
        }

        public IActionResult RemoverItemDoCarrinhoCompra(int lancheId) //Recebo o id do lanche que gostaria de remover
        {
            var lancheSelecionado = _lancheRepository.Lanches.FirstOrDefault(p => p.LancheId == lancheId); //localizo o lanche no banco usando LINQ
            if (lancheSelecionado != null)                                              //verifico se é null
            {
                _carrinhoCompra.RemoverDoCarrinho(lancheSelecionado);                   //removo do carrinho
            }
            return RedirectToAction("Index");
        }


    }
}
