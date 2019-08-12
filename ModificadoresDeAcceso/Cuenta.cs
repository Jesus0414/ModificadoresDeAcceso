using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresDeAcceso
{
    class Cuenta
    {
        public float saldo { get; set; }
        public Cliente cliente { get; set; }
        private string _identificador;
        public string Identificador
        {
            get
            {
                return _identificador;
            }
            set
            {
                if (value.Length ==10)
                {
                    _identificador = value;
                }
                else
                {
                    throw new Exception("Ocupa ser 10 caracteres");
                }
            }
        }
    }
}
