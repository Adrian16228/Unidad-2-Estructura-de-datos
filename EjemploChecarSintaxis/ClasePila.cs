using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploChecarSintaxis
{
    internal class ClasePila<Tipo>
    {
        private ClaseNodo<Tipo> _Cima;
        private int _intTamaño;
        public ClasePila()
        {
            _Cima = null;
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
                if (_Cima == null) return true;
                else
                    return false;
            }
        }
        public void Agregar(Tipo n)//push
        {
            ClaseNodo<Tipo> NuevoNodo = new ClaseNodo<Tipo>();
            NuevoNodo.Dato = n;
            NuevoNodo.Siguiente = _Cima;
            _Cima = NuevoNodo;
            _intTamaño++;
        }
        public Tipo ELiminar()//pop
        {
            if (Vacia)
            {
                throw new Exception("La pila esta vacia no se puede eliminar nada");
            }
            Tipo Valor = _Cima.Dato;
            _Cima = _Cima.Siguiente;
            _intTamaño--;
            return Valor;
        }
        public Tipo Peek()
        {
            if (Vacia)
            {
                throw new Exception("La pila esta vacia");
            }
            return _Cima.Dato;
        }
        public IEnumerator<Tipo> GetEnumerator()
        {
            ClaseNodo<Tipo> actual = _Cima;
            while (actual != null)
            {
                yield return actual.Dato;
                actual = actual.Siguiente;
            }
        }
    }
}
