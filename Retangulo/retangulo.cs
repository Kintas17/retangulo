using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retangulo
{
    class retangulo
    {
        private double valor;
        private double valor2;

        public string recebe
        {
            set
            {
                valor = Convert.ToDouble(value)* valor2;
            }
        }
        public string envia
        {
            get
            {
               return valor.ToString();
            }
        }
    }
}
