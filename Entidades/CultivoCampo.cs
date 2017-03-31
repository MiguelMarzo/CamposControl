using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class CultivoCampo : IEquatable<CultivoCampo>
    {
        private DateTime año;
        private int idCampo;
        private int idCultivo;
        private String malasHierbas;
        private int idAbono;
        private double kilosAbono;
        private String tratamientos;
        private String labores;

        public CultivoCampo(DateTime año, int idCampo, int idCultivo, int idAbono, String malasHierbas, double kilosAbono,
            String tratamientos, String labores)
        {
            this.año = año;
            this.idCampo = idCampo;
            this.idCultivo = idCultivo;
            this.idAbono = idAbono;
            this.malasHierbas = malasHierbas;
            this.kilosAbono = kilosAbono;
            this.tratamientos = tratamientos;
            this.labores = labores;
        }
        public bool Equals(CultivoCampo other)
        {
            if (other == null)
                return false;

            if (this.idCampo == other.idCampo && this.año == other.año)
                return true;
            else
                return false;
        }
    }
}
