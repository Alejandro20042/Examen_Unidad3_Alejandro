using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad3_Alejandro
{
    class Nodo
    {
        public int Valor;
        public Nodo Siguiente;

        public Nodo(int valor)
        {
            Valor = valor;
            Siguiente = null;

        }
    }

    class ListaEnlazada
    {
        public Nodo primero;

        public ListaEnlazada()
        {
            primero = null;
        }

        public void InsertarAlFinal(int valor)
        {
            Nodo nuevoNodo = new Nodo(valor);
            nuevoNodo.Siguiente = primero;
            primero = nuevoNodo;
        }
       
        public void ImprimirLista()
        {
            Nodo actual = primero;
            while (actual != null)
            {
                Console.WriteLine(actual.Valor + "");
                actual = actual.Siguiente;
            }
        }

    }
}





