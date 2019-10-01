using System;

namespace aula6CrudPeople.Models
{
    public class Person
    {
        public Person() { }


        public Person(int id, string name, DateTime dataLeitura, DateTime dataPagamento, double valorPagar, double mediaConsumo, int kwGasto)
        {
            this.id = id;
            this.name = name;
            this.dataLeitura = dataLeitura;
            this.dataPagamento = dataPagamento;
            this.valorPagar = valorPagar;
            this.mediaConsumo = mediaConsumo;
            this.kwGasto = kwGasto;

        }
        public int id { get; set; }
        public string name { get; set; }
        public DateTime dataLeitura { get; set; }
        public DateTime dataPagamento { get; set; }
        public double valorPagar { get; set; }
        public double mediaConsumo { get; set; }
        public int kwGasto { get; set; }

    }


}