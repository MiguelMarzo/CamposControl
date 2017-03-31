using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.DSCamposTableAdapters;

namespace CapaDatos
{
    public class Datos
    {
        private DSCampos dsCampos;
        private CamposTableAdapter daCampo;
        private CultivoTableAdapter daCultivo;
        private AbonosTableAdapter daAbono;
        private CampoAñoCultivoTableAdapter daCampoAñoCultivo;

        public Datos()
        {
            CrearDataSetCompleto();
        }

        private void CrearDataSetCompleto()
        {
            dsCampos = new DSCampos();

            daCampo = new DSCamposTableAdapters.CamposTableAdapter();
            daCampo.Fill(dsCampos.Campos);

            daCultivo = new DSCamposTableAdapters.CultivoTableAdapter();
            daCultivo.Fill(dsCampos.Cultivo);

            daAbono = new DSCamposTableAdapters.AbonosTableAdapter();
            daAbono.Fill(dsCampos.Abonos);

            daCampoAñoCultivo = new DSCamposTableAdapters.CampoAñoCultivoTableAdapter();
            daCampoAñoCultivo.Fill(dsCampos.CampoAñoCultivo);
        }

        //SELECTS
    }
}
