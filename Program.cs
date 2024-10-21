using Proyecto;

internal class Program
{
    private static void Main(string[] args)
    {

        ListaSimple lista = new ListaSimple();
        int opcion;

        do
        {
            Console.WriteLine("MENU LISTAS");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1.- Insertar Nodo");
            Console.WriteLine("2.- Imprimir Tamaño");
            Console.WriteLine("3.- Buscar Nodo");
            Console.WriteLine("4.- Borrar Nodo");
            Console.WriteLine("5.- Modificar Nodo");
            Console.WriteLine("6.- Buscar Valor");
            Console.WriteLine("7.- Imprimir Lista");
            Console.WriteLine("8.- Salir");
            Console.WriteLine("_____________________");
            Console.Write("Seleccionar Opción => ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el valor a insertar: ");
                    int valor = Convert.ToInt32(Console.ReadLine());
                    lista.Insertar(valor);
                    break;

                case 2:
                    Console.WriteLine($"Tamaño de la lista: {lista.Tamano()}");
                    break;

                case 3:
                    Console.Write("Ingrese el valor a buscar: ");
                    int buscar = Convert.ToInt32(Console.ReadLine());
                    var nodoEncontrado = lista.Buscar(buscar);
                    Console.WriteLine(nodoEncontrado != null ? $"Nodo con valor {buscar} encontrado." : "Nodo no encontrado.");
                    break;

                case 4:
                    Console.Write("Ingrese el valor a borrar: ");
                    int borrar = Convert.ToInt32(Console.ReadLine());
                    lista.Borrar(borrar);
                    break;

                case 5:
                    Console.Write("Ingrese el valor a modificar: ");
                    int valorAntiguo = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese el nuevo valor: ");
                    int valorNuevo = Convert.ToInt32(Console.ReadLine());
                    lista.Modificar(valorAntiguo, valorNuevo);
                    break;

                case 6:
                    Console.Write("Ingrese el valor a buscar: ");
                    int buscarValor = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(lista.ContieneValor(buscarValor) ? $"El valor {buscarValor} está en la lista." : "Valor no encontrado.");
                    break;

                case 7:
                    lista.ImprimirLista();
                    break;

                case 8:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != 8);
    }
}