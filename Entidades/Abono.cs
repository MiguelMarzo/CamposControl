using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Abono : IEquatable<Abono>
    {
        private int id;
        private String formulacion;
        private String marca;

        public Abono(int id, String formularcion, String marca)
        {
            this.id = id;
            this.formulacion = formulacion;
            this.marca = marca;
        }
        public bool Equals(Abono other)
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
            return marca.ToString();
        }
    }
}
