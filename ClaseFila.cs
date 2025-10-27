using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPila
{
    internal class ClaseFila<Tipo>
    {
        private ClaseNodo<Tipo> _Inicio;
        private ClaseNodo<Tipo> _Final;
        private int _intTamaño;
        public ClaseFila()
        {
            _Inicio = null;
            _intTamaño = 0;
        }
        public int Tamaño
        {
            get { return _intTamaño; }
            set { _intTamaño = value; }
        }
        public bool Vacia
        {
            get
            {
                if (_Inicio == null) return true;
                else
                    return false;
            }
        }
        public void Agregar(Tipo n)
        {
            ClaseNodo<Tipo> NuevoNodo = new ClaseNodo<Tipo>();
            NuevoNodo.Dato = n;
            if(Vacia)
            {
                _Inicio=NuevoNodo;
                _Final=NuevoNodo;
            }
            else
            {
                _Final.Siguiente = NuevoNodo;
                _Final = NuevoNodo;
            }
            _intTamaño++;

        }
        public Tipo ELiminar()
        {
            if (Vacia)
            {
                throw new Exception("La cola esta vacia no se puede eliminar nada");
            }
            Tipo Valor = _Inicio.Dato;
            _Inicio = _Inicio.Siguiente;
            _intTamaño--;

            if(_Inicio == null)
                _Final=null;
            
            return Valor;
        }
        public IEnumerator<Tipo> GetEnumerator()
        {
            ClaseNodo<Tipo> actual = _Inicio;
            while (actual != null)
            {
                yield return actual.Dato;
                actual = actual.Siguiente;
            }
        }

    }
}
