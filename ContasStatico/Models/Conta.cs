using System;

namespace ContasStatico.Models
{
    public class Conta
    {
        public Conta() { }

        public Conta(int numLeitura, DateTime dataLeitura, int kwGasto, double valorConta, DateTime dataPagamento, double consumoMedio)
        {
            this.numLeitura = numLeitura;
            this.dataLeitura = dataLeitura;
            this.kwGasto = kwGasto;
            this.valorConta = valorConta;
            this.dataPagamento = dataPagamento;
            this.consumoMedio = consumoMedio;

        }
        public int numLeitura { get; set; }
        public DateTime dataLeitura { get; set; }
        public int kwGasto { get; set; }
        public double valorConta { get; set; }
        public DateTime dataPagamento { get; set; }
        public double consumoMedio { get; set; }

    }
}