using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_paint
{
    public class Retangulo : Figura
    {
        private int priv_larg;
        private int priv_altu;
        static int contador;

        public Retangulo(int x, int y, int largura, int altura)
        {
            px = x;
            py = y;
            priv_larg = largura;
            priv_altu = altura;

            contador += 1;
        }

        public override string Imprime()
        {
            return "retangulo[x:" + px + ",y:" + py + ",l:" + priv_larg + ",a:" + priv_altu + "]";
        }

        public static void ZeraContador()
        {
            contador = 0;
        }

        public static int LeContador()
        {
            return contador;
        }

        public override void Desenha(Graphics g)
        {
            g.DrawRectangle(Pens.Black, px, py, priv_larg, priv_altu);
        }
    }
}
