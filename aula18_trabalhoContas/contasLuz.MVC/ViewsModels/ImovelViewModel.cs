using System.Collections.Generic;
using contasLuz.Entities;
using contasLuz.Repositories.repositories;

namespace contasLuz.MVC.ViewsModels
{
    public class ImovelViewModel
    {
        public ImovelViewModel(ImovelRepository imovelRepository)
        {
            this.listaImovel = imovelRepository.Get();
        }
        public IEnumerable<Imoveis> listaImovel { get; set; }
    }
}