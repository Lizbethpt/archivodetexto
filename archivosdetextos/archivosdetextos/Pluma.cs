using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace archivosdetextos
{
    class Pluma
    {
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public Pluma()
        {
            tipo = "";
            color = "";
        }
        public Pluma(string tipo, string color)
        {
            this.tipo = tipo;
            this.color = color;
        }
        public override string ToString()
        {
            return tipo + " " + color;
        }


    }
}
