using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeArmas.NewFolder1
{
    internal class ArmasInfo : Armas
    {
        float p;
        float d;
        float v;
        float m;

        public ArmasInfo (string name, float p, float d, float v, float m, string nameArmo)
        {
            this.p = p;
            this.d = d;
            this.m = m;
            this.v = v;
            this.name = name;
            this.nameArmo = nameArmo;
        }
        public override float PrecioArma()
        {
            return p;
        }
        public override float DañoArma()
        {
            return d;
        }
        public override float VelocidadAtaque()
        {
            return v;
        }
        public override float Munición()
        {
            return m;
        }
    }
}
