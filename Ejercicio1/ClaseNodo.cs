using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class ClaseNodo<Tipo>
    {
        private Tipo _Dato;
        private ClaseNodo<Tipo> _siguiente;

        public ClaseNodo<Tipo> Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }


        public Tipo Dato
        {
            get { return _Dato; }
            set { _Dato = value; }
        }
        ~ClaseNodo()
        {
            Dato = default(Tipo);
        }
    }
}
