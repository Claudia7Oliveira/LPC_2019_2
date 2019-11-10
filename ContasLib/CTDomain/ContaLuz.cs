using System;
using System.ComponentModel.DataAnnotations;

namespace ContasEF.Models
{
    public class ContaLuz : DefId
    {
        public ContaLuz() { }

        public ContaLuz(int id, DateTime dataLeitura, int kwGasto, double valorConta, DateTime dataPagamento, double consumoMedio)
        {
            this.id = id;
            this.dataLeitura = dataLeitura;
            this.kwGasto = kwGasto;
            this.valorConta = valorConta;
            this.dataPagamento = dataPagamento;
            this.consumoMedio = consumoMedio;
        }
        /*formata a desgraça da data */
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage="Data em formato inválido")]
        public DateTime dataLeitura { get; set; }

        public int kwGasto { get; set; }

        public double valorAPagar { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage="Data em formato inválido")]
        public DateTime dataPagamento { get; set; }

        public double mediaConsumo { get; set; }
    }
    
}