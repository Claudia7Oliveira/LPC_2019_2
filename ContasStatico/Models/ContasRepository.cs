using System.Collections.Generic;

namespace ContasStatico.Models
{
    public class ContasRepository
    {
        public static List<Conta> contas = new List<Conta>();
    
        public ContasRepository()
        {           
        }

        public void Create(Conta Conta)
        {
            contas.Add(Conta);
        }
        public List<Conta> GetAll()
        {
            return contas;
        }
        
        public Conta GetById(int numeroLeitura)
        {
            return contas.Find(i=>i.numLeitura == numeroLeitura);
        }
        public void Delete(int numeroLeitura)
        {
            contas.Remove(GetById(numeroLeitura));
        }

        public void Update(Conta Conta)
        {
            var i = contas.FindIndex(x=>x.numLeitura == Conta.numLeitura);
            contas[i].numLeitura = Conta.numLeitura;
            contas[i].dataLeitura = Conta.dataLeitura;
            contas[i].kwGasto = Conta.kwGasto;
            contas[i].valorConta = Conta.valorConta;
            contas[i].dataPagamento = Conta.dataPagamento;
            contas[i].consumoMedio = Conta.consumoMedio;
        }

    }
}