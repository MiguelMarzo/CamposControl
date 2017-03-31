using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Campo : IEquatable<Campo>
    {
        public int id;
        public int parcela;
        public int poligono;
        public double superficie;
        public String nombre;

        public Campo(int id, int parcela, int poligono, double superficie, String nombre)
        {
            this.id = id;
            this.parcela = parcela;
            this.poligono = poligono;
            this.superficie = superficie;
            this.nombre = nombre;
        }
        public bool Equals(Campo other)
        {
            if (other == null)
                return false;

            if (this.id == other.id)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return nombre.ToString();
        }
    }
}
