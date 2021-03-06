﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Cultivo : IEquatable<Cultivo>
    {
        public int id;
        public String tipo;
        public String variedad;

        public Cultivo (int id, String tipo, String variedad) {
            this.id = id;
            this.tipo = tipo;
            this.variedad = variedad;
        }
        public bool Equals(Cultivo other)
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
            return tipo + ", " + variedad;
        }
    }
}
