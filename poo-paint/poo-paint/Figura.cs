using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace poo_paint
{
    public class Circulo : Figura
    {
        protected int px;
        protected int py;

        public virtual string Imprime()
        {
            return "figura[x:" + px + ",y:" + py + "]";
        }

        public virtual void Desenha(Graphics g)
        {
        }
    }
}
