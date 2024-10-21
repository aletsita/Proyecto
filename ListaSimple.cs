using Proyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ListaSimple
{
    private Nodo cabeza;

    public ListaSimple()
    {
        cabeza = null;
    }

    // Insertar Nodo
    public void Insertar(int valor)
    {
        Nodo nuevoNodo = new Nodo(valor);
        if (cabeza == null)
        {
            cabeza = nuevoNodo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.ValorSiguiente != null)
            {
                actual = actual.ValorSiguiente;
            }
            actual.ValorSiguiente = nuevoNodo;
        }
        Console.WriteLine($"Nodo con valor {valor} insertado.");
    }

    // Imprimir Tamaño
    public int Tamano()
    {
        int contador = 0;
        Nodo actual = cabeza;
        while (actual != null)
        {
            contador++;
            actual = actual.ValorSiguiente;
        }
        return contador;
    }

    // Buscar Nodo por valor
    public Nodo Buscar(int valor)
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            if (actual.Valor == valor)
            {
                return actual;
            }
            actual = actual.ValorSiguiente;
        }
        return null;
    }

    // Borrar Nodo
    public void Borrar(int valor)
    {
        if (cabeza == null) return;

        if (cabeza.Valor == valor)
        {
            cabeza = cabeza.ValorSiguiente;
            Console.WriteLine($"Nodo con valor {valor} borrado.");
            return;
        }

        Nodo actual = cabeza;
        while (actual.ValorSiguiente != null)
        {
            if (actual.ValorSiguiente.Valor == valor)
            {
                actual.ValorSiguiente = actual.ValorSiguiente.ValorSiguiente;
                Console.WriteLine($"Nodo con valor {valor} borrado.");
                return;
            }
            actual = actual.ValorSiguiente;
        }
        Console.WriteLine($"Nodo con valor {valor} no encontrado.");
    }

    // Modificar Nodo
    public void Modificar(int valorAntiguo, int valorNuevo)
    {
        Nodo nodo = Buscar(valorAntiguo);
        if (nodo != null)
        {
            nodo.Valor = valorNuevo;
            Console.WriteLine($"Nodo modificado: {valorAntiguo} -> {valorNuevo}");
        }
        else
        {
            Console.WriteLine($"Nodo con valor {valorAntiguo} no encontrado.");
        }
    }

    // Buscar Valor
    public bool ContieneValor(int valor)
    {
        return Buscar(valor) != null;
    }

    // Imprimir Lista
    public void ImprimirLista()
    {
        Nodo actual = cabeza;
        if (actual == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        Console.WriteLine("Contenido de la lista:");
        while (actual != null)
        {
            Console.Write($"{actual.Valor}, ");
            actual = actual.ValorSiguiente;
        }
    }
}

