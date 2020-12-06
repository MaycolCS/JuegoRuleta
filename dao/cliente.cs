using System;
using System.Collections.Generic;
using System.Text;

namespace pruebaMasivian.dao
{
    class cliente
    {
        private Int32 idCliente;
        private Double saldoCliente;
        private Double gananciasCliente;
        private List<Int32> idApuestaCliente = new List<Int32>();
        private List<String> apuestaCliente = new List<String> ();
        private List<Int32> valorApuestaCliente = new List<Int32>();
        private Int32 idRuletaApuesta;
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public Double SaldoCliente { get => saldoCliente; set => saldoCliente = value; }
        public Double GananciasCliente { get => gananciasCliente; set => gananciasCliente = value; }
        public List<int> IdApuestaCliente { get => idApuestaCliente; set => idApuestaCliente = value; }
        public List<string> ApuestaCliente { get => apuestaCliente; set => apuestaCliente = value; }
        public List<int> ValorApuestaCliente { get => valorApuestaCliente; set => valorApuestaCliente = value; }
        public int IdRuletaApuesta { get => idRuletaApuesta; set => idRuletaApuesta = value; }
    }
}
