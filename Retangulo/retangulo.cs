using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retangulo
{
    class retangulo
    {
        private double _a, _l; // _a -> altura; _l -> Largura
        public string altura
        {
            set => _a = Convert.ToDouble(value);
        }
        public string largura
        {
            set => _l = Convert.ToDouble(value);
        }
        public string Area =>(_a * _l).ToString();
        public string Perimetro => ((_a + _l)*2).ToString();
        public string Diagonal =>Math.Sqrt(_a*_a + _l*_l).ToString();
    }
}
