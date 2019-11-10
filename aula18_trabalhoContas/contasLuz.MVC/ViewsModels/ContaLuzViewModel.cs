using System.Collections.Generic;
using contasLuz.interfaces;
using contasLuz.Entities;

namespace contasLuz.MVC.ViewsModels
{
    public class ContaLuzViewModel
    {
        public ContaLuzViewModel(IContaRepository ContaRepository)
        {
            this.listaContasLuz = ContaRepository.Get();
            this.menorConsumo = ContaRepository.GetMenorConsumo();
            this.maiorConsumo = ContaRepository.GetMaiorConsumo();
        }

        public IEnumerable<ContaLuz> listaContasLuz { get; set; }
        public ContaLuz menorConsumo { get; set; }
        public ContaLuz maiorConsumo { get; set; }
    }
}