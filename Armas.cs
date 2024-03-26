using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeArmas.NewFolder1
{
    internal class Armas
    {
        protected string name;
        protected string nameArmo;

        public string Name
        {
            get
            {
                return name;
            }
        }
        public string NameArmo
        {
            get
            {
                return nameArmo;
            }
        }
        public virtual float PrecioArma()
        {
            return 0;
        }
        public virtual float DañoArma()
        {
            return 0;
        }
        public virtual float VelocidadAtaque()
        {
            return 0;
        }
        public virtual float Munición()
        {
            return 0;
        }
    }
}
