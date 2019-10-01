using System.Collections.Generic;
using ContasEF.Models;

namespace ContasEF.ViewModel
{
    public class ContaViewModel
    {
        public ContaViewModel(IContasRepository contaLuzRepository)
        {
            this.listaContasLuz = contaLuzRepository.Get();
            this.menorConsumo = contaLuzRepository.GetMenor();
            this.maiorConsumo = contaLuzRepository.GetMaior();
        }

        public IEnumerable<ContaLuz> listaContasLuz { get; set; }
        public ContaLuz menorConsumo { get; set; }
        public ContaLuz maiorConsumo { get; set; }
    }
    
}